namespace AppDevis2
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.mesinfos = new System.Windows.Forms.TextBox();
            this.client = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.qte = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.Label();
            this.prix = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.param = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nouveau Devis";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label.Location = new System.Drawing.Point(12, 78);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(122, 20);
            this.label.TabIndex = 1;
            this.label.Text = "Vos coordonnées";
            // 
            // mesinfos
            // 
            this.mesinfos.Location = new System.Drawing.Point(12, 101);
            this.mesinfos.Multiline = true;
            this.mesinfos.Name = "mesinfos";
            this.mesinfos.Size = new System.Drawing.Size(323, 83);
            this.mesinfos.TabIndex = 2;
            // 
            // client
            // 
            this.client.Location = new System.Drawing.Point(465, 154);
            this.client.Multiline = true;
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(323, 83);
            this.client.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(465, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Coordonnées Client";
            // 
            // titre
            // 
            this.titre.Location = new System.Drawing.Point(12, 261);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(455, 23);
            this.titre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Titre du devis";
            // 
            // qte
            // 
            this.qte.Location = new System.Drawing.Point(475, 338);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(227, 23);
            this.qte.TabIndex = 8;
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text3.Location = new System.Drawing.Point(475, 315);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(31, 20);
            this.text3.TabIndex = 7;
            this.text3.Text = "qté";
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(233, 338);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(236, 23);
            this.prix.TabIndex = 10;
            // 
            // text2
            // 
            this.text2.AutoSize = true;
            this.text2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text2.Location = new System.Drawing.Point(233, 315);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(33, 20);
            this.text2.TabIndex = 9;
            this.text2.Text = "Prix";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(12, 338);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(215, 23);
            this.nom.TabIndex = 12;
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.text1.Location = new System.Drawing.Point(12, 315);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(116, 20);
            this.text1.TabIndex = 11;
            this.text1.Text = "Nom du produit";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(776, 47);
            this.button1.TabIndex = 13;
            this.button1.Text = "Générer devis";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(713, 337);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // param
            // 
            this.param.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.param.Location = new System.Drawing.Point(695, 26);
            this.param.Name = "param";
            this.param.Size = new System.Drawing.Size(93, 31);
            this.param.TabIndex = 15;
            this.param.Text = "Paramètres";
            this.param.UseVisualStyleBackColor = true;
            this.param.Click += new System.EventHandler(this.param_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.param);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.qte);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.titre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.client);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mesinfos);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pdf Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label;
        private TextBox mesinfos;
        private TextBox client;
        private Label label2;
        private TextBox titre;
        private Label label3;
        private TextBox qte;
        private Label text3;
        private TextBox prix;
        private Label text2;
        private TextBox nom;
        private Label text1;
        private Button button1;
        private Button buttonAdd;
        private Button param;
    }
}