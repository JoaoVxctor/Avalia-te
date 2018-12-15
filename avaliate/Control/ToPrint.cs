using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using Npgsql;
using static avaliate.MontagemProva;

namespace avaliate.Control
{
    class ToPrint
    {
        public ToPrint()
        {

        }



        public void imprimir(System.Drawing.Image imagem, string output, Conexao con, System.Windows.Forms.ListBox.ObjectCollection itens, Document doc) { 
        doc = new Document(PageSize.A4);
        int i = 0;
        Font fonte = FontFactory.GetFont("Arial", 10);
        Font fonteB = FontFactory.GetFont("Arial", 12, Font.BOLD);


            try
            {

                using (var fileStream = new System.IO.FileStream(output, System.IO.FileMode.Create, System.IO.FileAccess.Write, System.IO.FileShare.None))
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, fileStream);


                    using (NpgsqlConnection conn = new NpgsqlConnection(con.getConn()))
                    {
                        conn.Open();
                        doc.Open();
                        try
                        {
                            //Image.GetInstance(cabecalho, System.Drawing.Imaging.ImageFormat.Png);
                            Image pdfImage = Image.GetInstance(imagem, System.Drawing.Imaging.ImageFormat.Png);

                            pdfImage.ScaleToFit(510, 240);
                            //   pdfImage.SetAbsolutePosition(0,842);
                            doc.Add(pdfImage);

                        }
                        catch { MessageBox.Show("Sem cabeçalho"); }

                        //                 pdfImage.SetAbsolutePosition(Top);

                        foreach (Questao item in itens)
                        {


                            using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT enunciado, resposta FROM questoes WHERE id = @id", conn))
                            {
                                cmd.Parameters.AddWithValue("id", Convert.ToInt32(itens[i].ToString()));

                                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                                {
                                    while (reader.Read())
                                    {
                                        string titulo = Convert.ToString(i + 1) + " - " + reader.GetString(0) + "\n\n";
                                        string questao = " \t\t " + reader.GetString(1) + "\n\n";

                                        Paragraph a = new Paragraph(titulo);
                                        Paragraph b = new Paragraph(questao);

                                        a.Font = fonteB;
                                        b.Font = fonte;

                                        doc.Add(a);
                                        doc.Add(b);
                                       
                                    }

                                }
                            }

                            i++;

                        }
                        doc.Close();
                    }


                }
            }
            catch { MessageBox.Show("Alguma coisa deu de errado"); }
            }
    }
}
