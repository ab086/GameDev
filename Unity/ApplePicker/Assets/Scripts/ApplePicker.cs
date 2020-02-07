using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour {

    [Header("Set in Inspector")]
        public GameObject basketPrefab;
        public int numBaskets = 3;
        public float basketBottomY = -14f;
        public float basketSpacingY = 2f;
        public List<GameObject> basketList;

	// Use this for initialization
	void Start () {
        basketList = new List<GameObject>();
        Vector3 pos;

        for (int i = 0; i < numBaskets; i++)
        {
            GameObject tBasketGO = Instantiate<GameObject>(basketPrefab);
            pos = Vector3.zero;
            pos.y = basketBottomY + (basketSpacingY * i);
            tBasketGO.transform.position = pos;
            basketList.Add(tBasketGO);
        }
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void AppleDestroyed()
    {
        // Destroy all falling apples on miss
        GameObject[] tempAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        
        foreach(GameObject tempObj in tempAppleArray)
        {
            Destroy(tempObj);
        }

        // Destory a basket layer
        // Get index of last basket in list
        int basketIndex = basketList.Count - 1;

        // Get reference to that basket's instance
        GameObject tBasketGO = basketList[basketIndex];

        // Remove from list
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGO);

        if(basketList.Count == 0)
        {
            SceneManager.LoadScene("Scene_GameOver");
            //SceneManager.LoadScene("_Scene_0");
        }
    }
}
