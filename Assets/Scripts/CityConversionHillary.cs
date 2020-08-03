using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class CityConversionHillary : MonoBehaviour
{
	private int H_score;

	public GUIText H_count;

	public int nomination;

	void Start()
	{
		H_score = 0;
		UpdateCounter();
	}
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.CompareTag("Delegate"))
		{
			H_score += 20;
			UpdateCounter();
			if (H_score >= nomination)
			{
				SceneManager.LoadScene("loser");
			}
		}
	}
	void UpdateCounter()
	{
		H_count.text = "Hilary: " + H_score.ToString();
	}
}
