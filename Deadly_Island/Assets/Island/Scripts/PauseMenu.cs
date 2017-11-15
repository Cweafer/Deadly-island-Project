using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //to manage the scene transitions

public class PauseMenu : MonoBehaviour {

	public GameObject pauseCanvas;
	public GameObject questCanvas;
	public GameObject instructCanvas;
	public bool pausetoggle = false;
	//public GameObject playerChar; //to toggle ability to move

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.P)){
			if (pausetoggle) {
				pausetoggle = false;
			}
			else {
				pausetoggle = true;
			}

			Cursor.visible = true;
			pauseCanvas.SetActive (pausetoggle); //toggles the canvas based on press of p
			//playerChar.SetActive(false);
			
		}
	}

	public void InstructEnter(){
		instructCanvas.SetActive (true);
		pauseCanvas.SetActive (false);
	}
	public void InstructExit(){
		//on exit, return to menu
		instructCanvas.SetActive (false);
		pauseCanvas.SetActive (true);
	}
	public void QuestEnter(){
		questCanvas.SetActive (true);
		pauseCanvas.SetActive (false);
	}
	public void QuestExit(){
		//on exit, return to menu
		questCanvas.SetActive (false);
		pauseCanvas.SetActive (true);
	}

	public void pauseResume(){
		//on returning to the game
		//playerChar.SetActive(true);
		Cursor.visible = false;
		pauseCanvas.SetActive (false);
		pausetoggle = false;
	}

	public void SitchScene(){
		SceneManager.LoadScene("SitchScene"); //loads the title scene
	}

	public void InstructScene(){
		SceneManager.LoadScene("Instructions"); //loads the title scene
	}

	public void returnToMenu(){
		SceneManager.LoadScene("TitleSceen"); //loads the title scene
	}

	public void exitGame(){
		Application.Quit();
	}

	public void loadGame(){
		SceneManager.LoadScene ("Deadly Island_Demo");
	}
}
