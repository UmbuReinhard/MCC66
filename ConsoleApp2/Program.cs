using System;
using System.Data.SqlClient;
using System.Text;
using ConsoleApp2.Repositories.Data;
using ConsoleApp2;
using ConsoleApp2.Models;

namespace ConsoleApp2
{
    class Program 
    {

        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //Insert
            /*Console.Write("\nMasukkan Nama          : ");
           string nama = Console.ReadLine();
           Console.Write("\nJenis Kelamin (L/P)    : ");
           string jenkel = Console.ReadLine();
           allKaryawan.Insert(nama, jenkel);*/

            //Update
            /*Console.Write("\nMasukkan ID    : ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("\nMasukkan Nama          : ");
            string nama = Console.ReadLine();
            Console.Write("\nJenis Kelamin (L/P)    : ");
            string jenkel = Console.ReadLine();
            allKaryawan.Update(id, nama, jenkel);*/


            //Delete
            /* Console.Write("\nMasukkan ID    : ");
             int id = int.Parse(Console.ReadLine());
             allKaryawan.Delete(id);*/

            Menu menu = new Menu();
            menu.PilihMenu();

        }

    }
}

class Menu
{
    public int Qwerty { get; set; }

    public void PilihMenu()
    {
        Console.WriteLine("\nDaftar Menu");
        Console.WriteLine("1. Lihat Data Karyawan");
        Console.WriteLine("2. Tambah Data Karyawan");
        Console.WriteLine("3. Edit Data Karyawanaaaaa");
        Console.WriteLine("4. Hapus Data Karyawan");
        Console.WriteLine("Pilih Menu :   ");
        int Hasil = int.Parse(Console.ReadLine());
        KaryawanRepository allKaryawan = new KaryawanRepository();

        KaryawanModel param = new KaryawanModel();

        //isi variabel querty
        Qwerty = 0;


        switch (Hasil)
        {
            case 1: 
                    //Read hahaha
                    SqlDataReader dataReader = allKaryawan.GetAll();
                    Class1.Print();
                    Class1.PrintRow("ID", "Nama", "Jenis Kelamin");
                    Class1.Print();
                    while (dataReader.Read())
                    {
                        Class1.PrintRow(dataReader.GetValue(0).ToString(), dataReader.GetValue(1).ToString(), dataReader.GetValue(2).ToString());
                        Class1.Print();
                    }
                    dataReader.Close();
                    
                    break;
            case 2:
                    //Insert
                    Console.Write("\nMasukkan Nama          : ");
                    param.Nama = Console.ReadLine();
                    Console.Write("\nJenis Kelamin (L/P)    : ");
                    param.Jenkel = Console.ReadLine();
                    allKaryawan.Insert(param.Nama, param.Jenkel);
                    break;
            case 3:
                    //Update
                    Console.Write("\nMasukkan ID    : ");
                    param.Id = int.Parse(Console.ReadLine());
                    Console.Write("\nMasukkan Nama          : ");
                    param.Nama = Console.ReadLine();
                    Console.Write("\nJenis Kelamin (L/P)    : ");
                    param.Jenkel = Console.ReadLine();
                    allKaryawan.Update(param.Id, param.Nama, param.Jenkel);
                    break;
            case 4:
                    //Delete
                    Console.Write("\nMasukkan ID    : ");
                    param.Id = int.Parse(Console.ReadLine());
                    allKaryawan.Delete(param.Id);
                    break;
            default:
                    Console.WriteLine("\nPilihan Tidak Ada");
                    break;

        } 

    }

    public int Again(string a)
    {
        if (a == "y")
        {
            int x = 0;
            return x;
        }
        else
        {
            int x = 1;
            return x;
        }
    }


}
