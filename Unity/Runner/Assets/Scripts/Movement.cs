using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    public Rigidbody body;
    public int forwardSpeed = 1000;
    public int sideSpeed = 550;

    void Start()
    {
        
    }
	
	
	// Update is called once per frame
    // FixedUpdate plays nicer with physics
	void FixedUpdate () {
        body.AddForce(0, 0, forwardSpeed * Time.deltaTime); // Allows consistent movement regardless of fps

        // Using A & D to move side to side
        if(Input.GetKey("d"))
        {
            body.AddForce(sideSpeed * Time.deltaTime, 0, 0);
        } else if(Input.GetKey("a"))
        {
            body.AddForce(-sideSpeed * Time.deltaTime, 0, 0);
        } else
        {
            // Do Nothing
        }
	}

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if(collision.collider.tag == "Obstacle")
        {
            SceneManager.LoadScene("Scene_GameOver");
        }
    }
}
