namespace WindowsFormsApp2
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btexit = new System.Windows.Forms.Button();
            this.btsubmit = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.chprime = new System.Windows.Forms.CheckBox();
            this.rbgame = new System.Windows.Forms.RadioButton();
            this.rbelec = new System.Windows.Forms.RadioButton();
            this.cbqty = new System.Windows.Forms.ComboBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.tbnumber = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.btsearch = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btupdate = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.lbid = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btexit);
            this.groupBox1.Controls.Add(this.btsubmit);
            this.groupBox1.Controls.Add(this.dtp);
            this.groupBox1.Controls.Add(this.chprime);
            this.groupBox1.Controls.Add(this.rbgame);
            this.groupBox1.Controls.Add(this.rbelec);
            this.groupBox1.Controls.Add(this.cbqty);
            this.groupBox1.Controls.Add(this.tbprice);
            this.groupBox1.Controls.Add(this.tbnumber);
            this.groupBox1.Controls.Add(this.tbname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 380);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Details";
            // 
            // btexit
            // 
            this.btexit.Location = new System.Drawing.Point(158, 337);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(75, 23);
            this.btexit.TabIndex = 24;
            this.btexit.Text = "Exit";
            this.btexit.UseVisualStyleBackColor = true;
            // 
            // btsubmit
            // 
            this.btsubmit.Location = new System.Drawing.Point(43, 337);
            this.btsubmit.Name = "btsubmit";
            this.btsubmit.Size = new System.Drawing.Size(75, 23);
            this.btsubmit.TabIndex = 23;
            this.btsubmit.Text = "Submit";
            this.btsubmit.UseVisualStyleBackColor = true;
            this.btsubmit.Click += new System.EventHandler(this.btsubmit_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(79, 295);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 22;
            // 
            // chprime
            // 
            this.chprime.AutoSize = true;
            this.chprime.Location = new System.Drawing.Point(138, 247);
            this.chprime.Name = "chprime";
            this.chprime.Size = new System.Drawing.Size(52, 17);
            this.chprime.TabIndex = 21;
            this.chprime.Text = "Prime";
            this.chprime.UseVisualStyleBackColor = true;
            this.chprime.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbgame
            // 
            this.rbgame.AutoSize = true;
            this.rbgame.Location = new System.Drawing.Point(194, 198);
            this.rbgame.Name = "rbgame";
            this.rbgame.Size = new System.Drawing.Size(61, 17);
            this.rbgame.TabIndex = 20;
            this.rbgame.TabStop = true;
            this.rbgame.Text = "Gaming";
            this.rbgame.UseVisualStyleBackColor = true;
            // 
            // rbelec
            // 
            this.rbelec.AutoSize = true;
            this.rbelec.Location = new System.Drawing.Point(106, 198);
            this.rbelec.Name = "rbelec";
            this.rbelec.Size = new System.Drawing.Size(72, 17);
            this.rbelec.TabIndex = 19;
            this.rbelec.TabStop = true;
            this.rbelec.Text = "Electronic";
            this.rbelec.UseVisualStyleBackColor = true;
            // 
            // cbqty
            // 
            this.cbqty.FormattingEnabled = true;
            this.cbqty.Location = new System.Drawing.Point(158, 152);
            this.cbqty.Name = "cbqty";
            this.cbqty.Size = new System.Drawing.Size(121, 21);
            this.cbqty.TabIndex = 18;
            this.cbqty.SelectedIndexChanged += new System.EventHandler(this.cbqty_SelectedIndexChanged);
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(158, 108);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(100, 20);
            this.tbprice.TabIndex = 17;
            this.tbprice.TextChanged += new System.EventHandler(this.tbprice_TextChanged);
            // 
            // tbnumber
            // 
            this.tbnumber.Location = new System.Drawing.Point(158, 68);
            this.tbnumber.Name = "tbnumber";
            this.tbnumber.Size = new System.Drawing.Size(100, 20);
            this.tbnumber.TabIndex = 16;
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(158, 28);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Membership";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Product Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Name";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(369, 33);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(100, 20);
            this.tbsearch.TabIndex = 1;
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(497, 33);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(75, 23);
            this.btsearch.TabIndex = 2;
            this.btsearch.Text = "Search";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(369, 101);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(240, 150);
            this.dgv.TabIndex = 3;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(369, 297);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 4;
            this.btupdate.Text = "Update";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.button4_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(497, 297);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(75, 23);
            this.btdelete.TabIndex = 5;
            this.btdelete.Text = "Delete";
            this.btdelete.UseVisualStyleBackColor = true;
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(471, 358);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(35, 13);
            this.lbid.TabIndex = 6;
            this.lbid.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.btdelete);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chprime;
        private System.Windows.Forms.RadioButton rbgame;
        private System.Windows.Forms.RadioButton rbelec;
        private System.Windows.Forms.ComboBox cbqty;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.TextBox tbnumber;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btsubmit;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Label lbid;
    }
}

