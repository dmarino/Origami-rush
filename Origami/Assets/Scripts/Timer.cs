using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

	public float targetTime = 60.0f;
	public TextMesh textObject;

	// Use this for initialization
	void Start () {
		textObject = GameObject.Find("timer").GetComponent<TextMesh>();
		
	}

	// Update is called once per frame
	void Update () {
		
		targetTime -= Time.deltaTime; 
		textObject.text = targetTime + "";

		if (targetTime <= 0.0f)
		{
			timerEnded();
		}


	}

	void timerEnded()
	{
		textObject.text = "Game Over";
	}
}
