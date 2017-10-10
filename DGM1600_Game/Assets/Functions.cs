using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour { //the scope of the class is the entire script, since C# treats the two the same. This is why you have to have the names matching.

	public void DoStuff(){ //the scope of a function is everything within the brackets.
		print("I'm doing stuff!");
	}

	void Start(){
		DoStuff();
		int result = AddNumbers(5,11);
		print(result);
	} //we created the return named results in the bottom code, and used the above code to expand that scope and bring it out of the function.

	public int AddNumbers(int num1, int numb2){ //this function has the parameters of int num1 and num2, whatever the code has set them to be. With this function, we use those parameters to make them do something.
		
		int result = num1 + numb2;

		return result;
	}

}