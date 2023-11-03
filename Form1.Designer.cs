namespace Карта
{
    partial class Карта
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Карта));
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.TxBxLong = new System.Windows.Forms.TextBox();
            this.TxBxWight = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxBxLongForName = new System.Windows.Forms.TextBox();
            this.TxBxWightForName = new System.Windows.Forms.TextBox();
            this.CreateMark = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxBxMarkText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Долгота = new System.Windows.Forms.Label();
            this.Long = new System.Windows.Forms.Label();
            this.width = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(564, 472);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControl1_OnPositionChanged);
            this.gMapControl1.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapControl1_OnMapZoomChanged);
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoadBtn.Location = new System.Drawing.Point(76, 113);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(187, 46);
            this.LoadBtn.TabIndex = 1;
            this.LoadBtn.Text = "Показать на точку карте";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // TxBxLong
            // 
            this.TxBxLong.Location = new System.Drawing.Point(3, 26);
            this.TxBxLong.Name = "TxBxLong";
            this.TxBxLong.Size = new System.Drawing.Size(260, 22);
            this.TxBxLong.TabIndex = 2;
            // 
            // TxBxWight
            // 
            this.TxBxWight.Location = new System.Drawing.Point(3, 85);
            this.TxBxWight.Name = "TxBxWight";
            this.TxBxWight.Size = new System.Drawing.Size(260, 22);
            this.TxBxWight.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.TxBxLongForName);
            this.panel1.Controls.Add(this.TxBxWightForName);
            this.panel1.Controls.Add(this.CreateMark);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxBxMarkText);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Долгота);
            this.panel1.Controls.Add(this.TxBxLong);
            this.panel1.Controls.Add(this.LoadBtn);
            this.panel1.Controls.Add(this.TxBxWight);
            this.panel1.Location = new System.Drawing.Point(602, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 491);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Широта";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Долгота";
            // 
            // TxBxLongForName
            // 
            this.TxBxLongForName.Location = new System.Drawing.Point(3, 194);
            this.TxBxLongForName.Name = "TxBxLongForName";
            this.TxBxLongForName.Size = new System.Drawing.Size(260, 22);
            this.TxBxLongForName.TabIndex = 11;
            // 
            // TxBxWightForName
            // 
            this.TxBxWightForName.Location = new System.Drawing.Point(3, 253);
            this.TxBxWightForName.Name = "TxBxWightForName";
            this.TxBxWightForName.Size = new System.Drawing.Size(260, 22);
            this.TxBxWightForName.TabIndex = 12;
            // 
            // CreateMark
            // 
            this.CreateMark.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateMark.Location = new System.Drawing.Point(76, 344);
            this.CreateMark.Name = "CreateMark";
            this.CreateMark.Size = new System.Drawing.Size(187, 46);
            this.CreateMark.TabIndex = 10;
            this.CreateMark.Text = "Добавить метку на карту";
            this.CreateMark.UseVisualStyleBackColor = false;
            this.CreateMark.Click += new System.EventHandler(this.CreateMark_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Описание метки";
            // 
            // TxBxMarkText
            // 
            this.TxBxMarkText.Location = new System.Drawing.Point(3, 316);
            this.TxBxMarkText.Name = "TxBxMarkText";
            this.TxBxMarkText.Size = new System.Drawing.Size(260, 22);
            this.TxBxMarkText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Широта";
            // 
            // Долгота
            // 
            this.Долгота.AutoSize = true;
            this.Долгота.Location = new System.Drawing.Point(6, 7);
            this.Долгота.Name = "Долгота";
            this.Долгота.Size = new System.Drawing.Size(61, 16);
            this.Долгота.TabIndex = 4;
            this.Долгота.Text = "Долгота";
            // 
            // Long
            // 
            this.Long.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Long.AutoSize = true;
            this.Long.Location = new System.Drawing.Point(284, 487);
            this.Long.Name = "Long";
            this.Long.Size = new System.Drawing.Size(0, 16);
            this.Long.TabIndex = 5;
            // 
            // width
            // 
            this.width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.width.AutoSize = true;
            this.width.Location = new System.Drawing.Point(12, 487);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(0, 16);
            this.width.TabIndex = 6;
            // 
            // Карта
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 515);
            this.Controls.Add(this.width);
            this.Controls.Add(this.Long);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gMapControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Карта";
            this.Text = "Карта";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.TextBox TxBxLong;
        private System.Windows.Forms.TextBox TxBxWight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Долгота;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxBxMarkText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxBxLongForName;
        private System.Windows.Forms.TextBox TxBxWightForName;
        private System.Windows.Forms.Button CreateMark;
        private System.Windows.Forms.Label Long;
        private System.Windows.Forms.Label width;
    }
}

