using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGetChild : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Children;
    private bool IsNearTreeParts;
    public bool IsNearTree;
    void Start()
    {
        IsNearTreeParts = false;
        IsNearTree = false;
    }

    void Update()
    {
        for (int i = 0; i < Children.Length; i++)
        {
            if (Children[i].CompareTag("NearTree"))
            {
                IsNearTreeParts = true;

            }
        }
        if (IsNearTreeParts)
        {
            IsNearTree = true;
        }
        else
        {
            IsNearTree = false;
        }
        IsNearTreeParts = false;

    }
}
