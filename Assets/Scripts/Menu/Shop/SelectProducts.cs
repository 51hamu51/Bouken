using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SelectProducts : MonoBehaviour
{
    [SerializeField]
    private ProductsData productsData;
    [SerializeField]
    private TextMeshProUGUI selectProducts;
    [SerializeField]
    private WoodTextScript woodTextScript;
    [SerializeField]
    private TextMeshProUGUI selectProductsPiece;
    public int[] ProductsPieces;
    public int ProductsKinds;
    public int SelectedNum;



    void Start()
    {
        SelectedNum = 0;

    }

    void Update()
    {
        selectProducts.text = productsData.Products[SelectedNum].Name;
        selectProductsPiece.text = ProductsPieces[SelectedNum].ToString();

    }
    public void BuyProducts()
    {
        if (woodTextScript.WoodNum >= productsData.Products[SelectedNum].Cost)
        {
            woodTextScript.WoodNum -= productsData.Products[SelectedNum].Cost;
            ProductsPieces[SelectedNum]++;
        }
    }
    public void NextProduct()
    {
        SelectedNum++;
        if (SelectedNum >= ProductsKinds)
        {
            SelectedNum = 0;
        }
    }
    public void PreviousProduct()
    {
        SelectedNum--;
        if (SelectedNum <= -1)
        {
            SelectedNum = ProductsKinds - 1;
        }
    }
}
