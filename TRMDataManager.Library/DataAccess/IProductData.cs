using System.Collections.Generic;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public interface IProductData
    {
        ProductModel GetProdcutById(int productId);
        List<ProductModel> GetProducts();
    }
}