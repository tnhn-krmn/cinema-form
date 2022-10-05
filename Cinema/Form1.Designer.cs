namespace Cinema
{
    partial class Form1
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
            this.dgw_Movies = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Passive = new System.Windows.Forms.Button();
            this.lbl_IsActive = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.cmbx_Categori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Director = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Movies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Movies
            // 
            this.dgw_Movies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Movies.Location = new System.Drawing.Point(1, 73);
            this.dgw_Movies.Name = "dgw_Movies";
            this.dgw_Movies.RowTemplate.Height = 25;
            this.dgw_Movies.Size = new System.Drawing.Size(797, 192);
            this.dgw_Movies.TabIndex = 0;
            this.dgw_Movies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgw_Movies_CellClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("SimSun-ExtB", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_Title.Location = new System.Drawing.Point(243, 32);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(342, 27);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Vizyon\'da Olan Filmler";
            this.lbl_Title.Click += new System.EventHandler(this.lbl_Title_Click);
            // 
            // btn_Passive
            // 
            this.btn_Passive.Location = new System.Drawing.Point(530, 394);
            this.btn_Passive.Name = "btn_Passive";
            this.btn_Passive.Size = new System.Drawing.Size(82, 30);
            this.btn_Passive.TabIndex = 2;
            this.btn_Passive.Text = "Kaldır";
            this.btn_Passive.UseVisualStyleBackColor = true;
            this.btn_Passive.Click += new System.EventHandler(this.btn_Passive_Click);
            // 
            // lbl_IsActive
            // 
            this.lbl_IsActive.AutoSize = true;
            this.lbl_IsActive.Location = new System.Drawing.Point(652, 315);
            this.lbl_IsActive.Name = "lbl_IsActive";
            this.lbl_IsActive.Size = new System.Drawing.Size(0, 15);
            this.lbl_IsActive.TabIndex = 3;
            this.lbl_IsActive.Visible = false;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(631, 394);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(62, 30);
            this.btn_Add.TabIndex = 4;
            this.btn_Add.Text = "Ekle";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // cmbx_Categori
            // 
            this.cmbx_Categori.FormattingEnabled = true;
            this.cmbx_Categori.Location = new System.Drawing.Point(572, 353);
            this.cmbx_Categori.Name = "cmbx_Categori";
            this.cmbx_Categori.Size = new System.Drawing.Size(121, 23);
            this.cmbx_Categori.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(498, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(500, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Director";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(514, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // txt_Director
            // 
            this.txt_Director.Location = new System.Drawing.Point(572, 321);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(121, 23);
            this.txt_Director.TabIndex = 10;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(572, 290);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(121, 23);
            this.txt_Name.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.txt_Director);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_Categori);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_IsActive);
            this.Controls.Add(this.btn_Passive);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.dgw_Movies);
            this.Name = "Form1";
            this.Text = "Bilet ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Movies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgw_Movies;
        private Label lbl_Title;
        private Button btn_Passive;
        private Label lbl_IsActive;
        private Button btn_Add;
        private ComboBox cmbx_Categori;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_Director;
        private TextBox txt_Name;
    }
}