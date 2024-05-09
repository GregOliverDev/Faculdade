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
    public class UpdateDb
    {
        // update item into barcodes table
        public static void UpdateBarcode(Barcode barcode)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE barcodes SET IdProduct = '" + barcode.IdProduct + "', GtinEan = '" + barcode.GtinEan + "' , Bar128 = '" + barcode.Bar128 + "' WHERE Id = '" + barcode.Id + "'";
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

        // update item into batches table
        public static void UpdateBatch(Batch batch)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE batches SET IdProduct = '" + batch.IdProduct + "', DueDate = '" + batch.DueDate + "' , FabricationDate = '" + batch.FabricationDate + "' , Number = '" + batch.Number + "' , Obsevation = '" + batch.Obsevation + "'WHERE Id = '" + batch.Id + "'";
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

        // update item into brands table
        public static void UpdateBrand(Brand brand)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE brands SET Description = '" + brand.Description + "' WHERE Id = '" + brand.Id + "'";
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

        // update item into categories table
        public static void UpdateCategory(Category category)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE categories SET Description = '" + category.Description + "' , MovStock = '" + category.MovStock + "'WHERE Id = '" + category.Id + "'";
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

        // update item into products table
        public static void UpdateProduct(Product product)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE products SET IdCategory = '" + product.IdCategory + "', IdBrand = '" + product.IdBrand + "', IdUnitM = '" + product.IdUnitM + "', Code = '" + product.Code + "' ,Description = '" + product.Description + "' , Name = '" + product.Name + "', ReplacementCost = '" + product.ReplacementCost.ToString() + "', Status = '" + product.Status + "', Value =  '" + product.Value.ToString() + "'WHERE Code = '" + product.Code + "'";
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

        // update item into suppliers table
        public static void UpdateSupplier(Supplier supplier)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE suppliers SET CpfCnpj = '" + supplier.CpfCnpj + "', CorporateReason = '" + supplier.CorporateReason + "', Name = '" + supplier.Name + "', Obsevation = '" + supplier.Obsevation + "', RegistrationType = '" + supplier.RegistrationType + "', Status = '" + supplier.Status + "' WHERE Id = '" + supplier.Id + "'";
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

        // update item into unitMs table
        public static void UpdateUnitM(UnitM unitM)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE unitMs SET Acronym = '" + unitM.Acronym + "', DecimalPlaces = '" + unitM.DecimalPlaces + "', Name = '" + unitM.Name + "' WHERE Id = '" + unitM.Id + "'";
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

        // update item into colors table
        public static void UpdateColorSave(ColorSave colorSave)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE colors SET ColorBack = '" + colorSave.ColorBack + "', ColorSecond = '" + colorSave.ColorSecond + "' WHERE Id = '" + colorSave.Id + "'";
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

        // update item into users table
        public static void UpdateUser(User user)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE users SET CnpjCfp = '" + user.CnpjCfp + "' ,Nome = '" + user.Name + "', Password = '" + user.Password + "', Type = '" + user.Type + "' WHERE Id = '" + user.Id + "'";
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

        // update item into stock table
        public static void UpdateStock(Stock stock)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE stock SET Quant = '" + stock.Quant.ToString() + "' WHERE IdProduct = '" + stock.IdProduct + "'";
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

        // update item into sales table
        public static void UpdateSales(Sales sales)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE sales SET value = '" + sales.Value.ToString() + "', Cliente = '" + sales.Cliente + "' WHERE Id = '" + sales.Id + "'";
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

        // update item into purchases table
        public static void UpdatePurchases(Purchases purchases)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "UPDATE purchases SET value = '" + purchases.Value.ToString() + "', IdSupplier = '" + purchases.IdSupplier + "' WHERE Id = '" + purchases.Id + "'";
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
