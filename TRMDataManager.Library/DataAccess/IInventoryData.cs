using System.Collections.Generic;
using TRMDataManager.Library.Models;

namespace TRMDataManager.Library.DataAccess
{
    public interface IInventoryData
    {
        List<InventoryModel> GetInvenotry();
        void SaveInventoryRecord(InventoryModel item);
    }
}