namespace Vet_Clinic
{
    partial class NewPet
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
            NewPetTitle = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            NameValidation = new Label();
            BreedValidation = new Label();
            MedicalValidation = new Label();
            WeightValidation = new Label();
            ColorValidation = new Label();
            ImageValidation = new Label();
            FavouriteToyValidation = new Label();
            SuspendLayout();
            // 
            // NewPetTitle
            // 
            NewPetTitle.AutoSize = true;
            NewPetTitle.Font = new Font("Ravie", 30F, FontStyle.Bold, GraphicsUnit.Point);
            NewPetTitle.ForeColor = Color.White;
            NewPetTitle.Location = new Point(300, 9);
            NewPetTitle.Name = "NewPetTitle";
            NewPetTitle.Size = new Size(306, 66);
            NewPetTitle.TabIndex = 0;
            NewPetTitle.Text = "New Pet";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.White;
            radioButton1.Location = new Point(180, 94);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(73, 33);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Dog";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.White;
            radioButton2.Location = new Point(288, 94);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 33);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Cat";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(89, 160);
            label1.Name = "label1";
            label1.Size = new Size(77, 33);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 221);
            label2.Name = "label2";
            label2.Size = new Size(107, 33);
            label2.TabIndex = 4;
            label2.Text = "Birthday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(89, 271);
            label3.Name = "label3";
            label3.Size = new Size(77, 33);
            label3.TabIndex = 5;
            label3.Text = "Breed";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Text", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 320);
            label4.Name = "label4";
            label4.Size = new Size(185, 33);
            label4.TabIndex = 6;
            label4.Text = "Medical History";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(451, 160);
            label5.Name = "label5";
            label5.Size = new Size(87, 31);
            label5.TabIndex = 7;
            label5.Text = "Weight";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(460, 223);
            label6.Name = "label6";
            label6.Size = new Size(68, 31);
            label6.TabIndex = 8;
            label6.Text = "Color";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(450, 281);
            label7.Name = "label7";
            label7.Size = new Size(78, 31);
            label7.TabIndex = 9;
            label7.Text = "Image";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(436, 330);
            label8.Name = "label8";
            label8.Size = new Size(134, 31);
            label8.TabIndex = 10;
            label8.Text = "Favorite Toy";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(181, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 281);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 330);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(219, 99);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(545, 169);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 23);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(546, 223);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(250, 23);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(546, 281);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(250, 23);
            textBox6.TabIndex = 6;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(578, 330);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(250, 23);
            textBox7.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSlateGray;
            button1.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(578, 396);
            button1.Name = "button1";
            button1.Size = new Size(164, 45);
            button1.TabIndex = 15;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // NameValidation
            // 
            NameValidation.AutoSize = true;
            NameValidation.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            NameValidation.ForeColor = Color.Red;
            NameValidation.Location = new Point(128, 195);
            NameValidation.Name = "NameValidation";
            NameValidation.Size = new Size(302, 16);
            NameValidation.TabIndex = 16;
            NameValidation.Text = "Name should be at least 3 characters long!";
            // 
            // BreedValidation
            // 
            BreedValidation.AutoSize = true;
            BreedValidation.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            BreedValidation.ForeColor = Color.Red;
            BreedValidation.Location = new Point(128, 307);
            BreedValidation.Name = "BreedValidation";
            BreedValidation.Size = new Size(303, 16);
            BreedValidation.TabIndex = 17;
            BreedValidation.Text = "Breed should be at least 5 characters long!\r\n";
            // 
            // MedicalValidation
            // 
            MedicalValidation.AutoSize = true;
            MedicalValidation.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            MedicalValidation.ForeColor = Color.Red;
            MedicalValidation.Location = new Point(57, 432);
            MedicalValidation.Name = "MedicalValidation";
            MedicalValidation.Size = new Size(374, 16);
            MedicalValidation.TabIndex = 18;
            MedicalValidation.Text = "Medical history should be at least 10 characters long!";
            // 
            // WeightValidation
            // 
            WeightValidation.AutoSize = true;
            WeightValidation.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            WeightValidation.ForeColor = Color.Red;
            WeightValidation.Location = new Point(616, 195);
            WeightValidation.Name = "WeightValidation";
            WeightValidation.Size = new Size(116, 16);
            WeightValidation.TabIndex = 19;
            WeightValidation.Text = "Wight is invalid!\r\n";
            // 
            // ColorValidation
            // 
            ColorValidation.AutoSize = true;
            ColorValidation.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ColorValidation.ForeColor = Color.Red;
            ColorValidation.Location = new Point(616, 249);
            ColorValidation.Name = "ColorValidation";
            ColorValidation.Size = new Size(126, 16);
            ColorValidation.TabIndex = 20;
            ColorValidation.Text = "Color is required!\r\n";
            // 
            // ImageValidation
            // 
            ImageValidation.AutoSize = true;
            ImageValidation.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            ImageValidation.ForeColor = Color.Red;
            ImageValidation.Location = new Point(616, 307);
            ImageValidation.Name = "ImageValidation";
            ImageValidation.Size = new Size(132, 16);
            ImageValidation.TabIndex = 21;
            ImageValidation.Text = "Image is required!\r\n";
            // 
            // FavouriteToyValidation
            // 
            FavouriteToyValidation.AutoSize = true;
            FavouriteToyValidation.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            FavouriteToyValidation.ForeColor = Color.Red;
            FavouriteToyValidation.Location = new Point(616, 356);
            FavouriteToyValidation.Name = "FavouriteToyValidation";
            FavouriteToyValidation.Size = new Size(171, 16);
            FavouriteToyValidation.TabIndex = 22;
            FavouriteToyValidation.Text = "Favorite toy is required!\r\n";
            // 
            // NewPet
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(882, 453);
            Controls.Add(FavouriteToyValidation);
            Controls.Add(ImageValidation);
            Controls.Add(ColorValidation);
            Controls.Add(WeightValidation);
            Controls.Add(MedicalValidation);
            Controls.Add(BreedValidation);
            Controls.Add(NameValidation);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(NewPetTitle);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "NewPet";
            Text = "NewPet";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NewPetTitle;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label NameValidation;
        private Label BreedValidation;
        private Label MedicalValidation;
        private Label WeightValidation;
        private Label ColorValidation;
        private Label ImageValidation;
        private Label FavouriteToyValidation;
    }
}