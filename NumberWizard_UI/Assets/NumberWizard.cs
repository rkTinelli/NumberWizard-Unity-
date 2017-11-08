using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization

	int max;
	int min;
	int guess;

	public Text text;

	int maxGuessAllowed = 10;

	void Start () {
		StartGame();
	}

	void StartGame(){
		max = 1000;
		min = 1;
		guess = Random.Range(min,max);
		text.text = guess.ToString();		
		max = max + 1;
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			//print ("Up Arrow was pressed");
			GuessLower();

		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			//print ("Down Arrow was pressed");
			GuessHigher();

		}
	}

	public void GuessHigher(){
		min = guess;
		NextGuess();
	}

	public void GuessLower(){
		max = guess;
		NextGuess();
	}

	public void NextGuess(){
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();
		maxGuessAllowed --;
		if (maxGuessAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
