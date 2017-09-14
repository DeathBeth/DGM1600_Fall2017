using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Math : MonoBehaviour {
	public int valueOne;

	public int valueTwo;

	private int result;

	// Use this for initialization
	void Start () {
		DoMath();
	}
	
	void DoMath (){
		result = valueOne + valueTwo;
		print(valueOne + " + " + valueTwo + " = " + result);
	
		result = valueTwo - valueOne;
		print(valueTwo + " - " + valueOne + " = " + result);

		result = valueOne * valueTwo - valueTwo;
		print(valueOne + " * " + valueTwo + " - " + valueTwo + " = " + result);

		result = valueTwo / valueOne;
		print(valueTwo + " / " + valueOne + " = " + result);

		result = valueTwo / valueOne + valueTwo;
		print(valueTwo + " / " + valueOne + " + " + valueTwo + " = " + result);

		result = valueTwo - valueOne + valueTwo;
		print(valueTwo + " - " + valueOne + " + " + valueTwo + " = " + result);

		result = valueOne / valueTwo + valueTwo - valueOne;
		print(valueOne + " / " + valueTwo + " + " + valueTwo + " - " + valueOne + " = " + result);

		result = valueTwo + valueOne * valueOne;
		print(valueTwo + " + " + valueOne + " * " + valueOne + " = " + result);

	}
	// Update is called once per frame
	void Update () {
		
	}
}
