namespace WP_2020_01_HW02_9A713008_11_19
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.pB1 = new System.Windows.Forms.PictureBox();
            this.rTB1 = new System.Windows.Forms.RichTextBox();
            this.btn2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn1.Location = new System.Drawing.Point(122, 48);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(170, 115);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "按";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // pB1
            // 
            this.pB1.Image = global::WP_2020_01_HW02_9A713008_11_19.Properties.Resources.P1;
            this.pB1.Location = new System.Drawing.Point(122, 196);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(170, 221);
            this.pB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pB1.TabIndex = 1;
            this.pB1.TabStop = false;
            // 
            // rTB1
            // 
            this.rTB1.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rTB1.Location = new System.Drawing.Point(375, 196);
            this.rTB1.Name = "rTB1";
            this.rTB1.Size = new System.Drawing.Size(167, 221);
            this.rTB1.TabIndex = 2;
            this.rTB1.Text = "0次";
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn2.Location = new System.Drawing.Point(375, 57);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(167, 115);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "reset";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.rTB1);
            this.Controls.Add(this.pB1);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pB1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.PictureBox pB1;
        private System.Windows.Forms.RichTextBox rTB1;
        private System.Windows.Forms.Button btn2;
    }
}

