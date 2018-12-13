using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonInput : MonoBehaviour {


	public void OpenScene (int sceneIndex) {

		SceneManager.LoadScene (sceneIndex);

	}

	public void CloseGame () {

		Application.Quit ();
		Debug.Log ("Closing the game");

	}

	void Update () {

		if( Input.GetKey ("escape")){

			Application.Quit ();
			Debug.Log ("Closing the game");
			Debug.Log ("It works. Hurray!!");

			}		

		}
		
	}

