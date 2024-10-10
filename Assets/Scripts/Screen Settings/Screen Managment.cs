using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ScreenManagment : MonoBehaviour
{
    void Start()
    {
        Resolutions = new()
        {
            new Resolution(1920, 1080, "HD"),
            new Resolution(2560, 1440, "QHD"),
            new Resolution(3840, 2160, "4K UHD"),
        };
        SwitchResolution(0);
    }
    //Lleva el indice de la resolucion mostrada en pantalla
    public int SelectedResolution= 0;
    //Lista de resoluciones Permitidas
    public List<Resolution> Resolutions;
    //Texto en el que se actualiza la resolucion a la que el usuario desea cambiar
    public TextMeshProUGUI TextoResolution;
    //Define si el usuario quiere o no jugar a pantalla completa
    public Toggle FullScreen;

    public void SwitchResolution(int side)
    {//Metodo llamado desde el inspector, encargado de variar la resolucion segun quiera el usuario
        SelectedResolution = (SelectedResolution + side)% Resolutions.Count;
        TextoResolution.text = Resolutions[SelectedResolution].Type + ": " + Resolutions[SelectedResolution].Vertical + " X "+ Resolutions[SelectedResolution].Horizontal;
    }

    public void ApplyChanges()
    {
        Screen.SetResolution(Resolutions[SelectedResolution].Horizontal, Resolutions[SelectedResolution].Vertical,FullScreen.isOn);
    }

}



[System.Serializable]
public class Resolution
{
    public Resolution(int vertical, int horizontal, string type)
    {
        Vertical = vertical;
        Horizontal = horizontal;
        Type = type;
    }

    public int Vertical { get; }
    public int Horizontal { get; }
    public string Type { get; }
}
