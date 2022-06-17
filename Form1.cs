using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DeReport
{

    public partial class WordReplace : Form
    {
        public WordReplace()
        {
            InitializeComponent();
        }
        public static WordReplace Form;
        public static class ItemValue
        {
            public static string Item1 { get; set; }
            public static string Item2 { get; set; }
            public static string Item3 { get; set; }
            public static string Item4 { get; set; }
            public static string Item5 { get; set; }
            public static string Item6 { get; set; }
            public static string Item7 { get; set; }
            public static object Item8 { get; set; }
        }
        public void Report_Item_Boxs_Visible()
        {
            Form = this;
            Form.Report_Item_Box.Visible = false;
            Form.Report_Item_Box_2.Visible = false;
            Form.Report_Item_Box_3.Visible = false;
            Form.Report_Item_Box_4.Visible = false;
            Form.Report_Item_Box_5.Visible = false;
            Form.Report_Item_Box_6.Visible = false;
            Form.Report_Item_Box_7.Visible = false;
        }
        public void ToWordEdit(string[] Value)
        {
            WordFileEdit wordFileEdit = new WordFileEdit();
            try
            {
                wordFileEdit.StartEdit(Value);
                MessageBox.Show("生成成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            string[] Value =  Save();
            int flag = 0;
            foreach (string IsNull in Value)
            {
                if (IsNull == "")
                {
                    flag ++;
                }
            }
            if (flag != 0)
            {
                MessageBoxButtons OK = MessageBoxButtons.OKCancel;
                DialogResult DR = MessageBox.Show("还有空项，是否继续？", "Error", OK);
                if (DR == DialogResult.OK)
                {
                    ToWordEdit(Value);
                }
                else
                {
                    MessageBox.Show("生成终止，请填补空项");
                }

            }
            else
            {
                ToWordEdit(Value);
            }
        }
        public void Item_List_Box_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (Item_List_Box.SelectedIndex)
            {
                case 0:
                    Report_Item_Boxs_Visible();
                    Report_Item_Box.Visible = true;
                    break;
                case 1:
                    Report_Item_Boxs_Visible();
                    Report_Item_Box_2.Visible = true;
                    break;
                case 2:
                    Report_Item_Boxs_Visible();
                    Report_Item_Box_3.Visible = true;
                    break;
                case 3:
                    Report_Item_Boxs_Visible();
                    Report_Item_Box_4.Visible = true;
                    break;
                case 4:
                    Report_Item_Boxs_Visible();
                    Report_Item_Box_5.Visible = true;
                    break;
                case 5:
                    Report_Item_Boxs_Visible();
                    Report_Item_Box_6.Visible = true;
                    break;
                case 6:
                    Report_Item_Boxs_Visible();
                    Report_Item_Box_7.Visible = true;
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }
        public string[] Save()
        {
            ItemValue.Item1 = Report_Item_Box.Text;
            ItemValue.Item2 = Report_Item_Box_2.Text;
            ItemValue.Item3 = Report_Item_Box_3.Text;
            ItemValue.Item4 = Report_Item_Box_4.Text;
            ItemValue.Item5 = Report_Item_Box_5.Text;
            ItemValue.Item6 = Report_Item_Box_6.Text;
            ItemValue.Item7 = Report_Item_Box_7.Text;
            string[] Value = new string[15];
            Value[0] = Name_Box.Text;
            Value[1] = UID_Box.Text;
            Value[2] = Class_List_Box.Text;
            Value[3] = Major_List_Box.Text;
            Value[4] = Report_Name_Box.Text;
            Value[5] = Report_Time_Box.Text;
            Value[6] = Report_Where_Box.Text;
            Value[7] = Report_Teacher_Box.Text;
            Value[8] = ItemValue.Item1;
            Value[9] = ItemValue.Item2;
            Value[10] = ItemValue.Item3;
            Value[11] = ItemValue.Item4;
            Value[12] = ItemValue.Item5;
            Value[13] = ItemValue.Item6;
            Value[14] = ItemValue.Item7;
            return Value;
        }

        private void WordReplace_Load(object sender, EventArgs e)
        {

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void 关于ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Zoisite\nVer 1.0\n\n本项目使用了以下开源组件，他们受Apache2.0协议的保护：\n1.nissl-lab\\npoi\n\n本项目使用了以下开源组件，他们受MIT协议的保护：\n1.icsharpcode\\SharpZipLib");
        }

        private void 协议ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("本项目使用了以下开源组件，他们受Apache2.0协议的保护：\n1.nissl-lab\\npoi\n\n你可以在以下位置查看Apache2.0协议的完整内容：\n1.https://github.com/nissl-lab/npoi/blob/master/LICENSE\n2.程序根目录/LICENSE\n\n文件本项目使用了以下开源组件，他们受MIT协议的保护：\n1.icsharpcode\\SharpZipLib\n\n你可以在以下位置查看MIT协议的完整内容：\n1.https://github.com/icsharpcode/SharpZipLib/blob/master/LICENSE.txt\n2.程序根目录/LICENSE文件");
        }
    }
}
