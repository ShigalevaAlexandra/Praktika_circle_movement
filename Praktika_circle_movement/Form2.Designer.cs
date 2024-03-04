namespace Praktika_circle_movement
{
    partial class Circle_color
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
            this.radioBtn_black = new System.Windows.Forms.RadioButton();
            this.radioBtn_yellow = new System.Windows.Forms.RadioButton();
            this.radioBtn_red = new System.Windows.Forms.RadioButton();
            this.radioBtn_green = new System.Windows.Forms.RadioButton();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioBtn_black
            // 
            this.radioBtn_black.AutoSize = true;
            this.radioBtn_black.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_black.Location = new System.Drawing.Point(41, 49);
            this.radioBtn_black.Name = "radioBtn_black";
            this.radioBtn_black.Size = new System.Drawing.Size(64, 20);
            this.radioBtn_black.TabIndex = 0;
            this.radioBtn_black.TabStop = true;
            this.radioBtn_black.Text = "Black";
            this.radioBtn_black.UseVisualStyleBackColor = true;
            // 
            // radioBtn_yellow
            // 
            this.radioBtn_yellow.AutoSize = true;
            this.radioBtn_yellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_yellow.Location = new System.Drawing.Point(41, 89);
            this.radioBtn_yellow.Name = "radioBtn_yellow";
            this.radioBtn_yellow.Size = new System.Drawing.Size(71, 20);
            this.radioBtn_yellow.TabIndex = 1;
            this.radioBtn_yellow.TabStop = true;
            this.radioBtn_yellow.Text = "Yellow";
            this.radioBtn_yellow.UseVisualStyleBackColor = true;
            // 
            // radioBtn_red
            // 
            this.radioBtn_red.AutoSize = true;
            this.radioBtn_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_red.Location = new System.Drawing.Point(41, 130);
            this.radioBtn_red.Name = "radioBtn_red";
            this.radioBtn_red.Size = new System.Drawing.Size(54, 20);
            this.radioBtn_red.TabIndex = 2;
            this.radioBtn_red.TabStop = true;
            this.radioBtn_red.Text = "Red";
            this.radioBtn_red.UseVisualStyleBackColor = true;
            // 
            // radioBtn_green
            // 
            this.radioBtn_green.AutoSize = true;
            this.radioBtn_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioBtn_green.Location = new System.Drawing.Point(41, 171);
            this.radioBtn_green.Name = "radioBtn_green";
            this.radioBtn_green.Size = new System.Drawing.Size(67, 20);
            this.radioBtn_green.TabIndex = 3;
            this.radioBtn_green.TabStop = true;
            this.radioBtn_green.Text = "Green";
            this.radioBtn_green.UseVisualStyleBackColor = true;
            // 
            // btn_OK
            // 
            this.btn_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_OK.Location = new System.Drawing.Point(171, 248);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 4;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // Circle_color
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 283);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.radioBtn_green);
            this.Controls.Add(this.radioBtn_red);
            this.Controls.Add(this.radioBtn_yellow);
            this.Controls.Add(this.radioBtn_black);
            this.Name = "Circle_color";
            this.Text = "Circle_color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioBtn_black;
        private System.Windows.Forms.RadioButton radioBtn_yellow;
        private System.Windows.Forms.RadioButton radioBtn_red;
        private System.Windows.Forms.RadioButton radioBtn_green;
        private System.Windows.Forms.Button btn_OK;
    }
}