using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCheck : MonoBehaviour
{
    [SerializeField]
    private ButtonDisplayManager buttonDisplayManager;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        // Debug.Log("stay");
        if (other.CompareTag("Tree"))
        {
            buttonDisplayManager.IsWoodNear = true;
            other.tag = "NearTree";
            // Debug.Log("tree");
        }
    }
    void OnTriggerExit(Collider other)
    {
        buttonDisplayManager.IsWoodNear = false;
        if (other.CompareTag("NearTree"))
        {
            other.tag = "Tree";
        }
        //Debug.Log("exit");
    }
}
