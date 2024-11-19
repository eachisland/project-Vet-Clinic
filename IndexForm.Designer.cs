namespace ProjectVetClinic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.labelTitle = new System.Windows.Forms.Label();
            this.listViewPets = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttonAddNewPet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(305, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(195, 57);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vet Clinic";
            // 
            // listViewPets
            // 
            this.listViewPets.LargeImageList = this.imageList1;
            this.listViewPets.Location = new System.Drawing.Point(107, 105);
            this.listViewPets.Name = "listViewPets";
            this.listViewPets.Size = new System.Drawing.Size(624, 270);
            this.listViewPets.SmallImageList = this.imageList1;
            this.listViewPets.TabIndex = 1;
            this.listViewPets.UseCompatibleStateImageBehavior = false;
            this.listViewPets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewPets_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-dog-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-cat-48.png");
            // 
            // buttonAddNewPet
            // 
            this.buttonAddNewPet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonAddNewPet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddNewPet.Location = new System.Drawing.Point(589, 398);
            this.buttonAddNewPet.Name = "buttonAddNewPet";
            this.buttonAddNewPet.Size = new System.Drawing.Size(142, 40);
            this.buttonAddNewPet.TabIndex = 2;
            this.buttonAddNewPet.Text = "Add New Pet";
            this.buttonAddNewPet.UseVisualStyleBackColor = false;

            this.buttonAddNewPet.Click += new System.EventHandler(this.buttonAddNewPet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAddNewPet);
            this.Controls.Add(this.listViewPets);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelTitle;
        private ListView listViewPets;
        private ImageList imageList1;
        private Button buttonAddNewPet;
    }
}