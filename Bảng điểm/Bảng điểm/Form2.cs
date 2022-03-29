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
namespace Bảng_điểm
{
    public partial class Form2 : Form
    {
        private string namefile;
        private listMonHoc ListMH;
        private bool issave; 
        public Form2()
        {
            issave = true;
            namefile = "dulieu.txt";
            ListMH = new listMonHoc(100);
            ListMH.docfile(namefile);
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)// thêm mục
        {
            double num = 0; int a = 0;
            if (!(double.TryParse(suadiem.Text, out num) || suadiem.Text == ""))
                MessageBox.Show("Vui lòng nhập lại điểm bằng số", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (!(int.TryParse(suatinchi.Text, out a) || suatinchi.Text == ""))
                MessageBox.Show("Vui lòng nhập lại tin chi bằng số", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (suanam.SelectedIndex <= -1 && suahk.SelectedIndex <= -1) { MessageBox.Show("Vui lòng nhập đẩy đủ năm và học kì", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            if (monhoc.Text != "" && tinchi.Text != "" && diem.Text != "" && int.TryParse(suatinchi.Text, out a) 
                && double.TryParse(suadiem.Text, out num) && suanam.SelectedIndex > -1 && suahk.SelectedIndex > -1)
            {
                ListViewItem itime = new ListViewItem();
                itime.Text = suamon.Text;
                itime.SubItems.Add(suatinchi.Text);
                itime.SubItems.Add(suadiem.Text);
                thongbao.Items.Add(itime);
                String line1; 
                line1 = suanam.SelectedItem.ToString() + "," +
                    suahk.SelectedItem.ToString() + "," +
                    suamon.Text + "," +
                    suatinchi.Text + "," +
                    suadiem.Text + ",";
                ListMH.addMonHoc(line1);
                suadiem.Clear();
                suatinchi.Clear();
                suamon.Clear();
                suamon.Focus();
                suanam.Text = null;
                suahk.Text = null;
                issave = false;
            }
            tongket.Text = ListMH.TongDiem().ToString();
            if (ListMH.TongDiem() >= 8 && ListMH.TongDiem() <= 10)
                textBox3.Text = "Giỏi";
            else if (ListMH.TongDiem() < 8 && ListMH.TongDiem() >= 6.5)
                textBox3.Text = "Khá";
            else if (ListMH.TongDiem() < 6.5 && ListMH.TongDiem() >= 5)
                textBox3.Text = "TB";
            else textBox3.Text = "Kém";

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (thongbao.SelectedItems.Count != 0)  {
                DialogResult dr;
                dr = MessageBox.Show("Bạn có muốn delete không ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ListViewItem item = thongbao.SelectedItems[0];
                    thongbao.Items.Remove(thongbao.SelectedItems[0]);
                    ListMH.deleteMonHoc(item.Text);
                    issave = false;
                }
            }
            tongket.Text = ListMH.TongDiem().ToString();
            if (ListMH.TongDiem() >= 8 && ListMH.TongDiem() <= 10)
                textBox3.Text = "Giỏi";
            else if (ListMH.TongDiem() < 8 && ListMH.TongDiem() >= 6.5)
                textBox3.Text = "Khá";
            else if (ListMH.TongDiem() < 6.5 && ListMH.TongDiem() >= 5)
                textBox3.Text = "TB";
            else textBox3.Text = "Kém";
        }
       
        private void ok_Click(object sender, EventArgs e)// sửa thông tin
        {
            if (thongbao.SelectedItems.Count != 0)
            {
                ListViewItem a = thongbao.SelectedItems[0];
                a.Text = suamon.Text;
                a.SubItems[1].Text = suatinchi.Text;
                a.SubItems[2].Text = suadiem.Text;
                COURSE monhoc1 = new COURSE();
                monhoc1.namhoc_1 = suanam.SelectedItem.ToString();
                monhoc1.hocki_1 = suahk.SelectedItem.ToString();
                monhoc1.monhoc_1 = suamon.Text;
                monhoc1.tinchi_1 = suatinchi.Text;
                monhoc1.diem_1 = suadiem.Text;
                issave = false;

                ListMH.okMonHoc(suamon.Text,monhoc1);
                if (ListMH.TongDiem() >= 8 && ListMH.TongDiem() <= 10)
                    textBox3.Text = "Giỏi";
                else if (ListMH.TongDiem() < 8 && ListMH.TongDiem() >= 6.5)
                    textBox3.Text = "Khá";
                else if (ListMH.TongDiem() < 6.5 && ListMH.TongDiem() >= 5)
                    textBox3.Text = "TB";
                else textBox3.Text = "Kém";
            }
            double num = 0; int b = 0;
            if (!(double.TryParse(suadiem.Text, out num) || suadiem.Text == ""))
                MessageBox.Show("Vui lòng nhập lại điểm bằng số", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (!(int.TryParse(suatinchi.Text, out b) || suatinchi.Text == ""))
                MessageBox.Show("Vui lòng nhập lại tin chi bằng số", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (suanam.SelectedIndex <= -1 && suahk.SelectedIndex <= -1)
            { MessageBox.Show("Vui lòng nhập đẩy đủ năm và học kì", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            suadiem.Clear();
            suatinchi.Clear();
            suamon.Clear();
            suamon.Focus();
            suanam.Text = null;
            suahk.Text = null;
            tongket.Text = ListMH.TongDiem().ToString();
            if (ListMH.TongDiem() >= 8 && ListMH.TongDiem() <= 10)
                textBox3.Text = "Giỏi";
            else if (ListMH.TongDiem() < 8 && ListMH.TongDiem() >= 6.5)
                textBox3.Text = "Khá";
            else if (ListMH.TongDiem() < 6.5 && ListMH.TongDiem() >= 5)
                textBox3.Text = "TB";
            else textBox3.Text = "Kém";
        }

        private void thongbao_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)//hiện thị list view sang text
        {
            if (thongbao.SelectedItems.Count != 0)
            {
                ListViewItem item = thongbao.SelectedItems[0];
                suamon.Text = item.Text;
                suatinchi.Text = item.SubItems[1].Text;
                suadiem.Text = item.SubItems[2].Text;
                COURSE monhoc1 = new COURSE();
                monhoc1 = ListMH.GetMH(item.Text);
                suahk.Text = monhoc1.hocki_1;
                suanam.Text = monhoc1.namhoc_1;
            }
        }
        private void namhoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (namhoc.SelectedItem.ToString() == "Tất cả")
            {
                thongbao.Items.Clear();
                ListMH.Load(ref thongbao);
                tongket.Text = ListMH.TongDiem().ToString();
                if (ListMH.TongDiem() >= 8 && ListMH.TongDiem() <= 10)
                    textBox3.Text = "Giỏi";
                else if (ListMH.TongDiem() < 8 && ListMH.TongDiem() >= 6.5)
                    textBox3.Text = "Khá";
                else if (ListMH.TongDiem() < 6.5 && ListMH.TongDiem() >= 5)
                    textBox3.Text = "TB";
                else textBox3.Text = "Kém";
                diemtbhk.Text = null;
            }
        }
        private void hocki_SelectedValueChanged(object sender, EventArgs e)
        {
            if (hocki.SelectedIndex > -1 && namhoc.SelectedIndex > -1)
            {
                thongbao.Items.Clear();
                diemtbhk.Text = ListMH.TBHK(namhoc.SelectedIndex.ToString(), hocki.SelectedItem.ToString()).ToString();
                ListMH.Loadhk(namhoc.SelectedIndex.ToString(), hocki.SelectedItem.ToString(), ref thongbao);
            }
           
        }

        private void Form2_Load(object sender, EventArgs e)//load file;
        {
            if (namhoc.SelectedItem.ToString() == "Tất cả")
            {
                ListMH.Load(ref thongbao);
                tongket.Text = ListMH.TongDiem().ToString();
                if (ListMH.TongDiem() >= 8 && ListMH.TongDiem() <= 10)
                    textBox3.Text = "Giỏi";
                else if (ListMH.TongDiem() < 8 && ListMH.TongDiem() >= 6.5)
                    textBox3.Text = "Khá";
                else if (ListMH.TongDiem() < 6.5 && ListMH.TongDiem() >= 5)
                    textBox3.Text = "TB";
                else textBox3.Text = "Kém";
            }
        }
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)//save file
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "(*.txt)|*.txt";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                string pat = sv.FileName;
                ListMH.SaveFileas(pat);
            }
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)//lưu file
        {
            ListMH.Savefile(namefile);
            tongket.Text = ListMH.TongDiem().ToString();
            if (ListMH.TongDiem() >= 8 && ListMH.TongDiem() <= 10)
                textBox3.Text = "Giỏi";
            else if (ListMH.TongDiem() < 8 && ListMH.TongDiem() >= 6.5)
                textBox3.Text = "Khá";
            else if (ListMH.TongDiem() < 6.5 && ListMH.TongDiem() >= 5)
                textBox3.Text = "TB";
            else textBox3.Text = "Kém";
            issave = true;

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) //mở file
        {
            OpenFileDialog chuc = new OpenFileDialog();
            chuc.InitialDirectory = "(*.txt)|*.txt";
            chuc.ShowDialog();
            thongbao.Items.Clear();
            namefile=chuc.FileName;
            ListMH.docfile(namefile);
            ListMH.Load(ref thongbao);
            tongket.Text = ListMH.TongDiem().ToString();
        }


        private void Form2_FormClosing(object sender, FormClosingEventArgs e)//thao tác tắt màn hình
        {
            DialogResult dr;
            if (issave == false)
            {
                dr = MessageBox.Show("Bạn có muốn luư trước khi thoát khỏi chương trình không ?", "Xác nhận", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                { ListMH.Savefile(namefile); Application.Exit(); }
                else if (dr == DialogResult.No)
                    Application.Exit();
                else e.Cancel = true;
            }
            Application.Exit();
        }

       
    }
}
