using UnityEngine;
using Assets.Scripts.Debugger;

public class StartingLogger : MonoBehaviour
{
	public Debugger logger;
	// Start is called before the first frame update
	void Start()
	{
		this.logger = new Debugger("StartingLogger");
		this.logger.Log("Starting application...");
	}

}
