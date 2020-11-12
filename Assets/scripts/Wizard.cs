using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
   int max = 100;
	int min = 1;
	int guess = 50;

	// Use this for initialization
	void Start () {
		print ("Hello I am the Number Wizard");
		print ("Pick a number between 1 and 100");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		print ("Is the number higher or lower than " + guess);
		print ("Push Arrow Up if your number is higher, Arrow Down if it is lower, and Enter if it is correct");
		
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			// print("up key pressed");
			min = guess;
			guess = (min + max) / 2;
			print ("Is the number higher or lower than " + guess);
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			// print("down key pressed");
			max = guess;
			guess = (min + max) / 2;
			print ("Is the number higher or lower than " + guess);
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
		}
	}
}



