namespace _4
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSeeAns = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("MiSans Medium", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(71, 53);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(135, 103);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSeeAns
            // 
            this.btnSeeAns.Font = new System.Drawing.Font("MiSans Medium", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeAns.Location = new System.Drawing.Point(60, 211);
            this.btnSeeAns.Name = "btnSeeAns";
            this.btnSeeAns.Size = new System.Drawing.Size(185, 103);
            this.btnSeeAns.TabIndex = 1;
            this.btnSeeAns.Text = "See\r\nAnswer";
            this.btnSeeAns.UseVisualStyleBackColor = true;
            this.btnSeeAns.Click += new System.EventHandler(this.btnSeeAns_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MiSans Medium", 13F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(379, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 47);
            this.label1.TabIndex = 2;
            this.label1.Text = "history";
            // 
            // listBox1
            // 
            this.listBox1.Enabled = false;
            this.listBox1.Font = new System.Drawing.Font("MiSans Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 36;
            this.listBox1.Location = new System.Drawing.Point(549, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(422, 508);
            this.listBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MiSans Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(247, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 36);
            this.textBox1.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("MiSans Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(57, 508);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(169, 106);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.Text = "Check\r\nAnswer";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("MiSans Medium", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(267, 508);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 84);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 635);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeeAns);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSeeAns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnReset;
    }
}

