using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangementPut : MonoBehaviour
{
    [SerializeField]
    private float RotateSpeed;
    public SelectProducts selectProducts;
    public GameObject ArrangementCamera;
    public Transform ArrangementPoint;
    private GameObject ArrangeObj;
    public bool IsRightRotate;
    public bool IsLeftRotate;

    void Start()
    {
        Arrangement_Generate();
        IsRightRotate = false;
        IsLeftRotate = false;
    }

    void Update()
    {
        if (IsRightRotate)
        {
            ArrangementRotationRight();
        }
        if (IsLeftRotate)
        {
            ArrangementRotationLeft();
        }
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
    public void RightRotateButtonDown()
    {
        IsRightRotate = true;
    }
    public void RightRotateButtonUp()
    {
        IsRightRotate = false;
    }
    public void LeftRotateButtonDown()
    {
        IsLeftRotate = true;
    }
    public void LeftRotateButtonUp()
    {
        IsLeftRotate = false;
    }

    public void ArrangementRotationRight()
    {
        ArrangeObj.transform.Rotate(0, Time.deltaTime * RotateSpeed, 0);
    }



    public void ArrangementRotationLeft()
    {
        ArrangeObj.transform.Rotate(0, -Time.deltaTime * RotateSpeed, 0);
    }
}



