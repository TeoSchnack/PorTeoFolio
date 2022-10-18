using System;
using System.Data;
using Npgsql;

namespace ClassLibrary1.SQL
{
    public class SQLInteraction
    {
        public static DataTable Select(SQLStringConnector Connector, string sColumns, string sDB)
        {
            DataTable tbl = new DataTable();

            NpgsqlConnection Connection = new NpgsqlConnection(Connector.sStringConexion);
            Connection.Open();

            string sSql = "Select ";
            if (sColumns == null)
            {
                sSql += "* ";
            }
            else
            {
                sSql += sColumns;
            }

            sSql += " From " + sDB;

            sSql += " Order by id";

            NpgsqlCommand Comando = new NpgsqlCommand();
            Comando.Connection = Connection;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sSql;

            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(Comando);
            nda.Fill(tbl);
            Comando.Dispose();

            Connection.Close();

            return tbl;
        }
        public static DataTable SelectAND(SQLStringConnector Connector, string sColumns, string sDB, List<string> sConditions)
        {
            DataTable tbl = new DataTable();

            NpgsqlConnection Connection = new NpgsqlConnection(Connector.sStringConexion);
            Connection.Open();

            string sSql = "Select ";
            if (sColumns == "")
            {
                sSql += "* " + Environment.NewLine;
            }
            else
            {
                sSql += sColumns + Environment.NewLine;
            }

            sSql += "From " + sDB + Environment.NewLine;

            if (sConditions != null)
            {
                sSql += "Where " + sConditions[0] + Environment.NewLine;

                if (sConditions.Count > 1)
                {
                    for (int I = 1; I < sConditions.Count; I++)
                    {
                        sSql += "AND " + sConditions[I] + Environment.NewLine;
                    }
                }
            }

            sSql += " Order by id";

            NpgsqlCommand Comando = new NpgsqlCommand();
            Comando.Connection = Connection;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sSql;

            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(Comando);
            nda.Fill(tbl);
            Comando.Dispose();

            return tbl;
        }
        public static DataTable SelectOR(SQLStringConnector Connector, List<string?> sColumns, string sDB, List<string?> sConditions)
        {
            DataTable tbl = new DataTable();

            NpgsqlConnection Connection = new NpgsqlConnection(Connector.sStringConexion);
            Connection.Open();

            string sSql = "Select ";
            if (sColumns == null)
            {
                sSql += "* ";
            }
            else
            {
                sSql += sColumns;
            }

            sSql = "From " + sDB;

            if (sConditions != null)
            {
                sSql += "Where " + sConditions;
            }

            sSql += " Order by id";

            NpgsqlCommand Comando = new NpgsqlCommand();
            Comando.Connection = Connection;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sSql;

            NpgsqlDataAdapter nda = new NpgsqlDataAdapter(Comando);
            nda.Fill(tbl);
            Comando.Dispose();

            return tbl;
        }
        public static void Update(SQLStringConnector Connector, string sDB, string sAlteredColumn, string sNewValue)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(Connector.sStringConexion);
            Connection.Open();

            string sSql = "Update " + sDB + " Set " + sAlteredColumn + " = " + sNewValue;

            NpgsqlCommand Comando = new NpgsqlCommand();
            Comando.Connection = Connection;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sSql;


            Connection.Close();
        }

        public static void Update(SQLStringConnector Connector, string sDB, List<string> sAlteredColumn, List<string> sNewValue)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(Connector.sStringConexion);
            Connection.Open();

            string sSql = "Update " + sDB + " Set ";

            for (int I = 0; I < sAlteredColumn.Count; I++)
            {
                sSql += Environment.NewLine + sAlteredColumn + " = " + sNewValue;
            }

            NpgsqlCommand Comando = new NpgsqlCommand();
            Comando.Connection = Connection;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sSql;


            Connection.Close();
        }

        /**public static void Update(SQLStringConnector Connector, string sDB, string sAlteredColumn, string sNewValue)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(Connector.sStringConexion);
            Connection.Open();

            string sSql = "Update " + sDB + " Set " + sAlteredColumn + " = " + sNewValue;

            NpgsqlCommand Comando = new NpgsqlCommand();
            Comando.Connection = Connection;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sSql;
        }**/

        public static void Update(SQLStringConnector Connector, string sDB, string sAlteredColumn, string sNewValue, string sColumnCondition, string sConditionValue)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(Connector.sStringConexion);
            Connection.Open();

            string sSql = "Update " + sDB + " Set " + sAlteredColumn + " = " + sNewValue +
                          " Where " + sColumnCondition + " = " + sConditionValue;


            NpgsqlCommand Comando = new NpgsqlCommand();
            Comando.Connection = Connection;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sSql;

            Comando.ExecuteNonQuery();

            Connection.Close();
        }

        public static void Insert (SQLStringConnector Connector, string sDB, string sNome, DateOnly dDataInicial, DateOnly dDataFinal, string sCondAmbiente)
        {
            NpgsqlConnection Connection = new NpgsqlConnection(Connector.sStringConexion);
            Connection.Open();

            int iNovoId = ContaId(Connector, sDB) + 1;
            
            string sSql = "INSERT INTO obras("+
                          "     id,"+
                          "     nome," +
                          "     datainicio," +
                          "     datafinal," +
                          "     condambiente" +
                          ")" +
                          "VALUES(" +
                          "     " + iNovoId +
                          " ,'" + sNome + "'" +
                          " ,'" + dDataInicial + "'" +
                          " ,'" + dDataFinal + "'" +
                          " ,'" + sCondAmbiente + "'" +
                          ")";

            NpgsqlCommand Comando = new NpgsqlCommand();
            Comando.Connection = Connection;
            Comando.CommandType = CommandType.Text;
            Comando.CommandText = sSql;

            Comando.ExecuteNonQuery();
        }

        public static int ContaId(SQLStringConnector Connector, string sDB)
        {
            DataTable tbl = Select(Connector, "id", sDB);

            return tbl.Rows.Count;
        }
    }
}