using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageMaster : MonoBehaviour
{

    public bool isDamaging;
    public float damage = 50;

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player")
        {
            col.SendMessage((isDamaging) ? "TakeDamage" : "HealDamage", Time.deltaTime * damage);
            Destroy(this.gameObject);
        }
    }
}
