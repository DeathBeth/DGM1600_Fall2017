using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour { //the scope of the class is the entire script, since C# treats the two the same. 
										 //This is why you have to have the names matching.

	public void DoStuff(){ //the scope of a function is everything within the brackets.
		print("I'm doing stuff!");
	}

	public void Nannies(){
		print("Hey, aren't I cute??");
	}

	public void Snacks(){
		print("What can I see on Haley's desk, I wonder?");
	}

	public void Sleep(){
		print("I could go for a nice coma right about now...");
	}

	public void HotPockets(){
		print("How many days of my life have I lost due to Hot Pockets?");
	}

	public void Memes(){
		print("How can you tell when a meme is dead?");
	}

	public void HeathDays(){
		print("I'll need the entire semester, and more.")
	}

	public void Work(){
		print("How little can I go to work and not starve?")
	}

	public void Introverted(){
		print("Why does no one believe that I'm introverted?")
	}

	public void Understanding(){
		print("I've been proven wrong. Homework doesn help me understand this. Dangit.");
	}


	void Start(){
		DoStuff();
		int result = AddNumbers(5,11);
		print(result);

		Cats();
		int total = NumberOfAnimals(1,2);
		print(total);

		Snacks();
		int calories = AddCalories(2000,1550);
		print(calories);

		Sleep();
		int hours = HoursSlept(5,3);
		print(hours);

		HotPockets();
		int hp = HpEaten(1,2);
		print(hp);

		Memes();
		int daysDank = Memeries(60,180);
		print(daysDank);

		HealthDays();
		int mentalHelath = Days(100,265);
		print(mentalHealth);

		Work();
		int stability = hoursWorked(4,5);
		print(stability);

		Introverted();
		int personality = mood(10,10);
		print(personality);

		Understanding();
		int knowledge = class(10,6);
		print(knowledge);



	} //we created the return named results in the bottom code, and used the above code to expand that scope and bring it out of the function.

	public int AddNumbers(int num1, int numb2){ //this function has the parameters of int num1 and num2, whatever the code has set them to be. 
												//With this function, we use those parameters to make them do something.
		int result = num1 + numb2;

		return result;
	}

	public int NumberOfAnimals(int cats, int dogs){

		int total = cats + dogs;

		return total;
	}

	public int AddCalories(int ruffles, int oreos){

		int calories = ruffles + oreos;

		return calories;
	}

	public int HoursSlept(int night1, int night2){

		int hours = night1 + night2;

		return hours;
	}

	public int HpEaten(int day1, int day2){

		int hp = day1 + day2;

		return hp;
	}

	public int Memeries(int facebook, int tumblr){

		int daysDank = facebook + tumblr;

		return daysDank;
	}

	public int Days(int stress, int homework){

		int mentalHealth = stress + homework;

		return mentalHealth;
	}

	public int hoursWorked(int hours, int days){

		int stability = hours * days;

		return stability;
	}

	public int mood(int affinity, int sleep){

		int personality = affinity + sleep;

		return personality;
	}

	public int knowledge(int hoursInClass, int hoursDoingHomework){

		int knowledge = hoursInClass + hoursDoingHomework;

		return knowledge;
	}


		
	

}