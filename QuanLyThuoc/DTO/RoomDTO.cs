using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DTO
{
    public class CategoryDTO
    {
        public CategoryDTO(DataRow datarow)
        {
            this.Type_medicine = datarow["TYPE_MEDICINE"].ToString();
        }
        
        private string type_medicine;

        public string Type_medicine { get => type_medicine; set => type_medicine = value; }
    }
}
