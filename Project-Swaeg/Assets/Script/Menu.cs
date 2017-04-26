using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour {

    public Canvas menu;
    public Button start;

	// Use this for initialization
	void Start () {
        menu = menu.GetComponent<Canvas>();
        start = start.GetComponent<Button>();
        menu.enabled = false;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ExitB()
    {
        menu.enabled = false;
        start.enabled = false;
    }

    public void StartB()
    {
        Application.LoadLevel(1);
    }
}
