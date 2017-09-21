using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour {

	public string[] heros = new string[6];

	// Use this for initialization
	void Start () {

		heros[0] = "Batman";
		heros[1] = "Superman";
		heros[2] = "Iron Man";
		heros[3] = "Wonder Woman";
		heros[4] = "Mario";
		heros[5] = "Mr. Incredible";

		print(heros[5]);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
