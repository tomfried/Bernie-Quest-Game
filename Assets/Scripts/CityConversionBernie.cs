using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CityConversionBernie : MonoBehaviour
{
	private int B_score;

	public GUIText B_count;

	public int nomination;

	void Start()
	{
		B_score = 0;
		UpdateCounter();
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.CompareTag("Delegate"))
		{
			B_score += 20;
			UpdateCounter();
			if (B_score >= nomination)
			{
				SceneManager.LoadScene("winner");
			}
		}
	}
	void UpdateCounter()
	{
		B_count.text = "Bernie: " + B_score.ToString();
	}
}
