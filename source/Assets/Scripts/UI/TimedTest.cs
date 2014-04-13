using UnityEngine;
using System.Collections;

public class TimedTest : MonoBehaviour {
	public GUIText score;
	public double interval = 1.0f;

	double timer;

	void Start()
	{
		timer = Time.time + interval;
	}

	void Update()
	{
		if(Time.time >= timer)
		{
			score.GetComponent<Score>().AddScore(12345);
			timer = Time.time + interval;
		}
	}
}
