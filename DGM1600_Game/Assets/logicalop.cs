using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//A logical operator sets conditions that must be met for a certain code to run. 
//The operators, either 'and' or 'or' are used in an if else statement.
//You can set it up in any way that is pertinent to your game, and anything else can be set under the 'else' statement. 
public class logicalop : MonoBehaviour {
	public string luke = "Jedi";
	public string vader = "Sith";
	public bool leia = true;
	public string darkSide = "Darth Maul";
	public string lightSide = "Obi Wan";
	public int num1 = 10;
	public float num2 = 10.5f;
	public string cat1 = "Rosie";
	public string cat2 = "Ash";
	public bool drPepper = true;
	public bool phone = true;
	public string light = "Beth";
	public string dark = "Bruce";
	public string snack1 = "Pop tart";
	public string snack2 = "Potatoes";
	public bool nap = true;




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

		if(cat1 == "Rosie" && cat2 == "Ash"){
			print("Look at those two kitties!");
		}
		else if(cat1 == "Ash" && cat2 == "Rosie"){
			print("Look at those two kitties that were written in backwards!");
		}
		else{
			print("At least one of those is wrong. I could be wrong. Cats are hard to tell apart");
		}

		if(drPepper){
			print("Enjoy!");
		}
		else if(!drPepper){
			print("Truly, today is the darkest of days.");
		}
		else{
			print("Go get me a Dr. Pepper, will ya?");
		}

		if(phone){
			print("All is well.");
		}
		else if(!phone){
			print("Oh no! My memes!");
		}
		else{
			print("Left shark is wandering around campus, and I don't have my phone to see if he's still relevent.");
		}

		if(light == "Beth" && dark == "Bruce"){
			print("The rebellion will prevail!");
		}
		else if(light == "Bruce" || dark == "Beth"){
			print("Wait. Something's wrong here. Do points transfer over evenly?");
		}
		else{
			print("All's fair in love and war. To the winner go the spoils.");
		}

		if(snack1 == "Pop Tarts" && snack2 == "Potatoes"){
			print("Definitely go with snack 1, are you crazy?");
		}
		else if(snack1 == "Potatoes" && snack2 == "Potatoes"){
			print("Not giving me many choices, huh? I may just have to RUN!");
		}
		else{
			print("that's probably healthier than the two options here...");
		}

		if(nap){
			print("Good. I need one.");
		}
		else if(!nap){
			print("Guys, you gottal let me nap! I'll get cranky!");
		}
		else{
			print("*unintelligable screeching*");
		}


	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
