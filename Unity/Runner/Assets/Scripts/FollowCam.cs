using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCam : MonoBehaviour {

    public Transform player; // Grabs the tranform of the player
    public Vector3 camOffset;

	// Update is called once per frame
	void FixedUpdate () {
        transform.position = player.position + camOffset;

        if(player.position.y <= -20)
        {
            SceneManager.LoadScene("Scene_GameOver");
        }
	}
}
