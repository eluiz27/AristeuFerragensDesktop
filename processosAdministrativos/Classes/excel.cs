using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;

namespace processosAdministrativos.Classes
{
    class Excel
    {
        string path = "";
        _Application Excels = new _Excel.Application();
        Workbook wb;
        Worksheet ws;
        public Excel()
        {

        }

        public Excel(string path, string pass)
        {
            this.path = path;
            wb = Excels.Workbooks.Open(path, Password: pass);
        }

        public string ReadCell(int linha, int coluna, int sheet)
        {
            ws = wb.Worksheets[sheet];
            linha++;
            coluna++;
            if (ws.Cells[linha, coluna].Value2 != null)
                return ws.Cells[linha, coluna].Value2.ToString();
            else
                return "";
        }
        public string ReadCell2(int sheet, int i, int j, string dia)
        {
            ws = wb.Worksheets[sheet];
            i++;
            j++;
            int x = 0;
            double y = 0;
            while (x == 0)
            {
                if (double.TryParse(ws.Cells[i, j].Text, out y))
                {
                    if (ws.Cells[i, 3].Value2.ToString() == dia)
                    {
                        y = Convert.ToDouble(ws.Cells[i, j].Text);
                        x = 1;
                    }
                    else
                        i++;
                }
                else
                    x = 1;
            }
            return y.ToString();
        }
        public string ReadCell3(int sheet, int i, int j, string dia)
        {
            ws = wb.Worksheets[sheet];
            i++;
            j++;
            int x = 0;
            double y = 0;
            while (x == 0)
            {
                if (ws.Cells[i, 2].Value2.ToString() == dia)
                {
                    y = Convert.ToDouble(ws.Cells[i, j].Text);
                    x = 1;
                }
                else
                    i++;
            }
            return y.ToString();
        }
        public List<string> ReadCell4()
        {
            List<string> cod = new List<string>();
            ws = wb.Worksheets[1];
            int x = 0;
            int y = 1;

            while (x == 0)
            {
                if (ws.Cells[y, 1].Value2 != null)
                    cod.Add(ws.Cells[y, 1].Value2.ToString());
                else
                    x = 1;
                y++;
            }
            return cod;
        }
        public List<string> ReadCell5()
        {
            List<string> qtde = new List<string>();
            ws = wb.Worksheets[1];
            int x = 0;
            int y = 1;

            while (x == 0)
            {
                if (ws.Cells[y, 2].Value2 != null)
                    qtde.Add(ws.Cells[y, 2].Value2.ToString());
                else
                    x = 1;
                y++;
            }
            return qtde;
        }
        public List<string> ReadCell6()
        {
            List<string> valor = new List<string>();
            ws = wb.Worksheets[1];
            int x = 0;
            int y = 1;

            while (x == 0)
            {
                if (ws.Cells[y, 3].Value2 != null)
                    valor.Add(ws.Cells[y, 3].Value2.ToString());
                else
                    x = 1;
                y++;
            }
            return valor;
        }

        public string[,] ReadRange(int linhaIB, int linhaIL, int linhaFB, int linhaFL, int sheet)
        {
            ws = wb.Worksheets[sheet];
            Range range = (Range)ws.Range[ws.Cells[linhaIB, linhaIL], ws.Cells[linhaFB, linhaFL]];

            if (range.Count > 1)
            {
                object[,] holder = range.Value2;

                string[,] returnstring = new string[(linhaFB + 1) - linhaIB, 1];
                for (int i = 0; i < holder.Length; i++)
                {
                    if (linhaIL == 15 || linhaIL == 36)
                        returnstring[i, 0] = String.Format("{0:0.00}", holder[i + 1, 1]);
                    else if (linhaIL == 28)
                        returnstring[i, 0] = String.Format("{0:0.0}", holder[i + 1, 1]);
                    else
                        returnstring[i, 0] = String.Format("{0:0,0}", holder[i + 1, 1]);
                }
                return returnstring;
            }
            else
            {
                object holder = range.Value2;

                string[,] returnstring = new string[(linhaFB + 1) - linhaIB, 1];
                if (linhaIL == 15 || linhaIL == 36)
                    returnstring[0, 0] = String.Format("{0:0.00}", holder);
                else if (linhaIL == 28)
                    returnstring[0, 0] = String.Format("{0:0.0}", holder);
                else
                    returnstring[0, 0] = String.Format("{0:0,0}", holder);
                return returnstring;
            }
        }

        public void WriteRange(int linhaIB, int linhaIL, int linhaFB, int linhaFL, int sheet, string[,] s)
        {
            ws = wb.Worksheets[sheet];
            Range range = (Range)ws.Range[ws.Cells[linhaIB, linhaIL], ws.Cells[linhaFB, linhaFL]];
            range.Value2 = s;
        }

        public void WriteRange2(int linhaIB, int linhaIL, int linhaFB, int linhaFL, int sheet, double[,] s)
        {
            ws = wb.Worksheets[sheet];
            Range range = (Range)ws.Range[ws.Cells[linhaIB, linhaIL], ws.Cells[linhaFB, linhaFL]];
            range.Value2 = s;
        }

        public void WriteCell(int sheet, int i, int j, string s, string dia)
        {
            ws = wb.Worksheets[sheet];
            i++;
            j++;
            int x = 0;
            while (x == 0)
            {
                if (ws.Cells[i, 3].Value2.ToString() == dia)
                {
                    ws.Cells[i, j].Value2 = s;
                    x = 1;
                }
                else
                    i++;
            }
        }

        public void WriteCellIndic(int sheet, int i, int j, string s, string dia)
        {
            ws = wb.Worksheets[sheet];
            i++;
            j++;
            int x = 0;
            while (x == 0)
            {
                if (ws.Cells[i, 2].Value2.ToString() == dia)
                {
                    ws.Cells[i, j].Value2 = s;
                    x = 1;
                }
                else
                    i++;
            }
        }

        public void WriteCell2(int sheet, int linha, int coluna, string s, string vdd)
        {
            ws = wb.Worksheets[sheet];
            linha++;
            coluna++;
            int x = 0;
            string aux;
            while (x == 0)
            {
                if (vdd != "LOJA")
                {
                    aux = ws.Cells[linha, 1].Text;
                    if (aux != string.Empty && aux.Substring(0, 3) == vdd.Substring(0, 3).ToUpper())
                    {
                        ws.Cells[linha, coluna].Value2 = s;
                        x = 1;
                    }
                    else
                        linha++;
                }
                else
                {
                    ws.Cells[linha, coluna].Value2 = s;
                    x = 1;
                }
            }

        }

        public void WriteCell3(int sheet, int i, int j, string s)
        {
            ws = wb.Worksheets[sheet];
            i++;
            j++;

            ws.Cells[i, j].Value2 = s;
        }

        public void WriteCell4(int sheet, int i, int j, double s)
        {
            ws = wb.Worksheets[sheet];
            i++;
            j++;

            ws.Cells[i, j].Value2 = s;
        }

        public void AjustarColunas(int sheet, string colIni, string colFim)
        {
            ws = wb.Worksheets[sheet];

            ws.Columns[colIni + ":" + colFim].AutoFit();
        }

        public void Negrito(int sheet, string ran)
        {
            wb.Worksheets[sheet].Range(ran).Font.Bold = true;
        }
        public void PintarAmerelo(int sheet, string ran)
        {
            wb.Worksheets[sheet].Range(ran).Interior.Color = XlRgbColor.rgbYellow;
        }
        public void PintarVermelho(int sheet, string ran)
        {
            wb.Worksheets[sheet].Range(ran).Interior.Color = XlRgbColor.rgbRed;
        }
        public void PintarCastaAreno(int sheet, string ran)
        {
            wb.Worksheets[sheet].Range(ran).Interior.Color = XlRgbColor.rgbSandyBrown;
        }
        public void Numero(int sheet, string ran)
        {
            wb.Worksheets[sheet].Range(ran).NumberFormat = "0.00";
        }
        public int ContaPastas()
        {
            return wb.Worksheets.Count;
        }
        public void CreateSheet(string nome)
        {
            ws = wb.Worksheets[wb.Worksheets.Count-1];
            ws.Copy(After: ws);
            ws = wb.Worksheets[wb.Worksheets.Count - 1];
            ws.Name = nome;
        }

        public void CreateFile()
        {
            this.wb = Excels.Workbooks.Add();
        }
        public void CreateSheet()
        {
            this.ws = wb.Worksheets.Add();
        }


        public void Save()
        {
            wb.Save();
        }
        public void SavaAs(string path)
        {
            wb.SaveAs(path);
        }
        public void Close()
        {
            wb.Close(true);
            Excels.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(Excels);
        }
    }
}
