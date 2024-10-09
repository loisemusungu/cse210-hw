using System;
using System.Collections.Generic;

/* This product class should have the following properties:
    - Contains the name, product id, price, and quantity of each product.
    - The total cost of the product is the price multiplied by the quantity.(if the
    price per unit was $3 and they bought 5 units, the total cost would be $15)
*/

class Product
{
    private string _name;
    private int _productId;
    private decimal _price;
    private int _quantity;

    public Product(string name, int productId, decimal price, int quantity)
    {
        _name = name;
        _productId = new Random().Next(1000, 9999);
        _price = price;
        _quantity = quantity;
    }

    public decimal CalculateTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingLabel()
    {
        return $"{_name} ({_productId})";
    }
}