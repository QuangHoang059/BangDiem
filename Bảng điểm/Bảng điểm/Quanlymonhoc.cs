using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace Bảng_điểm
{
    public class COURSE
    {
        public string namhoc_1 { get; set; }
        public string hocki_1 { get; set; }
        public string monhoc_1 { get; set; }
        public string tinchi_1 { get; set; }
        public string diem_1 { get; set; }
    };

    public class listMonHoc
    {
        public COURSE[] dsMonhoc;
        public int n;
        public listMonHoc(int maxsize)
        {
            this.dsMonhoc = new COURSE[maxsize];
            this.n = 0;
        }
        public void docfile(string namefile)
        {
            n = 0;
            StreamReader f = new StreamReader(namefile);
            f.ReadLine();
            while (true)
            {
                string line_1 = f.ReadLine();
                if (line_1 == null) break;
                addMonHoc(line_1);
            }
            f.Close();
        }
        public COURSE GetMH(string name)
        {
            for (int i = 0; i < n; i++)
            {
                if (dsMonhoc[i].monhoc_1 == name)
                {
                    return dsMonhoc[i];
                }
            }
            return null;
        }
        public void addMonHoc(string line1)
        {
            string[] cut = line1.Split(',');
            COURSE monhoc = new COURSE();
            monhoc.namhoc_1 = cut[0];
            monhoc.hocki_1 = cut[1];
            monhoc.monhoc_1 = cut[2];
            monhoc.tinchi_1 = cut[3];
            monhoc.diem_1 = cut[4];
            dsMonhoc[n] = monhoc;
            n++;
        }
        public void deleteMonHoc(string namemon)
        {
            int dest = 0;
            for (int i = 0; i < n; i++){
                if (dsMonhoc[i].monhoc_1 == namemon)
                { dest = i; break; }
            }
            for (int i = dest; i < n - 1; i++){
                dsMonhoc[i] = dsMonhoc[i + 1];
            }
            n--;
        }
        public void okMonHoc(string namemon,COURSE sua)
        {
            int dest = 0;
            for (int i = 0; i < n; i++) {
                if (dsMonhoc[i].monhoc_1 == namemon) {
                    dest = i; break;
                }
            }
            dsMonhoc[dest] = sua;

        }
        public void Savefile(string namefile)
        {
            StreamWriter f = new StreamWriter(namefile);
            f.WriteLine("năm,họckì,môn,tínchỉ,điểm");

            for (int i=0;i<n;i++)
            {
                f.WriteLine(dsMonhoc[i].namhoc_1 + "," + dsMonhoc[i].hocki_1 + "," + dsMonhoc[i].monhoc_1 + "," + dsMonhoc[i].tinchi_1 + "," + dsMonhoc[i].diem_1);
            }
            f.Close();
        }
        public void SaveFileas(string pat)
        {
            File.AppendAllText(pat, "năm, họckì, môn, tínchỉ, điểm\n" );

            for (int i = 0; i < n; i++)
            {
                File.AppendAllText(pat, dsMonhoc[i].namhoc_1 + "," + dsMonhoc[i].hocki_1 + "," + dsMonhoc[i].monhoc_1 + "," + dsMonhoc[i].tinchi_1 + "," + dsMonhoc[i].diem_1 + Environment.NewLine);
            }
        }
        public void Load(ref ListView  view)
        {
            for (int i = 0; i < n; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dsMonhoc[i].monhoc_1;
                item.SubItems.Add(dsMonhoc[i].tinchi_1);
                item.SubItems.Add(dsMonhoc[i].diem_1);
                view.Items.Add(item);

            }
        }
        public double TongDiem()
        {
            int sumtinchi = 0;
            double sumdiem=0;
            for (int i = 0; i < n; i++)
            {
                sumdiem += double.Parse(dsMonhoc[i].diem_1)*(int.Parse(dsMonhoc[i].tinchi_1));
                sumtinchi += int.Parse(dsMonhoc[i].tinchi_1);
            }
            return Math.Round(sumdiem / sumtinchi,2);
        }
        public double TBHK(string nam,string hk)
        {
            int sumtinchi = 0;
            double sumdiem = 0;
            for (int i = 0; i < n; i++)
            { if (nam != dsMonhoc[i].namhoc_1 || hk != dsMonhoc[i].hocki_1) continue;
                sumdiem += double.Parse(dsMonhoc[i].diem_1) * (int.Parse(dsMonhoc[i].tinchi_1));
                sumtinchi += int.Parse(dsMonhoc[i].tinchi_1);
            }
            return Math.Round(sumdiem / sumtinchi, 2);
        }
        public void Loadhk(string nam,string hk,ref ListView view)
        {
            for (int i = 0; i < n; i++)
            {
                if (nam != dsMonhoc[i].namhoc_1 || hk != dsMonhoc[i].hocki_1) continue;
                ListViewItem item = new ListViewItem();
                item.Text = dsMonhoc[i].monhoc_1;
                item.SubItems.Add(dsMonhoc[i].tinchi_1);
                item.SubItems.Add(dsMonhoc[i].diem_1);
                view.Items.Add(item);
            }
        }
    }
}
