using _163311055_ga.Classess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _163311055_ga
{
    public partial class UIGAMain : Form
    {
        #region Properties
        GA ga;
        #endregion

        #region Constructor
        /// <summary>
        /// The UIGAMain Constructor
        /// </summary>
        public UIGAMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Click / Event

        /// <summary>
        /// Başlama butonnuna basıldığında değerlere göre chart oluşuyor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startButton_Click(object sender, EventArgs e)
        {
            StartedChart();
        }

        #region Refresh Butonu
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        #endregion

        #region Kapatma Butonu
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Constants.WouldYouLikeToLogOut,
               Constants.Report,
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
            else
                return;
        }
        #endregion

        #region Tam Ekran Modunu Açma - Kapama İşlevini Sağlamaktadır.
        private void chkFullScreen_CheckedChanged_1(object sender, EventArgs e)
        {
            #region Tam Ekranı Modunu Açar
            if (chkFullScreen.Text == Constants.FullScreenOpen)
            {
                WindowState = FormWindowState.Maximized;
                chkFullScreen.Text = Constants.FullScreenClose;
            }
            #endregion
            #region Tam Ekran Modundan Çıkar
            else if (chkFullScreen.Text == Constants.FullScreenClose)
            {
                WindowState = FormWindowState.Normal;
                chkFullScreen.Text = Constants.FullScreenOpen;
            }
            #endregion
        }
        #endregion

        #region Kayan yazı işlevleri sağlanmaktadır. 
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblTeacher.Text = lblTeacher.Text.Substring(1) + lblTeacher.Text.Substring(0, 1);
        }

        private void UIGAMain_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblTeacher.Text = Constants.FormLoadOpenedOfInformationMessage;
        }
        #endregion

        #endregion

        #region Method

        /// <summary>
        /// Chart Güncelleme İşlemi yapılmaktadır. 
        /// Gelen değere göre diyagram değişiyor.
        /// </summary>
        public void UpdatedCharts()
        {
            ga.population = ga.population.OrderBy((Chromosome ch) => ch.FitnessFunction()).ToList();
            chartGrafik.Series.Clear();
            for (int i = 0; i < ga.population.Count; i++)
            {
                Series series = chartGrafik.Series.Add(ga.population[i].FitnessFunction().ToString());
                series.Points.Add(ga.population[i].FitnessFunction());
            }
            // Formülden gelen bilgiler generic listte tutulmaktadır. bu list içeriisndeki min ve max değerleri ekranda gösterilmektedir.
            min.Text = ga.population[0].listFunction.Min().ToString();
            max.Text = ga.population[0].listFunction.Max().ToString();
        }

        /// <summary>
        /// Başla Butonuna basıldığında gerçekleşecek olaylar yer almaktadır. 
        /// </summary>
        public void StartedChart()
        {
            #region GA sınıfı içerisindeki GenericList olarak bulunan population değişkeninin doldurulması sağlanıyor. 
            this.ga = new GA((int)populationSize.Value); //Populasyon sayısına göre gen oluşuyor.
            this.ga.population = this.ga.population.OrderBy((Chromosome ch) => ch.FitnessFunction()).ToList();
            #endregion
            if (Convert.ToInt32(populationSize.Value) <= 0)
                MessageBox.Show(Constants.PopulatisonSizeValueControlMessage,
                                Constants.Report,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            #region İterasyon Sayısı seçilme durumu
            else if (rbIteration.Checked)
            {
                ga.Iteration();
                UpdatedCharts();
                nmIteration.Maximum = 1000;
                nmIteration.Value = 100;
                nmIteration.Minimum = 0;
            }
            #endregion
            #region Uygunluk Değeri seçilme durumu
            else if (rbFunction.Checked)
            {
                #region Çarprazlama, mutasyon, seçkinlik değerlerinin kontrolü yapılıp chart oluşturuluyor.
                try
                {
                    GA.crossoverRate = double.Parse(nmCrossover.Text);
                    GA.mutationRate = double.Parse(nmMutation.Text);
                    GA.eliteCount = (int)nmElite.Value;
                    if (GA.crossoverRate < 0 ||
                        GA.crossoverRate > 1 ||
                        GA.mutationRate < 0 ||
                        GA.mutationRate > 1)
                        throw new Exception();
                }
                catch
                {
                    MessageBox.Show(Constants.OKWarningMessaging,
                                    Constants.Information,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    return;
                }
                nmIteration.Maximum = 10;
                nmIteration.Value = 10;
                nmIteration.Minimum = -10;
                startButton.Enabled = true;
                UpdatedCharts();
                #endregion
            }
            #endregion
            #region Durum seçilmeme işlemi
            else
                MessageBox.Show(Constants.IterationOrFunctionWarningMessaging,
                                Constants.Report,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            #endregion
        }

        #endregion
    }
}
