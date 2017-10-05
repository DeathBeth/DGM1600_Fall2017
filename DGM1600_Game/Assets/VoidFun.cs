using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoidFun : MonoBehaviour {
	public int laserBlast;

	// Use this for initialization
	void Start () {
		DeathStar(laserBlast);
		
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

}
