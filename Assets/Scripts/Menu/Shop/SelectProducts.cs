using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SelectProducts : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI selectProducts;
    [SerializeField]
    private WoodTextScript woodTextScript;
    [SerializeField]
    private TextMeshProUGUI selectProductsPiece;
    public int SelectedNum;
    public struct Products
    {
        public int ProductID;
        public string Name;
        public int Cost;
        public int Piece;
    }
    public static List<Products> products = new List<Products>();


    void Start()
    {
        SelectedNum = 0;
        Products chair = new Products();
        chair.ProductID = 0;
        chair.Name = "chair";
        chair.Cost = 2;
        chair.Piece = 0;

        products.Add(chair);
    }

    // Update is called once per frame
    void Update()
    {
        selectProducts.text = products[SelectedNum].Name;
        selectProductsPiece.text = products[SelectedNum].Piece.ToString();

    }
    public void BuyProducts()
    {
        if (woodTextScript.WoodNum >= products[SelectedNum].Cost)
        {
            woodTextScript.WoodNum -= products[SelectedNum].Cost;
            Products tmpData = products[SelectedNum];
            tmpData.Piece++;
            products[SelectedNum] = tmpData;
        }
    }
}
