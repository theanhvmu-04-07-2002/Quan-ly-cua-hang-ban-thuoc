using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Nhom01.DTO
{
   public class GUEST
    {
        private string password;
        public GUEST(string password)
        {
            this.Password = password;
        }
        public GUEST(DataRow row)
        {
             this.Password = row["PASSWORD"].ToString();
        }
        public string Password { get => password; set => password = value; }
    }
}
