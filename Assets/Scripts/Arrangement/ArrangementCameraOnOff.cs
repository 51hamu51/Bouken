using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangementCameraOnOff : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject ArrangementCamera;
    void Start()
    {
        ArrangementCameraOff();
    }


    void Update()
    {

    }

    public void ArrangementCameraOn()
    {
        ArrangementCamera.SetActive(true);
        MainCamera.SetActive(false);

    }
    public void ArrangementCameraOff()
    {
        MainCamera.SetActive(true);
        ArrangementCamera.SetActive(false);
    }
}