namespace PWDB_zad3_1
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
            pictureBox1 = new PictureBox();
            cropButton = new Button();
            scaleButton = new Button();
            mirrorButton = new Button();
            numericUpDownScale = new NumericUpDown();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            numericUpDownWidth = new NumericUpDown();
            loadButton = new Button();
            saveButton = new Button();
            label1 = new Label();
            button1 = new Button();
            rotateButton = new Button();
            label2 = new Label();
            numericUpDownHeight = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(31, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 400);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cropButton
            // 
            cropButton.Location = new Point(569, 258);
            cropButton.Name = "cropButton";
            cropButton.Size = new Size(94, 29);
            cropButton.TabIndex = 2;
            cropButton.Text = "Przytnij";
            cropButton.UseVisualStyleBackColor = true;
            cropButton.Click += cropButton_Click;
            // 
            // scaleButton
            // 
            scaleButton.Location = new Point(569, 302);
            scaleButton.Name = "scaleButton";
            scaleButton.Size = new Size(94, 29);
            scaleButton.TabIndex = 3;
            scaleButton.Text = "Skaluj";
            scaleButton.UseVisualStyleBackColor = true;
            scaleButton.Click += scaleButton_Click;
            // 
            // mirrorButton
            // 
            mirrorButton.Location = new Point(569, 349);
            mirrorButton.Name = "mirrorButton";
            mirrorButton.Size = new Size(94, 29);
            mirrorButton.TabIndex = 5;
            mirrorButton.Text = "Lustrzane odbicie";
            mirrorButton.UseVisualStyleBackColor = true;
            mirrorButton.Click += mirrorButton_Click;
            // 
            // numericUpDownScale
            // 
            numericUpDownScale.Location = new Point(706, 302);
            numericUpDownScale.Name = "numericUpDownScale";
            numericUpDownScale.Size = new Size(74, 27);
            numericUpDownScale.TabIndex = 7;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(812, 260);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(75, 27);
            numericUpDownWidth.TabIndex = 8;
            // 
            // loadButton
            // 
            loadButton.Location = new Point(569, 67);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(94, 29);
            loadButton.TabIndex = 9;
            loadButton.Text = "Otwórz plik";
            loadButton.UseVisualStyleBackColor = true;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(569, 112);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(94, 29);
            saveButton.TabIndex = 10;
            saveButton.Text = "Zapisz plik";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(706, 230);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 11;
            label1.Text = "Wysokość";
            // 
            // button1
            // 
            button1.Location = new Point(569, 393);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Obróć";
            button1.UseVisualStyleBackColor = true;
            // 
            // rotateButton
            // 
            rotateButton.Location = new Point(569, 393);
            rotateButton.Name = "rotateButton";
            rotateButton.Size = new Size(94, 29);
            rotateButton.TabIndex = 4;
            rotateButton.Text = "Obróć";
            rotateButton.UseVisualStyleBackColor = true;
            rotateButton.Click += rotateButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(812, 230);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "Szerokość";
            // 
            // numericUpDownHeight
            // 
            numericUpDownHeight.Location = new Point(706, 260);
            numericUpDownHeight.Name = "numericUpDownHeight";
            numericUpDownHeight.Size = new Size(74, 27);
            numericUpDownHeight.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 472);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(saveButton);
            Controls.Add(loadButton);
            Controls.Add(numericUpDownWidth);
            Controls.Add(numericUpDownScale);
            Controls.Add(numericUpDownHeight);
            Controls.Add(mirrorButton);
            Controls.Add(rotateButton);
            Controls.Add(button1);
            Controls.Add(scaleButton);
            Controls.Add(cropButton);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScale).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHeight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button cropButton;
        private Button scaleButton;
        private Button mirrorButton;
        private NumericUpDown numericUpDownScale;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private NumericUpDown numericUpDownWidth;
        private Button loadButton;
        private Button saveButton;
        private Label label1;
        private Button button1;
        private Button rotateButton;
        private Label label2;
        private NumericUpDown numericUpDownHeight;
    }
}
