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

		for(hotPockets = 10; hotPockets < 10; hotPockets --){
			print(hotPockets + " is too few. You need more.");
		}

		for(; music > 0; music ++){
			print(music + " is not enough. I need just one more song before bed...");
		}

		for(youtube = 0; youtube < 100; youtube ++){
			print(youtube + " is not sufficient. I need more internet consumption.");
		}

		for(drPepper = 100; drPepper > 0; drPepper --){
			print(drPepper + " bottles of Dr Pepper on the waaaalllll!");
		}

		for(halloween = 31; halloween > 0; halloween --){
			print(halloween + " days until Halloween! So spooky!");
		}

		for(; shrimp < 10; shrimp ++){
			print(shrimp + " left until we reach shrimp heaven! Now!");
		}

		for(poptarts = 0; poptarts < 100; poptarts ++){
			print(poptarts + " poptarts eaten! It's gotta be a new record!");
		}

		for(; iphone > 0; iphone ++){
			print(iphone + " is enough, don'tcha think? Do we really need another one?");
		}

		for(kleenex = 150; kleenex > 0; kleenex --){
			print(kleenex + " tissues left!");
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
