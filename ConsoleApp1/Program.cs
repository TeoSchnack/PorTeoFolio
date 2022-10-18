using System;
using System.Data;
using Npgsql;
using ClassLibrary1.SQL;
using ConsoleApp1.Enums;

namespace ConsoleApp1
{
    public class Rodador
    {
        public static void Main(string[] args)
        {
            try
            {
                SQLStringConnector Conexion = new SQLStringConnector();
                Menu1 mOpt = Menu1.Inicio;

                while (mOpt != Menu1.Fim)
                {
                    Gap(10);
                    mOpt = Menu();
                    Gap(10);

                    if (mOpt == Menu1.Select)
                    {
                        Select(Conexion);
                    }
                    else if (mOpt == Menu1.Update)
                    {
                        SQLInteraction.Update(Conexion, "Obras", "nome", "\'TrocaNomeTeste\'", "Id", "5");
                    }
                    else if (mOpt == Menu1.Insert)
                    {
                        SQLInteraction.Insert(Conexion, "obras", "TesteInsertC#", DateOnly.FromDateTime(DateTime.Now), new DateOnly(), "Qualquer");
                    }
                }

                Console.WriteLine("Até aqui ok!");
            }
            catch
            {
                Console.WriteLine("Erro!");
            }
        }


        public static void Select (SQLStringConnector Conexion)
        {
            DataTable tbl = SQLInteraction.Select(Conexion, null, "Obras");

            Console.WriteLine("id\tnome\tdatainicio\tdatafinal\tcondambiente");

            for (int I = 0; I < tbl.Rows.Count; I++)
            {
                Console.Write(tbl.Rows[I]["id"] + "\t");
                Console.Write(tbl.Rows[I]["nome"] + "\t");
                Console.Write(tbl.Rows[I]["datainicio"] + "\t");
                Console.Write(tbl.Rows[I]["datafinal"] + "\t");
                //Console.Write(tbl.Rows[I]["condambinete"] + "\t");

                Console.WriteLine();
            }
        }

        public static Menu1 Menu()
        {
            Console.WriteLine(" 1 | Select");
            Console.WriteLine(" 2 | Update");
            Console.WriteLine(" 3 | Insert");

            int OOO = Convert.ToInt32(Console.ReadLine());
            
            if (OOO == 1)
            {
                return Menu1.Select;
            }
            else if (OOO == 2)
            {
                return Menu1.Update;
            }
            else if (OOO == 3)
            {
                return Menu1.Insert;
            }
            else if (OOO == 4)
            {
                return Menu1.Delete;
            }
            else
            {
                return Menu1.Fim;
            }
        }

        public static void Gap(int Ln)
        {
            for (int I = 0; I < Ln; I++)
            {
                Console.WriteLine();
            }
        }
    }
}