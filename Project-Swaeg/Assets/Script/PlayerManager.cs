using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

 
    public GameObject player;
    public Image currentHealthbar;
    public Text ratioText;

    private float hitpoint = 150;
    private float maxHitpoint = 150;
 

    // Use this for initialization
    private void Start () {

      
    }

    private void UpdateHealthBar()
    {
        float ratio = hitpoint / maxHitpoint;
        currentHealthbar.rectTransform.localScale = new Vector3(ratio, 1, 1);
        ratioText.text = (ratio * 100).ToString("f0") + '%';

    }


   private void TakeDamage(float damage)
    {
        hitpoint -= damage;
        if(hitpoint < 0 )
        {
            hitpoint = 0;
            Debug.Log("Dead!");
            Application.Quit();
        }

        UpdateHealthBar();
    }
}
