using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangementPut : MonoBehaviour
{
    public SelectProducts selectProducts;
    public GameObject ArrangementCamera;
    public Transform ArrangementPoint;
    private GameObject ArrangeObj;

    void Start()
    {
        Arrangement_Generate();
    }

    void Update()
    {

    }

    public void Arrangement_Generate()
    {
        Destroy(ArrangeObj);
        if (selectProducts.ProductsPieces[selectProducts.SelectedNum] > 0)
        {
            ArrangeObj = Instantiate(selectProducts.products[selectProducts.SelectedNum], ArrangementPoint.position, Quaternion.identity, ArrangementCamera.transform);
        }
    }

    public void Arrangement_Put()
    {
        if (selectProducts.ProductsPieces[selectProducts.SelectedNum] > 0)
        {
            selectProducts.ProductsPieces[selectProducts.SelectedNum]--;
            ArrangeObj.transform.parent = null;
            ArrangeObj = null;
            Arrangement_Generate();
        }
        else
        {
            Debug.Log("You Don't have this object.");
        }
    }
}


