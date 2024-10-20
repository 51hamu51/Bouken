using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodTextScript : MonoBehaviour
{
    public int WoodNum;
    [SerializeField]
    private TextMeshProUGUI WoodText;
    void Start()
    {
        WoodNum = 0;
    }


    void Update()
    {
        WoodText.SetText("wood : {0}", WoodNum);
    }
}
