using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using YoutubeController;
using WinFormsApp1;

namespace YoutubeController
{
   
    public partial class MainForm : Form
    {

        static string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        static string path = Path.Combine(desktopPath, "User.xlsx");
        static Excel.Application excelApp = null;
        static Excel.Workbook workBook = null;
        static Excel.Worksheet workSheet = null;
        public string data;
        public MainForm()
        {
            InitializeComponent();
           
        }


        // User.xslx에 들어있는 ID와 Password의 동일 유무를 파악 하여 동일 하지 않을시 로그인 불가 동일시 Login 진행
        private void button1_Click(object sender, EventArgs e)
        {
            this.data=loginidBox.Text;
            try
            {

                excelApp = new Excel.Application();
                workBook = excelApp.Workbooks.Open(path);
                workSheet = workBook.Worksheets.get_Item(1) as Excel.Worksheet;

                Excel.Range range = workSheet.UsedRange;
                for (int row = 1; row <= range.Rows.Count; row++)
                {
                    string excelId = Convert.ToString((range.Cells[row, 1] as Excel.Range).Value2);
                    if (loginidBox.Text == excelId)
                    {
                        for (int row2 = 1; row2 <= range.Rows.Count; row2++)
                        {
                            string excelPassword = Convert.ToString((range.Cells[row, 2] as Excel.Range).Value2);
                            if (loginpasswordBox.Text == excelPassword)
                            {

                                
                                mainLable.Text = "Loging...";

                                workBook.Close(true);
                                excelApp.Quit();
                                this.Visible = false;
                                Form1 s = new Form1();
                                s.label7.Text = Convert.ToString(row);
                                
                                s.ShowDialog();                               
                                break;
                                break;
                                Close();
                            }
                            else
                            {
                                label4.Text = "The password is incorrect";
                                continue;
                            }
                        }
                    }
                    else
                    {
                        label4.Text = "The user does not exist";

                        continue;
                    }
                }
                workBook.SaveAs(path, Excel.XlFileFormat.xlWorkbookDefault);
                workBook.Close(true);
                excelApp.Quit();
            }
            catch
            {
                Close();
            }
            finally
            {
                ReleaseObject(workSheet);
                ReleaseObject(workBook);
                ReleaseObject(excelApp);
            }
        }
        
        public static void ReleaseObject(object obj)
        {
            try
            {
                if (obj != null)
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

        private void creatButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CreateUser s = new CreateUser();
            s.ShowDialog();
        }

        // MainForm 이 로드 되면서 바탕화면에 User.xlsx 파일 유무를 파악후에 없으면 생성하고 사용자에게 유저를 생성할 것을 유도
        private void MainForm_Load(object sender, EventArgs e)
        {
            FileInfo fi = new FileInfo(path);
            if (!fi.Exists)
            {
                CreateUser.createExcel(desktopPath, path);
                label5.Text = "User does not exist. \r\nPlase create a user.";

            }
        }
    }
}

