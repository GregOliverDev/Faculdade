using StockController.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace StockController.Data
{
    public class SelectDb
    {
        // select items by Id or use MAX(Id)
        #region selectById
        // select items from the barcodes table by id
        public static Barcode SelectBarcode(int Id, int control)
        {
            Barcode barcode = new Barcode();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM barcodes WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            barcode.Id = Convert.ToInt32(reader["Id"]);
                            barcode.IdProduct = Convert.ToInt32(reader["IdProduct"]);
                            barcode.GtinEan = reader["GtinEan"].ToString();
                            barcode.Bar128 = reader["Bar128"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM barcodes WHERE Id = (SELECT MAX(Id) FROM barcodes)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            barcode.Id = Convert.ToInt32(reader["Id"]);
                            barcode.IdProduct = Convert.ToInt32(reader["IdProduct"]);
                            barcode.GtinEan = reader["GtinEan"].ToString();
                            barcode.Bar128 = reader["Bar128"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            return barcode;
        }

        // select items from the batches table by id
        public static Batch SelectBatch(int Id, int control)
        {
            Batch batch = new Batch();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM batches WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            batch.Id = Convert.ToInt32(reader["Id"]);
                            batch.IdProduct = Convert.ToInt32(reader["IdProduct"]);
                            batch.Number = Convert.ToInt32(reader["Number"]);
                            batch.Obsevation = reader["Obsevation"].ToString();


                            string dateStringDueDate = reader["DueDate"].ToString();
                            string dataStringFabricationDate = reader["FabricationDate"].ToString();

                            DateTime dueDate, fabricationDate;
                            if (DateTime.TryParse(dateStringDueDate, out dueDate))
                            {
                                batch.DueDate = dueDate;
                            }
                            if (DateTime.TryParse(dataStringFabricationDate, out fabricationDate))
                            {
                                batch.FabricationDate = fabricationDate;
                            }

                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM batches WHERE Id = (SELECT MAX(Id) FROM batches)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            batch.Id = Convert.ToInt32(reader["Id"]);
                            batch.IdProduct = Convert.ToInt32(reader["IdProduct"]);
                            batch.Number = Convert.ToInt32(reader["Number"]);
                            batch.Obsevation = reader["Obsevation"].ToString();


                            string dateStringDueDate = reader["DueDate"].ToString();
                            string dataStringFabricationDate = reader["FabricationDate"].ToString();

                            DateTime dueDate, fabricationDate;
                            if (DateTime.TryParse(dateStringDueDate, out dueDate))
                            {
                                batch.DueDate = dueDate;
                            }
                            if (DateTime.TryParse(dataStringFabricationDate, out fabricationDate))
                            {
                                batch.FabricationDate = fabricationDate;
                            }

                        }
                    }
                }
                conexao.Close();
            }

            return batch;
        }

        // select items from the brands table by id
        public static Brand SelectBrand(int Id, int control)
        {
            Brand brand = new Brand();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM brands WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            brand.Id = Convert.ToInt32(reader["Id"]);
                            brand.Description = reader["Description"].ToString();
                        }
                    }
                }
                conexao.Close();
                return brand;
            }
            else if (control == 2)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM brands WHERE Id = (SELECT MAX(Id) FROM brands)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            brand.Id = Convert.ToInt32(reader["Id"]);
                            brand.Description = reader["Description"].ToString();
                        }
                    }
                }
                conexao.Close();
                return brand;
            }
            return brand;
        }

        // select items from the categories table by id
        public static Category SelectCategory(int Id, int control)
        {
            Category category = new Category();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM categories WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            category.Id = Convert.ToInt32(reader["Id"]);
                            category.Description = reader["Description"].ToString();
                            category.MovStock = reader["MovStock"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM categories WHERE Id = (SELECT MAX(Id) FROM categories )";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            category.Id = Convert.ToInt32(reader["Id"]);
                            category.Description = reader["Description"].ToString();
                            category.MovStock = reader["MovStock"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            return category;
        }

        // select items from the products table by Code
        public static Product SelectProduct(int Code, int control)
        {
            Product product = new Product();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM products WHERE Code = '" + Code + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Code", Code);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product.Id = Convert.ToInt32(reader["Id"]);
                            product.IdCategory = Convert.ToInt32(reader["IdCategory"]);
                            product.IdBrand = Convert.ToInt32(reader["IdBrand"]);
                            product.IdUnitM = Convert.ToInt32(reader["IdUnitM"]);
                            product.Code = Convert.ToInt32(reader["Code"]);
                            product.Description = reader["Description"].ToString();
                            product.Name = reader["Name"].ToString();
                            string strReplacementCost = reader["ReplacementCost"].ToString();
                            product.ReplacementCost = float.Parse(strReplacementCost);
                            product.Status = reader["Status"].ToString();
                            string strValue = reader["Value"].ToString();
                            product.Value = float.Parse(strValue);
                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM products WHERE Code = (SELECT MAX(Code) FROM products)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Code", Code);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            product.Id = Convert.ToInt32(reader["Id"]);
                            product.IdCategory = Convert.ToInt32(reader["IdCategory"]);
                            product.IdBrand = Convert.ToInt32(reader["IdBrand"]);
                            product.Code = Convert.ToInt32(reader["Code"]);
                            product.Description = reader["Description"].ToString();
                            product.Name = reader["Name"].ToString();
                            string strReplacementCost = reader["ReplacementCost"].ToString();
                            product.ReplacementCost = float.Parse(strReplacementCost);
                            product.Status = reader["Status"].ToString();
                            string strValue = reader["Value"].ToString();
                            product.Value = float.Parse(strValue);
                        }
                    }
                }
                conexao.Close();
            }
            return product;
        }

        // select items from the suppliers table by id
        public static Supplier SelectSupplier(int Id, int control)
        {
            Supplier supplier = new Supplier();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM suppliers WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            supplier.Id = Convert.ToInt32(reader["Id"]);
                            supplier.CpfCnpj = reader["CpfCnpj"].ToString();
                            supplier.CorporateReason = reader["CorporateReason"].ToString();
                            supplier.Name = reader["Name"].ToString();
                            supplier.Obsevation = reader["Obsevation"].ToString();
                            supplier.RegistrationType = reader["RegistrationType"].ToString();
                            supplier.Status = reader["Status"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM suppliers WHERE Id = (SELECT MAX(Id) FROM suppliers)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            supplier.Id = Convert.ToInt32(reader["Id"]);
                            supplier.CpfCnpj = reader["CpfCnpj"].ToString();
                            supplier.CorporateReason = reader["CorporateReason"].ToString();
                            supplier.Name = reader["Name"].ToString();
                            supplier.Obsevation = reader["Obsevation"].ToString();
                            supplier.RegistrationType = reader["RegistrationType"].ToString();
                            supplier.Status = reader["Status"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            return supplier;
        }

        // select items from the unitMs table by id
        public static UnitM SelectUnitM(int Id, int control)
        {
            UnitM unitM = new UnitM();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM unitMs WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unitM.Id = Convert.ToInt32(reader["Id"]);
                            unitM.Acronym = reader["Acronym"].ToString();
                            unitM.DecimalPlaces = Convert.ToInt32(reader["DecimalPlaces"]);
                            unitM.Name = reader["Name"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM unitMs WHERE Id = (SELECT MAX(Id) FROM unitMs)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            unitM.Id = Convert.ToInt32(reader["Id"]);
                            unitM.Acronym = reader["Acronym"].ToString();
                            unitM.DecimalPlaces = Convert.ToInt32(reader["DecimalPlaces"]);
                            unitM.Name = reader["Name"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            return unitM;
        }

        // select items from the colors table by id
        public static ColorSave SelectColorSave(int Id)
        {
            ColorSave colorSave = new ColorSave();

            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            string query = "SELECT * FROM colors WHERE Id = '" + Id + "'";

            conexao.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, conexao))
            {
                command.Parameters.AddWithValue("@Id", Id);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        colorSave.Id = Convert.ToInt32(reader["Id"]);
                        colorSave.ColorBack = reader["ColorBack"].ToString();
                        colorSave.ColorSecond = reader["ColorSecond"].ToString();

                        string colorString = colorSave.ColorBack;
                        int indexCheckStr = colorString.IndexOf("A=");
                        if (indexCheckStr != 7)
                        {
                            colorString = colorString.Replace("Color [", "").Replace("]", "");
                            colorSave.ColorBackCor = Color.FromName(colorString);
                        }
                        else
                        {
                            int startIndex = colorString.IndexOf("A=") + 2;
                            int length = colorString.IndexOf(",", startIndex) - startIndex;
                            int alpha = int.Parse(colorString.Substring(startIndex, length));
                            startIndex = colorString.IndexOf("R=") + 2;
                            length = colorString.IndexOf(",", startIndex) - startIndex;
                            int red = int.Parse(colorString.Substring(startIndex, length));
                            startIndex = colorString.IndexOf("G=") + 2;
                            length = colorString.IndexOf(",", startIndex) - startIndex;
                            int green = int.Parse(colorString.Substring(startIndex, length));
                            startIndex = colorString.IndexOf("B=") + 2;
                            length = colorString.IndexOf("]", startIndex) - startIndex;
                            int blue = int.Parse(colorString.Substring(startIndex, length));
                            colorSave.ColorBackCor = Color.FromArgb(alpha, red, green, blue);
                        }

                        colorString = colorSave.ColorSecond;
                        indexCheckStr = colorString.IndexOf("A=");
                        if (indexCheckStr != 7)
                        {
                            colorString = colorString.Replace("Color [", "").Replace("]", "");
                            colorSave.ColorSecondCor = Color.FromName(colorString);
                        }
                        else
                        {

                            int startIndex = colorString.IndexOf("A=") + 2;
                            int length = colorString.IndexOf(",", startIndex) - startIndex;
                            int alpha = int.Parse(colorString.Substring(startIndex, length));
                            startIndex = colorString.IndexOf("R=") + 2;
                            length = colorString.IndexOf(",", startIndex) - startIndex;
                            int red = int.Parse(colorString.Substring(startIndex, length));
                            startIndex = colorString.IndexOf("G=") + 2;
                            length = colorString.IndexOf(",", startIndex) - startIndex;
                            int green = int.Parse(colorString.Substring(startIndex, length));
                            startIndex = colorString.IndexOf("B=") + 2;
                            length = colorString.IndexOf("]", startIndex) - startIndex;
                            int blue = int.Parse(colorString.Substring(startIndex, length));
                            colorSave.ColorSecondCor = Color.FromArgb(alpha, red, green, blue);
                        }
                    }
                }
            }
            conexao.Close();
            return colorSave;

        }

        // select items from the codesSuppliers table by id
        public static CodesSuppliers SelectCodesSuppliers(int Id, int control)
        {
            CodesSuppliers codesSuppliers = new CodesSuppliers();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM codesSuppliers WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codesSuppliers.Id = Convert.ToInt32(reader["Id"]);
                            codesSuppliers.IdProduct = Convert.ToInt32(reader["IdProduct"]);
                            codesSuppliers.IdSupplier = Convert.ToInt32(reader["IdSupplier"]);
                            codesSuppliers.Code = reader["Code"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {

                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM codesSuppliers WHERE Id = (SELECT MAX(Id) FROM codesSuppliers)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            codesSuppliers.Id = Convert.ToInt32(reader["Id"]);
                            codesSuppliers.IdProduct = Convert.ToInt32(reader["IdProduct"]);
                            codesSuppliers.IdSupplier = Convert.ToInt32(reader["IdSupplier"]);
                            codesSuppliers.Code = reader["Code"].ToString();
                        }
                    }
                }
                conexao.Close();
            }
            return codesSuppliers;
        }

        //select items from the stock table by code product
        public static Stock SelectStock(int IdProduct)
        {
            Stock stock = new Stock();

            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            string query = "SELECT * FROM stock WHERE IdProduct = '" + IdProduct + "'";

            conexao.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, conexao))
            {
                command.Parameters.AddWithValue("@IdProduct", IdProduct);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        stock.Id = Convert.ToInt32(reader["Id"]);
                        stock.IdProduct = Convert.ToInt32(reader["IdProduct"]);
                        string strQuant = reader["Quant"].ToString();
                        stock.Quant = float.Parse(strQuant);
                    }
                }
            }
            conexao.Close();

            return stock;
        }

        // select items from the sales table by id
        public static Sales SelectSales(int Id, int control)
        {
            Sales sales = new Sales();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM sales WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sales.Id = Convert.ToInt32(reader["Id"]);
                            sales.Cliente = reader["Cliente"].ToString();
                            string strValue = reader["Value"].ToString();
                            sales.Value = float.Parse(strValue);
                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {

                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM sales WHERE Id = (SELECT MAX(Id) FROM sales)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sales.Id = Convert.ToInt32(reader["Id"]);
                            sales.Cliente = reader["Cliente"].ToString();
                            string strValue = reader["Value"].ToString();
                            sales.Value = float.Parse(strValue);
                        }
                    }
                }
                conexao.Close();
            }
            return sales;
        }

        // select items from the purchases table by id
        public static Purchases SelectPurchases(int Id, int control)
        {
            Purchases purchases = new Purchases();
            if (control == 1)
            {
                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM purchases WHERE Id = '" + Id + "'";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            purchases.Id = Convert.ToInt32(reader["Id"]);
                            purchases.IdSupplier = Convert.ToInt32(reader["IdSupplier"]);
                            string strValue = reader["Value"].ToString();
                            purchases.Value = float.Parse(strValue);
                        }
                    }
                }
                conexao.Close();
            }
            else if (control == 2)
            {

                string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
                string strConection = @"Data Source = " + baseDados + "; Version = 3";

                SQLiteConnection conexao = new SQLiteConnection(strConection);
                string query = "SELECT * FROM purchases WHERE Id = (SELECT MAX(Id) FROM purchases)";

                conexao.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@Id", Id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            purchases.Id = Convert.ToInt32(reader["Id"]);
                            purchases.IdSupplier = Convert.ToInt32(reader["IdSupplier"]);
                            string strValue = reader["Value"].ToString();
                            purchases.Value = float.Parse(strValue);
                        }
                    }
                }
                conexao.Close();
            }
            return purchases;
        }


        // select items from the movstock table by idorigin and idstock
        public static MovsStock SelectMovsStock(MovsStock movsStock)
        {
            MovsStock movsStockAux = new MovsStock();


            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            string query = "SELECT * FROM movsStock WHERE Id = '" + movsStock.IdOrigin + "'";

            conexao.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, conexao))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        movsStockAux.Id = Convert.ToInt32(reader["Id"]);
                        movsStockAux.IdOrigin = Convert.ToInt32(reader["IdOrigin"]);
                        movsStockAux.IdStock = Convert.ToInt32(reader["IdStock"]);
                        string strQuant = reader["QuantMov"].ToString();
                        movsStockAux.QuantMov = float.Parse(strQuant);
                        movsStockAux.TypeMov = reader["TypeMov"].ToString();
                    }
                }
            }
            conexao.Close();


            return movsStockAux;
        }
        #endregion

        // select item by name user
        #region SelectUser
        public static User selectUser(string Name)
        {
            User user = new User();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);
            string query = "SELECT * FROM users WHERE Nome = '" + Name + "'";

            conexao.Open();
            using (SQLiteCommand command = new SQLiteCommand(query, conexao))
            {
                command.Parameters.AddWithValue("@Nome", Name);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        user.Id = Convert.ToInt32(reader["Id"]);
                        user.CnpjCfp = reader["CnpjCfp"].ToString();
                        user.Name = reader["Nome"].ToString();
                        user.Password = reader["Password"].ToString();
                        user.Type = Convert.ToInt32(reader["Type"]);
                    }
                }
            }
            conexao.Close();
            return user;
        }

        #endregion

        // select all items or use comand in
        #region selectAll
        // select all items from brandes table
        public static DataTable SelectBrandAll(string filter1, string filter2, string control)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM brands";

                if (control == "Codigo")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM brands WHERE Id BETWEEN '" + filter1 + "' AND '" + filter2 + "'";
                    }
                }
                else if (control == "Descrição")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM brands WHERE Description LIKE '%" + filter1 + "%' AND Description LIKE '%" + filter2 + "%'";
                    }
                }


                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from categories table
        public static DataTable SelectCategoryAll(string filter1, string filter2, string control)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM categories";

                if (control == "Codigo")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM categories WHERE Id BETWEEN '" + filter1 + "' AND '" + filter2 + "'";
                    }
                }
                else if (control == "Descrição")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM categories WHERE Description LIKE '%" + filter1 + "%' AND Description LIKE '%" + filter2 + "%'";
                    }
                }


                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from products table
        public static DataTable SelectProductAll(string filter1, string filter2, string control)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM products";

                if (control == "Codigo")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM products WHERE Code BETWEEN '" + filter1 + "' AND '" + filter2 + "'";
                    }
                }
                else if (control == "Nome")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM products WHERE Name LIKE '%" + filter1 + "%' AND Name LIKE '%" + filter2 + "%'";
                    }
                }


                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from the product table using the code
        public static DataTable SelectProductAllCode(int IdOrigem, String Type)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT p.* FROM products p JOIN stock s ON p.Code = s.IdProduct JOIN movsStock m ON s.Id = m.IdStock WHERE m.IdOrigin = '" + IdOrigem + "' AND m.TypeMov = '" + Type + "'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from suppliers table
        public static DataTable SelectSupplierAll(string filter1, string filter2, string control)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM suppliers";

                if (control == "Codigo")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM suppliers WHERE Id BETWEEN '" + filter1 + "' AND '" + filter2 + "'";
                    }
                }
                else if (control == "Nome")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM suppliers WHERE Name LIKE '%" + filter1 + "%' AND Name LIKE '%" + filter2 + "%'";
                    }
                }


                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from unitMs
        public static DataTable SelectUnitMsAll(string filter1, string filter2, string control)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM unitMs";

                if (control == "Codigo")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM unitMs WHERE Id BETWEEN '" + filter1 + "' AND '" + filter2 + "'";
                    }
                }
                else if (control == "Nome")
                {
                    if (filter1 != "")
                    {
                        query = "SELECT * FROM unitMs WHERE Name LIKE '%" + filter1 + "%' AND Name LIKE '%" + filter2 + "%'";
                    }
                }


                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from barcodes
        public static DataTable SelectBarcodeAll(int idProductCurrent)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM barcodes WHERE IdProduct = '"+idProductCurrent+"'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from batches
        public static DataTable SelectBatchAll(int idProductCurrent)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM batches WHERE IdProduct = '"+idProductCurrent+"'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from codesSuppliers
        public static DataTable SelectCodesSuppliersAll(int idProductCurrent)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM codesSuppliers WHERE IdProduct = '"+idProductCurrent+"'";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from sales
        public static DataTable SelectSalesAll(string filter1, string filter2)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT * FROM sales";


                if (filter1 != "")
                {
                    query = "SELECT * FROM sales WHERE Cliente LIKE '%" + filter1 + "%' AND Cliente LIKE '%" + filter2 + "%'";
                }


                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        // select all items from purchases
        public static DataTable SelectPurchasesAll(string filter1, string filter2)
        {
            DataTable dataTable = new DataTable();
            string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
            string strConection = @"Data Source = " + baseDados + "; Version = 3";

            SQLiteConnection conexao = new SQLiteConnection(strConection);

            try
            {
                string query = "SELECT p.Id, s.Name, p.Value FROM purchases p JOIN suppliers s ON p.IdSupplier = s.Id";


                if (filter1 != "")
                {
                    query = "SELECT p.Id, s.Name, p.Value FROM purchases p JOIN suppliers s ON p.IdSupplier = s.Id  WHERE s.Name LIKE '%" + filter1 + "%' AND s.Name LIKE '%" + filter2 + "%'";
                }


                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, strConection);

                conexao.Open();

                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.Close();
            }
            return dataTable;
        }

        #endregion
    }
}

