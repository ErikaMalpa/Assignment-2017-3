using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
    
    public void QuitScene()
    {
        Application.Quit();
    }
}
