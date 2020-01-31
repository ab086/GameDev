using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour {

    [Header("Set in Inspector")]
        public GameObject applePrefab;
        public float speed = 5f; // appleTree speed
        public float leftRightEdge = 10.0f; // When appleTree turns around
        public float directionChangeChance = 0.001f;
        public float appleSpawnRate = 1f;

	// Use this for initialization
	void Start () {
        // Drop apples every second
        Invoke("DropApple", 2f);
	}
	
	// Update is called once per frame
	void Update () {
        // basic movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        // change direction
        if (pos.x < -(leftRightEdge))
        {
            speed = Mathf.Abs(speed);

        } else if(pos.x > leftRightEdge)
        {
            speed = -(Mathf.Abs(speed));

        }
        //if (Random.value < directionChangeChance)
        //{
        //    speed *= -1;
        //}
	}

    // Locked update to 60 FPS
    void FixedUpdate()
    {
        if (Random.value < directionChangeChance)
        {
            speed *= -1;
        }
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", appleSpawnRate);
    }
}
