using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player; // Only need the player's position. Nothing else
    public float playerMinDistance = 10.0f;
    public Text score;
    public int scoreNum = 100;

    void FixedUpdate()
    {
        if(player.position.z >= playerMinDistance)
        {
            score.text = scoreNum.ToString();

            playerMinDistance += 10;
            scoreNum += 100;
        }
    }
}
