using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour {

    [Header("Set Dynamically")]
        public Text scoreGT;

    void Start()
    {
        // Find score counter
        GameObject scoreGO = GameObject.Find("Score Counter");

        // Get text out of score counter
        scoreGT = scoreGO.GetComponent<Text>();

        // Set starting score to zero
        scoreGT.text = "0";
    }

    // Update is called once per frame
    void Update () {
        // Get current screen position of the mouse
        // from input class
        Vector3 mousePos2D = Input.mousePosition;

        // The camera's z position sets how far to push the mouse into 3D
        mousePos2D.z = -(Camera.main.transform.position.z);

        // Convert point from 2D space into 3D world space
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        // Move the x position of this basket to the x position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision collision)
    {
        // Finding what caused collision
        GameObject collidedWith = collision.gameObject;
        if(collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);

            // Make score int
            int score = int.Parse(scoreGT.text);
            score += 100;

            // Convert back to text to display
            scoreGT.text = score.ToString();
            if(score > HighScore.score)
            {
                HighScore.score = score;
            }
        }
    }
}
