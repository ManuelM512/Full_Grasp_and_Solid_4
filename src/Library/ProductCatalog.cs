namespace Full_GRASP_And_SOLID;
using System.Collections.Generic;
using System.Linq;
public class ProductCatalog : ICatalog
{
    List<Product> productCatalog;
    public ProductCatalog()
    {
        productCatalog = new List<Product>();
    }

    public void Add(string description, int unitcost)
    {
        Product p = new Product(description, unitcost);
        productCatalog.Add(p);
    }

    public Product GetProduct(string description)
    {
        var query = from Product product in productCatalog where product.Description == description select product;
        return query.FirstOrDefault();
    }

    public Product ProductAt(int index)
    {
        return productCatalog[index] as Product;
    }
}