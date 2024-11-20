using Nhom01.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DAL
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }
        public List<CategoryDTO> LoadCategory()
        {
            List<CategoryDTO> tableList = new List<CategoryDTO>();

            DataTable data = DataP.Instance.ExcuteQuery("SELECT DISTINCT MEDICINE.TYPE_MEDICINE FROM MEDICINE");

            foreach (DataRow item in data.Rows)
            {
                CategoryDTO table = new CategoryDTO(item);
                tableList.Add(table);
            }

            return tableList;
        }
     
        public bool InserCategory(string name, string type, int numMedicine, DateTime dateofmanufuture, DateTime dateexpirationDay, int numprice, string more)
        {
            string query = "EXEC CREATE_MEDICINE @MEDICINE_NAME , @TYPE_MEDICINE , @NUMBER_MEDICINE , @DAY_OF_MANUFUTURE_MEDICINE , @EXPIRATION_DAY_MEDICINE , @PRICE_MEDICINE , @MORE_MEDICINE";
            int result = DataP.Instance.ExcuteNonQuery(query, new object[] { name, type, numMedicine, dateofmanufuture, dateexpirationDay, numprice , more });
            return result > 0;
        }
        public bool UpdateCategory(int ID,string name, string type, int numMedicine, DateTime dateofmanufuture, DateTime dateexpirationDay, int numprice, string more)
        {
            string query = "EXEC UPDATE_MEDICINE @ID , @MEDICINE_NAME , @TYPE_MEDICINE , @NUMBER_MEDICINE , @DAY_OF_MANUFUTURE_MEDICINE , @EXPIRATION_DAY_MEDICINE , @PRICE_MEDICINE , @MORE_MEDICINE";
            int result = DataP.Instance.ExcuteNonQuery(query, new object[] {ID, name, type, numMedicine, dateofmanufuture, dateexpirationDay, numprice, more });
            return result > 0;
        }
        public bool UpdateAfterBuy(int ID,int numMedicine, int count = 0)
        {
            numMedicine-=count;
            
                string query = "EXEC BUY_MEDICINE @ID , @NUMBER_MEDICINE";
                int result = DataP.Instance.ExcuteNonQuery(query, new object[] { ID, numMedicine });
                return result > 0;
            
            
           
        }
        public bool DelCategory(int ID)
        {
            string query = "EXEC DELETE_MEDICINE @ID";
            int result = DataP.Instance.ExcuteNonQuery(query, new object[] { ID });
            return result > 0;
        }
    }
}
