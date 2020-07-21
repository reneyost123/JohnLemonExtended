using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class SwitchCamera : MonoBehaviour
{
    public GameObject virtualCam1;
    public GameObject virtualCam2;
    
    
    
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            virtualCam2.SetActive(false);
            virtualCam1.SetActive(true);
        }
        if (Input.GetKeyDown("2"))
        {
            virtualCam1.SetActive(false);
            virtualCam2.SetActive(true);
        }
    }
}
