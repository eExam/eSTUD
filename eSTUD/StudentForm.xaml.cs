using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Data;

namespace ModernLogin
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        OleDbConnection connect = new OleDbConnection();
        public StudentForm()
        {
            InitializeComponent();
            try
            {
                connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Melida\Documents\eSTUD.accdb; Persist Security Info=False;";
                connect.Open();
                connect.Close();

            }
            catch (Exception esc)
            {
                MessageBox.Show("Error");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                connect.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = connect;
                string query = "select * from Users";
                cmd.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGrid.ItemsSource = dt.DefaultView;
                MessageBox.Show("Data loaded");
                connect.Close();


            }
            catch(Exception esc)
            {

            }
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
