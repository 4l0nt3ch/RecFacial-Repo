using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using RecFacial.DatabaseDriver.Models;
using System.Threading.Tasks;

namespace RecFacial.DatabaseDriver.Management
{
    public class MasterConnection
    {
        public static SQLiteAsyncConnection connDB;
        public MasterConnection(String dbPath) {
            connDB = new SQLiteAsyncConnection(dbPath);
            connDB.CreateTableAsync<EmpModel>().Wait();
        }

        public Task<int> EmpCreate(EmpModel empModel)
        {
            if (empModel.UserID == 0)
            {
                return MasterConnection.connDB.InsertAsync(empModel);
            }
            else
            {
                return null;
            }
        }
    }

}
