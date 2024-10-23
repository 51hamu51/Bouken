using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WoodTextScript : MonoBehaviour
{
    public int WoodNum;
    [SerializeField]
    private TextMeshProUGUI WoodText;
    [SerializeField]
    private ButtonDisplayManager buttonDisplayManager;
    void Start()
    {
        // WoodNum = 0;
    }


    void Update()
    {
        WoodText.SetText("wood : {0}", WoodNum);
    }

    public void WoodGet()
    {
        WoodNum++;
    }
    public void WoodDead()
    {

        buttonDisplayManager.IsWoodNear = false;
    }
}
