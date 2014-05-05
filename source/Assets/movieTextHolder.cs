using UnityEngine;
using System.Collections;

public class movieTextHolder : MonoBehaviour {
	
	
	public GameObject nameText;
	public GameObject text;
	int clicked = 0;
	

	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0)&&(clicked == 0)){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Come in";
			}

		if(Input.GetMouseButtonDown(0)&&(clicked == 1)){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "You wanted to see me director Johnson?";
			}

		if(Input.GetMouseButtonDown(0)&&(clicked == 2)){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Yes, Cox, sit down";
			}

		/*
			if (clicked == 3){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "The enemies of America don’t sit sir, so neither will I.";
			}
			
			if (clicked == 4){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Very well, I wanted to inform you that you have been selected for the NSA-SS Task force, with the Freedomfist division";
			}
			
			if (clicked == 5){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Really sir?";
			}
			
			if (clicked == 6){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Yes, out of all of our agents you best exemplify the American values: Freedom, Guns, and distaste for everyone who isn’t a straight white male";
			}
			
			if (clicked == 7){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Thank you sir";
			}

			if (clicked == 8){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Seriously, it is like two bald eagles banged on top of mount Rushmore, and you were spawned from their love, and were then raised in the White House by George Washington and Teddy Roosevelt.";
			}
			
			if (clicked == 9){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Thank you?";
			}
			
			if (clicked == 10){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "I meant every word. Now obviously as an NSA employee you are familiar with the intricacies of the Internet, correct?";
			}
			
			if (clicked == 11){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Not really sir";
			}
			
			if (clicked == 12){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Well, the gist of it is that it is awesome, and most users use it for the usual stuff, videos, cat pictures and porn. However we believe that some citizens of our greatest nation are using it for… darker things.";
			}
			
			if (clicked == 13){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "You mean gay porn?";
			}
			
			if (clicked == 14){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "No. Well yes, that too, but mainly planning attacks on America.";
			}
			
			if (clicked == 15){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Really?";
			}

			if (clicked == 16){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Indeed, your mission will be to target to terrorists computers, and neutralize them, using our newest technology: Freedom Bird.";
			}
			
			if (clicked == 17){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "I’m sorry?";
			}
			
			if (clicked == 18){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "I don’t quite understand it, but the tech geeks say that your conscience is uploaded to the Internet and becomes a jet or whatever, and can then attack the computers directly, obtaining vital data. Also, the computer will blow up and fry the living fuck out of them";
			}
			
			if (clicked == 19){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "What?";
			}
			
			if (clicked == 20){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Yeah it’s fucking awesome, they showed it on a hamster, that sucker was toast, it was great.";
			}
			
			if (clicked == 21){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "But how do we determine if they are terrorists?";
			}
			
			if (clicked == 22){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "You think they aren’t terrorists?";
			}
			
			if (clicked == 23){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Well if we cant-";
			}
			
			if (clicked == 24){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Of course they are terrorists! You think we would be able to do this without any oversight, and an unlimited budget if they weren’t? ";
			}
			
			if (clicked == 25){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Well-";
			}
			
			if (clicked == 26){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "And even if we do send up some grandmas before their time, we did it for America. Besides, if we don’t kill grandmas, the terrorists win.";
			}
			
			if (clicked == 27){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "But aren’t there committees or something that we report to?";
			}
			
			if (clicked == 28){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Nope, pretty sweet huh?";
			}
			
			if (clicked == 29){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "I suppose so.";
			}
			
			if (clicked == 30){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Director James Johnson";
				text.GetComponent<GUIText>().text = "Excellent, here are your first targets, good luck.";
			}
			
			if (clicked == 31){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Thank you sir.";
			}

			if (clicked == 32){
				clicked += 1;
				nameText.GetComponent<GUIText>().text = "Wiliam Cox";
				text.GetComponent<GUIText>().text = "Remember, Cox, don’t do this for you, or even for me. Do it for America.";
			}
*/
	}
}
