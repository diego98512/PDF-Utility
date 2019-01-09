namespace PDF_Merger
{
	partial class form_MergePDF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_MergePDF));
			this.txt_Filename = new System.Windows.Forms.TextBox();
			this.txt_Directory = new System.Windows.Forms.TextBox();
			this.lbl_Filename = new System.Windows.Forms.Label();
			this.lbl_Directory = new System.Windows.Forms.Label();
			this.btn_Merge = new System.Windows.Forms.Button();
			this.btn_Browse_Merge = new System.Windows.Forms.Button();
			this.btn_Help_Merge = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tab_PDFMerge = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btn_Browse_TIFF = new System.Windows.Forms.Button();
			this.txt_Directory_TIFF = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_Filename_TIFF = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Convert = new System.Windows.Forms.Button();
			this.btn_Help_TIFF = new System.Windows.Forms.Button();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.btn_SaveAs_TIFF = new System.Windows.Forms.Button();
			this.btn_SaveAs_Merge = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.tab_PDFMerge.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_Filename
			// 
			this.txt_Filename.Location = new System.Drawing.Point(76, 416);
			this.txt_Filename.Name = "txt_Filename";
			this.txt_Filename.Size = new System.Drawing.Size(161, 20);
			this.txt_Filename.TabIndex = 0;
			// 
			// txt_Directory
			// 
			this.txt_Directory.Location = new System.Drawing.Point(124, 449);
			this.txt_Directory.Name = "txt_Directory";
			this.txt_Directory.Size = new System.Drawing.Size(287, 20);
			this.txt_Directory.TabIndex = 1;
			// 
			// lbl_Filename
			// 
			this.lbl_Filename.AutoSize = true;
			this.lbl_Filename.Location = new System.Drawing.Point(26, 419);
			this.lbl_Filename.Name = "lbl_Filename";
			this.lbl_Filename.Size = new System.Drawing.Size(52, 13);
			this.lbl_Filename.TabIndex = 2;
			this.lbl_Filename.Text = "Filename:";
			// 
			// lbl_Directory
			// 
			this.lbl_Directory.AutoSize = true;
			this.lbl_Directory.Location = new System.Drawing.Point(26, 452);
			this.lbl_Directory.Name = "lbl_Directory";
			this.lbl_Directory.Size = new System.Drawing.Size(100, 13);
			this.lbl_Directory.TabIndex = 3;
			this.lbl_Directory.Text = "PDF Files Directory:";
			// 
			// btn_Merge
			// 
			this.btn_Merge.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Merge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.btn_Merge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btn_Merge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Merge.Font = new System.Drawing.Font("Kozuka Mincho Pr6N R", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_Merge.Location = new System.Drawing.Point(253, 285);
			this.btn_Merge.Name = "btn_Merge";
			this.btn_Merge.Size = new System.Drawing.Size(285, 69);
			this.btn_Merge.TabIndex = 4;
			this.btn_Merge.Text = "Merge!";
			this.btn_Merge.UseVisualStyleBackColor = true;
			this.btn_Merge.Click += new System.EventHandler(this.btn_Merge_Click);
			// 
			// btn_Browse_Merge
			// 
			this.btn_Browse_Merge.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Browse_Merge.Font = new System.Drawing.Font("Javanese Text", 9.75F);
			this.btn_Browse_Merge.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Browse_Merge.Location = new System.Drawing.Point(417, 443);
			this.btn_Browse_Merge.Name = "btn_Browse_Merge";
			this.btn_Browse_Merge.Size = new System.Drawing.Size(77, 30);
			this.btn_Browse_Merge.TabIndex = 6;
			this.btn_Browse_Merge.Text = "Browse...";
			this.btn_Browse_Merge.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Browse_Merge.UseVisualStyleBackColor = true;
			this.btn_Browse_Merge.Click += new System.EventHandler(this.btn_Browse_Merge_Click);
			// 
			// btn_Help_Merge
			// 
			this.btn_Help_Merge.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Help_Merge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.btn_Help_Merge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btn_Help_Merge.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Help_Merge.Location = new System.Drawing.Point(744, 444);
			this.btn_Help_Merge.Name = "btn_Help_Merge";
			this.btn_Help_Merge.Size = new System.Drawing.Size(75, 29);
			this.btn_Help_Merge.TabIndex = 7;
			this.btn_Help_Merge.Text = "Help";
			this.btn_Help_Merge.UseVisualStyleBackColor = true;
			this.btn_Help_Merge.Click += new System.EventHandler(this.btn_Help_Merge_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(123, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(573, 221);
			this.pictureBox1.TabIndex = 8;
			this.pictureBox1.TabStop = false;
			// 
			// tab_PDFMerge
			// 
			this.tab_PDFMerge.Controls.Add(this.tabPage1);
			this.tab_PDFMerge.Controls.Add(this.tabPage2);
			this.tab_PDFMerge.HotTrack = true;
			this.tab_PDFMerge.ItemSize = new System.Drawing.Size(58, 20);
			this.tab_PDFMerge.Location = new System.Drawing.Point(3, 2);
			this.tab_PDFMerge.Name = "tab_PDFMerge";
			this.tab_PDFMerge.SelectedIndex = 0;
			this.tab_PDFMerge.Size = new System.Drawing.Size(839, 524);
			this.tab_PDFMerge.TabIndex = 9;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btn_SaveAs_Merge);
			this.tabPage1.Controls.Add(this.pictureBox1);
			this.tabPage1.Controls.Add(this.btn_Browse_Merge);
			this.tabPage1.Controls.Add(this.btn_Help_Merge);
			this.tabPage1.Controls.Add(this.txt_Directory);
			this.tabPage1.Controls.Add(this.lbl_Directory);
			this.tabPage1.Controls.Add(this.btn_Merge);
			this.tabPage1.Controls.Add(this.txt_Filename);
			this.tabPage1.Controls.Add(this.lbl_Filename);
			this.tabPage1.Location = new System.Drawing.Point(4, 24);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(831, 496);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "PDF Merge";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btn_SaveAs_TIFF);
			this.tabPage2.Controls.Add(this.btn_Browse_TIFF);
			this.tabPage2.Controls.Add(this.txt_Directory_TIFF);
			this.tabPage2.Controls.Add(this.label1);
			this.tabPage2.Controls.Add(this.txt_Filename_TIFF);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.btn_Convert);
			this.tabPage2.Controls.Add(this.btn_Help_TIFF);
			this.tabPage2.Controls.Add(this.pictureBox3);
			this.tabPage2.Location = new System.Drawing.Point(4, 24);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(831, 496);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "TIFF -> PDF";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btn_Browse_TIFF
			// 
			this.btn_Browse_TIFF.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Browse_TIFF.Font = new System.Drawing.Font("Javanese Text", 9.75F);
			this.btn_Browse_TIFF.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Browse_TIFF.Location = new System.Drawing.Point(363, 443);
			this.btn_Browse_TIFF.Name = "btn_Browse_TIFF";
			this.btn_Browse_TIFF.Size = new System.Drawing.Size(77, 30);
			this.btn_Browse_TIFF.TabIndex = 16;
			this.btn_Browse_TIFF.Text = "Browse...";
			this.btn_Browse_TIFF.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btn_Browse_TIFF.UseVisualStyleBackColor = true;
			this.btn_Browse_TIFF.Click += new System.EventHandler(this.btn_Browse_TIFF_Click);
			// 
			// txt_Directory_TIFF
			// 
			this.txt_Directory_TIFF.Location = new System.Drawing.Point(70, 449);
			this.txt_Directory_TIFF.Name = "txt_Directory_TIFF";
			this.txt_Directory_TIFF.Size = new System.Drawing.Size(287, 20);
			this.txt_Directory_TIFF.TabIndex = 13;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 452);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 15;
			this.label1.Text = "TIF File:";
			// 
			// txt_Filename_TIFF
			// 
			this.txt_Filename_TIFF.Location = new System.Drawing.Point(76, 416);
			this.txt_Filename_TIFF.Name = "txt_Filename_TIFF";
			this.txt_Filename_TIFF.Size = new System.Drawing.Size(161, 20);
			this.txt_Filename_TIFF.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(26, 419);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Filename:";
			// 
			// btn_Convert
			// 
			this.btn_Convert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Convert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.btn_Convert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btn_Convert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_Convert.Font = new System.Drawing.Font("Kozuka Mincho Pr6N R", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_Convert.Location = new System.Drawing.Point(253, 285);
			this.btn_Convert.Name = "btn_Convert";
			this.btn_Convert.Size = new System.Drawing.Size(285, 69);
			this.btn_Convert.TabIndex = 11;
			this.btn_Convert.Text = "Convert!";
			this.btn_Convert.UseVisualStyleBackColor = true;
			this.btn_Convert.Click += new System.EventHandler(this.btn_Convert_Click);
			// 
			// btn_Help_TIFF
			// 
			this.btn_Help_TIFF.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_Help_TIFF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
			this.btn_Help_TIFF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
			this.btn_Help_TIFF.Font = new System.Drawing.Font("Javanese Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_Help_TIFF.Location = new System.Drawing.Point(744, 444);
			this.btn_Help_TIFF.Name = "btn_Help_TIFF";
			this.btn_Help_TIFF.Size = new System.Drawing.Size(75, 29);
			this.btn_Help_TIFF.TabIndex = 10;
			this.btn_Help_TIFF.Text = "Help";
			this.btn_Help_TIFF.UseVisualStyleBackColor = true;
			this.btn_Help_TIFF.Click += new System.EventHandler(this.btn_Help_TIFF_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(123, 21);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(573, 221);
			this.pictureBox3.TabIndex = 9;
			this.pictureBox3.TabStop = false;
			// 
			// btn_SaveAs_TIFF
			// 
			this.btn_SaveAs_TIFF.Font = new System.Drawing.Font("Javanese Text", 9.75F);
			this.btn_SaveAs_TIFF.Location = new System.Drawing.Point(243, 412);
			this.btn_SaveAs_TIFF.Name = "btn_SaveAs_TIFF";
			this.btn_SaveAs_TIFF.Size = new System.Drawing.Size(75, 28);
			this.btn_SaveAs_TIFF.TabIndex = 17;
			this.btn_SaveAs_TIFF.Text = "Save As...";
			this.btn_SaveAs_TIFF.UseVisualStyleBackColor = true;
			this.btn_SaveAs_TIFF.Click += new System.EventHandler(this.btn_SaveAs_TIFF_Click);
			// 
			// btn_SaveAs_Merge
			// 
			this.btn_SaveAs_Merge.Font = new System.Drawing.Font("Javanese Text", 9.75F);
			this.btn_SaveAs_Merge.Location = new System.Drawing.Point(243, 412);
			this.btn_SaveAs_Merge.Name = "btn_SaveAs_Merge";
			this.btn_SaveAs_Merge.Size = new System.Drawing.Size(75, 28);
			this.btn_SaveAs_Merge.TabIndex = 18;
			this.btn_SaveAs_Merge.Text = "Save As...";
			this.btn_SaveAs_Merge.UseVisualStyleBackColor = true;
			this.btn_SaveAs_Merge.Click += new System.EventHandler(this.btn_SaveAs_Merge_Click);
			// 
			// form_MergePDF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(846, 531);
			this.Controls.Add(this.tab_PDFMerge);
			this.Name = "form_MergePDF";
			this.Text = "PDF Utility";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.tab_PDFMerge.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txt_Filename;
		private System.Windows.Forms.TextBox txt_Directory;
		private System.Windows.Forms.Label lbl_Filename;
		private System.Windows.Forms.Label lbl_Directory;
		private System.Windows.Forms.Button btn_Merge;
		private System.Windows.Forms.Button btn_Browse_Merge;
		private System.Windows.Forms.Button btn_Help_Merge;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabControl tab_PDFMerge;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btn_Help_TIFF;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button btn_Convert;
		private System.Windows.Forms.TextBox txt_Directory_TIFF;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_Filename_TIFF;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Browse_TIFF;
		private System.Windows.Forms.Button btn_SaveAs_TIFF;
		private System.Windows.Forms.Button btn_SaveAs_Merge;
	}
}

