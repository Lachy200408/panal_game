using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagement : MonoBehaviour
{
    [SerializeField] public List<GameObject> Panels;


    public void NuevaPartida()
    {
        SceneManager.LoadScene("Initial Scene");
    }
    public void OpenPanel(GameObject Destiny){
        //Se encarga de abrir paneles de la UI
        foreach (GameObject panel in Panels)
        panel.SetActive(false);

        Destiny.SetActive(true);
    }
    public void Quit() => Application.Quit();
}
