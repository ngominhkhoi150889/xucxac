using System;
using System.Drawing;
using System.Windows.Forms;

namespace GameXucXacTuChe
{
    public partial class Form1 : Form
    {
        private Button nutTung = new Button();
        private Label ketQua = new Label();
        private Label loiChuc = new Label();
        private Random xucXac = new Random();

        public Form1()
        {
            this.Width = 450;
            this.Height = 350;
            this.Text = "Siêu Cấp Tung Xúc Xắc 🎲";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.LightYellow;

            nutTung.Text = "BẤM TUNG NGAY 🎲";
            nutTung.Width = 220;
            nutTung.Height = 50;
            nutTung.Location = new Point(110, 30);
            nutTung.Font = new Font("Arial", 12, FontStyle.Bold);
            nutTung.BackColor = Color.Orange;
            nutTung.Click += NutTung_Click;
            this.Controls.Add(nutTung);

            ketQua.Text = "?";
            ketQua.Width = 200;
            ketQua.Height = 80;
            ketQua.Location = new Point(120, 100);
            ketQua.Font = new Font("Arial", 48, FontStyle.Bold);
            ketQua.TextAlign = ContentAlignment.MiddleCenter;
            ketQua.ForeColor = Color.DarkBlue;
            this.Controls.Add(ketQua);

            loiChuc.Text = "Hãy thử vận may của bạn!";
            loiChuc.Width = 400;
            loiChuc.Height = 40;
            loiChuc.Location = new Point(20, 220);
            loiChuc.Font = new Font("Arial", 14, FontStyle.Italic);
            loiChuc.TextAlign = ContentAlignment.MiddleCenter;
            loiChuc.ForeColor = Color.Gray;
            this.Controls.Add(loiChuc);
        }

        private void NutTung_Click(object sender, EventArgs e)
        {
            int diem = xucXac.Next(1, 7);
            ketQua.Text = diem.ToString();

            if (diem == 6)
            {
                loiChuc.Text = "🎉 ĐỈNH CAO! Bạn trúng giải Độc Đắc rồi! 🎉";
                loiChuc.ForeColor = Color.Red;
            }
            else if (diem == 1)
            {
                loiChuc.Text = "😢 Hơi đen rồi! Tung lại để phục thù nào!";
                loiChuc.ForeColor = Color.Black;
            }
            else
            {
                loiChuc.Text = "Khá tốt! Tiếp tục bấm để săn số 6 đi!";
                loiChuc.ForeColor = Color.DarkGreen;
            }
        }

        // --- NÚT NGUỒN KÍCH HOẠT ĐỂ BIÊN DỊCH ĐỘC LẬP ---
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Mở giao diện game lên đầu tiên
        }
    }
}
