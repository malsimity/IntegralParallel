namespace IntegralParallel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label4 = new System.Windows.Forms.Label();
            this._rtbResult = new System.Windows.Forms.RichTextBox();
            this._cbmMetod = new System.Windows.Forms.ComboBox();
            this._btCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this._nudN = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this._tbMIN = new System.Windows.Forms.TextBox();
            this._tbMAX = new System.Windows.Forms.TextBox();
            this._chGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this._cbParal = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this._nudN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._chGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Метод";
            // 
            // _rtbResult
            // 
            this._rtbResult.Location = new System.Drawing.Point(12, 246);
            this._rtbResult.Name = "_rtbResult";
            this._rtbResult.ReadOnly = true;
            this._rtbResult.Size = new System.Drawing.Size(169, 47);
            this._rtbResult.TabIndex = 18;
            this._rtbResult.Text = "";
            // 
            // _cbmMetod
            // 
            this._cbmMetod.Cursor = System.Windows.Forms.Cursors.Hand;
            this._cbmMetod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbmMetod.FormattingEnabled = true;
            this._cbmMetod.Items.AddRange(new object[] {
            "Метод трапеции",
            "Метод прямоугольника",
            "Метод Симпсона"});
            this._cbmMetod.Location = new System.Drawing.Point(12, 157);
            this._cbmMetod.Name = "_cbmMetod";
            this._cbmMetod.Size = new System.Drawing.Size(121, 21);
            this._cbmMetod.TabIndex = 17;
            // 
            // _btCalculate
            // 
            this._btCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this._btCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._btCalculate.Location = new System.Drawing.Point(12, 310);
            this._btCalculate.Name = "_btCalculate";
            this._btCalculate.Size = new System.Drawing.Size(122, 61);
            this._btCalculate.TabIndex = 16;
            this._btCalculate.Text = "Расчитать";
            this._btCalculate.UseVisualStyleBackColor = true;
            this._btCalculate.Click += new System.EventHandler(this._btCalculate_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Кол-во шагов";
            // 
            // _nudN
            // 
            this._nudN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._nudN.Location = new System.Drawing.Point(12, 114);
            this._nudN.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this._nudN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._nudN.Name = "_nudN";
            this._nudN.Size = new System.Drawing.Size(120, 20);
            this._nudN.TabIndex = 14;
            this._nudN.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Нижний предел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Верхний предел";
            // 
            // _tbMIN
            // 
            this._tbMIN.Location = new System.Drawing.Point(12, 71);
            this._tbMIN.Name = "_tbMIN";
            this._tbMIN.Size = new System.Drawing.Size(120, 20);
            this._tbMIN.TabIndex = 11;
            this._tbMIN.Text = "1";
            // 
            // _tbMAX
            // 
            this._tbMAX.Location = new System.Drawing.Point(12, 28);
            this._tbMAX.Name = "_tbMAX";
            this._tbMAX.Size = new System.Drawing.Size(120, 20);
            this._tbMAX.TabIndex = 10;
            this._tbMAX.Text = "100";
            // 
            // _chGraph
            // 
            chartArea1.Name = "ChartArea1";
            this._chGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this._chGraph.Legends.Add(legend1);
            this._chGraph.Location = new System.Drawing.Point(201, 13);
            this._chGraph.Name = "_chGraph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Follower";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Parallel";
            this._chGraph.Series.Add(series1);
            this._chGraph.Series.Add(series2);
            this._chGraph.Size = new System.Drawing.Size(419, 296);
            this._chGraph.TabIndex = 20;
            this._chGraph.Text = "chart1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Параллельно или последовательно";
            // 
            // _cbParal
            // 
            this._cbParal.Cursor = System.Windows.Forms.Cursors.Hand;
            this._cbParal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cbParal.FormattingEnabled = true;
            this._cbParal.Items.AddRange(new object[] {
            "Последовательно",
            "Параллельно"});
            this._cbParal.Location = new System.Drawing.Point(12, 197);
            this._cbParal.Name = "_cbParal";
            this._cbParal.Size = new System.Drawing.Size(121, 21);
            this._cbParal.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 374);
            this.Controls.Add(this.label5);
            this.Controls.Add(this._cbParal);
            this.Controls.Add(this._chGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._rtbResult);
            this.Controls.Add(this._cbmMetod);
            this.Controls.Add(this._btCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this._nudN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tbMIN);
            this.Controls.Add(this._tbMAX);
            this.Name = "Form1";
            this.Text = "Широков М.О. гр 3-47";
            ((System.ComponentModel.ISupportInitialize)(this._nudN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._chGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox _rtbResult;
        private System.Windows.Forms.ComboBox _cbmMetod;
        private System.Windows.Forms.Button _btCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _nudN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _tbMIN;
        private System.Windows.Forms.TextBox _tbMAX;
        private System.Windows.Forms.DataVisualization.Charting.Chart _chGraph;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _cbParal;
    }
}

