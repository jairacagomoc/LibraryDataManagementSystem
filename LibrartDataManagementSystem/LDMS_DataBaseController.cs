﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MessageBox = System.Windows.MessageBox;



//// Pull or clone muna kayo lagi sa master branch bago kayo gumawa sa mga branches nyo
/// Boom 

/// <summary>
/// 
/// </summary>

namespace LibrartDataManagementSystem
{
    class LDMS_Constants
    {
        
        public const string tbl_book_CONST = "tbl_book";
        public const string tbl_borrower_CONST = "tbl_borrower";
        public const string tbl_borrowed_book_CONST = "tbl_borrowed_book";
        public const string tbl_logs_type_CONST = "tbl_logs_types";
        public const string tbl_logs_CONST = "tlb_logs";



        public static string get_ID_Name_Of_Table(string table_Name)
        {
            if(table_Name == Info_TBL_BOOK.Const_Names.table_Name)
            {
                return Info_TBL_BOOK.Const_Names.Primary_Key_ID_Name_CONST;
            }
            else if (table_Name == Info_TBL_BORR0WER.Const_Names.table_Name)
            {
                return Info_TBL_BORR0WER.Const_Names.Primary_Key_ID_Name_CONST;
            }
            else if (table_Name == Info_TBL_BORROWED_BOOK.Const_Names.table_Name)
            {
                return Info_TBL_BORROWED_BOOK.Const_Names.Primary_Key_ID_Name_CONST;
            }
            else
            {
                return "";
            }
        }

    }

    class Info_TBL_BOOK
    {
        public string Book_Tittle;
        public string Book_Author;
        public string Book_Genre; /*DateTime*/
        public string Book_Year_Published;
        public string Book_Publisher;
        public int Book_Number_Of_Quantity;

        public static class Const_Names
        {
            public const string table_Name = "tbl_book";


            public const string Primary_Key_ID_Name_CONST = "Book_ID";


            public const string col_0_Book_ID_CONST = Primary_Key_ID_Name_CONST;
            public const string col_1_Book_Tittle_CONST = "Book_Title";
            public const string col_2_Book_Author_CONST = "Book_Author";
            public const string col_3_Book_Genre_CONST = "Book_Genre";
            public const string col_4_Book_Year_Published_CONST = "Book_Year_Published";
            public const string col_5_Book_Publisher_CONST = "Book_Publisher";
            public const string col_6_Book_Number_Of_Quantity_CONST = "Book_Number_Of_Quantity";
            public const string col_7_Book_Date_Encoded_CONST = "Book_Date_Encoded";

        }
        public static class Prop_About
        {
            public const int n_Size = 8;
        }
        public string get_Table_Name()
        {
            return Info_TBL_BOOK.Const_Names.table_Name;
        }

        public string get_Table_Primary_Key_ID_Name()
        {
            return Info_TBL_BOOK.Const_Names.Primary_Key_ID_Name_CONST;
        }

        
    }


    class Info_TBL_BORR0WER
    {
        public string Borrower_First_Name;
        public string Borrower_Middle_Name;
        public string Borrower_Last_Name;
        public string Borrower_Gender;
        public string Borrower_Address;
        public string Borrower_Contact_Number;
        public string Borrower_BirthDate;
        public string Borrower_Type_of_Valid_ID;
        public class Const_Names
        {
            public const string table_Name = "tbl_borrower";


            public const string Primary_Key_ID_Name_CONST = "Borrower_ID";

            public const string col_0_Borrower_ID_CONST = Primary_Key_ID_Name_CONST;
            public const string col_1_Borrower_First_Name_CONST = "Borrower_First_Name";
            public const string col_2_Borrower_Middle_Name_CONST = "Borrower_Middle_Name";
            public const string col_3_Borrower_Last_Name_CONST = "Borrower_Last_Name";
            public const string col_4_Borrower_Gender_CONST = "Borrower_Gender";
            public const string col_5_Borrower_Address_CONST = "Borrower_Address";
            public const string col_6_Borrower_Contact_Number_CONST = "Borrower_Contact_Number";
            public const string col_7_Borrower_BirthDate_CONST = "Borrower_BirthDate";
            public const string col_8_Borrower_Type_of_Valid_ID_CONST = "Borrower_Type_of_Valid_ID";
            public const string col_9_Borrower_Date_Encoded_CONST = "Borrower_Date_Encoded";

        }
        public static class Prop_About
        {
            public const int n_Size = 10;
        }

        public string get_Table_Name()
        {
            return Info_TBL_BORR0WER.Const_Names.table_Name;
        }

        public string get_Table_Primary_Key_ID_Name()
        {
            return Info_TBL_BORR0WER.Const_Names.Primary_Key_ID_Name_CONST;
        }



        
    }



    class Info_TBL_BORROWED_BOOK
    {
        private int Book_ID;
        private int Borrower_ID;

        public string Borrowed_Book_Date_Borrowed;
        public string Borrowed_Book_Due_Date;
        public string Borrowed_Book_Due_Status;
        public string Borrowed_Book_Date_Returned;
        public int Borrowed_Book_Number_of_Copies;
        public static class Const_Names
        {
            public const string table_Name = "tbl_borrowed_book";

            public const string Primary_Key_ID_Name_CONST = "Borrowed_Book_ID";
            public const string Foreign_Key_Book_ID_Name_CONST = "Book_ID";
            public const string Foreign_Key_Borrower_ID_Name_CONST = "Borrower_ID";


            public const string col_0_Borrowed_Book_ID_CONST = Primary_Key_ID_Name_CONST;
            public const string col_1_Book_ID_CONST = Foreign_Key_Book_ID_Name_CONST;
            public const string col_2_Borrower_ID_CONST = Foreign_Key_Borrower_ID_Name_CONST;
            public const string col_3_Borrowed_Book_Date_Borrowed_CONST = "Borrowed_Book_Date_Borrowed";
            public const string col_4_Borrowed_Book_Due_Date_CONST = "Borrowed_Book_Due_Date";
            public const string col_5_Borrowed_Book_Due_Status_CONST = "Borrowed_Book_Due_Status";
            public const string col_6_Borrowed_Book_Date_Returned_CONST = "Borrowed_Book_Date_Returned";
            public const string col_7_Borrowed_Book_Number_of_Copies_CONST = "Borrowed_Book_Number_of_Copies";
            public const string col_8_Borrowed_Book_Date_Encoded_CONST = "Borrowed_Book_Date_Encoded";
        }

        public static class Prop_About
        {
            public const int n_Size = 9;
        }

        public Info_TBL_BORROWED_BOOK(int Book_ID, int Borrower_ID)
        {
            LDMS_DataBaseController dbController = new LDMS_DataBaseController();

            if ((dbController.is_table_ID_Exist(Info_TBL_BOOK.Const_Names.table_Name, Book_ID)) 
                && (dbController.is_table_ID_Exist(Info_TBL_BORR0WER.Const_Names.table_Name, Borrower_ID)))
            {
                this.Book_ID = Book_ID;
                this.Borrower_ID = Borrower_ID;
            }
            else
            {
                MessageBox.Show("invalid Foreign Keys");
            }

            
        }


        public string get_Table_Name()
        {
            return Info_TBL_BORROWED_BOOK.Const_Names.table_Name;
        }

        public string get_Table_Primary_Key_ID_Name()
        {
            return Info_TBL_BORROWED_BOOK.Const_Names.Primary_Key_ID_Name_CONST;
        }


        public int get_Foreign_Key_Book_ID()
        {
            return Book_ID;
        }
        public int get_Foreign_Key_Borrower_ID()
        {
            return Borrower_ID;
        }

        
    }

    class Enum_CONST_Gender//My_Enum_Gender//Enum_CONST_Gender
    {
        public const string const_Male = "Male";
        public const string const_Female = "Female";
        
        public static List<string> get_Enum_Values_Return_String_List()
        {
            List<string> enum_Values = new List<string>();

            enum_Values.Add(const_Male);
            enum_Values.Add(const_Female);

            return enum_Values;
        }
        public static void set_ComboBox_Items(ComboBox genderComboBox)
        {
            genderComboBox.Items.Clear();

            List<string> enum_values = get_Enum_Values_Return_String_List();

            foreach (string enum_item in enum_values)
            {
                genderComboBox.Items.Add(enum_item);
            }

            //genderComboBox.Items.Add(const_Male);
            //genderComboBox.Items.Add(const_Female);

            genderComboBox.SelectedIndex = 0;

            genderComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }

    class Enum_CONST_Type_Valid_ID
    {

        public const string const_0_School_ID_with_Birth_Certificate ="School ID with Birth Certificate";
        public const string const_1_NBI_Clearance_ID = "NBI Clearance/ID";
        public const string const_2_Police_Clearance = "Police Clearance";
        public const string const_3_National_ID = "National ID";
        public const string const_4_Drivers_License = "Driver\'s License";
        public const string const_5_Postal_ID = "Postal ID";
        public const string const_6_TIN_ID = "TIN ID";
        public const string const_7_Voters_ID = "Voter\'s ID";
        public const string const_8_Senior_Citizen_ID = "Senior Citizen ID";
        public const string const_9_PWD_ID = "PWD ID";

        public static List<string> get_Enum_Values_Return_String_List()
        {
            List<string> enum_Values = new List<string>();

            enum_Values.Add(const_0_School_ID_with_Birth_Certificate);
            enum_Values.Add(const_1_NBI_Clearance_ID);
            enum_Values.Add(const_2_Police_Clearance);
            enum_Values.Add(const_3_National_ID);
            enum_Values.Add(const_4_Drivers_License);
            enum_Values.Add(const_5_Postal_ID);
            enum_Values.Add(const_6_TIN_ID);
            enum_Values.Add(const_7_Voters_ID);
            enum_Values.Add(const_8_Senior_Citizen_ID);
            enum_Values.Add(const_9_PWD_ID);


            return enum_Values;
        }


        public static void set_ComboBox_Items(ComboBox enumComboBox)
        {
            enumComboBox.Items.Clear();

            List<string> enum_values = get_Enum_Values_Return_String_List();

            foreach (string enum_item in enum_values)
            {
                enumComboBox.Items.Add(enum_item);
            }

            enumComboBox.SelectedIndex = 0;

            enumComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void print_this()
        {
            //string str = "";

            foreach (string str in get_Enum_Values_Return_String_List())
            {
                MessageBox.Show(str);
            }
        }

    }

    class LDMS_DataBaseController
    {
        string ConnectString = "datasource = localhost; username = root; password=; database = library_data_management_system;";//databasesample;";
        //string ConnectString = "datasource = sql6.freemysqlhosting.net; username = sql6505213; password=3xepDlsiuM; database = sql6505213; port = 3306";//databasesample;";
        MySqlConnection connectDB;
        MySqlCommand cmd;
        MySqlDataAdapter da;

        public DataTable dt;
        int result;


        
        
        public bool IsDataBaseOpen()
        {
            bool success;
            connectDB = new MySqlConnection(ConnectString);
            try
            {
                connectDB.Open();
                success = true;
            }
            catch
            {
                success = false;
            }
            return success;
        }

        public bool connectDB_And_ExecuteNonQuery(string execute_SQL_StateMent)
        {
            bool success;

            connectDB = new MySqlConnection(ConnectString);

            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(execute_SQL_StateMent, connectDB);
                //cmd.Connection = connectDB;
                //cmd.CommandText = sqlStrCommand;
                result = cmd.ExecuteNonQuery();

                success = true;
            }
            catch (Exception e)
            {
                string delProb = "Cannot delete or update a parent row: a foreign key constraint fails " +
                    "(`library_data_management_system`.`tbl_borrowed_book`, CONSTRAINT " +
                    "`tbl_borrowed_book_ibfk_1` FOREIGN KEY (`Book_ID`) REFERENCES `tbl_book` (`Book_ID`))";
                if (e.Message == delProb)
                {
                    MessageBox.Show("The book has currently borrower.");
                }
                else
                {
                    MessageBox.Show("Failed! " + e.Message);
                }
                success = false;
            }
            finally
            {
                connectDB.Close();
            }
            return success;
            

            //sqlCommandDB(sqlStrCommand);

        }


        /// <summary>
        /// insert method base on the statement
        /// </summary>
        /// <param name="insert_SQL_StateMent">sql statement to use</param>
        public bool insert_DBMethod(string insert_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(insert_SQL_StateMent);
        }
        //*/    


        public bool is_table_ID_Exist(string table_Name, int table_ID)
        {
            string table_ID_Name = LDMS_Constants.get_ID_Name_Of_Table(table_Name);
            if (table_ID_Name != "")
            {
                string query = $"SELECT {table_ID_Name} FROM `{table_Name}` WHERE `{table_ID_Name}` = \"{table_ID}\"";
                List<List<string>> table_ID_2D_List = select_DBMethod_return_2DList_Table_Records(query);
                return ((table_ID_2D_List.Count != 0) && (table_ID_2D_List[0][0].Equals(table_ID.ToString())));
            }
            else
            {
                return false;
            }
            /*
            if ((table_ID_2D_List.Count != 0) && (table_ID_2D_List[0][0].Equals(table_ID.ToString())))
            {
                return true;
            }
            else
            {
                return false;
            }
            //*/
        }

        public bool insert_DBMethod_BOOKS(Info_TBL_BOOK tbl_Infos) //(string Book_Tittle, string Book_Author, string Book_Genre, /*DateTime*/ string Book_Year_Published, string Book_Publisher, int Book_Number_Of_Quantity)
        {

            string insert_SQL_StateMent = $"INSERT INTO `{tbl_Infos.get_Table_Name()}` (" +
            $"`{Info_TBL_BOOK.Const_Names.col_1_Book_Tittle_CONST}`" + ", " +
            $"`{Info_TBL_BOOK.Const_Names.col_2_Book_Author_CONST}`" + ", " +
            $"`{Info_TBL_BOOK.Const_Names.col_3_Book_Genre_CONST}`" + ", " +
            $"`{Info_TBL_BOOK.Const_Names.col_4_Book_Year_Published_CONST}`" + ", " +
            $"`{Info_TBL_BOOK.Const_Names.col_5_Book_Publisher_CONST}`" + ", " +
            $"`{Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST}`" +
            $") " +
            $"VALUES (" +
            $"\"{tbl_Infos.Book_Tittle}\"" + ", " +
            $"\"{tbl_Infos.Book_Author}\"" + ", " +
            $"\"{tbl_Infos.Book_Genre}\"" + ", " +
            $"\"{tbl_Infos.Book_Year_Published}\"" + ", " +
            $"\"{tbl_Infos.Book_Publisher}\"" + ", " +
            $"\"{tbl_Infos.Book_Number_Of_Quantity}\"" +
            $") ";

            return insert_DBMethod(insert_SQL_StateMent);

        }

        public bool insert_DBMethod_BORROWER(Info_TBL_BORR0WER tbl_Infos)//(string Borrower_First_Name, string Borrower_Middle_Name, string Borrower_Last_Name, string Borrower_Gender, string Borrower_Address, string Borrower_Contact_Number, /*Datetime*/ string Borrower_BirthDate, string Borrower_Type_of_Valid_ID)
        {
            Console.WriteLine(tbl_Infos.Borrower_First_Name);
            string insert_SQL_StateMent = $"INSERT INTO `{tbl_Infos.get_Table_Name()}` (" +
            $"`{Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST}`" + ", " +
            $"`{Info_TBL_BORR0WER.Const_Names.col_2_Borrower_Middle_Name_CONST}`" + ", " +
            $"`{Info_TBL_BORR0WER.Const_Names.col_3_Borrower_Last_Name_CONST}`" + ", " +
            $"`{Info_TBL_BORR0WER.Const_Names.col_4_Borrower_Gender_CONST}`" + ", " +
            $"`{Info_TBL_BORR0WER.Const_Names.col_5_Borrower_Address_CONST}`" + ", " +
            $"`{Info_TBL_BORR0WER.Const_Names.col_6_Borrower_Contact_Number_CONST}`" + ", " +
            $"`{Info_TBL_BORR0WER.Const_Names.col_7_Borrower_BirthDate_CONST}`" + ", " +
            $"`{Info_TBL_BORR0WER.Const_Names.col_8_Borrower_Type_of_Valid_ID_CONST}`" +
            $") " +
            $"VALUES (" +
            $"\"{tbl_Infos.Borrower_First_Name}\"" + ", " +
            $"\"{tbl_Infos.Borrower_Middle_Name}\"" + ", " +
            $"\"{tbl_Infos.Borrower_Last_Name}\"" + ", " +
            $"\"{tbl_Infos.Borrower_Gender}\"" + ", " +
            $"\"{tbl_Infos.Borrower_Address}\"" + ", " +
            $"\"{tbl_Infos.Borrower_Contact_Number}\"" + ", " +
            $"\"{tbl_Infos.Borrower_BirthDate}\"" + ", " +
            $"\"{tbl_Infos.Borrower_Type_of_Valid_ID}\"" +
            $") ";
            //return false;
            return insert_DBMethod(insert_SQL_StateMent);

        }

        //*
        public bool insert_DBMethod_BORROWED_BOOK(Info_TBL_BORROWED_BOOK tbl_Infos) //(int Book_ID, int Borrower_ID, string Borrowed_Book_Date_Borrowed, string Borrowed_Book_Due_Date, string Borrowed_Book_Due_Status, string Borrowed_Book_Date_Returned, int Borrowed_Book_Number_of_Copies)
        {
                
            if ((is_table_ID_Exist(Info_TBL_BOOK.Const_Names.table_Name, tbl_Infos.get_Foreign_Key_Book_ID())) && (is_table_ID_Exist(Info_TBL_BORR0WER.Const_Names.table_Name, tbl_Infos.get_Foreign_Key_Borrower_ID())))
            {
                /*
                string insert_SQL_StateMent = $"INSERT INTO `{tbl_Infos.get_Table_Name()}` (" +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_1_Book_ID_CONST}`" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_2_Borrower_ID_CONST}`" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_3_Borrowed_Book_Date_Borrowed_CONST}`" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_4_Borrowed_Book_Due_Date_CONST}`" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_5_Borrowed_Book_Due_Status_CONST}`" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_6_Borrowed_Book_Date_Returned_CONST}`" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_7_Borrowed_Book_Number_of_Copies_CONST}`" +
                    $") " +
                    $"VALUES (" +
                    $"{tbl_Infos.get_Foreign_Key_Book_ID()}" + ", " +
                    $"{tbl_Infos.get_Foreign_Key_Borrower_ID()}" + ", " +
                    $"\"{tbl_Infos.Borrowed_Book_Date_Borrowed}\"" + ", " +
                    $"\"{tbl_Infos.Borrowed_Book_Due_Date}\"" + ", " +
                    $"\"{tbl_Infos.Borrowed_Book_Due_Status}\"" + ", " +
                    $"\"{tbl_Infos.Borrowed_Book_Date_Returned}\"" +
                    $"{tbl_Infos.Borrowed_Book_Number_of_Copies}" +
                    $") ";
                //*/


                string singleQuoteChar = "'";

                string table_Name = tbl_Infos.get_Table_Name();//"tbl_borrowed_book";
                //string table_Columns = "(Book_ID, Borrower_ID, Borrowed_Book_Date_Borrowed, Borrowed_Book_Due_Date, Borrowed_Book_Due_Status, Borrowed_Book_Date_Returned, Borrowed_Book_Number_of_Copies)";
                string table_Columns = $"(" +
                    $"{Info_TBL_BORROWED_BOOK.Const_Names.col_1_Book_ID_CONST}, " +
                    $"{Info_TBL_BORROWED_BOOK.Const_Names.col_2_Borrower_ID_CONST}, " +
                    $"{Info_TBL_BORROWED_BOOK.Const_Names.col_3_Borrowed_Book_Date_Borrowed_CONST}, " +
                    $"{Info_TBL_BORROWED_BOOK.Const_Names.col_4_Borrowed_Book_Due_Date_CONST}, " +
                    $"{Info_TBL_BORROWED_BOOK.Const_Names.col_5_Borrowed_Book_Due_Status_CONST}, " +
                    $"{Info_TBL_BORROWED_BOOK.Const_Names.col_6_Borrowed_Book_Date_Returned_CONST}, " +
                    $"{Info_TBL_BORROWED_BOOK.Const_Names.col_7_Borrowed_Book_Number_of_Copies_CONST}" +
                    $")";
                //string table_Columns = "(Book_Tittle, Book_Author, Book_Genre,  Book_Publisher, Book_Number_Of_Quantity)";
                string table_Column_Values = "(" +
                    tbl_Infos.get_Foreign_Key_Book_ID() + ", " +
                    tbl_Infos.get_Foreign_Key_Borrower_ID() + ", " +
                    singleQuoteChar + tbl_Infos.Borrowed_Book_Date_Borrowed + singleQuoteChar + ", " +
                    singleQuoteChar + tbl_Infos.Borrowed_Book_Due_Date + singleQuoteChar + ", " +
                    singleQuoteChar + tbl_Infos.Borrowed_Book_Due_Status + singleQuoteChar + ", " +
                    singleQuoteChar + tbl_Infos.Borrowed_Book_Date_Returned + singleQuoteChar + ", " +
                    tbl_Infos.Borrowed_Book_Number_of_Copies +
                    ")";
                string insert_SQL_StateMent = "Insert into " + table_Name + " " + table_Columns + "  values " + table_Column_Values;


                bool isSuccess = insert_DBMethod(insert_SQL_StateMent);

                int num_Qntty = int.Parse(select_DBMethod_return_a_Cell(Info_TBL_BOOK.Const_Names.table_Name,
                                                                        tbl_Infos.get_Foreign_Key_Book_ID(),
                                                                        Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST));

                int number_of_Books_Left = num_Qntty - tbl_Infos.Borrowed_Book_Number_of_Copies;
                if (isSuccess)
                {
                    if ((number_of_Books_Left > 0))
                    {
                        string query = $"UPDATE `{Info_TBL_BOOK.Const_Names.table_Name}` SET " +
                        $"`{Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST}`=\"{number_of_Books_Left}\" " +
                        $"WHERE `{Info_TBL_BOOK.Const_Names.Primary_Key_ID_Name_CONST}` = '{tbl_Infos.get_Foreign_Key_Book_ID()}'";
                        return connectDB_And_ExecuteNonQuery(query);
                    }
                    else if((number_of_Books_Left == 0))
                    {
                        string query = $"UPDATE `{Info_TBL_BOOK.Const_Names.table_Name}` SET " +
                        $"`{Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST}`=\"{number_of_Books_Left}\" " +
                        $"WHERE `{Info_TBL_BOOK.Const_Names.Primary_Key_ID_Name_CONST}` = '{tbl_Infos.get_Foreign_Key_Book_ID()}'";
                        bool islastOneAvailbleTaken = connectDB_And_ExecuteNonQuery(query);

                        if (islastOneAvailbleTaken)
                        {
                            return delete_DBMethod_return_Boolean(Info_TBL_BOOK.Const_Names.table_Name, tbl_Infos.get_Foreign_Key_Book_ID());
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;       
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        //*/
        
        


        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_ID"></param>
        /// <param name="tbl_Infos"></param>
        /// <returns></returns>
        public bool update_DBMethod_BOOKS(int table_ID, Info_TBL_BOOK tbl_Infos)
        {

            if (is_table_ID_Exist(tbl_Infos.get_Table_Name(), table_ID))
            {
                string update_SQL_StateMent = $"UPDATE `{tbl_Infos.get_Table_Name()}` SET " +

                    $"`{Info_TBL_BOOK.Const_Names.col_1_Book_Tittle_CONST}`=\"{tbl_Infos.Book_Tittle}\"" + ", " +
                    $"`{Info_TBL_BOOK.Const_Names.col_2_Book_Author_CONST}`=\"{tbl_Infos.Book_Author}\"" + ", " +
                    $"`{Info_TBL_BOOK.Const_Names.col_3_Book_Genre_CONST}`=\"{tbl_Infos.Book_Genre}\"" + ", " +
                    $"`{Info_TBL_BOOK.Const_Names.col_4_Book_Year_Published_CONST}`=\"{tbl_Infos.Book_Year_Published}\"" + ", " +
                    $"`{Info_TBL_BOOK.Const_Names.col_5_Book_Publisher_CONST}`=\"{tbl_Infos.Book_Publisher}\"" + ", " +
                    $"`{Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST}`=\"{tbl_Infos.Book_Number_Of_Quantity}\"" +

                    $" WHERE `{tbl_Infos.get_Table_Primary_Key_ID_Name()}` = '{table_ID}'";

                return connectDB_And_ExecuteNonQuery(update_SQL_StateMent);//update_DBMethod(query);
            }
            else
            {
                return false;
            }
            //return connectDB_And_ExecuteNonQuery(update_SQL_StateMent);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_ID"></param>
        /// <param name="tbl_Infos"></param>
        /// <returns></returns>
        public bool update_DBMethod_BORROWER(int table_ID, Info_TBL_BORR0WER tbl_Infos)
        {

            if (is_table_ID_Exist(tbl_Infos.get_Table_Name(), table_ID))
            {
                string update_SQL_StateMent = $"UPDATE `{tbl_Infos.get_Table_Name()}` SET " +

                    $"`{Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST}`=\"{tbl_Infos.Borrower_First_Name}\"" + ", " +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_2_Borrower_Middle_Name_CONST}`=\"{tbl_Infos.Borrower_Middle_Name}\"" + ", " +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_3_Borrower_Last_Name_CONST}`=\"{tbl_Infos.Borrower_Last_Name}\"" + ", " +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_4_Borrower_Gender_CONST}`=\"{tbl_Infos.Borrower_Gender}\"" + ", " +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_5_Borrower_Address_CONST}`=\"{tbl_Infos.Borrower_Address}\"" + ", " +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_6_Borrower_Contact_Number_CONST}`=\"{tbl_Infos.Borrower_Contact_Number}\"" + ", " +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_7_Borrower_BirthDate_CONST}`=\"{tbl_Infos.Borrower_BirthDate}\"" + ", " +
                    $"`{Info_TBL_BORR0WER.Const_Names.col_8_Borrower_Type_of_Valid_ID_CONST}`=\"{tbl_Infos.Borrower_Type_of_Valid_ID}\"" +
              
                    $" WHERE `{tbl_Infos.get_Table_Primary_Key_ID_Name()}` = '{table_ID}'";
                return connectDB_And_ExecuteNonQuery(update_SQL_StateMent);//update_DBMethod(query);
            }
            else
            {
                return false;
            }
            //return connectDB_And_ExecuteNonQuery(update_SQL_StateMent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_ID"></param>
        /// <param name="tbl_Infos"></param>
        /// <returns></returns>
        public bool update_DBMethod_BORROWED_BOOK(int table_ID, Info_TBL_BORROWED_BOOK tbl_Infos)
        {

            if ((is_table_ID_Exist(Info_TBL_BOOK.Const_Names.table_Name, tbl_Infos.get_Foreign_Key_Book_ID())) && (is_table_ID_Exist(Info_TBL_BORR0WER.Const_Names.table_Name, tbl_Infos.get_Foreign_Key_Borrower_ID())))
            {
                string update_SQL_StateMent = $"UPDATE `{tbl_Infos.get_Table_Name()}` SET " +

                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_1_Book_ID_CONST}`=\"{tbl_Infos.get_Foreign_Key_Book_ID()}\"" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_2_Borrower_ID_CONST}`=\"{tbl_Infos.get_Foreign_Key_Borrower_ID()}\"" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_3_Borrowed_Book_Date_Borrowed_CONST}`=\"{tbl_Infos.Borrowed_Book_Date_Borrowed}\"" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_4_Borrowed_Book_Due_Date_CONST}`=\"{tbl_Infos.Borrowed_Book_Due_Date}\"" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_5_Borrowed_Book_Due_Status_CONST}`=\"{tbl_Infos.Borrowed_Book_Due_Status}\"" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_6_Borrowed_Book_Date_Returned_CONST}`=\"{tbl_Infos.Borrowed_Book_Date_Returned}\"" + ", " +
                    $"`{Info_TBL_BORROWED_BOOK.Const_Names.col_7_Borrowed_Book_Number_of_Copies_CONST}`=\"{tbl_Infos.Borrowed_Book_Number_of_Copies}\"" +

                    $" WHERE `{tbl_Infos.get_Table_Primary_Key_ID_Name()}` = '{table_ID}'";

                bool isSuccess = connectDB_And_ExecuteNonQuery(update_SQL_StateMent);//update_DBMethod(query);

                string num_Qntty = select_DBMethod_return_a_Cell(Info_TBL_BOOK.Const_Names.table_Name, 
                                                                    tbl_Infos.get_Foreign_Key_Book_ID(), 
                                                                    Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST);

                int value = int.Parse(num_Qntty) - tbl_Infos.Borrowed_Book_Number_of_Copies;
                if (isSuccess)
                {
                    string query = $"UPDATE `{Info_TBL_BOOK.Const_Names.table_Name}` SET " +
                    $"`{Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST}`=\"{value}\" " +
                    $"WHERE `{Info_TBL_BOOK.Const_Names.Primary_Key_ID_Name_CONST}` = '{tbl_Infos.get_Foreign_Key_Book_ID()}'";
                    return connectDB_And_ExecuteNonQuery(query);
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            if (is_table_ID_Exist(tbl_Infos.get_Table_Name(), table_ID))
            {
                
            }
            else
            {
                return false;
            }
            //return connectDB_And_ExecuteNonQuery(update_SQL_StateMent);

        }

 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="table_ID"></param>
        /// <param name="column_Name"></param>
        /// <param name="value_INT_TYPE"></param>
        /// <returns></returns>
        public bool update_DBMethod_Update_A_Cell(string table_Name, int table_ID, string column_Name, int value_INT_TYPE)//int quantity)
        {
            if (is_table_ID_Exist(table_Name, table_ID))
            {
                int currentQuantity = int.Parse(select_DBMethod_return_a_Cell(table_Name, table_ID, column_Name));
                
                string query = $"UPDATE `{table_Name}` SET `{column_Name}`='{currentQuantity + value_INT_TYPE}' " +
                                $"WHERE `Book_ID` = \"{table_ID}\"";

                return connectDB_And_ExecuteNonQuery(query);
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="table_ID"></param>
        /// <param name="column_Name"></param>
        /// <param name="value_STRING_TYPE"></param>
        /// <returns></returns>
        public bool update_DBMethod_Update_A_Cell(string table_Name, int table_ID, string column_Name, string value_STRING_TYPE)//int quantity)
        {
            if (is_table_ID_Exist(table_Name, table_ID))
            {
                int currentQuantity = int.Parse(select_DBMethod_return_a_Cell(table_Name, table_ID, column_Name));

                string query = $"UPDATE `{table_Name}` SET `{column_Name}`='{currentQuantity + value_STRING_TYPE}' " +
                                $"WHERE `Book_ID` = \"{table_ID}\"";

                return connectDB_And_ExecuteNonQuery(query);
            }
            else
            {
                return false;
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="select_SQL_StateMent"></param>
        /// <returns></returns>
        public List<List<string>> select_DBMethod_return_2DList_Table_Records(string select_SQL_StateMent)
        {
            connectDB = new MySqlConnection(ConnectString);

            List<List<string>> select_Query_Result_2D_Liist = new List<List<string>>();
            try
            {
                connectDB.Open();
                cmd = new MySqlCommand(select_SQL_StateMent, connectDB);
                MySqlDataReader tableReader = cmd.ExecuteReader();

                while (tableReader.Read())
                {
                    List<string> rowRecord_StrList = new List<string>();

                    for (int i = 0; i < tableReader.FieldCount; i++)
                    {
                        rowRecord_StrList.Add(tableReader.GetValue(i).ToString());
                    }
                 
                    select_Query_Result_2D_Liist.Add(rowRecord_StrList);
                }
            }
            catch (Exception e)
            {

                return null;
            }
            finally
            {
                connectDB.Close();
            }

            return select_Query_Result_2D_Liist;
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="table_ID"></param>
        /// <param name="column_Name"></param>
        /// <returns></returns>
        public string select_DBMethod_return_a_Cell(string table_Name, int table_ID, string column_Name)
        {
            string select_SQL_StateMent = $"SELECT {column_Name} FROM `{table_Name}` WHERE `{LDMS_Constants.get_ID_Name_Of_Table(table_Name)}` = \"{table_ID}\"";
            List<List<string>> temp2DStrList_Row = select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
            string select_Query_A_Cell = "";

            select_Query_A_Cell = temp2DStrList_Row[0][0];
            
            return select_Query_A_Cell;
        }
        /*
            int outerIndex = 0;
            foreach (List<string> infos in temp2DStrList_Row)
            {
                int innerIndex = 0;
                foreach (string info in infos)
                {
                    select_Query_1D_StrList_Row.Add(temp2DStrList_Row[outerIndex][innerIndex]);
                    innerIndex++;
                }
                outerIndex++;
            }
            //*/






        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="table_ID"></param>
        /// <returns></returns>
        public List<string> select_DBMethod_return_A_Row_Of_Records(string table_Name, int table_ID)
        {
            string select_SQL_StateMent = $"SELECT * FROM `{table_Name}` WHERE `{LDMS_Constants.get_ID_Name_Of_Table(table_Name)}` = \"{table_ID}\"";
            return select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent)[0];
     
        }


        /*
            List<List<string>> temp2DStrList_Row = select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
            List<string> select_Query_1D_StrList_Row = new List<string>();

            int outerIndex = 0;
            foreach (List<string> infos in temp2DStrList_Row)
            {
                int innerIndex = 0;
                foreach (string info in infos)
                {
                    select_Query_1D_StrList_Row.Add(temp2DStrList_Row[outerIndex][innerIndex]);
                    innerIndex++;
                }
                outerIndex++;
            }

            return select_Query_1D_StrList_Row;
            */




        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="column_Name"></param>
        /// <returns></returns>
        public List<string> select_DBMethod_return_A_Column_Of_Records(string table_Name, string column_Name)
        {
            string select_SQL_StateMent = $"SELECT {column_Name} FROM `{table_Name}`";
            List<List<string>> temp2DStrList_Column = select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
            List<string> select_Query_1D_StrList_Column = new List<string>();

            foreach (List<string> rowItem in temp2DStrList_Column)
            {
                select_Query_1D_StrList_Column.Add(rowItem[0]);
            }
            return select_Query_1D_StrList_Column;

        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="column_Name"></param>
        /// <param name="column_Name_OrderBy"></param>
        /// <param name="orderBy"></param>
        /// <returns></returns>
        public List<string> select_DBMethod_return_A_Column_Of_Distinct_Records_OrderBy(string table_Name, string column_Name, string column_Name_OrderBy, string orderBy = "ASC")
        {
            string select_SQL_StateMent = $"SELECT {column_Name} FROM `{table_Name}` ORDER BY {column_Name_OrderBy} {orderBy}";
            List<List<string>> temp2DStrList_Column = select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
            List<string> select_Query_1D_StrList_Column = new List<string>();

            foreach (List<string> rowItem in temp2DStrList_Column)
            {
                select_Query_1D_StrList_Column.Add(rowItem[0]);
            }


            select_Query_1D_StrList_Column = select_Query_1D_StrList_Column.Distinct().ToList();

            return select_Query_1D_StrList_Column;
        }


        public List<List<string>> select_DBMethod_BORROWER()
        {
                       
            string select_SQL_StateMent = "Select * From " + Info_TBL_BORR0WER.Const_Names.table_Name;

            return select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);
        }







        public List<string> select_DBMethod_Table_Details_Return_Prime_ID_Column(Info_TBL_BOOK tbl_Infos)
            //(string bookTitle, string bookAuthor, string bookGenre, string bookPublisher, string yearPublished)
        {
            string query = $"SELECT * FROM `{tbl_Infos.get_Table_Name()}` WHERE " +
                
                $"`{Info_TBL_BOOK.Const_Names.col_1_Book_Tittle_CONST}` = \"{tbl_Infos.Book_Tittle}\" AND " +
                $"`{Info_TBL_BOOK.Const_Names.col_2_Book_Author_CONST}` = \"{tbl_Infos.Book_Author}\" AND " +
                $"`{Info_TBL_BOOK.Const_Names.col_3_Book_Genre_CONST}` = \"{tbl_Infos.Book_Genre}\" AND " +
                $"`{Info_TBL_BOOK.Const_Names.col_4_Book_Year_Published_CONST}` = \"{tbl_Infos.Book_Year_Published}\" AND " +
                $"`{Info_TBL_BOOK.Const_Names.col_5_Book_Publisher_CONST}` = \"{tbl_Infos.Book_Publisher}\" AND " +
                $"`{Info_TBL_BOOK.Const_Names.col_6_Book_Number_Of_Quantity_CONST}` = \"{tbl_Infos.Book_Number_Of_Quantity}\"";

            List<List<string>> rslts_2D = select_DBMethod_return_2DList_Table_Records(query);
            List<string> prime_ID_Columns = new List<string>();
            foreach (List<string> book in rslts_2D)
            {
                prime_ID_Columns.Add(book[0]);
            }
            return prime_ID_Columns;
        }

        public List<string> select_DBMethod_Table_Details_Return_Prime_ID_Column(Info_TBL_BORR0WER tbl_Infos)
        //(string bookTitle, string bookAuthor, string bookGenre, string bookPublisher, string yearPublished)
        {
            string query = $"SELECT * FROM `{tbl_Infos.get_Table_Name()}` WHERE " +

                $"`{Info_TBL_BORR0WER.Const_Names.col_1_Borrower_First_Name_CONST}` = \"{tbl_Infos.Borrower_First_Name}\" AND " +
                $"`{Info_TBL_BORR0WER.Const_Names.col_2_Borrower_Middle_Name_CONST}` = \"{tbl_Infos.Borrower_Middle_Name}\" AND " +
                $"`{Info_TBL_BORR0WER.Const_Names.col_3_Borrower_Last_Name_CONST}` = \"{tbl_Infos.Borrower_Middle_Name}\" AND " +
                $"`{Info_TBL_BORR0WER.Const_Names.col_4_Borrower_Gender_CONST}` = \"{tbl_Infos.Borrower_Gender}\" AND " +
                $"`{Info_TBL_BORR0WER.Const_Names.col_5_Borrower_Address_CONST}` = \"{tbl_Infos.Borrower_Address}\" AND " +
                $"`{Info_TBL_BORR0WER.Const_Names.col_6_Borrower_Contact_Number_CONST}` = \"{tbl_Infos.Borrower_Contact_Number}\" AND " +
                $"`{Info_TBL_BORR0WER.Const_Names.col_7_Borrower_BirthDate_CONST}` = \"{tbl_Infos.Borrower_BirthDate}\" AND " +
                $"`{Info_TBL_BORR0WER.Const_Names.col_8_Borrower_Type_of_Valid_ID_CONST}` = \"{tbl_Infos.Borrower_Type_of_Valid_ID}\"";

            List<List<string>> rslts_2D = select_DBMethod_return_2DList_Table_Records(query);
            List<string> prime_ID_Columns = new List<string>();
            foreach (List<string> book in rslts_2D)
            {
                prime_ID_Columns.Add(book[0]);
            }
            return prime_ID_Columns;
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="update_SQL_StateMent"></param>
        /// <returns></returns>
        public bool update_DBMethod(string update_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(update_SQL_StateMent);
        }

        




        /*
        /// <summary>
        /// Update book dependin on ID and book info
        /// </summary>
        /// <param name="Book_ID"></param>
        /// <param name="tbl_book_Info"></param>
        /// <returns></returns>
        public bool update_DBMethod_tbl_book(int Book_ID, Info_TBL_BOOK tbl_book_Info)
        {
            if (is_table_ID_Exist("tbl_book", table_ID))
            {
                string query = $"UPDATE `tbl_book` SET `Book_Title`=\"{tbl_book_Info.Book_Tittle}\"," +
                $"`Book_Author`=\"{tbl_book_Info.Book_Author}\"" +
                $",`Book_Genre`=\"{tbl_book_Info.Book_Genre}\"," +
                $"`Book_Year_Published`=\"{tbl_book_Info.Book_Year_Published}\"," +
                $"`Book_Publisher`=\"{tbl_book_Info.Book_Publisher}\"" +
                $",`Book_Number_Of_Quantity`=\"{tbl_book_Info.Book_Number_Of_Quantity}\" WHERE `Book_ID` = '{Book_ID}'";
                return update_DBMethod(query);
            }
            else
            {
                return false;
            }                 
        }
        //*/






        /*
        /// <summary>
        /// 
        /// </summary>
        /// <param name="delete_SQL_StateMent"></param>
        /// <returns></returns>
        public bool delete_DBMethod(string delete_SQL_StateMent)
        {
            return connectDB_And_ExecuteNonQuery(delete_SQL_StateMent);
        }
        //*/

        /*
        public List<string> delete_DBMethod_return_row_Record(string table_name, int ID)
        {
            List<string> select_row = new List<string>();
            if (is_table_ID_Exist("tbl_book", table_ID))
            {
                string select_querry = $"Select * from WHERE `Book_ID` = '{Book_ID}'";
                List<List<string>> temp = select_DBMethod_return_2DList_Table_Records(select_querry);
                select_row = new List<string>(temp);
                string query = $"DELETE FROM `tbl_book` WHERE `Book_ID` = '{Book_ID}'";
                bool isSucces = connectDB_And_ExecuteNonQuery(query);
                if(isSucces)
                {
                    return select_row;
                }
                else
                {
                    return "";
                }


            }
            else
            {
                return "";
            }
        }
        //*/


        /// <summary>
        /// 
        /// </summary>
        /// <param name="table_Name"></param>
        /// <param name="table_ID"></param>
        /// <returns></returns>
        public bool delete_DBMethod_return_Boolean(string table_Name, int table_ID)
        {
            if (is_table_ID_Exist(table_Name, table_ID))
            {
                string query = $"DELETE FROM `{table_Name}` WHERE `{LDMS_Constants.get_ID_Name_Of_Table(table_Name)}` = '{table_ID}'";
                return connectDB_And_ExecuteNonQuery(query);//delete_DBMethod(query);
            }
            else
            {
                return false;
            } 
        }

        public List<List<string>> selectbakalla()
        {
            string table_Name = "tbl_borrower";

            string select_SQL_StateMent = "Select Borrower_Last_Name from " + table_Name + "where Borrower_Last_Name = Tan";

            return select_DBMethod_return_2DList_Table_Records(select_SQL_StateMent);

        }
    }

}
