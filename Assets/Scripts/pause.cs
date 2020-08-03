using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	public bool gamePaused = false;
	public float pauseBoxWidth = 250;
	public float pauseBoxHeight = 150;
	public Texture pauseTexture;
	public GUIStyle myStyle;

	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) && !(gamePaused)) {
			gamePaused = true;
			Time.timeScale = 0;
		}
		else if(Input.GetKeyDown(KeyCode.Escape) && gamePaused) {
			gamePaused = false;
			Time.timeScale = 1;
		}
	}

	void OnGUI() {
		if(gamePaused == true) {
			GUI.Box(new Rect((Screen.width / 2) - (pauseBoxWidth / 2), 
				(Screen.height / 2) - (pauseBoxHeight / 2 ), pauseBoxWidth, pauseBoxHeight), pauseTexture, myStyle);
		}
	}
}