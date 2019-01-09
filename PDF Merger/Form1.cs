using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_Merger
{
	public partial class form_MergePDF : Form
	{
		public string folderPath = "";
		public string filePath = "";
		public FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
		public OpenFileDialog fileDialog1 = new OpenFileDialog();
		public SaveFileDialog saveDialog1 = new SaveFileDialog();
		public SaveFileDialog saveDialog2 = new SaveFileDialog();

		public form_MergePDF()
		{
			InitializeComponent();
		}

		#region PDF Merge
		private void btn_Merge_Click(object sender, EventArgs e)
		{
			if (txt_Filename.Text != "")
			{
				try
				{
					MergePDF.CreateMergedPDF(txt_Filename.Text, txt_Directory.Text);
				}

				catch
				{
					MessageBox.Show(
						text: "You need to have a directory selected!",
						caption: "PDF Merger - Error"
						);
				}
			}
			else
				MessageBox.Show(
					text: "You need to enter a filename!",
					caption: "PDF Merger - Error"
					);
		}

		private void btn_Help_Merge_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				text: "Filename: Enter the desired filename for your merged PDF or click \"Save As...\" to select a location in a file explorer.\n\n" +
						"PDF Files Directory: Click the \"Browse\" button. Choose a directory that contains the PDF files you wish to merge. I read them as they are organized by default from top down. Once you have the directory selected, hit that OK button.\n\n" +
						"Merge!: Clicking the \"Merge!\" button will tell me that you're ready to have your documents merged together.",
				caption: "PDF Merger - Help"
				);
		}

		private void btn_Browse_Merge_Click(object sender, EventArgs e)
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				folderPath = folderBrowserDialog1.SelectedPath;
			}

			txt_Directory.Text = folderPath;
		}

		private void btn_SaveAs_Merge_Click(object sender, EventArgs e)
		{
			saveDialog1.InitialDirectory = @"C:\";
			saveDialog1.RestoreDirectory = true;
			saveDialog1.Title = "Save as...";
			saveDialog1.DefaultExt = "pdf";
			saveDialog1.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*";
			saveDialog1.FilterIndex = 2;
			saveDialog1.CheckFileExists = false;
			saveDialog1.CheckPathExists = true;

			DialogResult result = saveDialog2.ShowDialog();

			if (result == DialogResult.OK) // Test result.
			{
				txt_Filename_TIFF.Text = saveDialog2.FileName;
			}
		}

		#endregion PDF Merge

		#region TIFF -> PDF

		public void ConvertTiff(string input, string output)
		{
			// creation of the document with a certain size and certain margins
			iTextSharp.text.Document document = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 0, 0, 0, 0);

			// creation of the different writers
			iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(document, new System.IO.FileStream(output, System.IO.FileMode.Create));

			// load the tiff image and count the total pages
			System.Drawing.Bitmap bm = new Bitmap(input);
			int total = bm.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page);

			document.Open();
			iTextSharp.text.pdf.PdfContentByte cb = writer.DirectContent;
			for (int k = 0; k < total; ++k)
			{
				bm.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, k);

				iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(bm, ImageFormat.Tiff);
				img.SetAbsolutePosition(0, 0);
				img.ScaleAbsoluteHeight(document.PageSize.Height);
				img.ScaleAbsoluteWidth(document.PageSize.Width);
				cb.AddImage(img);

				document.NewPage();
			}
			document.Close();

			MessageBox.Show(
					text: "TIFF Conversion Has Completed! Check this program's directory for your merged document!",
					caption: "TIFF Conversion - Success"
					);
		}


		private void btn_Convert_Click(object sender, EventArgs e)
		{

			ConvertTiff(txt_Directory_TIFF.Text, txt_Filename_TIFF.Text);
			
		}

		private void btn_Browse_TIFF_Click(object sender, EventArgs e)
		{

			int size = -1;

			DialogResult result = fileDialog1.ShowDialog(); // Show the dialog.

			if (result == DialogResult.OK) // Test result.
			{
				string file = fileDialog1.FileName;
				try
				{
					string text = File.ReadAllText(file);
					size = text.Length;
					txt_Directory_TIFF.Text = file;
				}
				catch (IOException)
				{
				}
			}

			//txt_Directory_TIFF.Text = file;

		}

		private void btn_Help_TIFF_Click(object sender, EventArgs e)
		{
			MessageBox.Show(
				text: "Filename: Enter the desired filename for your converted PDF or click \"Save As...\" to select a location in a file explorer and enter the name there.\n\n" +
						"TIF File: Enter the directory and filename of your .TIF file or click the \"Browse\" button to select the file in a file explorer.\n\n" +
						"Convert!: Clicking the \"Convert!\" button will tell me that you're ready to have your TIF file converted to PDF.",
				caption: "Convert TIFF - Help"
				);
		}

		private void btn_SaveAs_TIFF_Click(object sender, EventArgs e)
		{
			saveDialog1.InitialDirectory = @"C:\";
			saveDialog1.RestoreDirectory = true;
			saveDialog1.Title = "Save as...";
			saveDialog1.DefaultExt = "pdf";
			saveDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
			saveDialog1.FilterIndex = 2;
			saveDialog1.CheckFileExists = false;
			saveDialog1.CheckPathExists = true;

			DialogResult result = saveDialog1.ShowDialog();

			if (result == DialogResult.OK) // Test result.
			{
				txt_Filename_TIFF.Text = saveDialog1.FileName;
			}

		}
		#endregion TIFF -> PDF

		
	}
}
