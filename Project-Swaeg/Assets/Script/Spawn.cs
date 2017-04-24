﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject Enemyprefab;

    public Vector3 center;
    public Vector3 size;


	// Use this for initialization
	void Start () {
        center = transform.position;
        SpawnEnemy();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SpawnEnemy()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2), Random.Range(-size.z / 2, size.z / 2));
        Instantiate(Enemyprefab, pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(transform.localPosition, size);
    }
}
