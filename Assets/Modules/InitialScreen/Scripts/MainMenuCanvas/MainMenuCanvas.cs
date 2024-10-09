using UnityEngine;

public class MainMenuCanvas : MonoBehaviour
{
	public void OnLoadMenu()
	{
		Destroy(GameObject.Find("CreditsScreen"));
	}
}