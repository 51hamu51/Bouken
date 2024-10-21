using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOnOffButton : MonoBehaviour
{
    [SerializeField]
    private GameObject Shop;
    [SerializeField]
    private GameObject Menu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShopOn()
    {
        Shop.SetActive(true);
        Menu.SetActive(false);
    }
    public void ShopOff()
    {
        Shop.SetActive(false);
        Menu.SetActive(true);
    }
}
