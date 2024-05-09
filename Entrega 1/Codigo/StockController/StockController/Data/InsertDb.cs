using StockController.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StockController.Data
{
    // class insert items into tables
    public class InsertDb
    {
        // insert items into barcodes table
        public static void InsertBarcode(Barcode barcode)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO barcodes(Id, IdProduct, GtinEan, Bar128 ) VALUES ('" + barcode.Id + "', '" + barcode.IdProduct + "', '" + barcode.GtinEan + "', '" + barcode.Bar128 + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into batches table
        public static void InsertBatch(Batch batch)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO batches(Id, IdProduct, DueDate, FabricationDate, Number, Obsevation) VALUES ('" + batch.Id + "','" + batch.IdProduct + "', '" + batch.DueDate + "', '" + batch.FabricationDate + "', '" + batch.Number + "', '" + batch.Obsevation + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into brands table
        public static void InsertBrand(Brand brand)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO brands( Id, Description ) VALUES ('" + brand.Id + "', '" + brand.Description + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into categories table
        public static void InsertCategory(Category category)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO categories( Id, Description, MovStock ) VALUES ('" + category.Id + "', '" + category.Description + "','" + category.MovStock + "' );";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into products table
        public static void InsertProduct(Product product)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO products (IdCategory, IdBrand, IdUnitM , Code, Description, Name, ReplacementCost, Status, Value) VALUES ('" + product.IdCategory + "','" + product.IdBrand + "', '" + product.IdUnitM + "','" + product.Code + "','" + product.Description + "','" + product.Name + "','" + product.ReplacementCost.ToString() + "','" + product.Status + "','" + product.Value.ToString() + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into suppliers table
        public static void InsertSupplier(Supplier supplier)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO suppliers(Id, CpfCnpj, CorporateReason, Name, Obsevation, RegistrationType, Status) VALUES ('" + supplier.Id + "', '" + supplier.CpfCnpj + "','" + supplier.CorporateReason + "', '" + supplier.Name + "','" + supplier.Obsevation + "','" + supplier.RegistrationType + "', '" + supplier.Status + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into unitMs table
        public static void InsertUnitM(UnitM unitM)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO unitMs( Id, Acronym, DecimalPlaces, Name) VALUES ('" + unitM.Id + "', '" + unitM.Acronym + "', '" + unitM.DecimalPlaces + "', '" + unitM.Name + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into colors table
        public static void InsertColorSave(ColorSave colorSave)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO colors( Id, ColorBack, ColorSecond) VALUES ('" + colorSave.Id + "', '" + colorSave.ColorBack + "', '" + colorSave.ColorSecond + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into users table
        public static void InsertUser(User user)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO users( CnpjCfp, Nome , Password, Type ) VALUES ( '" + user.CnpjCfp + "', '" + user.Name + "', '" + user.Password + "', '" + user.Type + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert user dev into users table
        public static void InsertUserDev()
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO users( Id, CnpjCfp, Nome , Password, Type ) VALUES ('" + 1 + "', '" + "dev" + "', '" + "dev" + "', '" + "dev" + "', '" + 4 + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into codesSuppliers table
        public static void InsertCodesSuppliers(CodesSuppliers codesSuppliers)
        {

            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO codesSuppliers( Id, IdProduct, IdSupplier, Code) VALUES ('" + codesSuppliers.Id + "', '" + codesSuppliers.IdProduct + "', '" + codesSuppliers.IdSupplier + "', '" + codesSuppliers.Code + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into stock table
        public static void InsertStock(Stock stock)
        {

            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO stock( IdProduct, Quant) VALUES ('" + stock.IdProduct + "', '" + stock.Quant.ToString() + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into movsStock table
        public static void InsertMovsStock(MovsStock movsStock)
        {

            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO movsStock( IdStock, IdOrigin, TypeMov, QuantMov) VALUES ('" + movsStock.IdStock + "', '" + movsStock.IdOrigin + "', '" + movsStock.TypeMov + "', '" + movsStock.QuantMov.ToString() + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into sales table
        public static void InsertSales(Sales sales)
        {

            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO sales( Id, Cliente, Value) VALUES ('" + sales.Id + "', '" + sales.Cliente + "', '" + sales.Value.ToString() + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }

        // insert items into purchases table
        public static void InsertPurchases(Purchases purchases)
        {

            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "INSERT INTO purchases( Id, IdSupplier, Value) VALUES ('" + purchases.Id + "', '" + purchases.IdSupplier + "', '" + purchases.Value.ToString() + "');";
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexao.Close();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
