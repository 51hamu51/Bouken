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
    void Start()
    {
        IsUp = false;
        IsDown = false;
        IsRight = false;
        IsLeft = false;
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
}
