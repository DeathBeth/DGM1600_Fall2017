using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFun : MonoBehaviour {
	public int laserBlast;

	// Use this for initialization
	
	//a void function allows a variable to be set with different stipulations to set off different kinds of code.
	//We go through a temporary variable in the void Update to call the function.
	//The first letter of a void fuction must be capitalized, and the variable must be lower case.
	void Start () {
		DeathStar(laserBlast);
		McDonalds(menu);
		Dinner(cookAtHome);
		GameSystem(freeTime);
		Music(listen);
		Cereal(food);
		Poster(rolledUpOnTheFloor);
		Animals(pets);
		BoardGames(play);
		People(iSee);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void DeathStar (int vent){
		print("That's no moon, that's a space station!");



		print(vent);

		if(vent == 1){
			print("Porkin's misses the mark!");
		}
		else if(vent == 2){
			print("Red Leader misses!");
		}
		else{
			print("I don't understand Star Wars, to be totally honest.");
		}
	}

	void McDonalds (int nuggets){


		print(nuggets);

		if(nuggets == 4){
			print("Child's play.");
		}
		else if(nuggets == 6){
			print("On a budget");
		}
		else{
			print("Ah, yes, a fully functioning millenial. Eat your dang nuggets");
		}
	}

	void Dinner (int options){

		print(options);

		if(options == 1){
			print("Cook a full, healthy meal for the whole house! You have the time!");
		}
		else if(options == 2){
			print("Every man for himself. Grab a muffin.");
		}
		else{
			print("Screw it. Get in the car. We're getting McDonalds.");
		}
	}

	void GameSystem (int system){

		print(system);

		if(system == 1){
			print("Nintendo Switch");
		}
		else if(system == 2){
			print("Xbox 1");
		}
		else{
			print("3DS");
		}
	}

	void Music (playlist){

		print(playlist);

		if(playlist == 1){
			print("Ascendant");
		}
		else if(playlist == 2){
			print("El Beeper");
		}
		else{
			print("*insert generic song*");
		}
	}

	void Cereal (int inMyLineOfSight){

		print(inMyLineOfSight);

		if(inMyLineOfSight == 1){
			print("Franken Berry");
		}
		else if(inMyLineOfSight == 2){
			print("Boo Berry Crunch");
		}
		else{
			print("Rice Chex. That one is mine... Man, I'm boring.");
		}
	}

	void Poster (int whatISee){

		print(whatISee);

		if(whatISee == 1){
			print("Koopa Troopa");
		}
		else if(whatISee == 2){
			print("Dry Bones");
		}
		else{
			print("I swear, these character names are crazy.");
		}
	}

	void Animals (int nannies){

		print(nannies);

		if(nannies == 1){
			print("Rosie");
		}
		else if(nannies == 2){
			print("Ash");
		}
		else{
			print("That white lump is probably Luna");
		}
	}

	void BoardGames (int onTheShelf){

		print(onTheShelf);

		if(onTheShelf == 1){
			print("Mario Chess");
		}
		else if(onTheShelf == 2){
			print("Puerto Rico");
		}
		else{
			print("Ticket To Ride");
		}
	}

	void People (int homies){

		print(homies);

		if(homies == 1){
			print("Yup, that one's Haley.");
		}
		else if(homies == 2){
			print("Probs Jong Hwa.");
		}
		else{
			print("Man, that's Kyle. He basically lives here anyway.");
		}
	}
}
