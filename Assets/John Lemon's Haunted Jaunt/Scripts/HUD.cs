using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public bool debug = false;
    public Slider healthSlider;
    public Text healthText;
    private Status Status;
    void Update()
    {
        healthText.text = "Health = " + Status.GetHealth().ToString();
        healthSlider.value = Status.GetHealth();
    }
    void Awake()
    {
        Status = FindObjectOfType<Status>() as Status;
        if (debug) Debug.Log(Status);
        healthText = GameObject.Find("HealthText").GetComponent<Text>();
        healthSlider = GameObject.Find("HealthSlider").GetComponent<Slider>();
    }
}