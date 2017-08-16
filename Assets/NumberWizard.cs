using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	int max;
	int min;
	int guess;

	int maxGuesses = 10;

	public Text text;
	
	void Start () {
		StartGame();
	}
	
	void StartGame () {
		max = 1000;
		min = 1;
		NextGuess ();

	}

	void NextGuess () {
		guess = Random.Range(min, max + 1);
		maxGuesses--;
		text.text = guess.ToString();
		if (maxGuesses <= 0) {
			SceneManager.LoadScene ("Win");
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
		
}
