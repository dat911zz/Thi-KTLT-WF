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

//==================================================================//
//						   -Nhom 13-								//
//		Truong Nhom: Vu Ngo Dat		    MSSV: 2001202045			//
//		 Thanh vien: Mai Van Thoa	    MSSV: 2001202260			//
//		 Thanh vien: Tieu Huu Hau		MSSV: 2001202071			//
//		 Thanh vien: Doan Ngoc Thach	MSSV: 2001202237			//
//		 Thanh vien: Ho Lu Quoc Khanh	MSSV: 2001206924			//
//							De tai 23								//
//	Tim hieu, so sanh va cai dat cac ham xu ly mang 2 chieu tren	//
// 			    cac ngon ngu lap trinh C/C++ va C#					//
//==================================================================//
namespace Thi_KTLT_WF
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        //==================================================================
        //Phần giao diện
        // Install a new output TextWriter for the Console window.
        private void Form1_Load(object sender, EventArgs e)
        {
            TextBoxWriter writer = new TextBoxWriter(txtConsole);
            Console.SetOut(writer);
            panelInput.Visible = false;
            NhapNPanel.Visible = false;
        }
        // Write to the Console window.
        private void btnRun_Click(object sender, EventArgs e)
        {
            txtConsole.Clear();
            this.Refresh();
            thucHienChuongTrinh();
        }
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            panelInput.Visible = false;
            NhapNPanel.Visible = false;
            txtConsole.Clear();
            this.Refresh();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelInput.Visible = false;
            NhapNPanel.Visible = false;

            txtConsole.Clear();
            this.Refresh();
        }
        private void endBtn_Click(object sender, EventArgs e)
        {
            panelInput.Visible = false;
            NhapNPanel.Visible = false;
            txtConsole.Clear();
            this.Refresh();
            MessageBox.Show("Cảm ơn mọi người đã chú ý theo dõi! <3", "Chương Trình", MessageBoxButtons.OK);
            Application.Exit();
        }
        private void randBtn_CheckedChanged(object sender, EventArgs e)
        {
            NhapNPanel.Visible = true;
        }

        private void fileBtn_CheckedChanged(object sender, EventArgs e)
        {
            NhapNPanel.Visible = false;
        }
        //==================================================================
        //Phần Chương trình
        private void thucHienChuongTrinh()
        {
            int[,] a = new int[100, 100];
            int chon, n = 0, i = 0, j = 0, error = 0;
            if (randBtn.Checked == true)
            {
                //Check error stage 1
                if (int.TryParse(n_gt.Text, out n) && n > 0)
                {
                    errorProvider3.SetError(this.n, "");
                }
                else
                {
                    errorProvider3.SetError(this.n, "Chỉ được nhập số");
                    error++;
                }
                //Check error stage 2
                if (error == 0)
                {

                    taoM2C_Rand(a, n);
                }
                else
                {
                    string message = "Vui lòng nhập lại!";
                    string title = "ERROR!";

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                }
            }
            if (fileBtn.Checked == true)
            {
                taoM2C_File(a, ref n);
            }

            txtConsole.Controls.Clear();
            this.Refresh();
            chon = listBox1.SelectedIndex;
            switch (chon)
            {
                case 0:
                    xuatM2C(a, n);
                    Console.WriteLine();
                    Console.WriteLine("Cac cuc tri: ");
                    XuatCucTri(a, n);
                    break;
                case 1:
                    xuatM2C(a, n);
                    sapXepCotCSLeTangChanGiam(a, n);
                    Console.WriteLine();
                    xuatM2C(a, n);
                    break;
                case 2:
                    xuatM2C(a, n);
                    sapXepDuongCheoSongSongDCCVaDCC(a, n);
                    Console.WriteLine();
                    xuatM2C(a, n);
                    break;
                case 3:
                    xuatM2C(a, n);
                    if (kiemTraCacGiaTriMaTranCoGiamDanTheoTungCotKhong(a, n) == true)
                    {
                        Console.WriteLine("Cac gia tri trong ma tran giam dan theo tung cot");
                    }
                    else
                    {
                        Console.WriteLine("Cac gia tri trong ma tran khong giam dan theo tung cot!");
                    }
                    break;
                case 4:
                    xuatM2C(a, n);
                    xuatChan(a, n);
                    break;
                case 5:
                    xuatM2C(a, n);
                    xuatDCSongSongDCC(a, n);
                    break;
                case 6:
                    xuatM2C(a, n);
                    Console.WriteLine("Gia tri xuat hien nhieu nhat: {0}", TimGiaTriXuatHienNhieuNhat(a, n));
                    break;
                case 7:
                    xuatM2C(a, n);
                    timCacCSXuatHienNhieuNhat(a, n);
                    break;
                case 8:
                    xuatM2C(a, n);
                    xuatDCSongSongDCP(a, n);
                    break;
                case 9:
                    error = 0;
                    xuatM2C(a, n);
                    panelInput.Visible = true;
                    //Check error stage 1
                    if (Int32.TryParse(i_gt.Text, out i) && i >= 0 && i < n) 
                    {
                        errorProvider1.SetError(i_gt, "");
                    }
                    else
                    {
                        if (i < 0 || i > n)
                        {
                            errorProvider1.SetError(i_gt, "Nhập số vượt giới hạn n");
                        }
                        else
                        {
                            errorProvider1.SetError(i_gt, "Chỉ được nhập số");
                        }                       
                        error++;
                    }
                    if (Int32.TryParse(j_gt.Text, out j) && j >= 0 && j < n)
                    {
                        errorProvider2.SetError(j_gt, "");
                    }
                    else
                    {
                        if (j < 0 || j > n)
                        {
                            errorProvider2.SetError(j_gt, "Nhập số vượt giới hạn n");
                        }
                        else
                        {
                            errorProvider2.SetError(j_gt, "Chỉ được nhập số");
                        }
                        error++;
                    }
                    //Check error stage 2
                    if (error == 0)
                    {
                        _hoanViCotIVaJ(a, n, i, j);
                        Console.WriteLine();
                        xuatM2C(a, n);
                    }
                    else
                    {
                        string message = "Vui lòng nhập lại!";
                        string title = "ERROR!";

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Error);
                    }

                    break;
                default:
                    Console.WriteLine("Thanks for your patient!");
                    break;
            }
        }
        static void nhapn(ref int n)
        {
            Console.Write("Nhap n: ");
            n = int.Parse(Console.ReadLine());
        }
        static void toaM2C_Manual(int[,] a, ref int n)
        {
            nhapn(ref n);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("\nNhap phan tu a[{0},{1}]: ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }
        static void taoM2C_Rand(int[,] a, int n)
        {
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(-50, 50);
                }
            }
        }
        static void taoM2C_File(int[,] a, ref int n)
        {
            string fileContent;
            //Đọc giá trị từ file
            try
            {
                fileContent = File.ReadAllText("input.txt");
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            try
            {
                int j = 0;
                string[] integerStrings = fileContent.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                n = int.Parse(integerStrings[j++]);
                for (int i = 0; i < n * n; i++)
                {
                    a[i / n, i % n] = int.Parse(integerStrings[j++]);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
        static void xuatM2C(int[,] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" {0}", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        //Bài 1
        void xuatPT(int[,] a, int x, int y)
        {
            Console.WriteLine("a[{0},{1}] = {2}", x, y, a[x, y]);
        }
        void timPTCucDai(int[,] a, int n)
        {
            if (n * n == 1)
            {
                xuatPT(a, 0, 0);
            }
            else
            {
                //==========================================
                //TH 1:Cac PT nam o 4 goc 
                if (a[0,0] > a[0,1] && a[0,0] > a[1,0] && a[0,0] > a[1,1])
                {
                    xuatPT(a, 0, 0);
                }

                if (a[0,n - 1] > a[0,n - 2] && a[0,n - 1] > a[1,n - 2] && a[0,n - 1] > a[1,n - 1])
                {
                    xuatPT(a, 0, n - 1);
                }

                if (a[n - 1,0] > a[n - 1,1] && a[n - 1,0] > a[n - 2,0] && a[n - 1,0] > a[n - 2,1])
                {
                    xuatPT(a, n - 1, 0);
                }

                if (a[n - 1,n - 1] > a[n - 2,n - 1] && a[n - 1,n - 1] > a[n - 1,n - 2] && a[n - 1,n - 1] > a[n - 2,n - 2])
                {
                    xuatPT(a, n - 1, n - 1);
                }
                //==========================================
                //TH 2:Cac PT nam o 4 duong bien ( tru cac PT o 4 goc)
                //Bien tren
                for (int j = 1; j < n - 1; j++)
                {
                    if (a[0,j] > a[0,j - 1] && a[0,j] > a[1,j - 1] && a[0,j] > a[1,j] && a[0,j] > a[1,j + 1] && a[0,j] > a[0,j + 1])
                    {
                        xuatPT(a, 0, j);
                    }
                }
                //Bien duoi
                for (int j = 1; j < n - 1; j++)
                {
                    if (a[n - 1,j] > a[n - 1,j - 1] && a[n - 1,j] > a[1,j - 1] && a[n - 1,j] > a[n - 2,j] && a[n - 1,j] > a[n - 2,j + 1] && a[n - 1,j] > a[n - 1,j + 1])
                    {
                        xuatPT(a, n - 1, j);
                    }
                }
                //Bien trai
                for (int i = 1; i < n - 1; i++)
                {
                    if (a[i,0] > a[i - 1,0] && a[i,0] > a[i - 1,1] && a[i,0] > a[i,1] && a[i,0] > a[i + 1,1] && a[i,0] > a[i + 1,0])
                    {
                        xuatPT(a, i, 0);
                    }
                }
                //Bien phai 
                for (int i = 1; i < n - 1; i++)
                {
                    if (a[i,n - 1] > a[i - 1,n - 1] && a[i,n - 1] > a[i - 1,n - 2] && a[i,n - 1] > a[i,n - 2] && a[i,n - 1] > a[i + 1,n - 2] && a[i,n - 1] > a[i + 1,n - 1])
                    {
                        xuatPT(a, i, n - 1);
                    }
                }
                //==========================================
                //TH con lai
                for (int i = 1; i < n - 1; i++)
                {
                    for (int j = 1; j < n - 1; j++)
                    {
                        if (a[i,j] > a[i - 1,j - 1] && a[i,j] > a[i - 1,j] && a[i,j] > a[i - 1,j + 1] && a[i,j] > a[i,j + 1] && a[i,j] > a[i + 1,j + 1] && a[i,j] > a[i + 1,j] && a[i,j] > a[i + 1,j - 1] && a[i,j] > a[i,j - 1])
                        {
                            xuatPT(a, i, j);
                        }
                    }
                }
            }
        }
        void timPTCucTieu(int[,] a, int n)
        {
            if (n * n == 1)
            {
                xuatPT(a, 0, 0);
            }
            else
            {
                //==========================================
                //TH 1:Cac PT nam o 4 goc 
                if (a[0,0] < a[0,1] && a[0,0] < a[1,0] && a[0,0] < a[1,1])
                {
                    xuatPT(a, 0, 0);
                }

                if (a[0,n - 1] < a[0,n - 2] && a[0,n - 1] < a[1,n - 2] && a[0,n - 1] < a[1,n - 1])
                {
                    xuatPT(a, 0, n - 1);
                }

                if (a[n - 1,0] < a[n - 1,1] && a[n - 1,0] < a[n - 2,0] && a[n - 1,0] < a[n - 2,1])
                {
                    xuatPT(a, n - 1, 0);
                }

                if (a[n - 1,n - 1] < a[n - 2,n - 1] && a[n - 1,n - 1] < a[n - 1,n - 2] && a[n - 1,n - 1] < a[n - 2,n - 2])
                {
                    xuatPT(a, n - 1, n - 1);
                }
                //==========================================
                //TH 2:Cac PT nam o 4 duong bien ( tru cac PT o 4 goc)
                //Bien tren
                for (int j = 1; j < n - 1; j++)
                {
                    if (a[0,j] < a[0,j - 1] && a[0,j] < a[1,j - 1] && a[0,j] < a[1,j] && a[0,j] < a[1,j + 1] && a[0,j] < a[0,j + 1])
                    {
                        xuatPT(a, 0, j);
                    }
                }
                //Bien duoi
                for (int j = 1; j < n - 1; j++)
                {
                    if (a[n - 1,j] < a[n - 1,j - 1] && a[n - 1,j] < a[1,j - 1] && a[n - 1,j] < a[n - 2,j] && a[n - 1,j] < a[n - 2,j + 1] && a[n - 1,j] < a[n - 1,j + 1])
                    {
                        xuatPT(a, n - 1, j);
                    }
                }
                //Bien trai
                for (int i = 1; i < n - 1; i++)
                {
                    if (a[i,0] < a[i - 1,0] && a[i,0] < a[i - 1,1] && a[i,0] < a[i,1] && a[i,0] < a[i + 1,1] && a[i,0] < a[i + 1,0])
                    {
                        xuatPT(a, i, 0);
                    }
                }
                //Bien phai 
                for (int i = 1; i < n - 1; i++)
                {
                    if (a[i,n - 1] < a[i - 1,n - 1] && a[i,n - 1] < a[i - 1,n - 2] && a[i,n - 1] < a[i,n - 2] && a[i,n - 1] < a[i + 1,n - 2] && a[i,n - 1] < a[i + 1,n - 1])
                    {
                        xuatPT(a, i, n - 1);
                    }
                }
                //==========================================
                //TH con lai
                for (int i = 1; i < n - 1; i++)
                {
                    for (int j = 1; j < n - 1; j++)
                    {
                        if (a[i,j] < a[i - 1,j - 1] && a[i,j] < a[i - 1,j] && a[i,j] < a[i - 1,j + 1] && a[i,j] < a[i,j + 1] && a[i,j] < a[i + 1,j + 1] && a[i,j] < a[i + 1,j] && a[i,j] < a[i + 1,j - 1] && a[i,j] < a[i,j - 1])
                        {
                            xuatPT(a, i, j);
                        }
                    }
                }
            }
        }
        void XuatCucTri(int[,] a, int n)
        {
            timPTCucDai(a, n);
            timPTCucTieu(a, n);
        }
        //Bài 2
        // Sap xep cot le Tang dan
        static void sapXepCotTang(int[,] a, int n, int k)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (a[i, k] > a[j, k])
                        swap(ref a[i, k], ref a[j, k]);
            }
        }
        // Sap xep cot chan Giam dan
        static void sapXepCotGiam(int[,] a, int n, int k)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                    if (a[i, k] < a[j, k])
                        swap(ref a[i, k], ref a[j, k]);
            }
        }
        static void sapXepCotCSLeTangChanGiam(int[,] a, int n)
        {
            for (int j = 0; j < n; j++)
            {
                if (j % 2 != 0)
                    sapXepCotTang(a, n, j);
                else
                {
                    sapXepCotGiam(a, n, j);
                }
            }
        }
        //Bài 3
        static void sapXepDuongCheoSongSongDCCVaDCC(int[,] a, int n)
        {
            int[] tmp = new int[100];
            for (int i = 2 - n; i < n; i++)
            {
                int k = 0;
                //Trich xuat cac phan tu song song DCC va DCC
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= 0 && i + j < n)
                    {
                        /*cout << " |" << j << i + j;*/
                        tmp[k] = a[j, i + j];
                        k++;
                    }
                }
                //Sap xep cac phan tu duong cheo hien trong mang tmp
                for (int h = 0; i < k - 1; i++)
                {
                    for (int j = h + 1; j < k; j++)
                    {
                        if (tmp[h] > tmp[j])
                        {
                            /*cout << " " << tmp[i] << " " << tmp[j];*/
                            swap(ref tmp[h], ref tmp[j]);
                        }
                    }

                }
                k = 0;
                //Ghi de cac phan tu trong mang tmp vao lai duong cheo
                for (int j = 0; j < n; j++)
                {
                    if (i + j >= 0 && i + j < n)
                    {
                        a[j, i + j] = tmp[k];
                        k++;
                    }
                }
            }
        }
        //Bài 4
        static bool kiemTraCacGiaTriMaTranCoGiamDanTheoTungCotKhong(int[,] a, int n)
        {
            int check = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] < a[i + 1, j])
                    {
                        check = 1;
                    }
                }
            }
            if (check == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Bài 5
        static bool check1DongChan(int[,] a, int n, int dong)
        {
            int check = 0;
            for (int j = 0; j < n; j++)
            {
                if (a[dong, j] % 2 != 0)
                    check = 1;
            }
            if (check == 0)
                return true;
            else
                return false;
        }

        static void xuatChan(int[,] a, int n)
        {
            int dem = 0;
            Console.WriteLine("Liet ke dong toan chan: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    if (check1DongChan(a, n, i))
                    {
                        Console.Write(" {0}", a[i, j]);
                        dem++;
                    }
                }
            }
            if (dem == 0)
            {
                Console.WriteLine("Khong co dong nao chua toan gia tri chan!");
            }
        }
        //Bài 6
        static void xuatDCSongSongDCC(int[,] a, int n)
        {
            Console.WriteLine("Xuat Duong cheo tren DCC: \n");
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("{0} ", a[j, i + j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Xuat Duong cheo duoi DCC: \n");
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("{0} ", a[i + j, j]);
                }
                Console.WriteLine();

            }
        }
        //Bài 7
        static int DemSoLanXuatHienCuaX(int[,] a, int n, int x)
        {
            int Dem = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (a[i, j] == x)
                    {
                        Dem++;
                    }
                }
            }
            return Dem;
        }

        static int TimGiaTriXuatHienNhieuNhat(int[,] a, int n)
        {
            int Dem1, Dem = DemSoLanXuatHienCuaX(a, n, a[0, 0]), A1 = 0, A2 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Dem1 = DemSoLanXuatHienCuaX(a, n, a[i, j]);
                    if (Dem < Dem1)
                    {
                        Dem = Dem1;
                        A1 = i;
                        A2 = j;
                    }
                }
            }
            return a[A1, A2];
        }

        //Bài 8
        static void updateLookup(int[] lookup, int x)
        {
            int tmp;
            if (x == 0)
            {
                lookup[0]++;
            }
            else
            {
                while (x != 0)
                {
                    tmp = x % 10;
                    lookup[tmp]++;
                    x /= 10;
                }
            }
        }
        static void memset(int[] a)
        {
            byte[,] yourArray = new byte[100, 100];

            // clear elements
            Array.Clear(yourArray, 0, yourArray.Length);
        }
        static void xuatM1C(int[] a, int n)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} ", a[i]);
            }
        }
        static void timCacCSXuatHienNhieuNhat(int[,] a, int n)
        {
            int[] lookup = new int[10];
            int max = 0;
            //Tao bang luu gia tri
            memset(lookup);
            //Kiem tra tung chu so
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    updateLookup(lookup, Math.Abs(a[i, j]));
                }
            }
            //Tim max
            for (int i = 0; i < 10; i++)
            {
                if (lookup[i] > max)
                {
                    max = lookup[i];
                }
            }
            //Xuat cac CS xuat hien nhieu nhat
            Console.Write("Cac chu so xuat hien nhieu nhat: ");
            for (int i = 0; i < 10; i++)
            {
                if (max == lookup[i])
                {
                    Console.Write("{0} ", i);
                }
            }
        }
        //Bài 9
        static void xuatDCSongSongDCP(int[,] a, int n)
        {
            Console.WriteLine("Xuat Duong cheo tren DCP: ");
            for (int i = n - 2; i >= 1; i--)
            {
                for (int j = 0, k = i; j < n && k >= 0; j++, k--)
                {
                    Console.Write("{0} ", a[j, k]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Xuat Duong cheo duoi DCP: ");
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("{0} ", a[i + j, n - 1 - j]);
                }
                Console.WriteLine();
            }
        }
        //Bài 10
        static void swap(ref int x, ref int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
        static void hoanViCotIVaJ(int[,] a, int n, int x, int y)
        {
            for (int i = 0; i < n; i++)
            {
                swap(ref a[i, x], ref a[i, y]);
            }
        }
        static void _hoanViCotIVaJ(int[,] a, int n, int i, int j)
        {
            int x = i, y = j; 
            hoanViCotIVaJ(a, n, x, y);
        }

       
    }
}
