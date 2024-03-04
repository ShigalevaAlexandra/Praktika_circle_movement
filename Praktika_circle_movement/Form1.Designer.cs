namespace Praktika_circle_movement
{
    partial class circle_movement
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
            this.components = new System.ComponentModel.Container();
            this.pictBox_circle = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.timer_circle = new System.Windows.Forms.Timer(this.components);
            this.trackBar_speed_circle = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed_circle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictBox_circle
            // 
            this.pictBox_circle.Location = new System.Drawing.Point(12, 12);
            this.pictBox_circle.Name = "pictBox_circle";
            this.pictBox_circle.Size = new System.Drawing.Size(498, 208);
            this.pictBox_circle.TabIndex = 0;
            this.pictBox_circle.TabStop = false;
            this.pictBox_circle.Paint += new System.Windows.Forms.PaintEventHandler(this.pictBox_circle_Paint);
            this.pictBox_circle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictBox_circle_MouseClick);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(12, 237);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(85, 29);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Старт";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stop.Location = new System.Drawing.Point(12, 283);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(85, 29);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Стоп";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // timer_circle
            // 
            this.timer_circle.Tick += new System.EventHandler(this.timer_circle_Tick);
            // 
            // trackBar_speed_circle
            // 
            this.trackBar_speed_circle.Location = new System.Drawing.Point(115, 237);
            this.trackBar_speed_circle.Name = "trackBar_speed_circle";
            this.trackBar_speed_circle.Size = new System.Drawing.Size(395, 45);
            this.trackBar_speed_circle.TabIndex = 3;
            this.trackBar_speed_circle.Scroll += new System.EventHandler(this.trackBar_speed_circle_Scroll);
            // 
            // circle_movement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 324);
            this.Controls.Add(this.trackBar_speed_circle);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pictBox_circle);
            this.Name = "circle_movement";
            this.Text = "circle_movement";
            this.Load += new System.EventHandler(this.circle_movement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_speed_circle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox_circle;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Timer timer_circle;
        private System.Windows.Forms.TrackBar trackBar_speed_circle;
    }
}

