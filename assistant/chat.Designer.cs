namespace assistant
{
    partial class chat
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chat));
            this.History = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.xuiButton3 = new XanderUI.XUIButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbody = new System.Windows.Forms.TextBox();
            this.txtsupp = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txttooo = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.History.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // History
            // 
            this.History.Controls.Add(this.metroTabPage1);
            this.History.Controls.Add(this.metroTabPage2);
            this.History.Dock = System.Windows.Forms.DockStyle.Fill;
            this.History.Location = new System.Drawing.Point(20, 60);
            this.History.Name = "History";
            this.History.RightToLeftLayout = true;
            this.History.SelectedIndex = 0;
            this.History.Size = new System.Drawing.Size(700, 406);
            this.History.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.xuiButton3);
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.label4);
            this.metroTabPage1.Controls.Add(this.label3);
            this.metroTabPage1.Controls.Add(this.label5);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.txtbody);
            this.metroTabPage1.Controls.Add(this.txtsupp);
            this.metroTabPage1.Controls.Add(this.txtemail);
            this.metroTabPage1.Controls.Add(this.txtpass);
            this.metroTabPage1.Controls.Add(this.txttooo);
            this.metroTabPage1.Controls.Add(this.button2);
            this.metroTabPage1.Controls.Add(this.textBox1);
            this.metroTabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(692, 367);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "chat";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            // 
            // xuiButton3
            // 
            this.xuiButton3.BackgroundColor = System.Drawing.Color.Transparent;
            this.xuiButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.BackgroundImage")));
            this.xuiButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xuiButton3.ButtonImage = ((System.Drawing.Image)(resources.GetObject("xuiButton3.ButtonImage")));
            this.xuiButton3.ButtonStyle = XanderUI.XUIButton.Style.Invert;
            this.xuiButton3.ButtonText = "";
            this.xuiButton3.ClickBackColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.ClickTextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.CornerRadius = 5;
            this.xuiButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.xuiButton3.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.HoverBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.HoverTextColor = System.Drawing.Color.Transparent;
            this.xuiButton3.ImagePosition = XanderUI.XUIButton.imgPosition.Left;
            this.xuiButton3.Location = new System.Drawing.Point(324, 257);
            this.xuiButton3.Name = "xuiButton3";
            this.xuiButton3.Size = new System.Drawing.Size(87, 50);
            this.xuiButton3.TabIndex = 37;
            this.xuiButton3.TextColor = System.Drawing.Color.DodgerBlue;
            this.xuiButton3.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiButton3.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(606, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "الرسالة :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-70, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 33;
            this.label4.Text = "الباسورد :";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-70, -20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 14);
            this.label3.TabIndex = 34;
            this.label3.Text = "الايميل :";
            this.label3.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-64, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "الى :";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(606, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "الموضوع :";
            // 
            // txtbody
            // 
            this.txtbody.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbody.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtbody.Location = new System.Drawing.Point(156, 52);
            this.txtbody.Multiline = true;
            this.txtbody.Name = "txtbody";
            this.txtbody.Size = new System.Drawing.Size(444, 189);
            this.txtbody.TabIndex = 27;
            // 
            // txtsupp
            // 
            this.txtsupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupp.ForeColor = System.Drawing.Color.DodgerBlue;
            this.txtsupp.Location = new System.Drawing.Point(156, 17);
            this.txtsupp.Name = "txtsupp";
            this.txtsupp.Size = new System.Drawing.Size(444, 29);
            this.txtsupp.TabIndex = 28;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(0, -22);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(45, 29);
            this.txtemail.TabIndex = 29;
            this.txtemail.Text = "bolaa682@gmail.com";
            this.txtemail.Visible = false;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(0, 8);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(45, 29);
            this.txtpass.TabIndex = 30;
            this.txtpass.Text = "01277755208";
            this.txtpass.Visible = false;
            // 
            // txttooo
            // 
            this.txttooo.Location = new System.Drawing.Point(0, 60);
            this.txttooo.Name = "txttooo";
            this.txttooo.Size = new System.Drawing.Size(45, 29);
            this.txttooo.TabIndex = 31;
            this.txttooo.Text = "bedaba15@gmail.com";
            this.txttooo.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(525, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 29);
            this.button2.TabIndex = 25;
            this.button2.Text = "استلام";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(276, 317);
            this.textBox1.TabIndex = 26;
            this.textBox1.Visible = false;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.panel1);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(692, 367);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "HISTORY ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(349, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 367);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 100;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 367);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 367);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.GridColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 100;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(343, 367);
            this.dataGridView2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.History);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "chat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "chat";
            this.Load += new System.EventHandler(this.chat_Load_1);
            this.History.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl History;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private XanderUI.XUIButton xuiButton3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtbody;
        private System.Windows.Forms.TextBox txtsupp;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txttooo;
        private System.Windows.Forms.Button button2;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}