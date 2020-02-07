using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour {

	// Update is called once per frame
	public void PlayGame(string sceneLoad) {
        SceneManager.LoadScene(sceneLoad);
	}

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit(); // Does not work in Unity editor
    }
}
