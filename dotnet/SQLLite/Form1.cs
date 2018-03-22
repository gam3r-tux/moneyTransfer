using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SQLLiteDemo
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : Form
	{
		private DataGrid Grid;
		private TextBox txtDesc;
		private Button btnDel;
		private Button btnAdd;
		private Button btnNew;
		private Label lblDesc;
		private Button btnEdit;
		
		private int i=0;
        		
		private SQLiteConnection sql_con;
		private SQLiteCommand sql_cmd;
		private SQLiteDataAdapter DB;
		private DataSet DS = new DataSet();
		private DataTable DT = new DataTable();
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Button button3;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if ( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.Grid = new System.Windows.Forms.DataGrid();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AlternatingBackColor = System.Drawing.Color.WhiteSmoke;
            this.Grid.BackColor = System.Drawing.Color.Gainsboro;
            this.Grid.BackgroundColor = System.Drawing.Color.DarkGray;
            this.Grid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Grid.CaptionBackColor = System.Drawing.Color.DarkKhaki;
            this.Grid.CaptionFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Grid.CaptionForeColor = System.Drawing.Color.Black;
            this.Grid.DataMember = "";
            this.Grid.FlatMode = true;
            this.Grid.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Grid.ForeColor = System.Drawing.Color.Black;
            this.Grid.GridLineColor = System.Drawing.Color.Silver;
            this.Grid.HeaderBackColor = System.Drawing.Color.Black;
            this.Grid.HeaderFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Grid.HeaderForeColor = System.Drawing.Color.White;
            this.Grid.LinkColor = System.Drawing.Color.DarkSlateBlue;
            this.Grid.Location = new System.Drawing.Point(18, 325);
            this.Grid.Name = "Grid";
            this.Grid.ParentRowsBackColor = System.Drawing.Color.LightGray;
            this.Grid.ParentRowsForeColor = System.Drawing.Color.Black;
            this.Grid.PreferredColumnWidth = 120;
            this.Grid.PreferredRowHeight = 25;
            this.Grid.ReadOnly = true;
            this.Grid.SelectionBackColor = System.Drawing.Color.Firebrick;
            this.Grid.SelectionForeColor = System.Drawing.Color.White;
            this.Grid.Size = new System.Drawing.Size(541, 160);
            this.Grid.TabIndex = 0;
            this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(109, 12);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(137, 19);
            this.txtDesc.TabIndex = 2;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(213, 284);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(50, 23);
            this.btnDel.TabIndex = 3;
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(85, 284);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(19, 284);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(42, 23);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblDesc
            // 
            this.lblDesc.Location = new System.Drawing.Point(15, 12);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(88, 19);
            this.lblDesc.TabIndex = 7;
            this.lblDesc.Text = "Nombre:";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(149, 284);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SQLLite.Properties.Resources.avatar;
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Apellido Paterno:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido Materno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Fecha Nac.:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Dirección:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Foto:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "ID Frente:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "ID Reverso:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(137, 20);
            this.textBox1.TabIndex = 21;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(137, 20);
            this.textBox2.TabIndex = 22;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(137, 20);
            this.textBox3.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(110, 107);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(137, 20);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(110, 131);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(137, 20);
            this.textBox5.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(109, 155);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(137, 20);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(110, 180);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(137, 20);
            this.textBox7.TabIndex = 27;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(252, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(109, 203);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(137, 20);
            this.textBox8.TabIndex = 30;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(109, 226);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 31;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(109, 249);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 32;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(252, 203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(573, 497);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.Grid);
            this.Name = "Form1";
            this.Text = "SQLLiteDemo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void LoadData()
		{
			SetConnection(); 
			sql_con.Open();

			sql_cmd = sql_con.CreateCommand();
			string CommandText = "select NOMBRE, APAT, AMAT, FCHNAC, DIRECCION, ESTADO, TELEFONO, EMAIL from personas";
			DB = new SQLiteDataAdapter(CommandText,sql_con);
            DS.Reset();
			DB.Fill(DS);
			DT= DS.Tables[0];
			Grid.DataSource = DT;
			sql_con.Close();			
		}

        private void SetConnection()
        {
			sql_con = new SQLiteConnection("Data Source=c:\\demoMT\\demomt.db;Version=3;New=False;Compress=True;");			
        }

		private void ExecuteQuery(string txtQuery)
		{
			SetConnection();
			sql_con.Open();
          
			sql_cmd = sql_con.CreateCommand();
			sql_cmd.CommandText=txtQuery;
		
			sql_cmd.ExecuteNonQuery();
			sql_con.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadData();
		}

        private void Add()
        {
            string txtSQLQuery = String.Format("insert into personas (NOMBRE, APAT, AMAT, FCHNAC, DIRECCION, ESTADO, TELEFONO, EMAIL, RUTAFOTO, IDENTIFICACIONA, IDENTIFICACIONB) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                 txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text);
		    ExecuteQuery(txtSQLQuery);			
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{		
		    Add();
            LoadData();
		    txtDesc.Text = string.Empty;
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			txtDesc.Enabled = true;
			txtDesc.Text = string.Empty;			
		}

		private void Grid_Click(object sender, EventArgs e)
		{
            i = Convert.ToInt32(DT.Rows[Grid.CurrentRowIndex]["id"]);

            label1.Text = Convert.ToString(i);
			txtDesc.Text = DT.Rows[Grid.CurrentRowIndex]["desc"].ToString();
		}

		private void Delete()
		{			
			string txtSQLQuery = "delete from personas where id =" + i;
			ExecuteQuery(txtSQLQuery);			
			txtDesc.Text = string.Empty;			
		}

        private void Edit()
        {
	        string txtSQLQuery = String.Format("update personas set NOMBRE = '{0}', APAT = '{1}', AMAT = '{2}', FCHNAC = '{3}', DIRECCION = '{4}', ESTADO = '{5}', TELEFONO = '{6}', EMAIL = '{7}', RUTAFOTO = '{8}', IDENTIFICACIONA = '{9}', IDENTIFICACIONB = '{10}' where id = {11}",
                                 txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, txtDesc.Text, i);
            ExecuteQuery(txtSQLQuery);
        }

  		private void btnDel_Click(object sender, EventArgs e)
		{
		    Delete();
	        LoadData();
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{		
		    Edit();
		    LoadData();
		}

    }
}
