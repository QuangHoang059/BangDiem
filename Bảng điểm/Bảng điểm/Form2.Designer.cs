
namespace Bảng_điểm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.namhoc = new System.Windows.Forms.ComboBox();
            this.hocki = new System.Windows.Forms.ComboBox();
            this.thongbao = new System.Windows.Forms.ListView();
            this.monhoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tinchi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.diem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.sua = new System.Windows.Forms.Panel();
            this.suanam = new System.Windows.Forms.ComboBox();
            this.suahk = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.xeploai = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.tongket = new System.Windows.Forms.TextBox();
            this.diemtbhk = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.suadiem = new System.Windows.Forms.TextBox();
            this.suatinchi = new System.Windows.Forms.TextBox();
            this.suamon = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sua.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namhoc
            // 
            this.namhoc.FormattingEnabled = true;
            this.namhoc.ItemHeight = 13;
            this.namhoc.Items.AddRange(new object[] {
            "Tất cả",
            "Năm nhất",
            "Năm hai",
            "Năm ba",
            "Năm bốn"});
            this.namhoc.Location = new System.Drawing.Point(56, 18);
            this.namhoc.Name = "namhoc";
            this.namhoc.Size = new System.Drawing.Size(121, 21);
            this.namhoc.TabIndex = 6;
            this.namhoc.Text = "Tất cả";
            this.namhoc.SelectedValueChanged += new System.EventHandler(this.namhoc_SelectedValueChanged);
            // 
            // hocki
            // 
            this.hocki.FormattingEnabled = true;
            this.hocki.ItemHeight = 13;
            this.hocki.Items.AddRange(new object[] {
            "I",
            "II"});
            this.hocki.Location = new System.Drawing.Point(248, 18);
            this.hocki.Name = "hocki";
            this.hocki.Size = new System.Drawing.Size(121, 21);
            this.hocki.TabIndex = 7;
            this.hocki.SelectedValueChanged += new System.EventHandler(this.hocki_SelectedValueChanged);
            // 
            // thongbao
            // 
            this.thongbao.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.thongbao.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.thongbao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.monhoc,
            this.tinchi,
            this.diem});
            this.thongbao.GridLines = true;
            this.thongbao.HideSelection = false;
            this.thongbao.HoverSelection = true;
            this.thongbao.Location = new System.Drawing.Point(1, 39);
            this.thongbao.Name = "thongbao";
            this.thongbao.Size = new System.Drawing.Size(368, 363);
            this.thongbao.TabIndex = 9;
            this.thongbao.UseCompatibleStateImageBehavior = false;
            this.thongbao.View = System.Windows.Forms.View.Details;
            this.thongbao.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.thongbao_ItemSelectionChanged);
            // 
            // monhoc
            // 
            this.monhoc.Text = "Môn học";
            this.monhoc.Width = 211;
            // 
            // tinchi
            // 
            this.tinchi.Text = "Tín chỉ";
            this.tinchi.Width = 52;
            // 
            // diem
            // 
            this.diem.Text = "Điểm";
            this.diem.Width = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Image = global::Bảng_điểm.Properties.Resources.hinh_nen_lien_minh_huyen_thoai_cho_game_thu_12;
            this.label1.Location = new System.Drawing.Point(587, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hiển thị";
            // 
            // sua
            // 
            this.sua.BackColor = System.Drawing.Color.White;
            this.sua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sua.Controls.Add(this.suanam);
            this.sua.Controls.Add(this.suahk);
            this.sua.Controls.Add(this.label7);
            this.sua.Controls.Add(this.label10);
            this.sua.Controls.Add(this.ok);
            this.sua.Controls.Add(this.textBox3);
            this.sua.Controls.Add(this.xeploai);
            this.sua.Controls.Add(this.delete);
            this.sua.Controls.Add(this.tongket);
            this.sua.Controls.Add(this.diemtbhk);
            this.sua.Controls.Add(this.label9);
            this.sua.Controls.Add(this.label8);
            this.sua.Controls.Add(this.label4);
            this.sua.Controls.Add(this.label3);
            this.sua.Controls.Add(this.label2);
            this.sua.Controls.Add(this.suadiem);
            this.sua.Controls.Add(this.suatinchi);
            this.sua.Controls.Add(this.suamon);
            this.sua.Controls.Add(this.add);
            this.sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sua.Location = new System.Drawing.Point(413, 39);
            this.sua.Name = "sua";
            this.sua.Size = new System.Drawing.Size(397, 363);
            this.sua.TabIndex = 3;
            // 
            // suanam
            // 
            this.suanam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.suanam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.suanam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suanam.FormattingEnabled = true;
            this.suanam.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.suanam.Location = new System.Drawing.Point(313, 152);
            this.suanam.Name = "suanam";
            this.suanam.Size = new System.Drawing.Size(74, 24);
            this.suanam.TabIndex = 4;
            // 
            // suahk
            // 
            this.suahk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.suahk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.suahk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suahk.FormattingEnabled = true;
            this.suahk.Items.AddRange(new object[] {
            "I",
            "II"});
            this.suahk.Location = new System.Drawing.Point(109, 150);
            this.suahk.Name = "suahk";
            this.suahk.Size = new System.Drawing.Size(74, 24);
            this.suahk.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "Học kì";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(226, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 22);
            this.label10.TabIndex = 14;
            this.label10.Text = "Năm học";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ok
            // 
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ok.Location = new System.Drawing.Point(172, 246);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 6;
            this.ok.Text = "Ok";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(313, 323);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(63, 24);
            this.textBox3.TabIndex = 12;
            // 
            // xeploai
            // 
            this.xeploai.AutoSize = true;
            this.xeploai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xeploai.Location = new System.Drawing.Point(310, 302);
            this.xeploai.Name = "xeploai";
            this.xeploai.Size = new System.Drawing.Size(61, 18);
            this.xeploai.TabIndex = 11;
            this.xeploai.Text = "Xếp loại";
            this.xeploai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // delete
            // 
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(313, 246);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(63, 23);
            this.delete.TabIndex = 7;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // tongket
            // 
            this.tongket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongket.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tongket.Location = new System.Drawing.Point(172, 323);
            this.tongket.Name = "tongket";
            this.tongket.ReadOnly = true;
            this.tongket.Size = new System.Drawing.Size(75, 24);
            this.tongket.TabIndex = 9;
            // 
            // diemtbhk
            // 
            this.diemtbhk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diemtbhk.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.diemtbhk.Location = new System.Drawing.Point(11, 323);
            this.diemtbhk.Name = "diemtbhk";
            this.diemtbhk.ReadOnly = true;
            this.diemtbhk.Size = new System.Drawing.Size(75, 24);
            this.diemtbhk.TabIndex = 8;
            this.diemtbhk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 18);
            this.label9.TabIndex = 7;
            this.label9.Text = "Điểm TBHK ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(169, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Tổng kết";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tín chỉ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Điểm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Môn học";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // suadiem
            // 
            this.suadiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suadiem.Location = new System.Drawing.Point(313, 90);
            this.suadiem.Name = "suadiem";
            this.suadiem.Size = new System.Drawing.Size(74, 29);
            this.suadiem.TabIndex = 2;
            // 
            // suatinchi
            // 
            this.suatinchi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suatinchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suatinchi.Location = new System.Drawing.Point(109, 90);
            this.suatinchi.Name = "suatinchi";
            this.suatinchi.Size = new System.Drawing.Size(74, 29);
            this.suatinchi.TabIndex = 1;
            // 
            // suamon
            // 
            this.suamon.BackColor = System.Drawing.Color.White;
            this.suamon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.suamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suamon.Location = new System.Drawing.Point(109, 25);
            this.suamon.Name = "suamon";
            this.suamon.Size = new System.Drawing.Size(278, 29);
            this.suamon.TabIndex = 0;
            // 
            // add
            // 
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add.FlatAppearance.CheckedBackColor = System.Drawing.Color.PowderBlue;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.add.Location = new System.Drawing.Point(11, 246);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-2, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "NĂM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Học kì";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(778, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(49, 416);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.openToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(42, 24);
            this.toolStripMenuItem1.Text = "FIle";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.saveFileToolStripMenuItem.Text = "Save as";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(827, 416);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sua);
            this.Controls.Add(this.thongbao);
            this.Controls.Add(this.hocki);
            this.Controls.Add(this.namhoc);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHAPDIEM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.sua.ResumeLayout(false);
            this.sua.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox namhoc;
        private System.Windows.Forms.ComboBox hocki;
        private System.Windows.Forms.ListView thongbao;
        private System.Windows.Forms.ColumnHeader monhoc;
        private System.Windows.Forms.ColumnHeader tinchi;
        private System.Windows.Forms.ColumnHeader diem;
        private System.Windows.Forms.Panel sua;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox suadiem;
        private System.Windows.Forms.TextBox suatinchi;
        private System.Windows.Forms.TextBox suamon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tongket;
        private System.Windows.Forms.TextBox diemtbhk;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label xeploai;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox suanam;
        private System.Windows.Forms.ComboBox suahk;
        private System.Windows.Forms.Label label7;
    }
}