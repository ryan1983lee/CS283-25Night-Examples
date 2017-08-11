using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using oilLibrary;

//using System.IO;// for check file exist
//using System.Data.SQLite;//for SQLite

namespace Carassistant
{
    public partial class Carassistant : Form
    {
        //private SQLiteConnection sqlite_connect;
        //private SQLiteCommand sqlite_cmd;
        //public oil oil;

        public Carassistant()
        {
            InitializeComponent();
        }

        /*
        private SQLiteConnection OpenConn(string database)
        {
            throw new NotImplementedException();
        }

        public void SQLiteInsertUpdateDelete(string Database, string SqlSelectString)
        {
            SQLiteConnection icn = OpenConn(Database);
            SQLiteCommand cmd = new SQLiteCommand(SqlSelectString, icn);
            SQLiteTransaction mySqlTransaction = icn.BeginTransaction();
            try
            {
                cmd.Transaction = mySqlTransaction;
                cmd.ExecuteNonQuery();
                mySqlTransaction.Commit();
            }
            catch (Exception ex)
            {
                mySqlTransaction.Rollback();
                throw (ex);
            }
            if (icn.State == ConnectionState.Open) icn.Close();
        }
        */

        private void postbtn_Click(object sender, EventArgs e)
        {
            /*
          sqlite_connect = new SQLiteConnection("Data source=oiltest.db");
          //建立資料庫連線

          sqlite_connect.Open();// Open
          sqlite_cmd = sqlite_connect.CreateCommand();//create command

          {
              SQLiteCommand sqlCommand = new SQLiteCommand("INSERT INTO oiltest (mileage,oilbill,oilquantity,oilmoney,bfoildistance,oilcapactity) Values (@Fmileage,@oilbill,@oilquantity,@oilmoney,@bfoildistance,@oilcapactity)", myConnection);
              sqlCommand.Parameters.AddWithValue("@mileage", mileage.Text);
              sqlCommand.Parameters.AddWithValue("@oilbill", oilbill.Text);
              sqlCommand.Parameters.AddWithValue("@oilquantity", oilquantity.Text);
              sqlCommand.Parameters.AddWithValue("@oilmoney", oilmoney.Text);
              sqlCommand.Parameters.AddWithValue("@bfoildistance", bfoildistance.Text);
              sqlCommand.Parameters.AddWithValue("@oilcapactity", oilcapactity.Text);

              myConnection.Open();
              return sqlCommand.ExecuteNonQuery();

              sqlite_connect.Close();
*/
            String mile = mileage.Text.ToString();
            String bill = oilbill.Text.ToString();
            String quantity = oilquantity.Text.ToString();
            String money = oilmoney.Text.ToString();
            String capacity = oilcapacity.Text.ToString();
            String distance = bfoildistance.Text.ToString();

            int Mileage = int.Parse(mile);

            int Oilbill = int.Parse(bill);

            Double Oilquantity = Convert.ToDouble(quantity);

            Double Oilmoney = Convert.ToDouble(money);

            Double Oilcapacity = Convert.ToDouble(capacity);

            int Bfoildistance = int.Parse(distance);

            int Drivedistance = Mileage - Bfoildistance;

            Double Bfoil = Drivedistance / Oilquantity;

            drivedistance.Text = Drivedistance.ToString();

            useoil.Text = Oilquantity.ToString();

            bfoil.Text = Bfoil.ToString();
        }

        private void cleanbtn_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(this.Controls);
        }

        private void ClearTextBoxes(Control.ControlCollection cc)
        {
            foreach (Control ctrl in cc)
            {
                TextBox tb = ctrl as TextBox;
                if (tb != null)
                    tb.Text = "";
                else
                    ClearTextBoxes(ctrl.Controls);
            }
        }
    }
}