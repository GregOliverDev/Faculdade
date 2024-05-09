using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockController.Data
{
    // classe create(DataBase and Tables)
    public class CreateDb
    {
        public static void CreateDataBase()
        {
            string dataBase = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + dataBase + "; Version = 3";

            if (!File.Exists(dataBase))
            {
                SQLiteConnection.CreateFile(dataBase);
            }

            SQLiteConnection conexao = new SQLiteConnection(strConection);
        }
        public static void CreateBarcodesTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE barcodes ( Id INTEGER NOT NULL PRIMARY KEY, IdProduct INTEGER, GtinEan NVARCHAR(13), Bar128 NVARCHAR(50))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateBatchesTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE batches( Id INTEGER NOT NULL PRIMARY KEY, IdProduct INTEGER, DueDate  NVARCHAR(40), FabricationDate NVARCHAR(40), Number INTEGER, Obsevation NVARCHAR(200))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateBrandsTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE brands ( Id INTEGER NOT NULL PRIMARY KEY, Description NVARCHAR(50))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateCategoriesTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE categories ( Id INTEGER NOT NULL PRIMARY KEY, Description NVARCHAR(200), MovStock NVARCHAR(3))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateProductsTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE products ( Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, IdCategory INTEGER, IdBrand INTEGER, IdUnitM INTEGER, Code INTEGER, Description NVARCHAR(200), Name NVARCHAR(50), ReplacementCost NVARCHAR(70), Status NVARCHAR(15), Value NVARCHAR(70))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateSuppliersTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE suppliers (Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, CpfCnpj NVARCHAR(18), CorporateReason NVARCHAR(70), Name NVARCHAR(70), Obsevation NVARCHAR(200), RegistrationType NVARCHAR(1) , Status NVARCHAR(1))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateUnitMsTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE unitMs ( Id INTEGER NOT NULL PRIMARY KEY, Acronym NVARCHAR(5), DecimalPlaces INTEGER, Name NVARCHAR(50))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateColorsTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE colors ( Id INTEGER NOT NULL PRIMARY KEY, ColorBack NVARCHAR(50), ColorSecond NVARCHAR(50))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateUsersTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE users ( Id INTEGER NOT NULL PRIMARY KEY, CnpjCfp NVARCHAR(18), Nome NVARCHAR(10), Password NVARCHAR(20), Type INTEGER)";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateCodesSuppliersTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE codesSuppliers ( Id INTEGER NOT NULL PRIMARY KEY, IdProduct INTEGER, IdSupplier, Code NVARCHAR(50))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreatePurchasesTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE purchases ( Id INTEGER NOT NULL PRIMARY KEY, IdSupplier INTEGER, Value NVARCHAR(70))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateSalesTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE sales (Id INTEGER NOT NULL PRIMARY KEY, Cliente NVARCHAR(50), Value NVARCHAR(70))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateStockTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE stock ( Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, IdProduct INTEGER, Quant NVARCHAR(70))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
        public static void CreateMovsStockTable()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "CREATE TABLE movsStock ( Id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, IdStock INTEGER, IdOrigin INTEGER, TypeMov NVARCHAR(70) , QuantMov NVARCHAR(70))";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
#pragma warning restore CS0168 // Variable is declared but never used
        }
    }
}

