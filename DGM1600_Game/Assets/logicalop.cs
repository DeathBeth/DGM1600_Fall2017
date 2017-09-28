using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//A logical operator
public class logicalop : MonoBehaviour {
	public string luke = "Jedi";
	public string vader = "Sith";
	public bool leia = true;
	public string darkSide = "Darth Maul";
	public string lightSide = "Obi Wan";
	public int num1 = 10;
	public float num2 = 10.5f;



	// Use this for initialization
	void Start () {
		if(luke == "Jedi" && vader == "Nanny"){
			print("Vaders yo nanny!");
		}
		else if ( luke == "Jawa" && vader == "Sith"){
			print("Utinni!");
		}
		else if (luke == "Jedi" && vader == "Sith"){
			print("No... I AM your father!");
		}
		else{
			print("The End.");
		}

		if(leia){
			print("No, there is another.");
		}
		else if(!leia){
			print("Hooray! Now I can date Luke!");
		}
		else{
			print("Han fired first!");
		}
		
		if(lightSide == "Obi Wan" || darkSide == "Jar Jar Binks"){
			print("Meeza Evil Bad-Bad Sith Lorda");
		}
		else if(lightSide == "Boba Fett" || darkSide == "Darth Maul"){
			print("As you wish, my master.");
		}
		else{
			print("Not the younglings!");
		}

		if(num1 == 10 && num2 == 10.5){
			print("Yes!");
		}
		else if(num1 == 10 || num2 == 10){
			print("Noooooo! I mean yes!");
		}
		else{
			print("Utinni!");
		}


	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
