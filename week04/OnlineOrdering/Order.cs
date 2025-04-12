using System;
using System.Collections.Generic;
class Order{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer){
        this.customer = customer;
        this.products = new List<Product>();
    }

    public void AddProduct(Product product){
        products.Add(product);
    }

    public decimal GetTotalCost(){
        decimal total = 0;
        foreach (var product in products)
        {
            total += product.GetTotalCost();
        }

        total += customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel(){
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"- {product.GetPackingInfo()}\n";
        }
        return label;
    }

    public string GetShippingLabel(){
        return $"Shipping Label:\n{customer.GetName()}\n{customer.GetAddress()}";
    }
}