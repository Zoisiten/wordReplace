using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NPOI.XWPF.UserModel;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Office.Interop.Word;

namespace DeReport
{

    public class WordFileEdit
    {

        public void StartEdit(string[] array)
        {
            _EditWord(array);
        }
        static Tuple<string, string> GetWordFile()
        {
            string _InputFileName = @".\template\template.docx";
            string _OutputFileName = @".\Out\报告.docx";
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
        static void HuanHang()
        {

        }
        static void _EditWord(string[] array)
        {
            var _FileNameList = GetWordFile();
            using (FileStream FileStreams = File.OpenRead(_FileNameList.Item1))
            {
                XWPFDocument DOC = new XWPFDocument(FileStreams);
                File.Copy(_FileNameList.Item1, _FileNameList.Item2, true);
                using (FileStream FileOut = File.Create(_FileNameList.Item2))
                //using (FileStream FileOut = File.OpenWrite(_FileNameList.Item2))
                {
                    int Index = 0;
                    foreach (var paragraph in DOC.Paragraphs)
                    {
                        foreach (var _KeyList in _KeyList())
                        {
                            if (paragraph.ParagraphText.Contains(_KeyList))
                            {
                                if (array[Index].Contains("\n"))
                                {
                                    string[] text = Regex.Split(array[Index], "\n");
                                    string[] SplitText = new string[text.Length];

                                    string SplitFlag = null;
                                    foreach (var newlinetext in text)
                                    {
                                        //SplitText[SplitIndex] = newlinetext;
                                        SplitFlag = SplitFlag + newlinetext + "{FP}";
                                    }
                                    paragraph.ReplaceText(_KeyList, SplitFlag);
                                    Index++;
                                }
                                else
                                {
                                    paragraph.ReplaceText(_KeyList, array[Index]);
                                    Index++;
                                }
                            }
                        }
                    }
                    DOC.Write(FileOut);
                }
            }
        }
    }
}
