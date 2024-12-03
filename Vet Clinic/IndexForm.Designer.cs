namespace Vet_Clinic
{
    partial class IndexForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            label1 = new Label();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            AddPetButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Ravie", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(287, 21);
            label1.Name = "label1";
            label1.Size = new Size(333, 66);
            label1.TabIndex = 0;
            label1.Text = "VetClinic";
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(39, 117);
            listView1.Name = "listView1";
            listView1.Size = new Size(797, 284);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += OnLoad;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "cat");
            imageList1.Images.SetKeyName(1, "dog icon.png");
            // 
            // AddPetButton
            // 
            AddPetButton.BackColor = Color.DarkSlateGray;
            AddPetButton.Cursor = Cursors.Hand;
            AddPetButton.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            AddPetButton.ForeColor = Color.White;
            AddPetButton.Location = new Point(645, 433);
            AddPetButton.Name = "AddPetButton";
            AddPetButton.Size = new Size(191, 62);
            AddPetButton.TabIndex = 2;
            AddPetButton.Text = "Add New Pet\r\n";
            AddPetButton.UseVisualStyleBackColor = false;
            AddPetButton.Click += AddPetButton_Click;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(882, 533);
            Controls.Add(AddPetButton);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "IndexForm";
            Text = "Form1";
            Load += OLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ImageList imageList1;
        private Button AddPetButton;
    }
}
