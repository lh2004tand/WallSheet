using CHAT_WALLSHEET.Properties;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CHAT_WALLSHEET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }
        private bool check;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (check)
            {
                panel1.Width -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    pictureBox2.Left = 23;
                    timer1.Stop();
                    check = false;
                    pictureBox2.Image = Resources.unnamed__1_;

                }
            }
            else
            {

                panel1.Width += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    pictureBox2.Left = +200;
                    timer1.Stop();
                    check = true;
                    pictureBox2.Image = Resources.sangphai;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel4.Visible == false)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void UserItem()
        {
            panel4.Controls.Clear();
            SqlDataAdapter adapter;
            SqlConnection connection = new SqlConnection("your_connection_string");
            adapter = new SqlDataAdapter("SELECT * FROM login2", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    UserControl1[] userControls = new UserControl1[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            userControls[i] = new UserControl1();
                            MemoryStream stream = new MemoryStream((byte[])row["image"]);
                            userControls[i].Icon = new Bitmap(stream);
                            userControls[i].Title = row["firstname"].ToString();
                            if (userControls[i].Title == label1.Text)
                            {
                                flowLayoutPanel1.Controls.Add(userControls[i]);
                            }
                            else
                            {
                                flowLayoutPanel1.Controls.Add(userControls[i]);
                            }
                            userControls[i].Click += new System.EventHandler(this.button3_Click);
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserItem();
            panel4.BringToFront();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
