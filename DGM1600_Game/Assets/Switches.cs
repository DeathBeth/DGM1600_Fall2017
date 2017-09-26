using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {
	public string townCenter;

	public string foodChoice;


	// Use this for initialization
	void Start () {
		switch (townCenter){
			case "main":
				print("Welcoem to Main Street!");
				break;
			case "blacksmith":
				print("The blacksmith grumbles as you pick through the sword bin.");
				break;
			case "bakery":
				print("Mmmmmmmm good baked good and whatnot!");
				break;
			case "morgue":
				print("Now this is MY kind of place!");
				break;
			default:
				print("I don't know what you're talking about!");
				break;

			switch (foodChoice){
				case "hot pockets":
					print("Okay, cool. I guess we're calling in sick for work tomorrow.");
					break;
				case "juice":
					print("Just juice..? Nothing else? Good luck getting protein, friend.");
					break;
				case "salad":
					print("Not very sustaining. Salad comes before a meal, it's not the meal itself.");
					break;
				case "pizza":
					print("You're disgusting. That's disgusting.");
					break;
			
			}
			
					}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
