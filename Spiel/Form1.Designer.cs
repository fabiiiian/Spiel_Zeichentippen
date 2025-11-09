namespace Spiel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StartButton = new Button();
            StopButton = new Button();
            ZeichenLabel = new Label();
            Easyradiobutton = new RadioButton();
            MediumradioButton = new RadioButton();
            Hardradiobutton = new RadioButton();
            label1 = new Label();
            Restzeichenlabel = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.Location = new Point(236, 58);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(113, 47);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // StopButton
            // 
            StopButton.Enabled = false;
            StopButton.Location = new Point(431, 61);
            StopButton.Name = "StopButton";
            StopButton.Size = new Size(113, 44);
            StopButton.TabIndex = 1;
            StopButton.Text = "Stop";
            StopButton.UseVisualStyleBackColor = true;
            StopButton.Click += StopButton_Click;
            // 
            // ZeichenLabel
            // 
            ZeichenLabel.BorderStyle = BorderStyle.FixedSingle;
            ZeichenLabel.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ZeichenLabel.Location = new Point(282, 241);
            ZeichenLabel.Name = "ZeichenLabel";
            ZeichenLabel.Size = new Size(178, 138);
            ZeichenLabel.TabIndex = 2;
            ZeichenLabel.Text = "&";
            ZeichenLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // Easyradiobutton
            // 
            Easyradiobutton.AutoSize = true;
            Easyradiobutton.Checked = true;
            Easyradiobutton.Location = new Point(396, 157);
            Easyradiobutton.Name = "Easyradiobutton";
            Easyradiobutton.Size = new Size(64, 19);
            Easyradiobutton.TabIndex = 3;
            Easyradiobutton.TabStop = true;
            Easyradiobutton.Text = "Einfach";
            Easyradiobutton.UseVisualStyleBackColor = true;
            // 
            // MediumradioButton
            // 
            MediumradioButton.AutoSize = true;
            MediumradioButton.Location = new Point(396, 182);
            MediumradioButton.Name = "MediumradioButton";
            MediumradioButton.Size = new Size(56, 19);
            MediumradioButton.TabIndex = 4;
            MediumradioButton.Text = "Mittel";
            MediumradioButton.UseVisualStyleBackColor = true;
            // 
            // Hardradiobutton
            // 
            Hardradiobutton.AutoSize = true;
            Hardradiobutton.Location = new Point(396, 207);
            Hardradiobutton.Name = "Hardradiobutton";
            Hardradiobutton.Size = new Size(76, 19);
            Hardradiobutton.TabIndex = 5;
            Hardradiobutton.Text = "Schwierig";
            Hardradiobutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(236, 159);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 6;
            label1.Text = "Schwierigkeitsgrad:";
            // 
            // Restzeichenlabel
            // 
            Restzeichenlabel.AutoSize = true;
            Restzeichenlabel.Location = new Point(506, 297);
            Restzeichenlabel.Name = "Restzeichenlabel";
            Restzeichenlabel.Size = new Size(0, 15);
            Restzeichenlabel.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Restzeichenlabel);
            Controls.Add(label1);
            Controls.Add(Hardradiobutton);
            Controls.Add(MediumradioButton);
            Controls.Add(Easyradiobutton);
            Controls.Add(ZeichenLabel);
            Controls.Add(StopButton);
            Controls.Add(StartButton);
            KeyPreview = true;
            Name = "Form1";
            Text = "Ziffern tippen";
            KeyPress += Form1_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Button StopButton;
        private Label ZeichenLabel;
        private RadioButton Easyradiobutton;
        private RadioButton MediumradioButton;
        private RadioButton Hardradiobutton;
        private Label label1;
        private Label Restzeichenlabel;
    }
}
