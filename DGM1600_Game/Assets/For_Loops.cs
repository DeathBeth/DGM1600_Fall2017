using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_Loops : MonoBehaviour {

	public int bottles = 100;
	
	//a for loop is much like a while loop in terms of output, but the setup and principles are different.
	// A for loops sets ups a variable, a conditional for that variable, and what causes the loop to run.
	//in the first example, we see the varable 'bottles' introduced, the conditional of 'bottles > 0' is set, and then it's determined that every time the code runs, the set number will go down by 1.
	void Start () {
		// while(bottles > 0){
		// 	print(bottles + " bottles of orange crush on the wall!");
		// 	bottles --;
		// }
		
		for(; bottles > 0; bottles --){
			print(bottles + " bottles of orange crush on the wall!");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
