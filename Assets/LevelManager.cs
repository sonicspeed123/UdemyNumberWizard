using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Needed to change scenes/levels
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		//takes name and loads level based on name
		SceneManager.LoadScene (name);
	}
	public void QuitRequest(){
		Application.Quit ();
	}
}
