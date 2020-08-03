using UnityEngine;
using System.Collections;

public class DestoryNeutralCity : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D collider) {
		Destroy (gameObject);
	}
}
