using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

/*
    Order Class will have the following properties:
    - a list of products and a customer. Can calculate the total cost of the order. Can return a string for the packing label. Can return a string for the shipping label.
    - The total price is calculated as the sum of the total cost of each product plus a one-time shipping cost.
    - This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
    - A packing label should list the name and product id of each product in the order.
    - A shipping label should list the name and address of the customer
*/
class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal CalculateTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateTotalCost();
        }

        if (_customer.IsInUSA())
        {
            totalCost += 5;
        }
        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in _products)
        {
            packingLabel += product.GetPackingLabel() + "\n";
        }
        return packingLabel.Trim();
    }

    public string GetShippingLabel()
    {
        return _customer.GetShippingLabel();
    }
}