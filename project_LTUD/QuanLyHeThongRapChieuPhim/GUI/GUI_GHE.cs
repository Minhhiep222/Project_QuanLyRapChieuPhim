using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;


namespace GUI
{
    public partial class FormGhe : Form
    {
        List<Button> danhSachGhe = new List<Button>();
        List<Button> danhSachGheChon = new List<Button>();  

        Ve_BUS ve = new Ve_BUS();
        public FormGhe()
        {
            InitializeComponent();
        }
        public void chon()
        {
            

            danhSachGhe.Add(btn1);
            danhSachGhe.Add(btn2);
            danhSachGhe.Add(btn3);
            danhSachGhe.Add(btn4);
            danhSachGhe.Add(btn5);
            danhSachGhe.Add(btn6);
            danhSachGhe.Add(btn7);
            danhSachGhe.Add(btn8);
            danhSachGhe.Add(btn9);
            danhSachGhe.Add(btn10);
            danhSachGhe.Add(btn11);
            danhSachGhe.Add(btn12);
            danhSachGhe.Add(btn13);
            danhSachGhe.Add(btn14);
            danhSachGhe.Add(btn15);
            danhSachGhe.Add(btn16);
            danhSachGhe.Add(btn17);
            danhSachGhe.Add(btn18);
            danhSachGhe.Add(btn19);
            danhSachGhe.Add(btn20);
            danhSachGhe.Add(btn21);
            danhSachGhe.Add(btn22);
            danhSachGhe.Add(btn23);
            danhSachGhe.Add(btn24);
            danhSachGhe.Add(btn25);
            danhSachGhe.Add(btn26);
            danhSachGhe.Add(btn27);
            danhSachGhe.Add(btn28); 
            danhSachGhe.Add(btn29);
            danhSachGhe.Add(btn30);  
            danhSachGhe.Add(btn_31);
            danhSachGhe.Add(btn_32); 
            danhSachGhe.Add(btn_33);
            danhSachGhe.Add(btn_34);      
            danhSachGhe.Add(btn_35);
            danhSachGhe.Add(btn_36);
            


            
            dataGridView2.DataSource = ve.LaySoGhe();

            //string danhsachghedadat = dataGridView1.Rows[0].Cells[0].Value.ToString();
            dataGridView1.DataSource = ve.LayDSVE();
            string[] danhsachghedadat = new string[dataGridView1.Rows.Count];

            for (int i = 0; i < danhsachghedadat.Length-1; i++)
            {
                danhsachghedadat[i] = dataGridView1.Rows[i].Cells[5].Value.ToString();
                
            }
           
            int index = 0;
            foreach (Button btn in danhSachGhe)
            {
                btn.Text = dataGridView2.Rows[index].Cells[0].Value.ToString();
                
                foreach(string dat in danhsachghedadat)
                {
                    
                    if (btn.Text == dat)
                    {
                        
                        btn.BackColor = Color.Purple;
                        btn.ForeColor = Color.White;
                    }
                    

                }



                index ++;

            }
            
        }

        
        private void FormThanhToan_Load(object sender, EventArgs e)
        {
           
            chon();
            btn_chon.Enabled = false;



            //danhSachGheChon.Add(btn1);
            //foreach(Button btn in danhSachGheChon)
            //{
            //    btn.BackColor = Color.Purple;
            //    btn.ForeColor = Color.White;
            //}
        }

        public void click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor != Color.Purple)
            {
                if (btn.BackColor == Color.White)
                {
                    btn.BackColor = Color.Yellow;
                    btn.ForeColor = Color.Purple;
                    danhSachGheChon.Add(btn);
                }
                else
                {
                    btn.BackColor = Color.White;
                    danhSachGheChon.Remove(btn);
                }

                btn_chon.Enabled =true;
            }
        }

        public void btn_chon_Click(object sender, EventArgs e)
        {
          

            if(danhSachGheChon.Count > 1)
            {
                MessageBox.Show("Chỉ được chọn một ghế");

            }
            else
            {
               

                if(danhSachGheChon.Count < 1)
                {
                    MessageBox.Show("Bạn phải chọn một ghế!");
                }
                else
                {
                    this.Hide();
                    frmNhapThongTinVe ve = new frmNhapThongTinVe(danhSachGheChon[0].Text);                                 
                    ve.ShowDialog(); 
                    this.Close();

                }


            }
            

            

            //ve = null;

            //this.Show();


            //xacnhan();

        }                           
        public List<Button>  xacnhan()
        {
            return danhSachGheChon;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this.Hide();
            frmNhapThongTinVe ve = new frmNhapThongTinVe();
            ve.ShowDialog();
            this.Close();
        }


        //public string xacnhan()

        //public string xacnhan()
        //{
        //    foreach (Button btn in danhSachGheChon)
        //    {
        //         return btn.Text;

        //    }
        //    return "Chưa chọn ghế";

        //}





        private void btn1_Click(object sender, EventArgs e)
        {
            click(sender, e);

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn_31_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn_35_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn_34_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn_33_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn_32_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn_36_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn30_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn29_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn28_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn27_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void btn26_Click(object sender, EventArgs e)
        {
            click(sender, e);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

   
}
