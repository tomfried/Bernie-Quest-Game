using UnityEngine;
using System.Collections;

public class BernieMove : MonoBehaviour {
	public float speed = 8f;
	private float x_move = 8f;
	private float y_move = 8f;
	bool characterFacingRight = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		x_move = Input.GetAxis ("Horizontal");
		y_move = Input.GetAxis ("Vertical");
		GetComponent<Rigidbody2D>().velocity = new Vector2 (x_move * speed, y_move * speed);
		if (x_move > 0 && !characterFacingRight || x_move < 0 && characterFacingRight) {
			// Set Character Facing Direction To Opposite or False
			characterFacingRight = !characterFacingRight;
			Vector3 currentScale = transform.localScale;
			// Multiply Current Scale By Negative To Flip Direction
			currentScale.x *= -1;
			transform.localScale = currentScale;
		}
	}
}
