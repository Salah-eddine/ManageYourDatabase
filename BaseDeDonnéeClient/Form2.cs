using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseDeDonnéeClient
{
    public partial class Form2 : Form
    {
        
        private TableInformation CurrentTable;
        private TextBox field = new TextBox();
        public Form2(TableInformation CurrentTable)
        {
            this.CurrentTable = CurrentTable;
            InitializeComponent();
            this.CreateFields();
            this.SubmitButton();    
            for(int i=0;i<columns_field.Count;i++)
            {
                MessageBox.Show(columns_field[i].Text) ;
            }
        }

        private void Form2_Closing(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Hello ");
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
           
            /*this.Controls.Add(this.field);
            this.field.Location = new System.Drawing.Point(12, 68);
            this.field.Name="champ";
            this.field.Text = "champ";
            this.field.Size = new System.Drawing.Size(200, 20);*/

        }

    }
    
}
