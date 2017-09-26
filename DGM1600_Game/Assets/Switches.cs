using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A switch is an alternative to the else-if statements. It allows the player to either input their own written answer, or choose from a 
//designated list of options, and get a response. Switches can also be used to determine what line of code will play based on what certain
//stipulations have been met, the intelligence switch for example. A string could be determined by an unseen level or number, or could be
//triggered by the option chosen by the player. This coding method, I'm sure, is very useful in games with stories based on the player's decisions.


public class Switches : MonoBehaviour {
	public string townCenter;
	public string foodChoice;
	public string musicImListeningTo;
	public string hotPockets;
	public int intelligence = 5;
	public string sodaRatings;
	public int thingRatings = 3;
	public string moreMusic;
	public string randomThoughts;
	public string imOutOfIdeas;


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
		}

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
				default:
					print("I don't have a lot of options for ya, and I'll ridicule you for all of them. Good luck.");
					break;
			
			}

			switch (musicImListeningTo){
				case "song 1":
					print("Pitiful Children");
					break;
				case "song 2":
					print("Shrimp Heaven Now");
					break;
				case "song 3":
					print("Taxi Cab");
					break;
				default:
					print("I swear I listen to normal music, I just decided to do this switch at a weird point in my playlist.");
					break;
			
			}

			switch(hotPockets){
				case "Pepperoni":
					print("Good, but overdone. Can't take a lot of those.");
					break;
				case "Ham and Cheese":
					print("I enjoyed them a lot when I was a kid, but I can't eat those anymore. It's too fake tasting.");
					break;
				case "Meatball":
					print("Would eat over pepperoni because of the wider variety of flavor and disbursement of meat.");
					break;
				case "Three meat three cheese":
					print("The pinnacle of deliciousness. I can eat a 20 pack by myself over enough time. 10/10 -IGN");
					break;
				default:
					print("I know what I'm about, son. I take my hot pockets very seriously.");
					break;
				
			}

			switch(intelligence){
				case 5:
					print("Let's have a nice discussion over our different beliefs and keep the volume level in our voices low.");
					break;
				case 4:
					print("We should talk about our beliefs and I'll only yell when I get passionate, but apologize quickly after.");
					break;
				case 3:
					print("I'm going to loudly tell you what my beliefs are, expecting you to sit quietly. But when you wish to argue your side, I will debate every point.");
					break;
				case 2:
					print("I'm just going to scream at you, and threaten you bodily harm if you try to debate my points.");
					break;
				case 1:
					print("I'm offended.");
					break;

					}
				
				switch(sodaRatings){
					case "Dr. Pepper":
						print("The literal nectar of the gods. Will definitely be flowing freely on heaven's eternal buffet.");
						break;
					case "Mountain Dew":
						print("I was into this when I was litle. I can't drink it straight anymore. I can only get it at Sodalicious with flavorings.");
						break;
					case "Sprite":
						print("Forever a classic that will go down in history as one of the best sodas ever invented.");
						break;
					case "Water":
						print("boi");
						break;
					default:
						print("Look, I'm actually a pretty healthy person. This is just where my mind goes when I'm thinking of ideas.");
						break;
					
				}

				switch(thingRatings){
					case 3:
						print("These cool little drawing posers called Body-kun. I have a male and female one.");
						break;
					case 2:
						print("Little wooden ocarina my dad bought me. I've only played it once -_-'");
						break;
					case 1:
						print("Haley made me this little wooden plaque with 'daydream' witten on it, and as a maladaptive daydreamer, I'm triggered. Ironically, obviously.");
						break;
					default:
						print("I have too many knick knacks. I should go to DI..");
						break;
					
				}
			
				switch(moreMusic){
					case "song 1":
						print("Despacito. It's a good song, okay??");
						break;
					case "song 2":
						print("Learn to Let Go");
						break;
					case "song 3":
						print("Praying");
						break;
					case "song 4":
						print("Sadness Runs Through Him");
						break;
					default:
						print("No one cares about the music I listen to.");
						break;
						
				}

				switch(randomThoughts){
					case "thought 1":
						print("My little siblings all suffer from asthma. Luckily I only paritally suffer from it during winter. But this cold came too fast.");
						break;
					case "thought 2":
						print("One Punch Man is a genius show. It allows us to see what an actual overpowered super hero would be like in a comical way.");
						break;
					case "thought 3":
						print("I swear 3D modeling is changing my brain. I literally dreamed I was 3D modeling. All night.");
						break;
					case "thought 4":
						print("My coworker jokes that it's Friday. Every day.");
						break;
					default:
						print("Really nothing super interesting to see here.");
						break;
					
				}

				switch(imOutOfIdeas){
					case "1":
						print("I'm");
						break;
					case "2":
						print("out");
						break;
					case "3":
						print("of");
						break;
					case "4":
						print("ideas");
						break;
					default:
						print("clearly I'm not very creative at 11pm. I should have done this before I spent so long watching Kitchen Nightmares.");
						break;
						

				}
					}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
