using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatSpawner : MonoBehaviour {

    public GameObject spawn;

	// Use this for initialization
	void Start () {
        Instantiate(spawn, transform.position, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
		if(!GameObject.FindGameObjectWithTag("Bat"))
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(spawn, transform.position, Quaternion.identity);
            }
        }
	}
}
