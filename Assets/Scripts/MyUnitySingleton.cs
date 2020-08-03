using UnityEngine;
using System.Collections;

public class MyUnitySingleton : MonoBehaviour {

	private static MyUnitySingleton instance = null;

	public static MyUnitySingleton Instance {
		get { return instance; }
	}

	void Awake() {
		if (instance != null && instance != this) {
			Destroy(this.gameObject);
			return;
		} 
		else
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
	}

	void Update(){
		if (Application.loadedLevelName == "play") {
			if(this.gameObject == instance.gameObject)
				Destroy (this.gameObject);
		}
	}

}
