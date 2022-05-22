
namespace Restaurant_AD0557
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIceCream = new System.Windows.Forms.Button();
            this.btnTheoffers = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnTheDrinks = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.iceControl1 = new Restaurant_AD0557.IceControl();
            this.theDrinkControl1 = new Restaurant_AD0557.TheDrinkControl();
            this.secControl1 = new Restaurant_AD0557.secControl();
            this.firstControl1 = new Restaurant_AD0557.firstControl();
            this.btnTotalPrice = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnIceCream);
            this.panel1.Controls.Add(this.btnTheoffers);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMain);
            this.panel1.Location = new System.Drawing.Point(60, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 123);
            this.panel1.TabIndex = 0;
            // 
            // btnIceCream
            // 
            this.btnIceCream.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIceCream.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnIceCream.Location = new System.Drawing.Point(508, 63);
            this.btnIceCream.Name = "btnIceCream";
            this.btnIceCream.Size = new System.Drawing.Size(145, 44);
            this.btnIceCream.TabIndex = 6;
            this.btnIceCream.Text = "Ice Cream";
            this.btnIceCream.UseVisualStyleBackColor = true;
            this.btnIceCream.Click += new System.EventHandler(this.btnIceCream_Click);
            // 
            // btnTheoffers
            // 
            this.btnTheoffers.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTheoffers.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheoffers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTheoffers.Location = new System.Drawing.Point(243, 63);
            this.btnTheoffers.Name = "btnTheoffers";
            this.btnTheoffers.Size = new System.Drawing.Size(116, 44);
            this.btnTheoffers.TabIndex = 2;
            this.btnTheoffers.Text = "The Offers";
            this.btnTheoffers.UseVisualStyleBackColor = true;
            this.btnTheoffers.Click += new System.EventHandler(this.btnTheoffers_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(376, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnMain
            // 
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMain.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMain.Location = new System.Drawing.Point(243, 13);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(116, 44);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "Main";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnTheDrinks
            // 
            this.btnTheDrinks.Font = new System.Drawing.Font("Elephant", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheDrinks.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTheDrinks.Location = new System.Drawing.Point(568, 25);
            this.btnTheDrinks.Name = "btnTheDrinks";
            this.btnTheDrinks.Size = new System.Drawing.Size(145, 44);
            this.btnTheDrinks.TabIndex = 3;
            this.btnTheDrinks.Text = "The Drinks";
            this.btnTheDrinks.UseVisualStyleBackColor = true;
            this.btnTheDrinks.Click += new System.EventHandler(this.btnTheDrinks_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Elephant", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(999, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iceControl1
            // 
            this.iceControl1.Location = new System.Drawing.Point(60, 141);
            this.iceControl1.Name = "iceControl1";
            this.iceControl1.Size = new System.Drawing.Size(933, 438);
            this.iceControl1.TabIndex = 6;
            // 
            // theDrinkControl1
            // 
            this.theDrinkControl1.Location = new System.Drawing.Point(60, 141);
            this.theDrinkControl1.Name = "theDrinkControl1";
            this.theDrinkControl1.Size = new System.Drawing.Size(933, 438);
            this.theDrinkControl1.TabIndex = 5;
            // 
            // secControl1
            // 
            this.secControl1.Location = new System.Drawing.Point(60, 141);
            this.secControl1.Name = "secControl1";
            this.secControl1.Size = new System.Drawing.Size(933, 438);
            this.secControl1.TabIndex = 2;
            // 
            // firstControl1
            // 
            this.firstControl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.firstControl1.Location = new System.Drawing.Point(60, 141);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(933, 438);
            this.firstControl1.TabIndex = 1;
            // 
            // btnTotalPrice
            // 
            this.btnTotalPrice.BackColor = System.Drawing.Color.Gold;
            this.btnTotalPrice.Font = new System.Drawing.Font("Elephant", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalPrice.Location = new System.Drawing.Point(350, 585);
            this.btnTotalPrice.Name = "btnTotalPrice";
            this.btnTotalPrice.Size = new System.Drawing.Size(254, 64);
            this.btnTotalPrice.TabIndex = 7;
            this.btnTotalPrice.Text = "Total The Price";
            this.btnTotalPrice.UseVisualStyleBackColor = false;
            this.btnTotalPrice.Click += new System.EventHandler(this.btnTotalPrice_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 651);
            this.Controls.Add(this.btnTotalPrice);
            this.Controls.Add(this.iceControl1);
            this.Controls.Add(this.btnTheDrinks);
            this.Controls.Add(this.theDrinkControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.secControl1);
            this.Controls.Add(this.firstControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "MenuRestaruant";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnTheDrinks;
        private System.Windows.Forms.Button btnTheoffers;
        private firstControl firstControl1;
        private secControl secControl1;
        private System.Windows.Forms.Button btnClose;
        private TheDrinkControl theDrinkControl1;
        private System.Windows.Forms.Button btnIceCream;
        private IceControl iceControl1;
        private System.Windows.Forms.Button btnTotalPrice;
    }
}