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
using System.Data.SqlClient;
using HandyControl.Data;
using HandyControl.Themes;
using HandyControl.Tools;
using System.Windows.Markup;

namespace WpfAbsenceApp
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ADO d = new ADO();


        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void butDashboard_Click(object sender, RoutedEventArgs e)
        {

        }

        private void butFormateur_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.Visibility = Visibility.Visible;
            butAjouter.Visibility = Visibility.Visible;
            txtFullname.Visibility = Visibility.Hidden;
            txtEmail.Visibility = Visibility.Hidden;
            txtPassword.Visibility = Visibility.Hidden;
            txtDateNaissance.Visibility = Visibility.Hidden;
            txtClasse.Visibility = Visibility.Hidden;
            txtFormateur.Visibility = Visibility.Hidden;
            txtRoleld.Visibility = Visibility.Hidden;
            lblFullname.Visibility = Visibility.Hidden;
            lblEmail.Visibility = Visibility.Hidden;
            lblPassword.Visibility = Visibility.Hidden;
            lblRoleId.Visibility = Visibility.Hidden;
            lblDateNaissance.Visibility = Visibility.Hidden;
            lblClasse.Visibility = Visibility.Hidden;
            lblFourmateur.Visibility = Visibility.Hidden;
            butEnregister.Visibility = Visibility.Hidden;

            d.CONNECTER();
            d.cmd.CommandText = ("select * from Formateur ");
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DataGrid.ItemsSource = d.dt.DefaultView;
            d.dr.Close();




        }

        private void butSecrétaire_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.Visibility = Visibility.Visible;
            d.CONNECTER();
            d.cmd.CommandText = ("select * from Secretaire");
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DataGrid.ItemsSource = d.dt.DefaultView;
            d.dr.Close();

        }

        private void butApprenants_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void butAjouter_Click(object sender, RoutedEventArgs e)
        {
            DataGrid.Visibility = Visibility.Hidden;
            txtFullname.Visibility = Visibility.Visible;
            txtEmail.Visibility = Visibility.Visible;
            txtPassword.Visibility = Visibility.Visible;
            txtClasse.Visibility = Visibility.Visible;
            txtRoleld.Visibility = Visibility.Visible;
            lblFullname.Visibility = Visibility.Visible;
            lblEmail.Visibility = Visibility.Visible;
            lblPassword.Visibility = Visibility.Visible;
            lblRoleId.Visibility = Visibility.Visible;
            lblClasse.Visibility = Visibility.Visible;
            txtAnnée.Visibility = Visibility.Visible;
            lblAnnée.Visibility = Visibility.Visible;
            butEnregister.Visibility = Visibility.Visible;
            butAjouter.Visibility = Visibility.Visible;


        }

        private void txtFullname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void lblRoleld_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtClasse_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtRoleld_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        

        private void txtRoleld_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {/*
            txtRoleld.Items.Clear();
            d.cmd.CommandText = ("select * from Role");
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            while (d.dr.Read())
            {
                txtRoleld.Items.Add(d.dr[0]);
            }
            
            d.dr.Close();*/
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }
        // Remplir de datagid

        public void RemplirGrid()
        {
            d.cmd.CommandText = "select * form Formateur";
            d.cmd.Connection = d.con;
            d.dr = d.cmd.ExecuteReader();
            d.dt.Load(d.dr);
            DataGrid.ItemsSource = d.dt.DefaultView;
            d.dr.Close();
        }

        private void butEnregister_Click(object sender, RoutedEventArgs e)
        {
            d.CONNECTER();
            d.cmd = new SqlCommand(" insert into Formateur (Fullname,email,password,Année) values ('" + txtFullname.Text + "','" + txtEmail.Text + "','" + txtPassword.Text + "'," + txtAnnée.Text + ")", d.con);
            d.cmd.Connection = d.con;
            d.cmd.ExecuteNonQuery();
            d.con.Close();
        }
    }
}
