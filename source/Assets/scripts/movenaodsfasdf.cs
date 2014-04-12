using UnityEngine;
using System.Collections;

public class movenaodsfasdf : MonoBehaviour {

	// Use this for initialization
	void Awake () 
	{
		bool movinup = true;
		int count = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		if ( movinup =true)
		{
			if ( count >= 15)
			{

				movinup = false;
				count = 0;

			}

			rigidbod2d.AddForce(0 ,5);
			count += 1;

		}
		if (movinup = false)

			{

			if (count >= 15)

			{

				movinup = true;
				count = 0;

			}

			rigidbod2d.AddForce(0,-5);
			count += 1;

			}

	}
}
