using YaseminAydın.Models;
namespace YaseminAydın
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != String.Empty && dateTimePicker1 != null && dateTimePicker2 != null & dateTimePicker3 != null)
                {
                    Film film = new Film() { FilmAd = textBox1.Text, Seans1 = dateTimePicker1.Value.TimeOfDay, Seans2 = dateTimePicker2.Value.TimeOfDay, Seans3 = dateTimePicker3.Value.TimeOfDay };
                    using (var DB = new Context())
                    {
                        DB.Film.Add(film);
                        DB.SaveChanges();
                    }
                    MessageBox.Show("Veri Kaydedildi!");
                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayın!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (error.InnerException != null)
                {
                    MessageBox.Show(error.InnerException.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text != String.Empty && maskedTextBox1.Text != String.Empty)
                {
                    Salon salon = new Salon() { SalonAd = textBox2.Text, Kapasite = Convert.ToInt32(maskedTextBox1.Text) };
                    using (var DB = new Context())
                    {
                        DB.Salon.Add(salon);
                        DB.SaveChanges();
                    }
                    MessageBox.Show("Veri Kaydedildi!");
                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayın!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (error.InnerException != null)
                {
                    MessageBox.Show(error.InnerException.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null && dateTimePicker4.Value != null && comboBox2.SelectedItem != null && comboBox3.SelectedItem != null && textBox3.Text != String.Empty && textBox4.Text != String.Empty && maskedTextBox2.Text != String.Empty)
                {
                    Seans seans = new Seans() { FilmAd = comboBox1.SelectedItem.ToString(), Tarih = dateTimePicker4.Value, SeansSaat = TimeSpan.Parse(comboBox2.SelectedItem.ToString()), Salon = comboBox3.SelectedItem.ToString(), MusteriAd = textBox3.Text, MusteriSoyad = textBox4.Text, KimlikNo = maskedTextBox2.Text.ToString() };
                    using (var DB = new Context())
                    {
                        var salon = DB.Salon.FirstOrDefault(s => s.SalonAd == seans.Salon);
                        if (salon != null && salon.Kapasite > 0)
                        {
                            DB.Seans.Add(seans);
                            salon.Kapasite -= 1;
                            DB.SaveChanges();
                            MessageBox.Show("Veri Kaydedildi!");
                        }
                        else
                        {
                            MessageBox.Show("Seçilen Salonda Yer Yok.");
                        }
                    }
                    using (var context = new Context())
                    {
                        var Seans = context.Seans.ToList();

                        dataGridView1.DataSource = Seans;
                    }
                }
                else
                {
                    MessageBox.Show("Boş Alan Bırakmayın!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (error.InnerException != null)
                {
                    MessageBox.Show(error.InnerException.Message);
                }
            }
        }
        private void comboBox1_MouseHover(object sender, EventArgs e)
        {
            try
            {
                using (var DB = new Context())
                {
                    var FilmAd = DB.Film.Select(f => f.FilmAd).ToList();
                    comboBox1.DataSource = FilmAd;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (error.InnerException != null)
                {
                    MessageBox.Show(error.InnerException.Message);
                }
            }
        }
        private void comboBox2_MouseHover(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    using (var context = new Context())
                    {
                        string? FilmAd = comboBox1.SelectedItem.ToString();

                        var seans = context.Film.Where(f => f.FilmAd == FilmAd).Select(f => new { f.Seans1, f.Seans2, f.Seans3 }).FirstOrDefault();

                        if (seans != null)
                        {
                            comboBox2.Items.Clear();
                            comboBox2.Items.Add(seans.Seans1.ToString());
                            comboBox2.Items.Add(seans.Seans2.ToString());
                            comboBox2.Items.Add(seans.Seans3.ToString());
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (error.InnerException != null)
                {
                    MessageBox.Show(error.InnerException.Message);
                }
            }
        }
        private void comboBox3_MouseHover(object sender, EventArgs e)
        {
            try
            {
                using (var DB = new Context())
                {
                    var SalonAd = DB.Salon.Select(f => f.SalonAd).ToList();
                    comboBox3.DataSource = SalonAd;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (error.InnerException != null)
                {
                    MessageBox.Show(error.InnerException.Message);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new Context())
                {
                    var Seans = context.Seans.ToList();
                    dataGridView1.DataSource = Seans;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                if (error.InnerException != null)
                {
                    MessageBox.Show(error.InnerException.Message);
                }
            }
        }
    }
}