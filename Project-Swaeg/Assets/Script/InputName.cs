using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputName : MonoBehaviour {

    public InputField playerName;

    private string charName = "Player Name";

    public void onSubmit()
    {
        charName = playerName.text;
        Debug.Log("Char name is" + charName);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
