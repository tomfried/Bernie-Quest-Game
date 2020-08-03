using UnityEngine;
using System.Collections;

public class HillaryMove : MonoBehaviour {

	public float speed;
	public float xMax;
	public float yMax;
	public float xMin;
	public float yMin;
	private float time;
	private float x;
	private float y;

	void Start () {
		x = Random.Range(-speed, speed);
		y = Random.Range(-speed, speed);
	}

	void Update () {
		time += Time.deltaTime;
		if (transform.localPosition.x > xMax) {
			x = Random.Range(-speed, 0.0f);
			time = 0.0f; 
		}
		if (transform.localPosition.x < xMin) {
			x = Random.Range(0.0f, speed);
			time = 0.0f; 
		}
		if (transform.localPosition.y > yMax) {
			y = Random.Range(-speed, 0.0f);
			time = 0.0f; 
		}
		if (transform.localPosition.y < yMin) {
			y = Random.Range(0.0f, speed);
			time = 0.0f; 
		}
		if (time > 1.0f) {
			x = Random.Range(-speed, speed);
			y = Random.Range(-speed, speed);
			time = 0.0f;
		}
		transform.localPosition = new Vector3(transform.localPosition.x + x, transform.localPosition.y + y, transform.localPosition.z);
	}
}