using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangementPut : MonoBehaviour
{
    public GameObject ArrangementCamera;
    public Transform ArrangementPoint;
    private GameObject ArrangeObj;
    [SerializeField]
    private GameObject _prefab;
    void Start()
    {

    }

    void Update()
    {

    }

    public void Arrangement_Generate()
    {
        ArrangeObj = Instantiate(_prefab, ArrangementPoint.position, Quaternion.identity, ArrangementCamera.transform);
    }
    public void Arrangement_Put()
    {
        ArrangeObj.transform.parent = null;
    }
}
