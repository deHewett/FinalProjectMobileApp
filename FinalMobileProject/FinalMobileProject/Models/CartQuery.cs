
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FinalMobileProject.Models
{
    class CartQuery
    {
        static object locker = new object();

        SQLite.SQLiteConnection conn = new SQLite.SQLiteConnection(App.db_path);

        public CartQuery()
        {
            //conn = DependencyService.Get<IProducts>().GetConnection();
            conn.CreateTable<CartRecord>();
        }

        //Insert 
        public int InsertDetails(CartRecord custDB)
        {
            lock (locker)
            {
                return conn.Insert(custDB);
            }
        }

        //Update 
        public int UpdateDetails(CartRecord custDB)
        {
            lock (locker)
            {
                return conn.Update(custDB);
            }
        }

        //Delete 
        public int DeleteNote(int id)
        {
            lock (locker)
            {
                return conn.Delete<CartRecord>(id);
            }
        }

        //Get all 
        public IEnumerable<CartRecord> GetList()
        {
            lock (locker)
            {
                return (from i in conn.Table<CartRecord>() select i).ToList();
            }
        }


        public int GetTotal()
        {
            int gtot = 0;
            lock (locker)
            {
                List<CartRecord> items = (from i in conn.Table<CartRecord>() select i).ToList();

                foreach (CartRecord x in items)
                {
                    gtot += Convert.ToInt32(x.Total);

                }
            }
            return gtot;
        }

        //Dispose
        public void Dispose()
        {
            conn.Dispose();
        }
    }
}
