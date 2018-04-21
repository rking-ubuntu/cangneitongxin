namespace Fengji
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.开始采集 = new System.Windows.Forms.Button();
            this.停止采集 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.端口号 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STATUS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.本机IP = new System.Windows.Forms.Label();
            this.本机端口号 = new System.Windows.Forms.Label();
            this.textBox_42 = new System.Windows.Forms.TextBox();
            this.textBox_41 = new System.Windows.Forms.TextBox();
            this.fjdataDataSet2 = new Fengji.fjdataDataSet();
            this.tableAdapterManager = new Fengji.fjdataDataSet1TableAdapters.TableAdapterManager();
            this.fengji_dataDataSet1 = new Fengji.fengji_dataDataSet();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.舱内设备健康监测测试系统 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.fjdataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fengji_dataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).BeginInit();
            this.SuspendLayout();
            // 
            // 开始采集
            // 
            this.开始采集.Font = new System.Drawing.Font("宋体", 15F);
            this.开始采集.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.开始采集.Location = new System.Drawing.Point(870, 267);
            this.开始采集.Name = "开始采集";
            this.开始采集.Size = new System.Drawing.Size(135, 56);
            this.开始采集.TabIndex = 0;
            this.开始采集.Text = "开始采集";
            this.开始采集.UseVisualStyleBackColor = true;
            this.开始采集.Click += new System.EventHandler(this.开始采集_Click);
            // 
            // 停止采集
            // 
            this.停止采集.Font = new System.Drawing.Font("宋体", 15F);
            this.停止采集.ForeColor = System.Drawing.Color.Red;
            this.停止采集.Location = new System.Drawing.Point(1023, 267);
            this.停止采集.Name = "停止采集";
            this.停止采集.Size = new System.Drawing.Size(135, 56);
            this.停止采集.TabIndex = 1;
            this.停止采集.Text = "停止采集";
            this.停止采集.UseVisualStyleBackColor = true;
            this.停止采集.Click += new System.EventHandler(this.停止采集_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.InitialDirectory = "E:\\VS\\Project";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IP,
            this.端口号,
            this.STATUS,
            this.ID});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(44, 364);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(922, 91);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IP
            // 
            this.IP.Text = "                     IP";
            this.IP.Width = 260;
            // 
            // 端口号
            // 
            this.端口号.Tag = "";
            this.端口号.Text = "端口号";
            this.端口号.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.端口号.Width = 232;
            // 
            // STATUS
            // 
            this.STATUS.Text = "状态";
            this.STATUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.STATUS.Width = 227;
            // 
            // ID
            // 
            this.ID.Text = "风机ID";
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ID.Width = 198;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1004, 381);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 21);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1004, 433);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 21);
            this.textBox2.TabIndex = 21;
            // 
            // 本机IP
            // 
            this.本机IP.AutoSize = true;
            this.本机IP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.本机IP.Location = new System.Drawing.Point(1002, 366);
            this.本机IP.Name = "本机IP";
            this.本机IP.Size = new System.Drawing.Size(41, 12);
            this.本机IP.TabIndex = 22;
            this.本机IP.Text = "本机IP";
            // 
            // 本机端口号
            // 
            this.本机端口号.AutoSize = true;
            this.本机端口号.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.本机端口号.Location = new System.Drawing.Point(1002, 417);
            this.本机端口号.Name = "本机端口号";
            this.本机端口号.Size = new System.Drawing.Size(65, 12);
            this.本机端口号.TabIndex = 23;
            this.本机端口号.Text = "本机端口号";
            // 
            // textBox_42
            // 
            this.textBox_42.Font = new System.Drawing.Font("宋体", 25F);
            this.textBox_42.Location = new System.Drawing.Point(1023, 200);
            this.textBox_42.Name = "textBox_42";
            this.textBox_42.Size = new System.Drawing.Size(135, 46);
            this.textBox_42.TabIndex = 66;
            this.textBox_42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_41
            // 
            this.textBox_41.Font = new System.Drawing.Font("宋体", 25F);
            this.textBox_41.Location = new System.Drawing.Point(1023, 123);
            this.textBox_41.Name = "textBox_41";
            this.textBox_41.Size = new System.Drawing.Size(135, 46);
            this.textBox_41.TabIndex = 65;
            this.textBox_41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fjdataDataSet2
            // 
            this.fjdataDataSet2.DataSetName = "fjdataDataSet";
            this.fjdataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = Fengji.fjdataDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fengji_dataDataSet1
            // 
            this.fengji_dataDataSet1.DataSetName = "fengji_dataDataSet";
            this.fengji_dataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Second;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(44, 123);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series1.Name = "振动信号";
            series1.View = lineSeriesView1;
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime;
            series2.Name = "温度信号";
            series2.View = lineSeriesView2;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl1.Size = new System.Drawing.Size(820, 200);
            this.chartControl1.TabIndex = 67;
            // 
            // 舱内设备健康监测测试系统
            // 
            this.舱内设备健康监测测试系统.AutoSize = true;
            this.舱内设备健康监测测试系统.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.舱内设备健康监测测试系统.ForeColor = System.Drawing.Color.DodgerBlue;
            this.舱内设备健康监测测试系统.Location = new System.Drawing.Point(172, 32);
            this.舱内设备健康监测测试系统.Name = "舱内设备健康监测测试系统";
            this.舱内设备健康监测测试系统.Size = new System.Drawing.Size(860, 48);
            this.舱内设备健康监测测试系统.TabIndex = 68;
            this.舱内设备健康监测测试系统.Text = "舱 内 设 备 健 康 监 测 测 试 系 统";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("宋体", 25F);
            this.label19.Location = new System.Drawing.Point(870, 203);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 34);
            this.label19.TabIndex = 105;
            this.label19.Text = "温度信号";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("宋体", 25F);
            this.label18.Location = new System.Drawing.Point(870, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 34);
            this.label18.TabIndex = 104;
            this.label18.Text = "振动信号";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 497);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.舱内设备健康监测测试系统);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.textBox_42);
            this.Controls.Add(this.textBox_41);
            this.Controls.Add(this.本机端口号);
            this.Controls.Add(this.本机IP);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.停止采集);
            this.Controls.Add(this.开始采集);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "舱内设备健康监测测试系统";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fjdataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fengji_dataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button 开始采集;
        private System.Windows.Forms.Button 停止采集;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IP;
        private System.Windows.Forms.ColumnHeader 端口号;
        private System.Windows.Forms.ColumnHeader STATUS;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label 本机IP;
        private System.Windows.Forms.Label 本机端口号;
        private System.Windows.Forms.TextBox textBox_42;
        public System.Windows.Forms.TextBox textBox_41;
        private fjdataDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private fjdataDataSet fjdataDataSet2;
        private fengji_dataDataSet fengji_dataDataSet1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Label 舱内设备健康监测测试系统;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}