using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{
    public int damage;
    public bool debug = false;
    void OnTriggerEnter(Collider col)
    {
        if (debug) Debug.Log(col);
        Status playerStatus = col.GetComponent<Status>();
        if (playerStatus) {
            playerStatus.ApplyDamage(damage);
        }
    }
}