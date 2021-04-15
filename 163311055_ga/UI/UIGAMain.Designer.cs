namespace _163311055_ga
{
    partial class UIGAMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.nmMutation = new System.Windows.Forms.NumericUpDown();
            this.nmCrossover = new System.Windows.Forms.NumericUpDown();
            this.populationSize = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nmPenalty = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nmElite = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkFullScreen = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.rbFunction = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbIteration = new System.Windows.Forms.RadioButton();
            this.nmIteration = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.chartGrafik = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblmin = new System.Windows.Forms.Label();
            this.lblmax = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmMutation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCrossover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPenalty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmElite)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacher
            // 
            this.lblTeacher.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTeacher.ForeColor = System.Drawing.Color.Gray;
            this.lblTeacher.Location = new System.Drawing.Point(28, 618);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(433, 34);
            this.lblTeacher.TabIndex = 50;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Colonna MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(790, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ayşe ŞİMŞEK";
            // 
            // nmMutation
            // 
            this.nmMutation.DecimalPlaces = 4;
            this.nmMutation.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmMutation.ForeColor = System.Drawing.Color.Maroon;
            this.nmMutation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmMutation.Location = new System.Drawing.Point(179, 108);
            this.nmMutation.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmMutation.Name = "nmMutation";
            this.nmMutation.Size = new System.Drawing.Size(80, 26);
            this.nmMutation.TabIndex = 34;
            this.nmMutation.Value = new decimal(new int[] {
            10,
            0,
            0,
            262144});
            // 
            // nmCrossover
            // 
            this.nmCrossover.DecimalPlaces = 2;
            this.nmCrossover.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmCrossover.ForeColor = System.Drawing.Color.Maroon;
            this.nmCrossover.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nmCrossover.Location = new System.Drawing.Point(179, 67);
            this.nmCrossover.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nmCrossover.Name = "nmCrossover";
            this.nmCrossover.Size = new System.Drawing.Size(80, 26);
            this.nmCrossover.TabIndex = 34;
            this.nmCrossover.Value = new decimal(new int[] {
            70,
            0,
            0,
            131072});
            // 
            // populationSize
            // 
            this.populationSize.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.populationSize.ForeColor = System.Drawing.Color.Maroon;
            this.populationSize.Location = new System.Drawing.Point(179, 22);
            this.populationSize.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.populationSize.Name = "populationSize";
            this.populationSize.Size = new System.Drawing.Size(80, 26);
            this.populationSize.TabIndex = 34;
            this.populationSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "Populasyon Boyutu";
            // 
            // nmPenalty
            // 
            this.nmPenalty.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmPenalty.ForeColor = System.Drawing.Color.Maroon;
            this.nmPenalty.Location = new System.Drawing.Point(179, 190);
            this.nmPenalty.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmPenalty.Name = "nmPenalty";
            this.nmPenalty.Size = new System.Drawing.Size(80, 26);
            this.nmPenalty.TabIndex = 32;
            this.nmPenalty.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Colonna MT", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Snow;
            this.label6.Location = new System.Drawing.Point(22, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(536, 68);
            this.label6.TabIndex = 46;
            this.label6.Text = "GA ALGORİTMASI";
            // 
            // nmElite
            // 
            this.nmElite.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmElite.ForeColor = System.Drawing.Color.Maroon;
            this.nmElite.Location = new System.Drawing.Point(179, 147);
            this.nmElite.Name = "nmElite";
            this.nmElite.Size = new System.Drawing.Size(80, 26);
            this.nmElite.TabIndex = 32;
            this.nmElite.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Seçkinlik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Çarprazlama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mutasyon";
            // 
            // chkFullScreen
            // 
            this.chkFullScreen.AutoSize = true;
            this.chkFullScreen.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkFullScreen.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chkFullScreen.Location = new System.Drawing.Point(34, 103);
            this.chkFullScreen.Name = "chkFullScreen";
            this.chkFullScreen.Size = new System.Drawing.Size(197, 23);
            this.chkFullScreen.TabIndex = 51;
            this.chkFullScreen.Text = "Tam Ekran Modunu Aç";
            this.chkFullScreen.UseVisualStyleBackColor = true;
            this.chkFullScreen.CheckedChanged += new System.EventHandler(this.chkFullScreen_CheckedChanged_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.nmMutation);
            this.panel2.Controls.Add(this.nmCrossover);
            this.panel2.Controls.Add(this.populationSize);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.nmPenalty);
            this.panel2.Controls.Add(this.nmElite);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(12, 142);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 245);
            this.panel2.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(12, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 19);
            this.label7.TabIndex = 31;
            this.label7.Text = "Penalty Parametresi";
            // 
            // rbFunction
            // 
            this.rbFunction.AutoSize = true;
            this.rbFunction.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbFunction.ForeColor = System.Drawing.Color.Maroon;
            this.rbFunction.Location = new System.Drawing.Point(157, 28);
            this.rbFunction.Name = "rbFunction";
            this.rbFunction.Size = new System.Drawing.Size(149, 23);
            this.rbFunction.TabIndex = 33;
            this.rbFunction.Text = "Uygunluk Değeri";
            this.rbFunction.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbFunction);
            this.panel1.Controls.Add(this.rbIteration);
            this.panel1.Controls.Add(this.nmIteration);
            this.panel1.Controls.Add(this.label5);
            this.panel1.ForeColor = System.Drawing.Color.OrangeRed;
            this.panel1.Location = new System.Drawing.Point(12, 393);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 137);
            this.panel1.TabIndex = 45;
            // 
            // rbIteration
            // 
            this.rbIteration.AutoSize = true;
            this.rbIteration.Checked = true;
            this.rbIteration.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbIteration.ForeColor = System.Drawing.Color.Maroon;
            this.rbIteration.Location = new System.Drawing.Point(14, 28);
            this.rbIteration.Name = "rbIteration";
            this.rbIteration.Size = new System.Drawing.Size(142, 23);
            this.rbIteration.TabIndex = 32;
            this.rbIteration.TabStop = true;
            this.rbIteration.Text = "İterasyon Sayısı";
            this.rbIteration.UseVisualStyleBackColor = true;
            // 
            // nmIteration
            // 
            this.nmIteration.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nmIteration.ForeColor = System.Drawing.Color.Maroon;
            this.nmIteration.Location = new System.Drawing.Point(191, 71);
            this.nmIteration.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmIteration.Name = "nmIteration";
            this.nmIteration.Size = new System.Drawing.Size(64, 26);
            this.nmIteration.TabIndex = 30;
            this.nmIteration.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(38, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Jenerasyon Sayısı : ";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startButton.ForeColor = System.Drawing.Color.Snow;
            this.startButton.Location = new System.Drawing.Point(12, 536);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(320, 61);
            this.startButton.TabIndex = 44;
            this.startButton.Text = "TAMAM";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // chartGrafik
            // 
            this.chartGrafik.BackColor = System.Drawing.Color.Transparent;
            this.chartGrafik.BorderlineColor = System.Drawing.Color.Transparent;
            this.chartGrafik.BorderSkin.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            this.chartGrafik.BorderSkin.BorderColor = System.Drawing.Color.DarkRed;
            chartArea2.Name = "ChartArea1";
            this.chartGrafik.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGrafik.Legends.Add(legend2);
            this.chartGrafik.Location = new System.Drawing.Point(338, 142);
            this.chartGrafik.Name = "chartGrafik";
            this.chartGrafik.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.BorderColor = System.Drawing.Color.Black;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Black;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square;
            series2.Name = "GA";
            this.chartGrafik.Series.Add(series2);
            this.chartGrafik.Size = new System.Drawing.Size(592, 455);
            this.chartGrafik.TabIndex = 52;
            this.chartGrafik.Text = "chart1";
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmin.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblmin.Location = new System.Drawing.Point(604, 615);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(38, 19);
            this.lblmin.TabIndex = 53;
            this.lblmin.Text = "Min";
            // 
            // lblmax
            // 
            this.lblmax.AutoSize = true;
            this.lblmax.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmax.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblmax.Location = new System.Drawing.Point(803, 618);
            this.lblmax.Name = "lblmax";
            this.lblmax.Size = new System.Drawing.Size(40, 19);
            this.lblmax.TabIndex = 54;
            this.lblmax.Text = "Max";
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.min.ForeColor = System.Drawing.Color.Gainsboro;
            this.min.Location = new System.Drawing.Point(549, 646);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(0, 19);
            this.min.TabIndex = 55;
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.max.ForeColor = System.Drawing.Color.Gainsboro;
            this.max.Location = new System.Drawing.Point(755, 646);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(0, 19);
            this.max.TabIndex = 56;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Image = global::_163311055_ga.Properties.Resources.refresh;
            this.pictureBox4.Location = new System.Drawing.Point(627, 32);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(57, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::_163311055_ga.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(564, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(57, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // UIGAMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(942, 702);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.max);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.min);
            this.Controls.Add(this.lblmax);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.chartGrafik);
            this.Controls.Add(this.lblTeacher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkFullScreen);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UIGAMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UIGAMain_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nmMutation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCrossover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.populationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPenalty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmElite)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGrafik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nmMutation;
        private System.Windows.Forms.NumericUpDown nmCrossover;
        private System.Windows.Forms.NumericUpDown populationSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmPenalty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nmElite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkFullScreen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rbFunction;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbIteration;
        private System.Windows.Forms.NumericUpDown nmIteration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGrafik;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Label lblmax;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

