using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Room_Booking_CSharp_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tblRoomAvailability_Paint(object sender, PaintEventArgs e)
        {
            DataSet ds;
            ds = createConnection();

            //ds.Tables("RESERVATIONS").rows[1].items[1];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private DataSet createConnection()
         {
            string connectionString =
              "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\RoomBooking.mdb;Persist Security Info = False;";
            //array of textboxes
           
            DataSet dataSet = new DataSet();
            
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // The insertSQL string contains a SQL statement that
                // inserts a new row in the source table.
                OleDbCommand command = new OleDbCommand("SELECT * FROM RESERVATIONS", connection);

                // Set the Connection to the new OleDbConnection.
                command.Connection = connection;

                // Open the connection and execute the insert command.
                try
                {
                     OleDbDataAdapter da = new OleDbDataAdapter(command);
                     da.Fill(dataSet);
                        //safely close connection
                    connection.Close();
                     da.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed when the
                // code exits the using block.

                return dataSet;
            }
            

        }


    }
}
