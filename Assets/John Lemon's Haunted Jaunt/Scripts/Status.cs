using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    public int health;
    public bool debug = false;

    public Slider healthSlider;
    public Text healthText;
    void Update()
    {
        healthSlider.value = health;
        healthText.text = "Health = " + (Mathf.RoundToInt(health)).ToString();
    }
    public IEnumerator ApplyDamage(int totalDamage)
    {
        health -= totalDamage;
        if (debug) Debug.Log("health " + health);

        yield return new WaitForSeconds(5);
    }

    public int GetHealth()
    {
        return health;
    }
}