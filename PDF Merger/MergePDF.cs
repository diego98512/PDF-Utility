using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.IO;
using System.Windows.Forms;
using System.Text;

namespace PDF_Merger
{
	public class MergePDF
	{
		public static void CreateMergedPDF(string targetPDF, string sourceDir)
		{
			using (FileStream stream = new FileStream((targetPDF + ".pdf"), FileMode.Create))
			{
				Document pdfDoc = new Document(PageSize.A4);
				PdfCopy pdf = new PdfCopy(pdfDoc, stream);
				pdfDoc.Open();
				var files = Directory.GetFiles(sourceDir);
				Console.WriteLine("Merging files count: " + files.Length);
				int i = 1;
				foreach (string file in files)
				{
					Console.WriteLine(i + ". Adding: " + file);
					pdf.AddDocument(new PdfReader(file));
					i++;
				}

				if (pdfDoc != null)
					pdfDoc.Close();

				MessageBox.Show(
					text: "PDF Merge Has Completed! Check this program's directory for your merged document!",
					caption: "PDF Merge - Success"
					);
			}
		}
	}
}