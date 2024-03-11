using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string endpoint = "https://retoolapi.dev/OEDUXm/member";
        HttpClient client = new HttpClient();


        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
            textBox_id.Clear();
            textBox_entry.Clear();
            textBox_rating.Clear();
            textBox_fullname.Clear();
            textBox_interest.Clear();
            listBox1.Items.Clear();

            try
            {
                HttpResponseMessage response = await client.GetAsync(endpoint);
                if (response.IsSuccessStatusCode)
                {
                    string jsonValasz = await response.Content.ReadAsStringAsync();
                    var jatekosok = Jatekos.FromJson(jsonValasz);

                    foreach (Jatekos jatekos in jatekosok)
                    {
                        listBox1.Items.Add(jatekos);
                    }
                    listBox1.DisplayMember = "Kiiratas";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
        }

        private void button_frissit_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private async void button_uj_Click(object sender, EventArgs e)
        {
            try
            {
                Jatekos jatekos = new Jatekos();
                jatekos.Entry = textBox_entry.Text;
                jatekos.Rating = int.Parse(textBox_rating.Text);
                jatekos.Fullname = textBox_fullname.Text;
                jatekos.Interest = textBox_interest.Text;

                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };

                var json = System.Text.Json.JsonSerializer.Serialize(jatekos);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(endpoint, data);
                if (response.IsSuccessStatusCode)
                {
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba: " + ex.Message);
            }
        }

        private async void button_modosit_Click(object sender, EventArgs e)
        {
            try
            {

                Jatekos jatekos = (Jatekos)listBox1.SelectedItem;
                jatekos.Id = int.Parse((textBox_id.Text));
                jatekos.Fullname = textBox_fullname.Text;
                jatekos.Entry = textBox_entry.Text;
                jatekos.Rating = int.Parse(textBox_rating.Text);
                jatekos.Interest = textBox_interest.Text;

                var options = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                };
                string json = JsonSerializer.Serialize(jatekos, options);
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PutAsync(endpoint + "/" + jatekos.Id, data);
                if (response.IsSuccessStatusCode)
                {
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_torol_Click(object sender, EventArgs e)
        {
            Jatekos jatekos = (Jatekos)listBox1.SelectedItem;
            var response = client.DeleteAsync(endpoint + "/" + jatekos.Id).Result;
            if (response.IsSuccessStatusCode)
            {
                Form1_Load(sender, e);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                Jatekos jatekos = (Jatekos)listBox1.SelectedItem;
                textBox_id.Text = jatekos.Id.ToString();
                textBox_fullname.Text = jatekos.Fullname;
                textBox_rating.Text = jatekos.Rating.ToString();
                textBox_interest.Text = jatekos.Interest;
                textBox_entry.Text = jatekos.Entry;
            }
        }
    }
}
