
namespace ProductPage
{
    partial class frmProductPage
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.imgProductImage = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnDecrease = new System.Windows.Forms.Button();
            this.btnIncrease = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.checkBoxConditionsAgreement = new System.Windows.Forms.CheckBox();
            this.rdbtnSelf = new System.Windows.Forms.RadioButton();
            this.rdbtnGift = new System.Windows.Forms.RadioButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.rtxtNote = new System.Windows.Forms.RichTextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.linklblDetailedInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProductName.Location = new System.Drawing.Point(321, 24);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(381, 24);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Lord of the Rings Book Set Turkish";
            // 
            // imgProductImage
            // 
            this.imgProductImage.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgProductImage.Image = global::ProductPage.Properties.Resources.product_image;
            this.imgProductImage.InitialImage = null;
            this.imgProductImage.Location = new System.Drawing.Point(38, 24);
            this.imgProductImage.Name = "imgProductImage";
            this.imgProductImage.Size = new System.Drawing.Size(239, 251);
            this.imgProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProductImage.TabIndex = 1;
            this.imgProductImage.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(419, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(116, 25);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "203.53 USD";
            // 
            // btnDecrease
            // 
            this.btnDecrease.Location = new System.Drawing.Point(548, 148);
            this.btnDecrease.Name = "btnDecrease";
            this.btnDecrease.Size = new System.Drawing.Size(44, 23);
            this.btnDecrease.TabIndex = 3;
            this.btnDecrease.Text = "-";
            this.btnDecrease.UseVisualStyleBackColor = true;
            // 
            // btnIncrease
            // 
            this.btnIncrease.Location = new System.Drawing.Point(438, 148);
            this.btnIncrease.Name = "btnIncrease";
            this.btnIncrease.Size = new System.Drawing.Size(45, 23);
            this.btnIncrease.TabIndex = 4;
            this.btnIncrease.Text = "+";
            this.btnIncrease.UseVisualStyleBackColor = true;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(408, 356);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(88, 23);
            this.btnAddToCart.TabIndex = 5;
            this.btnAddToCart.Text = "Add to Card";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            // 
            // checkBoxConditionsAgreement
            // 
            this.checkBoxConditionsAgreement.AutoSize = true;
            this.checkBoxConditionsAgreement.Location = new System.Drawing.Point(408, 279);
            this.checkBoxConditionsAgreement.Name = "checkBoxConditionsAgreement";
            this.checkBoxConditionsAgreement.Size = new System.Drawing.Size(271, 19);
            this.checkBoxConditionsAgreement.TabIndex = 6;
            this.checkBoxConditionsAgreement.Text = "I understand and accept rights and conditions.";
            this.checkBoxConditionsAgreement.UseVisualStyleBackColor = true;
            // 
            // rdbtnSelf
            // 
            this.rdbtnSelf.AutoSize = true;
            this.rdbtnSelf.Location = new System.Drawing.Point(408, 213);
            this.rdbtnSelf.Name = "rdbtnSelf";
            this.rdbtnSelf.Size = new System.Drawing.Size(62, 19);
            this.rdbtnSelf.TabIndex = 7;
            this.rdbtnSelf.TabStop = true;
            this.rdbtnSelf.Text = "For Me";
            this.rdbtnSelf.UseVisualStyleBackColor = true;
            // 
            // rdbtnGift
            // 
            this.rdbtnGift.AutoSize = true;
            this.rdbtnGift.Location = new System.Drawing.Point(518, 213);
            this.rdbtnGift.Name = "rdbtnGift";
            this.rdbtnGift.Size = new System.Drawing.Size(89, 19);
            this.rdbtnGift.TabIndex = 8;
            this.rdbtnGift.TabStop = true;
            this.rdbtnGift.Text = "As a Present";
            this.rdbtnGift.UseVisualStyleBackColor = true;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(509, 141);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(13, 15);
            this.lblQuantity.TabIndex = 9;
            this.lblQuantity.Text = "1";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(494, 156);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(48, 15);
            this.lblAdet.TabIndex = 10;
            this.lblAdet.Text = "Piece(s)";
            // 
            // rtxtNote
            // 
            this.rtxtNote.Location = new System.Drawing.Point(38, 333);
            this.rtxtNote.Name = "rtxtNote";
            this.rtxtNote.Size = new System.Drawing.Size(254, 96);
            this.rtxtNote.TabIndex = 13;
            this.rtxtNote.Text = "";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(38, 301);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(63, 15);
            this.lblNote.TabIndex = 14;
            this.lblNote.Text = "Your Note:";
            // 
            // linklblDetailedInfo
            // 
            this.linklblDetailedInfo.AutoSize = true;
            this.linklblDetailedInfo.Location = new System.Drawing.Point(408, 319);
            this.linklblDetailedInfo.Name = "linklblDetailedInfo";
            this.linklblDetailedInfo.Size = new System.Drawing.Size(138, 15);
            this.linklblDetailedInfo.TabIndex = 15;
            this.linklblDetailedInfo.TabStop = true;
            this.linklblDetailedInfo.Text = "For detailed information.";
            // 
            // frmProductPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(766, 469);
            this.Controls.Add(this.linklblDetailedInfo);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.rtxtNote);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.rdbtnGift);
            this.Controls.Add(this.rdbtnSelf);
            this.Controls.Add(this.checkBoxConditionsAgreement);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnIncrease);
            this.Controls.Add(this.btnDecrease);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.imgProductImage);
            this.Controls.Add(this.lblProductName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmProductPage";
            this.Text = "ProductPage";
            ((System.ComponentModel.ISupportInitialize)(this.imgProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.PictureBox imgProductImage;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.CheckBox checkBoxConditionsAgreement;
        private System.Windows.Forms.RadioButton rdbtnSelf;
        private System.Windows.Forms.RadioButton rdbtnGift;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.RichTextBox rtxtNote;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.LinkLabel linklblDetailedInfo;
    }
}

