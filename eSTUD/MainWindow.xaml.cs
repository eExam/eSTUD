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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Data;

namespace ModernLogin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        OleDbConnection connect = new OleDbConnection();
        public MainWindow()
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtUser.Text == "" && txtPass.Text == "")
                {
                    MessageBox.Show("Please Enter The Username & Password");
                }
                else
                {
                    connect.Open();
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = connect;
                    string query = "Select usertype from users where username='" + txtUser.Text + "' and password='" + txtPass.Text + "'";
                    cmd.CommandText = query;
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new System.Data.DataTable();
                    da.Fill(dt);
                    {
                        if (dt.Rows.Count == 1)
                        {
                            if (dt.Rows[0][0].ToString() == "student")

                            {
                                this.Hide();
                                StudentForm sf = new StudentForm();
                                sf.ShowDialog();                                
                               
                            }
                            else if(dt.Rows[0][0].ToString()=="admin")
                            {
                                this.Hide();
                                AdminForm af = new AdminForm();
                                af.ShowDialog();
                            }
                            else if(dt.Rows[0][0].ToString()=="referent")
                            {
                                this.Hide();
                                ReferentForm rf = new ReferentForm();
                                rf.ShowDialog();
                            }

                        }
                       if(dt.Rows.Count<1)
                        {
                            MessageBox.Show("Username and password are not correct");
                        }
                    }
                }
            }
            catch (Exception esc)
            {

            }
        }
    }
}
