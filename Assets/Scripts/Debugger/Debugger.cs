using UnityEngine;

namespace Assets.Scripts.Debugger
{

	public class Debugger
	{
		private string scriptName;
		public Debugger(string _scriptName)
		{
			this.scriptName = _scriptName;
		}

		public void Log(string str)
		{
			Debug.Log("[" + this.scriptName + "] - " + str);
		}
	}

}