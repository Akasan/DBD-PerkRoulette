
namespace DBDパークルーレット
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.survivorRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.killerRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.startRouletteButton = new System.Windows.Forms.Button();
            this.perk1Label = new System.Windows.Forms.Label();
            this.perk2Label = new System.Windows.Forms.Label();
            this.perk3Label = new System.Windows.Forms.Label();
            this.perk4Label = new System.Windows.Forms.Label();
            this.stopRouletteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.perk1PageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.perk1PositionTextBox = new System.Windows.Forms.TextBox();
            this.perk2PositionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.perk2PageTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.perk4PositionTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.perk4PageTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.perk3PositionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.perk3PageTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // survivorRadioButton
            // 
            this.survivorRadioButton.AutoSize = true;
            this.survivorRadioButton.Location = new System.Drawing.Point(6, 18);
            this.survivorRadioButton.Name = "survivorRadioButton";
            this.survivorRadioButton.Size = new System.Drawing.Size(72, 16);
            this.survivorRadioButton.TabIndex = 9;
            this.survivorRadioButton.TabStop = true;
            this.survivorRadioButton.Text = "サバイバー";
            this.survivorRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.killerRadioButton);
            this.groupBox1.Controls.Add(this.survivorRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(171, 47);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "モード";
            // 
            // killerRadioButton
            // 
            this.killerRadioButton.AutoSize = true;
            this.killerRadioButton.Enabled = false;
            this.killerRadioButton.Location = new System.Drawing.Point(96, 18);
            this.killerRadioButton.Name = "killerRadioButton";
            this.killerRadioButton.Size = new System.Drawing.Size(51, 16);
            this.killerRadioButton.TabIndex = 10;
            this.killerRadioButton.TabStop = true;
            this.killerRadioButton.Text = "キラー";
            this.killerRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.perk4PositionTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.perk4PageTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.perk3PositionTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.perk3PageTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.perk2PositionTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.perk2PageTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.perk1PositionTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.perk1PageTextBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.stopRouletteButton);
            this.groupBox2.Controls.Add(this.perk4Label);
            this.groupBox2.Controls.Add(this.perk3Label);
            this.groupBox2.Controls.Add(this.perk2Label);
            this.groupBox2.Controls.Add(this.perk1Label);
            this.groupBox2.Controls.Add(this.startRouletteButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 279);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ルーレット";
            // 
            // startRouletteButton
            // 
            this.startRouletteButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.startRouletteButton.Location = new System.Drawing.Point(47, 213);
            this.startRouletteButton.Name = "startRouletteButton";
            this.startRouletteButton.Size = new System.Drawing.Size(276, 44);
            this.startRouletteButton.TabIndex = 13;
            this.startRouletteButton.Text = "ルーレット開始";
            this.startRouletteButton.UseVisualStyleBackColor = true;
            this.startRouletteButton.Click += new System.EventHandler(this.startRouletteButton_Click);
            // 
            // perk1Label
            // 
            this.perk1Label.AutoSize = true;
            this.perk1Label.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.perk1Label.Location = new System.Drawing.Point(54, 37);
            this.perk1Label.Name = "perk1Label";
            this.perk1Label.Size = new System.Drawing.Size(93, 27);
            this.perk1Label.TabIndex = 17;
            this.perk1Label.Text = "パーク１";
            // 
            // perk2Label
            // 
            this.perk2Label.AutoSize = true;
            this.perk2Label.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.perk2Label.Location = new System.Drawing.Point(400, 37);
            this.perk2Label.Name = "perk2Label";
            this.perk2Label.Size = new System.Drawing.Size(89, 27);
            this.perk2Label.TabIndex = 18;
            this.perk2Label.Text = "パーク2";
            // 
            // perk3Label
            // 
            this.perk3Label.AutoSize = true;
            this.perk3Label.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.perk3Label.Location = new System.Drawing.Point(54, 129);
            this.perk3Label.Name = "perk3Label";
            this.perk3Label.Size = new System.Drawing.Size(89, 27);
            this.perk3Label.TabIndex = 19;
            this.perk3Label.Text = "パーク3";
            // 
            // perk4Label
            // 
            this.perk4Label.AutoSize = true;
            this.perk4Label.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.perk4Label.Location = new System.Drawing.Point(400, 129);
            this.perk4Label.Name = "perk4Label";
            this.perk4Label.Size = new System.Drawing.Size(89, 27);
            this.perk4Label.TabIndex = 20;
            this.perk4Label.Text = "パーク4";
            // 
            // stopRouletteButton
            // 
            this.stopRouletteButton.Enabled = false;
            this.stopRouletteButton.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.stopRouletteButton.Location = new System.Drawing.Point(405, 213);
            this.stopRouletteButton.Name = "stopRouletteButton";
            this.stopRouletteButton.Size = new System.Drawing.Size(276, 44);
            this.stopRouletteButton.TabIndex = 21;
            this.stopRouletteButton.Text = "ルーレット停止";
            this.stopRouletteButton.UseVisualStyleBackColor = true;
            this.stopRouletteButton.Click += new System.EventHandler(this.stopRouletteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label1.Location = new System.Drawing.Point(57, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "ページ：";
            // 
            // perk1PageTextBox
            // 
            this.perk1PageTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.perk1PageTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.perk1PageTextBox.Location = new System.Drawing.Point(125, 75);
            this.perk1PageTextBox.Name = "perk1PageTextBox";
            this.perk1PageTextBox.ReadOnly = true;
            this.perk1PageTextBox.Size = new System.Drawing.Size(31, 25);
            this.perk1PageTextBox.TabIndex = 23;
            this.perk1PageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label2.Location = new System.Drawing.Point(172, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "位置：";
            // 
            // perk1PositionTextBox
            // 
            this.perk1PositionTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.perk1PositionTextBox.Location = new System.Drawing.Point(231, 75);
            this.perk1PositionTextBox.Name = "perk1PositionTextBox";
            this.perk1PositionTextBox.ReadOnly = true;
            this.perk1PositionTextBox.Size = new System.Drawing.Size(92, 25);
            this.perk1PositionTextBox.TabIndex = 25;
            // 
            // perk2PositionTextBox
            // 
            this.perk2PositionTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.perk2PositionTextBox.Location = new System.Drawing.Point(578, 75);
            this.perk2PositionTextBox.Name = "perk2PositionTextBox";
            this.perk2PositionTextBox.ReadOnly = true;
            this.perk2PositionTextBox.Size = new System.Drawing.Size(92, 25);
            this.perk2PositionTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label3.Location = new System.Drawing.Point(519, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "位置：";
            // 
            // perk2PageTextBox
            // 
            this.perk2PageTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.perk2PageTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.perk2PageTextBox.Location = new System.Drawing.Point(472, 75);
            this.perk2PageTextBox.Name = "perk2PageTextBox";
            this.perk2PageTextBox.ReadOnly = true;
            this.perk2PageTextBox.Size = new System.Drawing.Size(31, 25);
            this.perk2PageTextBox.TabIndex = 27;
            this.perk2PageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label4.Location = new System.Drawing.Point(404, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "ページ：";
            // 
            // perk4PositionTextBox
            // 
            this.perk4PositionTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.perk4PositionTextBox.Location = new System.Drawing.Point(578, 165);
            this.perk4PositionTextBox.Name = "perk4PositionTextBox";
            this.perk4PositionTextBox.ReadOnly = true;
            this.perk4PositionTextBox.Size = new System.Drawing.Size(92, 25);
            this.perk4PositionTextBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label5.Location = new System.Drawing.Point(519, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "位置：";
            // 
            // perk4PageTextBox
            // 
            this.perk4PageTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.perk4PageTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.perk4PageTextBox.Location = new System.Drawing.Point(472, 165);
            this.perk4PageTextBox.Name = "perk4PageTextBox";
            this.perk4PageTextBox.ReadOnly = true;
            this.perk4PageTextBox.Size = new System.Drawing.Size(31, 25);
            this.perk4PageTextBox.TabIndex = 35;
            this.perk4PageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label6.Location = new System.Drawing.Point(404, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 34;
            this.label6.Text = "ページ：";
            // 
            // perk3PositionTextBox
            // 
            this.perk3PositionTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.perk3PositionTextBox.Location = new System.Drawing.Point(231, 165);
            this.perk3PositionTextBox.Name = "perk3PositionTextBox";
            this.perk3PositionTextBox.ReadOnly = true;
            this.perk3PositionTextBox.Size = new System.Drawing.Size(92, 25);
            this.perk3PositionTextBox.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label7.Location = new System.Drawing.Point(172, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 18);
            this.label7.TabIndex = 32;
            this.label7.Text = "位置：";
            // 
            // perk3PageTextBox
            // 
            this.perk3PageTextBox.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.perk3PageTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.perk3PageTextBox.Location = new System.Drawing.Point(125, 165);
            this.perk3PageTextBox.Name = "perk3PageTextBox";
            this.perk3PageTextBox.ReadOnly = true;
            this.perk3PageTextBox.Size = new System.Drawing.Size(31, 25);
            this.perk3PageTextBox.TabIndex = 31;
            this.perk3PageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.label8.Location = new System.Drawing.Point(57, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 30;
            this.label8.Text = "ページ：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 370);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DBD パークルーレット";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton survivorRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton killerRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button startRouletteButton;
        private System.Windows.Forms.Label perk4Label;
        private System.Windows.Forms.Label perk3Label;
        private System.Windows.Forms.Label perk2Label;
        private System.Windows.Forms.Label perk1Label;
        private System.Windows.Forms.Button stopRouletteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox perk1PositionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox perk1PageTextBox;
        private System.Windows.Forms.TextBox perk2PositionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox perk2PageTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox perk4PositionTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox perk4PageTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox perk3PositionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox perk3PageTextBox;
        private System.Windows.Forms.Label label8;
    }
}

