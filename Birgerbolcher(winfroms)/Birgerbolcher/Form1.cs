using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Birgerbolcher
{
    public partial class Form1 : Form
    {
        SqlConnection myConnection = new SqlConnection("user id=username;" +
                                          "password=password;" +
                                          "server=localhost;" +
                                          "Trusted_Connection=yes;" +
                                          "database=BirgerBolcher; " +
                                          "connection timeout=30");

        public Form1()
        {
            InitializeComponent();
            try
            {
                myConnection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }

        private void seallebolcher_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("se_alle_bolcher", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }

        private void tungeste_3_bolcher_Click(object sender, EventArgs e)
        {
            
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("tungeste_3_bolcher", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}", reader[0], reader[1]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }

        private void Se_random_bolche_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("Se_random_bolche", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }
        
        private void navnweightall_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("navn_weight_alle", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }

              
        private void alle_farver_alfa_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("alle_farver_alfa", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }
        
        private void navn_farve_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("find_navn_farve", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }
        
        private void find_navn_red_farve_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("find_navn_red_farve", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }

        private void find_b_navne_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("find_b_navne", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }

        private void find_navne_e_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("find_navne_e", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }

        private void navn_weight_10_12_Click(object sender, EventArgs e)
        {
            int x = 129;
            int y = 116;
            SqlCommand cmd = new SqlCommand("navn_weight_10_12", myConnection);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Label label = new Label
                    {
                        AutoSize = false,
                        Location = new Point(x, y)
                    };
                    label.AutoSize = true;
                    Controls.Add(label);
                    y = y + 25;
                    label.Text = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6], reader[7]);
                }
            }
            else
            {
                Console.WriteLine("no rows found");
            }
            reader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                myConnection.Close();
            }
            catch (Exception a)
            {
                Console.WriteLine(a.ToString());
            }
            Application.Exit();
        }

        private void slet_Click(object sender, EventArgs e)
        {
            for(int i =Controls.Count-1; i >= 0; i--)
            {
                if (Controls[i].GetType() == typeof(Label))
                {
                    Controls.Remove(Controls[i]);
                }
            }
        }
    }
}
