using System;
using TMPro;
using UnityEngine;

public class CreditsFadeInOut : MonoBehaviour
{
	private string[] credits = { "Panal Editions", "Cuban Games", "Over the Deal" };
	private int changeTimes = 0;
	private TextMeshProUGUI creditText;

	private void Start()
	{
		creditText = GetComponent<TextMeshProUGUI>();
	}

	public void OnAnimationEnded()
	{
		if (changeTimes < 3)
		{
			creditText.text = credits[changeTimes++];
		}
		else
		{
			Destroy(gameObject);
			GameObject.Find("MainMenuCanvas").SendMessage("OnLoadMenu");
		}
	}
}
