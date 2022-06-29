using Blood_Bank_Management_System_Layred.DL;
using Blood_Bank_Management_System_Layred.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Bank_Management_System_Layred.BL
{
    class StockBL
    {
        StockDL stockDL;


        public StockBL()
        {
            stockDL = new StockDL();
        }

        public DataSet fetchAll()
        {
            return stockDL.fetchAllFromDB();
        }
        public int UpdateStockTable(StockDTO sdo)
        {
            return stockDL.UpdateStock(sdo);
        }

        public int DecreaseStock(StockDTO sdo)
        {
            return stockDL.DecreaseStockFromDB(sdo);
        }
    }
}
