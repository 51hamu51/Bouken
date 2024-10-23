using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PutProductSelect : MonoBehaviour
{
    public SelectProducts selectProducts;
    [SerializeField]
    private ProductsData productsData;
    [SerializeField]
    private TextMeshProUGUI PutProducts;
    [SerializeField]
    private WoodTextScript woodTextScript;
    [SerializeField]
    private TextMeshProUGUI PutProductsPiece;
    void Start()
    {

    }

    void Update()
    {
        PutProducts.text = productsData.Products[selectProducts.SelectedNum].Name;
        PutProductsPiece.text = selectProducts.ProductsPieces[selectProducts.SelectedNum].ToString();
    }


}
