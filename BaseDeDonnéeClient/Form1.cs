using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDonnéeClient
{
    public partial class Form1 : Form
    {
        private string chaine_connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\elsal\source\repos\BaseDeDonnéeClient\BaseDeDonnéeClient\BilanCompany.mdf;Integrated Security=True; UID=DESKTOP-RNU0A81/elsal";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlCommand command;
            SqlDataReader reader; // S'instancie en appelant la méthode ExecuteReader de la classe Sql Commande au lieu de faire appelle à un constructeur
            SqlConnection cnn;
            string requete = "SELECT * FROM CLIENT;";
            cnn = new SqlConnection(this.chaine_connection);
            cnn.Open();
            command = new SqlCommand(requete,cnn);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
               MessageBox.Show(reader.GetName(1)+"\n"+reader.GetString(1));
            }
            reader.Close();
            cnn.Close();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            SqlConnection cnn;
            String requete;
            requete = @"INSERT INTO CLIENT VALUES('2343', 'Zak', 'Bruxelles', 'B2', 25444541);";
            cnn = new SqlConnection(chaine_connection);
            
            command = new SqlCommand(requete, cnn);
            cnn.Open();
                command.ExecuteNonQuery();
            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "Insert data in " + tables.SelectedItem;
            insertD.Text = s;
        }

        private void insertD_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<string> columns = new List<string>();
            string tableName,requete;
            SqlCommand command;
            SqlConnection cnn;
            SqlDataReader reader;
            DataSet ds;
            tableName = tables.SelectedItem.ToString();
            requete = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = "  +"'"+tableName+"'"+ ";";
            cnn = new SqlConnection(this.chaine_connection);
            cnn.Open();
            command = new SqlCommand(requete, cnn);
            reader =  command.ExecuteReader();
            while(reader.Read())
            {
                columns.Add(reader.GetString(0));
               
            }
            MessageBox.Show(columns[1]);


        }
    }
}
