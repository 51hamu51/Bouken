using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisplayManager : MonoBehaviour
{
    [SerializeField]
    private GameObject WoodButton;
    public bool IsWoodNear;
    void Start()
    {
        IsWoodNear = false;
    }


    void Update()
    {
        if (IsWoodNear)
        {
            WoodButton.SetActive(true);
        }
        else
        {
            WoodButton.SetActive(false);
        }
    }
}
