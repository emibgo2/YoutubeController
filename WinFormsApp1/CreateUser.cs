using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using YoutubeController;

namespace WinFormsApp1
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
             
        }
        class User {
            public string id;
            public string password;
            public string useUrl;
        }
        public static void createExcel(string desktopPath, string path)
        {
            try{
            
            excelApp = new Excel.Application();
            workbook = excelApp.Workbooks.Add();
            worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;
            worksheet.Cells[1, 1] = "ID";
            worksheet.Cells[1, 2] = "Password";
            worksheet.Cells[1, 3] = "Use Url";
            worksheet.Columns.AutoFit(); // 열 너비 자동 맞춤
            workbook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault); // 엑셀 파일 저장
            workbook.Close(true); 
            excelApp.Quit();
            }
            finally
            {
                ReleaseObject(worksheet); ReleaseObject(workbook); ReleaseObject(excelApp);

            }
        }

        static Excel.Application excelApp = null;
        static Excel.Workbook workbook = null;
        static Excel.Worksheet worksheet = null;
        static int start = 1;
        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static  string path = Path.Combine(desktopPath, "test.xlsx");
        private void Create_User()
        {

            try
            {
                

                excelApp = new Excel.Application();
                workbook = excelApp.Workbooks.Open(path);
                worksheet = workbook.Worksheets.get_Item(1) as Excel.Worksheet;


                start = worksheet.UsedRange.Rows.Count + 1;

                worksheet.Cells[start, 1] = idBox.Text;
                worksheet.Cells[start, 2] = passwordBox.Text;
                worksheet.Cells[start, 3] = "없음";
                worksheet.Columns.AutoFit(); // 열 너비 자동 맞춤
                workbook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault); // 엑셀 파일 저장

                workbook.Close(true);
                excelApp.Quit();
            }
            finally { ReleaseObject(worksheet); ReleaseObject(workbook); ReleaseObject(excelApp); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (idBox.Text != "" || passwordBox.Text != "")
            {
                Create_User();
            }
            else
                sign1.Text = "ID와 Password를 입력하세요";
        }
        public static void ReleaseObject(object obj)
        {
            try
            {
                if(obj!=null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;

            }
            finally
            {
                GC.Collect();
            }
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
            {
                createExcel(desktopPath,path);
            }
        }

        private void CreateUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Visible = false;
            MainForm s = new MainForm();
            s.ShowDialog();
            e.Cancel = true;

        }
    }
}
