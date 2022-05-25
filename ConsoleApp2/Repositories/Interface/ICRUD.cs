using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace ConsoleApp2.Repositories.Interface
{
    interface ICRUD
    {
        public void Insert(string a, string b);
        public void Update(int id, string a, string b);
        public void Delete(int id);
        public void GetById();
        public SqlDataReader GetAll();

    }
}
