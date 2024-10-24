using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangementMove : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed;
    public GameObject ArrangementCamera;
    public bool IsUp;
    public bool IsDown;
    public bool IsRight;
    public bool IsLeft;
    public bool IsHigh;
    public bool IsLow;
    void Start()
    {
        IsUp = false;
        IsDown = false;
        IsRight = false;
        IsLeft = false;
        IsHigh = false;
        IsLow = false;
    }


    void Update()
    {
        if (IsUp)
        {
            UpMove();
        }
        if (IsDown)
        {
            DownMove();
        }
        if (IsRight)
        {
            RightMove();
        }
        if (IsLeft)
        {
            LeftMove();
        }
        if (IsHigh)
        {
            HighMove();
        }
        if (IsLow)
        {
            LowMove();
        }
    }
    public void UpButtonDown()
    {
        IsUp = true;
    }
    public void UpButtonUp()
    {
        IsUp = false;
    }
    public void DownButtonDown()
    {
        IsDown = true;
    }
    public void DownButtonUp()
    {
        IsDown = false;
    }
    public void RightButtonDown()
    {
        IsRight = true;
    }
    public void RightButtonUp()
    {
        IsRight = false;
    }
    public void LeftButtonDown()
    {
        IsLeft = true;
    }
    public void LeftButtonUp()
    {
        IsLeft = false;
    }
    public void HighButtonDown()
    {
        IsHigh = true;
    }
    public void HighButtonUp()
    {
        IsHigh = false;
    }
    public void LowButtonDown()
    {
        IsLow = true;
    }
    public void LowButtonUp()
    {
        IsLow = false;
    }

    public void UpMove()
    {
        if (ArrangementCamera != null)
        {
            ArrangementCamera.transform.position += ArrangementCamera.transform.up * Time.deltaTime * MoveSpeed;
        }
    }
    public void DownMove()
    {
        if (ArrangementCamera != null)
        {
            ArrangementCamera.transform.position -= ArrangementCamera.transform.up * Time.deltaTime * MoveSpeed;
        }
    }
    public void RightMove()
    {
        if (ArrangementCamera != null)
        {
            ArrangementCamera.transform.position += ArrangementCamera.transform.right * Time.deltaTime * MoveSpeed;
        }
    }
    public void LeftMove()
    {
        if (ArrangementCamera != null)
        {
            ArrangementCamera.transform.position -= ArrangementCamera.transform.right * Time.deltaTime * MoveSpeed;
        }
    }
    public void HighMove()
    {
        if (ArrangementCamera != null)
        {
            ArrangementCamera.transform.position -= ArrangementCamera.transform.forward * Time.deltaTime * MoveSpeed;
        }
    }
    public void LowMove()
    {
        if (ArrangementCamera != null)
        {
            ArrangementCamera.transform.position += ArrangementCamera.transform.forward * Time.deltaTime * MoveSpeed;
        }
    }
}
