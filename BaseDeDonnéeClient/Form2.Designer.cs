namespace BaseDeDonnéeClient
{

    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Drawing;
    using System;
    partial class Form2
    {
        

        public List<Label> LabelTexte = new List<Label>();
        private List<TextBox> columns_field = new List<TextBox>();
        private Button SubmitForm = new Button();
        private int x = 12;
        private int y = 68;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          

            this.SuspendLayout();
            //  
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, (this.y * CurrentTable.GetCountName()+80));
            this.Name = "Form2";
            this.ResumeLayout(false);

         

        }
        private void CreateFields()
        {

            for (int i = 0; i < CurrentTable.GetCountName(); i++)
            {
               
                columns_field.Add(new TextBox());

            }


            for (int i = 0; i < columns_field.Count; i++)
            {
                this.Controls.Add(this.columns_field[i]);
            }
   

            for (int i = 0; i < CurrentTable.GetCountName(); i++)
            {
                this.LabelTexte.Add(new Label());
                this.Controls.Add(this.LabelTexte[i]);

                this.LabelTexte[i].Location = new System.Drawing.Point(this.x, this.y - 20);
                this.LabelTexte[i].Text = CurrentTable.GetColumnName(i);


                this.columns_field[i].Location = new System.Drawing.Point(this.x, this.y);
                this.columns_field[i].Name = this.CurrentTable.GetColumnName(i);
                this.columns_field[i].Size = new System.Drawing.Size(200, 20);
                this.columns_field[i].TabIndex = i;
                
                //this.x += 10;
                this.y += 50;
            }

            
        }

        public void SubmitButton()
        {
            this.Controls.Add(this.SubmitForm);
            this.SubmitForm.Location = new System.Drawing.Point(this.x, (this.y + 30));
            this.SubmitForm.Name = "soummissionFormulaire";
            this.SubmitForm.Text = "Submit";
            this.SubmitForm.Size = new System.Drawing.Size(120, 30);

        }

        public void CreateLabels()
        {
            for(int i =0;i<CurrentTable.GetCountName();i++)
            {
                this.LabelTexte.Add(new Label());
                this.Controls.Add(this.LabelTexte[i]);
            }
        }
        
#endregion
    }
}