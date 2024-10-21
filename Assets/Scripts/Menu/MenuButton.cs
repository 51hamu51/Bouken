using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField]
    private GameObject Menu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MenuOn()
    {
        Menu.SetActive(true);
    }
    public void MenuOff()
    {
        Menu.SetActive(false);
    }
}
