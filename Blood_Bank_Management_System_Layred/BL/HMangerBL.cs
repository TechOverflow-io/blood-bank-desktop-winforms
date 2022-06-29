using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blood_Bank_Management_System_Layred.DL;
using Blood_Bank_Management_System_Layred.DTO;
using System.Data;

namespace Blood_Bank_Management_System_Layred.BL
{

    class HMangerBL
    {
        HMangerDL hmD;
        public HMangerBL()
        {
            hmD = new HMangerDL();
        }
        public DataSet getAllDonorInfo()
        {
            return hmD.FetchAllFromDB();
        }
        public DataSet fetchByAddress(HMangerDTO hmDTO)
        {
            return hmD.FetchByAddressFromDB(hmDTO);
        }
        public DataSet fetchByBloodGroup(HMangerDTO hmDTO)
        {
            return hmD.FetchByBloodGroupFromDB(hmDTO);
        }
        public int AddReq(HMBloodAmmount hm)
        {
            int count = hmD.AddRequest(hm);
            return count;
        }
        public DataSet fetchAll()
        {
            return hmD.fetchAllFromDB();
        }
        public int DecreaseStock(HMBloodAmmount sdo)
        {
            return hmD.DecreaseStockFromDB(sdo);
        }
        public int DeleteFromReq(HMBloodAmmount d)
        {
            int row = hmD.DeleteFromRequest(d);
            return row;
        }
    }
}
