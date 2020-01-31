using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    [Header("Generic Header")]
        public static float bottomY = -20f;
	
	// Update is called once per frame
	void Update () {
		if(transform.position.y < bottomY)
        {
            Destroy(this.gameObject);

            // Get reference to ApplePicker
            ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();

            // Call appleDestroyed() method
            apScript.AppleDestroyed();
        }
	}
}
