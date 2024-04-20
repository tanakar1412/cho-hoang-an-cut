namespace gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            cbbLuaChon = new ComboBox();
            txtThongDIep = new TextBox();
            btnLoad = new Button();
            btnIn = new Button();
            groupBox2 = new GroupBox();
            txtCau2 = new TextBox();
            btnGhi = new Button();
            btnDoc = new Button();
            groupBox3 = new GroupBox();
            rdnNu = new RadioButton();
            rdnNam = new RadioButton();
            label5 = new Label();
            txtNganh = new TextBox();
            txtTen = new TextBox();
            label4 = new Label();
            label3 = new Label();
            dgvCau3 = new DataGridView();
            btnClear = new Button();
            btnLoad2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCau3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(cbbLuaChon);
            groupBox1.Controls.Add(txtThongDIep);
            groupBox1.Controls.Add(btnLoad);
            groupBox1.Controls.Add(btnIn);
            groupBox1.Location = new Point(1, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 311);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cau 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 190);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Lua Chon";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 120);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 4;
            label1.Text = "Thong Diep";
            // 
            // cbbLuaChon
            // 
            cbbLuaChon.FormattingEnabled = true;
            cbbLuaChon.Location = new Point(51, 224);
            cbbLuaChon.Name = "cbbLuaChon";
            cbbLuaChon.Size = new Size(273, 28);
            cbbLuaChon.TabIndex = 3;
            // 
            // txtThongDIep
            // 
            txtThongDIep.Location = new Point(51, 143);
            txtThongDIep.Name = "txtThongDIep";
            txtThongDIep.Size = new Size(273, 27);
            txtThongDIep.TabIndex = 2;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(230, 68);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnIn
            // 
            btnIn.Location = new Point(51, 68);
            btnIn.Name = "btnIn";
            btnIn.Size = new Size(94, 29);
            btnIn.TabIndex = 0;
            btnIn.Text = "In";
            btnIn.UseVisualStyleBackColor = true;
            btnIn.Click += btnIn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCau2);
            groupBox2.Controls.Add(btnGhi);
            groupBox2.Controls.Add(btnDoc);
            groupBox2.Location = new Point(1, 339);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(412, 311);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cau 1";
            // 
            // txtCau2
            // 
            txtCau2.Location = new Point(51, 143);
            txtCau2.Multiline = true;
            txtCau2.Name = "txtCau2";
            txtCau2.ScrollBars = ScrollBars.Both;
            txtCau2.Size = new Size(273, 168);
            txtCau2.TabIndex = 2;
            // 
            // btnGhi
            // 
            btnGhi.Location = new Point(230, 68);
            btnGhi.Name = "btnGhi";
            btnGhi.Size = new Size(94, 29);
            btnGhi.TabIndex = 1;
            btnGhi.Text = "Ghi";
            btnGhi.UseVisualStyleBackColor = true;
            btnGhi.Click += btnGhi_Click;
            // 
            // btnDoc
            // 
            btnDoc.Location = new Point(51, 68);
            btnDoc.Name = "btnDoc";
            btnDoc.Size = new Size(94, 29);
            btnDoc.TabIndex = 0;
            btnDoc.Text = "Doc";
            btnDoc.UseVisualStyleBackColor = true;
            btnDoc.Click += btnDoc_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(rdnNu);
            groupBox3.Controls.Add(rdnNam);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtNganh);
            groupBox3.Controls.Add(txtTen);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dgvCau3);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnLoad2);
            groupBox3.Location = new Point(419, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(418, 642);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cau 1";
            // 
            // rdnNu
            // 
            rdnNu.AutoSize = true;
            rdnNu.Location = new Point(155, 291);
            rdnNu.Name = "rdnNu";
            rdnNu.Size = new Size(49, 24);
            rdnNu.TabIndex = 11;
            rdnNu.TabStop = true;
            rdnNu.Text = "Nu";
            rdnNu.UseVisualStyleBackColor = true;
            // 
            // rdnNam
            // 
            rdnNam.AutoSize = true;
            rdnNam.Location = new Point(25, 291);
            rdnNam.Name = "rdnNam";
            rdnNam.Size = new Size(62, 24);
            rdnNam.TabIndex = 10;
            rdnNam.TabStop = true;
            rdnNam.Text = "Nam";
            rdnNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 259);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 9;
            label5.Text = "Gioi Tinh";
            // 
            // txtNganh
            // 
            txtNganh.Location = new Point(25, 216);
            txtNganh.Name = "txtNganh";
            txtNganh.Size = new Size(333, 27);
            txtNganh.TabIndex = 8;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(25, 151);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(333, 27);
            txtTen.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 181);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 7;
            label4.Text = "Nganh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 121);
            label3.Name = "label3";
            label3.Size = new Size(32, 20);
            label3.TabIndex = 6;
            label3.Text = "Ten";
            // 
            // dgvCau3
            // 
            dgvCau3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCau3.Location = new Point(0, 344);
            dgvCau3.Name = "dgvCau3";
            dgvCau3.RowHeadersWidth = 51;
            dgvCau3.Size = new Size(412, 292);
            dgvCau3.TabIndex = 2;
            dgvCau3.CellClick += dgvCau3_CellClick;
            dgvCau3.CellContentClick += dgvCau3_CellContentClick;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(230, 68);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLoad2
            // 
            btnLoad2.Location = new Point(51, 68);
            btnLoad2.Name = "btnLoad2";
            btnLoad2.Size = new Size(94, 29);
            btnLoad2.TabIndex = 0;
            btnLoad2.Text = "Load";
            btnLoad2.UseVisualStyleBackColor = true;
            btnLoad2.Click += btnLoad2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(843, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 629);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1290, 675);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCau3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox cbbLuaChon;
        private TextBox txtThongDIep;
        private Button btnLoad;
        private Button btnIn;
        private GroupBox groupBox2;
        private TextBox txtCau2;
        private Button btnGhi;
        private Button btnDoc;
        private GroupBox groupBox3;
        private Button btnClear;
        private Button btnLoad2;
        private RadioButton rdnNu;
        private RadioButton rdnNam;
        private Label label5;
        private TextBox txtNganh;
        private TextBox txtTen;
        private Label label4;
        private Label label3;
        private DataGridView dgvCau3;
        private PictureBox pictureBox1;
    }
}
