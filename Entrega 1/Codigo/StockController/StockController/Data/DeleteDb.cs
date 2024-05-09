using StockController.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockController.Data
{
    public class DeleteDb
    {
        #region deleteItensById
        // delete item barcodes by Id
        public static void DeleteBarcode(Barcode barcode)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM barcodes WHERE Id = '" + barcode.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item batches by Id
        public static void DeleteBatch(Batch batch)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM batches WHERE Id = '" + batch.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item brands by Id
        public static void DeleteBrand(Brand brand)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM brands WHERE Id = '" + brand.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item categories by Id
        public static void DeleteCategory(Category category)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM categories WHERE Id = '" + category.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item products by Code
        public static void DeleteProduct(Product product)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM products WHERE Code = '" + product.Code + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item suppliers by Id
        public static void DeleteSupplier(Supplier supplier)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM suppliers WHERE Id = '" + supplier.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item unitM by Id
        public static void DeleteUnitM(UnitM unitM)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM unitMs WHERE Id = '" + unitM.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        // delete item users by Id
        public static void DeleteUser(User user)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM users WHERE Id = '" + user.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item codesSuppliers by Id
        public static void DeleteCodesSuppliers(CodesSuppliers codesSuppliers)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM codesSuppliers WHERE Id = '" + codesSuppliers.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item stock by Id
        public static void DeleteStock(Stock stock)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM stock WHERE Id = '" + stock.IdProduct + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item sales by Id
        public static void DeleteSales(Sales sales)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM sales WHERE Id = '" + sales.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item purchases by Id
        public static void DeletePurchases(Purchases purchases)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM purchases WHERE Id = '" + purchases.Id + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        // delete item movsStock by Id
        public static void DeleteMovsStock(MovsStock movsStock)
        {
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                conexao.Open();

                SQLiteCommand comando = new SQLiteCommand();
                comando.Connection = conexao;

                comando.CommandText = "DELETE FROM movsStock WHERE IdOrigin = '" + movsStock.IdOrigin + "' AND IdStock = '" + movsStock.IdStock + "'";
                comando.ExecuteNonQuery();
                comando.Dispose();
                conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
        #endregion
    }
}
