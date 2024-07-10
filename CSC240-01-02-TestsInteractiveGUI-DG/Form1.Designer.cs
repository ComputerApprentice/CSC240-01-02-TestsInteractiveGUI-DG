namespace CSC240_01_02_TestsInteractiveGUI_DG
{
    partial class UxTestInteractiveFormDG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UxTestInteractiveFormDG));
            UxNumber1Label = new Label();
            UxNumber1Textbox = new TextBox();
            UxNumber2Label = new Label();
            UxNumber3Label = new Label();
            UxNumber4Label = new Label();
            UxNumber5Label = new Label();
            UxNumber2Textbox = new TextBox();
            UxNumber5Textbox = new TextBox();
            UxNumber4Textbox = new TextBox();
            UxNumber3Textbox = new TextBox();
            UxCalculateButton = new Button();
            UxOutputTextbox = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // UxNumber1Label
            // 
            UxNumber1Label.AutoSize = true;
            UxNumber1Label.Location = new Point(40, 25);
            UxNumber1Label.Name = "UxNumber1Label";
            UxNumber1Label.Size = new Size(65, 15);
            UxNumber1Label.TabIndex = 0;
            UxNumber1Label.Text = "Number 1-";
            // 
            // UxNumber1Textbox
            // 
            UxNumber1Textbox.Location = new Point(111, 22);
            UxNumber1Textbox.Name = "UxNumber1Textbox";
            UxNumber1Textbox.Size = new Size(32, 23);
            UxNumber1Textbox.TabIndex = 1;
            UxNumber1Textbox.TextChanged += UxNumber1Textbox_TextChanged;
            // 
            // UxNumber2Label
            // 
            UxNumber2Label.AutoSize = true;
            UxNumber2Label.Location = new Point(40, 62);
            UxNumber2Label.Name = "UxNumber2Label";
            UxNumber2Label.Size = new Size(65, 15);
            UxNumber2Label.TabIndex = 2;
            UxNumber2Label.Text = "Number 2-";
            // 
            // UxNumber3Label
            // 
            UxNumber3Label.AutoSize = true;
            UxNumber3Label.Location = new Point(40, 101);
            UxNumber3Label.Name = "UxNumber3Label";
            UxNumber3Label.Size = new Size(65, 15);
            UxNumber3Label.TabIndex = 3;
            UxNumber3Label.Text = "Number 3-";
            // 
            // UxNumber4Label
            // 
            UxNumber4Label.AutoSize = true;
            UxNumber4Label.Location = new Point(40, 136);
            UxNumber4Label.Name = "UxNumber4Label";
            UxNumber4Label.Size = new Size(65, 15);
            UxNumber4Label.TabIndex = 4;
            UxNumber4Label.Text = "Number 4-";
            // 
            // UxNumber5Label
            // 
            UxNumber5Label.AutoSize = true;
            UxNumber5Label.Location = new Point(40, 171);
            UxNumber5Label.Name = "UxNumber5Label";
            UxNumber5Label.Size = new Size(65, 15);
            UxNumber5Label.TabIndex = 5;
            UxNumber5Label.Text = "Number 5-";
            UxNumber5Label.Click += label4_Click;
            // 
            // UxNumber2Textbox
            // 
            UxNumber2Textbox.Location = new Point(111, 62);
            UxNumber2Textbox.Name = "UxNumber2Textbox";
            UxNumber2Textbox.Size = new Size(32, 23);
            UxNumber2Textbox.TabIndex = 6;
            // 
            // UxNumber5Textbox
            // 
            UxNumber5Textbox.Location = new Point(111, 168);
            UxNumber5Textbox.Name = "UxNumber5Textbox";
            UxNumber5Textbox.Size = new Size(32, 23);
            UxNumber5Textbox.TabIndex = 7;
            UxNumber5Textbox.TextChanged += textBox2_TextChanged;
            // 
            // UxNumber4Textbox
            // 
            UxNumber4Textbox.Location = new Point(111, 136);
            UxNumber4Textbox.Name = "UxNumber4Textbox";
            UxNumber4Textbox.Size = new Size(32, 23);
            UxNumber4Textbox.TabIndex = 9;
            // 
            // UxNumber3Textbox
            // 
            UxNumber3Textbox.Location = new Point(111, 101);
            UxNumber3Textbox.Name = "UxNumber3Textbox";
            UxNumber3Textbox.Size = new Size(32, 23);
            UxNumber3Textbox.TabIndex = 10;
            // 
            // UxCalculateButton
            // 
            UxCalculateButton.Location = new Point(40, 223);
            UxCalculateButton.Name = "UxCalculateButton";
            UxCalculateButton.Size = new Size(120, 55);
            UxCalculateButton.TabIndex = 11;
            UxCalculateButton.Text = "Click me to Figure Out Average of all Numbers";
            UxCalculateButton.UseVisualStyleBackColor = true;
            UxCalculateButton.Click += button1_Click;
            // 
            // UxOutputTextbox
            // 
            UxOutputTextbox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UxOutputTextbox.Location = new Point(43, 386);
            UxOutputTextbox.Name = "UxOutputTextbox";
            UxOutputTextbox.Size = new Size(100, 21);
            UxOutputTextbox.TabIndex = 12;
            UxOutputTextbox.TextChanged += UxOutputTextbox_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(65, 284);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(62, 86);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // UxTestInteractiveFormDG
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(182, 450);
            Controls.Add(pictureBox2);
            Controls.Add(UxOutputTextbox);
            Controls.Add(UxCalculateButton);
            Controls.Add(UxNumber3Textbox);
            Controls.Add(UxNumber4Textbox);
            Controls.Add(UxNumber5Textbox);
            Controls.Add(UxNumber2Textbox);
            Controls.Add(UxNumber5Label);
            Controls.Add(UxNumber4Label);
            Controls.Add(UxNumber3Label);
            Controls.Add(UxNumber2Label);
            Controls.Add(UxNumber1Textbox);
            Controls.Add(UxNumber1Label);
            Name = "UxTestInteractiveFormDG";
            Text = "Test Interactive DG";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UxNumber1Label;
        private TextBox UxNumber1Textbox;
        private Label UxNumber2Label;
        private Label UxNumber3Label;
        private Label UxNumber4Label;
        private Label UxNumber5Label;
        private TextBox UxNumber2Textbox;
        private TextBox UxNumber5Textbox;
        private TextBox UxNumber4Textbox;
        private TextBox UxNumber3Textbox;
        private Button UxCalculateButton;
        private TextBox UxOutputTextbox;
        private PictureBox pictureBox2;
    }
}
