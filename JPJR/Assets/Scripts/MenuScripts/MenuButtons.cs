using UnityEngine;
using System.Collections;

public class MenuButtons : MonoBehaviour {

	public string sceneName;
	public GameObject MainMenu;
	public GameObject OptionMenu;
	public string iconName;
	//public string text;
	
	void OnClick()
	{
		if(this.gameObject.name == "Start Game" || this.gameObject.name == "BackToMain"){
			Application.LoadLevel(sceneName);
			//AutoFade.LoadLevel(sceneName ,1,1,Color.gray);
			Debug.Log("objectName: "+this.gameObject.name);
		}else if(this.gameObject.name == "Option"){
			OptionMenu.gameObject.SetActiveRecursively(true);
			MainMenu.gameObject.SetActiveRecursively(false);
			Debug.Log("objectName: "+this.gameObject.name);
		}else if(this.gameObject.name == "OptionBack"){
			OptionMenu.gameObject.SetActiveRecursively(false);
			MainMenu.gameObject.SetActiveRecursively(true);
			Debug.Log("objectName: "+this.gameObject.name);
		}
		
	}
	
}

