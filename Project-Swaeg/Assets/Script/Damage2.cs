using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage2 : MonoBehaviour
{

    public bool isDamaging;
    public float damage = 15;

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
            Destroy(this.gameObject);
        }
    }
}
