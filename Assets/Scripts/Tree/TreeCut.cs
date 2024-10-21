using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCut : MonoBehaviour
{
    [SerializeField]
    private TreeGetChild treeGetChild;
    public int TreeHP;
    public int TreeMaxHP;
    [SerializeField]
    private WoodTextScript woodTextScript;
    void Start()
    {
        TreeHP = TreeMaxHP;
    }

    void Update()
    {
        if (TreeHP == 0)
        {
            woodTextScript.WoodDead();
            Destroy(gameObject);
        }
    }


    public void Cut()
    {
        if (treeGetChild.IsNearTree)
        {
            woodTextScript.WoodGet();
            TreeHP--;
        }

    }
}
