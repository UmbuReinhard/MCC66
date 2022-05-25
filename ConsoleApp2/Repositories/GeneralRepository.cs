using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ConsoleApp2.Repositories.Interface;
using ConsoleApp2.Models;
using System.Collections.Generic;

namespace ConsoleApp2.Repositories
{
    class GeneralRepository : ICRUD
    {

      public SqlConnection conn = new SqlConnection("Data Source=LAPTOP-IF1HQ23G; Initial Catalog= MCC66; User=sa; Password=qwerty123");

      public string NamaTabel;

        public void Delete(int id)
        {
            try
            {
                conn.Open();
                SqlCommand ValueTable = new SqlCommand("Delete from " + NamaTabel + " where id = @0", conn);
                ValueTable.Parameters.Add(new SqlParameter("0", id));
                ValueTable.ExecuteNonQuery();

                Console.WriteLine("Data Berhasil di Delete");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            conn.Close();
        }

        public SqlDataReader GetAll()
        {
           
           try 
           {
                conn.Open();
                SqlCommand ValueTable = new SqlCommand($"Select * from {NamaTabel}", conn);
                //ValueTable.Parameters.Add(new SqlParameter("tabel", NamaTabel));
                return ValueTable.ExecuteReader(); 

           }
           catch(Exception ex) 
           {
                Console.WriteLine(ex.Message);
              
           }
            conn.Close();
            return null;
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }

        public void Insert(string a, string b)
        {
            try
            {
                conn.Open();
                SqlCommand ValueTable = new SqlCommand("Insert into "+ NamaTabel +" Values(@a,@b)", conn);
                ValueTable.Parameters.Add(new SqlParameter("a", a));
                ValueTable.Parameters.Add(new SqlParameter("b", b));
                

                ValueTable.ExecuteNonQuery();


                /*List<KaryawanModel> AllKarywn = new List<KaryawanModel>();
                AllKarywn.Add(new KaryawanModel() {
                   Nama = a ,
                   Jenkel = b
                });*/

                Console.WriteLine("Data Berhasil di Insert");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }

        public void Update(int id, string a, string b)
        {
            try
            {
                conn.Open();
                SqlCommand ValueTable = new SqlCommand("Update "+ NamaTabel +" set nama=@0,jenkel=@1 where id=@2", conn);
                ValueTable.Parameters.Add(new SqlParameter("0", a));
                ValueTable.Parameters.Add(new SqlParameter("1", b));
                ValueTable.Parameters.Add(new SqlParameter("2", id));
                ValueTable.ExecuteNonQuery();

                Console.WriteLine("Data Berhasil di Update");
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            conn.Close();
        }
    }
}
