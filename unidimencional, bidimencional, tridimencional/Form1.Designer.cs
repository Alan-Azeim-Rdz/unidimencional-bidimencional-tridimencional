namespace unidimencional__bidimencional__tridimencional
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
            BtnShow = new Button();
            ListArray1 = new ListView();
            BtnSave = new Button();
            TextDataNum = new TextBox();
            NumericElectionArray = new NumericUpDown();
            DataNum3 = new TextBox();
            DataNum2 = new TextBox();
            LabelInstruction = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)NumericElectionArray).BeginInit();
            SuspendLayout();
            // 
            // BtnShow
            // 
            BtnShow.Location = new Point(98, 28);
            BtnShow.Name = "BtnShow";
            BtnShow.Size = new Size(101, 47);
            BtnShow.TabIndex = 0;
            BtnShow.Text = "show";
            BtnShow.UseVisualStyleBackColor = true;
            BtnShow.Click += BtnShow_Click;
            // 
            // ListArray1
            // 
            ListArray1.Location = new Point(52, 81);
            ListArray1.Name = "ListArray1";
            ListArray1.Size = new Size(207, 174);
            ListArray1.TabIndex = 2;
            ListArray1.UseCompatibleStateImageBehavior = false;
            // 
            // BtnSave
            // 
            BtnSave.Location = new Point(505, 108);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(101, 47);
            BtnSave.TabIndex = 3;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = true;
            BtnSave.Click += BtnSave_Click;
            // 
            // TextDataNum
            // 
            TextDataNum.Location = new Point(329, 64);
            TextDataNum.Multiline = true;
            TextDataNum.Name = "TextDataNum";
            TextDataNum.Size = new Size(131, 23);
            TextDataNum.TabIndex = 4;
            TextDataNum.TextAlign = HorizontalAlignment.Center;
            // 
            // NumericElectionArray
            // 
            NumericElectionArray.Location = new Point(505, 184);
            NumericElectionArray.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            NumericElectionArray.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumericElectionArray.Name = "NumericElectionArray";
            NumericElectionArray.ReadOnly = true;
            NumericElectionArray.Size = new Size(120, 23);
            NumericElectionArray.TabIndex = 5;
            NumericElectionArray.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumericElectionArray.ValueChanged += NumericElectionArray_ValueChanged;
            // 
            // DataNum3
            // 
            DataNum3.Location = new Point(657, 64);
            DataNum3.Multiline = true;
            DataNum3.Name = "DataNum3";
            DataNum3.Size = new Size(131, 23);
            DataNum3.TabIndex = 6;
            DataNum3.TextAlign = HorizontalAlignment.Center;
            // 
            // DataNum2
            // 
            DataNum2.Location = new Point(494, 64);
            DataNum2.Multiline = true;
            DataNum2.Name = "DataNum2";
            DataNum2.Size = new Size(131, 23);
            DataNum2.TabIndex = 7;
            DataNum2.TextAlign = HorizontalAlignment.Center;
            // 
            // LabelInstruction
            // 
            LabelInstruction.AutoSize = true;
            LabelInstruction.Location = new Point(543, 28);
            LabelInstruction.Name = "LabelInstruction";
            LabelInstruction.Size = new Size(31, 15);
            LabelInstruction.TabIndex = 8;
            LabelInstruction.Text = "Sum";
            LabelInstruction.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 226);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 9;
            label1.Text = "Number of array dimensions";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(710, 28);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 10;
            label2.Text = "rule of 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LabelInstruction);
            Controls.Add(DataNum2);
            Controls.Add(DataNum3);
            Controls.Add(NumericElectionArray);
            Controls.Add(TextDataNum);
            Controls.Add(BtnSave);
            Controls.Add(ListArray1);
            Controls.Add(BtnShow);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)NumericElectionArray).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnShow;
        private ListView ListArray1;
        private Button BtnSave;
        private TextBox TextDataNum;
        private NumericUpDown NumericElectionArray;
        private TextBox DataNum3;
        private TextBox DataNum2;
        private Label LabelInstruction;
        private Label label1;
        private Label label2;
    }
}
