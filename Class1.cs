using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace DeReport
{
    public class Report
    {
        public void StartEdit(string[] array)
        {
            _EditWord(array);
        }
        static Tuple<string, string> GetWordFile()
        {
            //System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            //string _InputFileName = assembly.GetName().Name + "Report_Word.docx";
            string _InputFileName = TempRes.DeReportReport_Word.ToString();
            string _OutputFileName = "";
            Tuple<string, string> _FileTuple = new Tuple<string, string>(_InputFileName, _OutputFileName);
            return _FileTuple;
        }
        static void FileCopy()
        {

        }
        static List<string> _KeyList()
        {
            List<string> _KeyList = new List<string>();
            _KeyList.Add("{Name}");
            _KeyList.Add("{Number}");
            _KeyList.Add("{Class}");
            _KeyList.Add("{Major}");
            _KeyList.Add("{Report_Name}");
            _KeyList.Add("{Report_Time}");
            _KeyList.Add("{Report_Where}");
            _KeyList.Add("{Report_Teacher}");
            _KeyList.Add("{Report_Item_1}");
            _KeyList.Add("{Report_Item_2}");
            _KeyList.Add("{Report_Item_3}");
            _KeyList.Add("{Report_Item_4}");
            _KeyList.Add("{Report_Item_5}");
            _KeyList.Add("{Report_Item_6}");
            _KeyList.Add("{Report_Item_7}");
            return _KeyList;
        }
        static void _EditWord(string[] array)
        {
            Application app = new Microsoft.Office.Interop.Word.Application();
            Type WordType = app.GetType();
            var docfile = GetWordFile().Item1;
            object readonlys = false;
            object IsVisBle = true;
            Document docs = null;

            try
            {
                docs = app.Documents.Open(docfile);
            }
            catch
            {

            }
        }
    }
    internal class Class1
    {
    }
}
