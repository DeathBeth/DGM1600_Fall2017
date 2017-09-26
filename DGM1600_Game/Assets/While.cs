using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class While : MonoBehaviour {

//whiles are a good way to calculate a mass amount of numbers, counting up or down. You are able to set things that happen when certain numbers
//are matched. You can trigger different things, including scripts to appear. This option in coding is much better to use with integers and floats
//rather than strings. Strings can make things messy in this situation.

	public int bottles = 100;
	public int tacos = 0;
	public int hoursOnYoutube = 0;
	public int waterDrunk = 0;
	public int lunchablesLeft = 10;
	public int crapsLeftToGive = 0;


	// Use this for initialization
	void Start () {
		while(bottles < 100){
			bottles --;
			print(bottles + " bottles of beer on the wall! ");

		}
		while(tacos < 5){
			tacos ++;
			print(tacos + "Nice! ");
		}
		while(tacos > 5){
			tacos ++;
			print("Okay, you may wanna slow down.");

		}
		while(tacos == 100){
			tacos ++;
			print("Dude, have fun at the hospital.");
		}
		
		while(hoursOnYoutube < 50){
			hoursOnYoutube ++;
			print("One more video.");

		}

		while(waterDrunk == 0){
			print("No wonder your face breaks out so often.");
		
		}

		while(lunchablesLeft < 10){
			lunchablesLeft --;
			print("Go buy more lunchables, you grown adult.");
		}
		while(lunchablesLeft == 0){
			print("RED ALERT!");

		}
		
		while(crapsLeftToGive == 1){
			crapsLeftToGive ++;
			print("That's too many.");
		}
		while(crapsLeftToGive == 0){
			print("correct");
		}

		

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
