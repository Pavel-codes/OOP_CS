namespace HW4_gui_2
{
    partial class FormShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShop));
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnEmptyCart = new System.Windows.Forms.Button();
            this.grpCartControls = new System.Windows.Forms.GroupBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblShowPrice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtBoxClock = new System.Windows.Forms.TextBox();
            this.picTopRight = new System.Windows.Forms.PictureBox();
            this.picTopLeft = new System.Windows.Forms.PictureBox();
            this.Products = new System.Windows.Forms.GroupBox();
            this.btnPreviewPrice = new System.Windows.Forms.Button();
            this.lblPriceOfItem = new System.Windows.Forms.Label();
            this.checkBoxIsProtective = new System.Windows.Forms.CheckBox();
            this.checkBoxCamera = new System.Windows.Forms.CheckBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.labelProductColor = new System.Windows.Forms.Label();
            this.lblProductSize = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.radioBtnGloves = new System.Windows.Forms.RadioButton();
            this.radioBtnPants = new System.Windows.Forms.RadioButton();
            this.radioBtnJacket = new System.Windows.Forms.RadioButton();
            this.radioBtnHelm = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listShoppingCart = new System.Windows.Forms.ListBox();
            this.grpCartControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopLeft)).BeginInit();
            this.Products.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(72, 38);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(121, 43);
            this.btnAddItem.TabIndex = 0;
            this.btnAddItem.Text = "Add item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnEmptyCart
            // 
            this.btnEmptyCart.Location = new System.Drawing.Point(451, 38);
            this.btnEmptyCart.Name = "btnEmptyCart";
            this.btnEmptyCart.Size = new System.Drawing.Size(121, 43);
            this.btnEmptyCart.TabIndex = 1;
            this.btnEmptyCart.Text = "Empty Cart";
            this.btnEmptyCart.UseVisualStyleBackColor = true;
            this.btnEmptyCart.Click += new System.EventHandler(this.btnEmptyCart_Click);
            // 
            // grpCartControls
            // 
            this.grpCartControls.Controls.Add(this.btnCheckout);
            this.grpCartControls.Controls.Add(this.btnRemoveItem);
            this.grpCartControls.Controls.Add(this.lblPrice);
            this.grpCartControls.Controls.Add(this.lblShowPrice);
            this.grpCartControls.Controls.Add(this.btnEmptyCart);
            this.grpCartControls.Controls.Add(this.btnAddItem);
            this.grpCartControls.Location = new System.Drawing.Point(153, 373);
            this.grpCartControls.Name = "grpCartControls";
            this.grpCartControls.Size = new System.Drawing.Size(617, 160);
            this.grpCartControls.TabIndex = 2;
            this.grpCartControls.TabStop = false;
            this.grpCartControls.Text = "Cart actions";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(262, 99);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(121, 43);
            this.btnCheckout.TabIndex = 6;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            this.btnCheckout.MouseLeave += new System.EventHandler(this.btnCheckout_MouseLeave);
            this.btnCheckout.MouseHover += new System.EventHandler(this.btnCheckout_MouseHover);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(262, 38);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(121, 43);
            this.btnRemoveItem.TabIndex = 5;
            this.btnRemoveItem.Text = "Remove item";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(81, 132);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(13, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "0";
            // 
            // lblShowPrice
            // 
            this.lblShowPrice.AutoSize = true;
            this.lblShowPrice.Location = new System.Drawing.Point(8, 132);
            this.lblShowPrice.Name = "lblShowPrice";
            this.lblShowPrice.Size = new System.Drawing.Size(67, 15);
            this.lblShowPrice.TabIndex = 3;
            this.lblShowPrice.Text = "Total price :";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtBoxClock
            // 
            this.txtBoxClock.Location = new System.Drawing.Point(7, 510);
            this.txtBoxClock.Name = "txtBoxClock";
            this.txtBoxClock.ReadOnly = true;
            this.txtBoxClock.Size = new System.Drawing.Size(140, 23);
            this.txtBoxClock.TabIndex = 3;
            // 
            // picTopRight
            // 
            this.picTopRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTopRight.Image = ((System.Drawing.Image)(resources.GetObject("picTopRight.Image")));
            this.picTopRight.Location = new System.Drawing.Point(734, 12);
            this.picTopRight.Name = "picTopRight";
            this.picTopRight.Size = new System.Drawing.Size(158, 168);
            this.picTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopRight.TabIndex = 4;
            this.picTopRight.TabStop = false;
            // 
            // picTopLeft
            // 
            this.picTopLeft.BackColor = System.Drawing.SystemColors.Control;
            this.picTopLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picTopLeft.BackgroundImage")));
            this.picTopLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picTopLeft.Image = ((System.Drawing.Image)(resources.GetObject("picTopLeft.Image")));
            this.picTopLeft.Location = new System.Drawing.Point(12, 12);
            this.picTopLeft.Name = "picTopLeft";
            this.picTopLeft.Size = new System.Drawing.Size(159, 156);
            this.picTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTopLeft.TabIndex = 5;
            this.picTopLeft.TabStop = false;
            // 
            // Products
            // 
            this.Products.Controls.Add(this.btnPreviewPrice);
            this.Products.Controls.Add(this.lblPriceOfItem);
            this.Products.Controls.Add(this.checkBoxIsProtective);
            this.Products.Controls.Add(this.checkBoxCamera);
            this.Products.Controls.Add(this.comboBoxColor);
            this.Products.Controls.Add(this.labelProductColor);
            this.Products.Controls.Add(this.lblProductSize);
            this.Products.Controls.Add(this.comboBoxSize);
            this.Products.Controls.Add(this.radioBtnGloves);
            this.Products.Controls.Add(this.radioBtnPants);
            this.Products.Controls.Add(this.radioBtnJacket);
            this.Products.Controls.Add(this.radioBtnHelm);
            this.Products.Location = new System.Drawing.Point(187, 3);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(531, 230);
            this.Products.TabIndex = 6;
            this.Products.TabStop = false;
            this.Products.Text = "Products";
            // 
            // btnPreviewPrice
            // 
            this.btnPreviewPrice.Location = new System.Drawing.Point(110, 186);
            this.btnPreviewPrice.Name = "btnPreviewPrice";
            this.btnPreviewPrice.Size = new System.Drawing.Size(96, 33);
            this.btnPreviewPrice.TabIndex = 11;
            this.btnPreviewPrice.Text = "Show price";
            this.btnPreviewPrice.UseVisualStyleBackColor = true;
            this.btnPreviewPrice.Click += new System.EventHandler(this.btnPreviewPrice_Click);
            this.btnPreviewPrice.MouseLeave += new System.EventHandler(this.btnPreviewPrice_MouseLeave);
            this.btnPreviewPrice.MouseHover += new System.EventHandler(this.btnPreviewPrice_MouseHover);
            // 
            // lblPriceOfItem
            // 
            this.lblPriceOfItem.AutoSize = true;
            this.lblPriceOfItem.Location = new System.Drawing.Point(208, 198);
            this.lblPriceOfItem.Name = "lblPriceOfItem";
            this.lblPriceOfItem.Size = new System.Drawing.Size(74, 15);
            this.lblPriceOfItem.TabIndex = 10;
            this.lblPriceOfItem.Text = "Price of item";
            // 
            // checkBoxIsProtective
            // 
            this.checkBoxIsProtective.AutoSize = true;
            this.checkBoxIsProtective.Location = new System.Drawing.Point(252, 107);
            this.checkBoxIsProtective.Name = "checkBoxIsProtective";
            this.checkBoxIsProtective.Size = new System.Drawing.Size(90, 19);
            this.checkBoxIsProtective.TabIndex = 9;
            this.checkBoxIsProtective.Text = "Is protective";
            this.checkBoxIsProtective.UseVisualStyleBackColor = true;
            // 
            // checkBoxCamera
            // 
            this.checkBoxCamera.AutoSize = true;
            this.checkBoxCamera.Location = new System.Drawing.Point(252, 56);
            this.checkBoxCamera.Name = "checkBoxCamera";
            this.checkBoxCamera.Size = new System.Drawing.Size(128, 19);
            this.checkBoxCamera.TabIndex = 8;
            this.checkBoxCamera.Text = "Can mount camera";
            this.checkBoxCamera.UseVisualStyleBackColor = true;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.AllowDrop = true;
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Location = new System.Drawing.Point(110, 107);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(96, 23);
            this.comboBoxColor.TabIndex = 7;
            // 
            // labelProductColor
            // 
            this.labelProductColor.AutoSize = true;
            this.labelProductColor.Location = new System.Drawing.Point(139, 89);
            this.labelProductColor.Name = "labelProductColor";
            this.labelProductColor.Size = new System.Drawing.Size(91, 15);
            this.labelProductColor.TabIndex = 6;
            this.labelProductColor.Text = "ColorOfProduct";
            // 
            // lblProductSize
            // 
            this.lblProductSize.AutoSize = true;
            this.lblProductSize.Location = new System.Drawing.Point(139, 37);
            this.lblProductSize.Name = "lblProductSize";
            this.lblProductSize.Size = new System.Drawing.Size(27, 15);
            this.lblProductSize.TabIndex = 5;
            this.lblProductSize.Text = "Size";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.AllowDrop = true;
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(110, 56);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(96, 23);
            this.comboBoxSize.TabIndex = 4;
            // 
            // radioBtnGloves
            // 
            this.radioBtnGloves.AutoSize = true;
            this.radioBtnGloves.Location = new System.Drawing.Point(20, 88);
            this.radioBtnGloves.Name = "radioBtnGloves";
            this.radioBtnGloves.Size = new System.Drawing.Size(60, 19);
            this.radioBtnGloves.TabIndex = 3;
            this.radioBtnGloves.TabStop = true;
            this.radioBtnGloves.Text = "Gloves";
            this.radioBtnGloves.UseVisualStyleBackColor = true;
            this.radioBtnGloves.CheckedChanged += new System.EventHandler(this.radioBtnGloves_CheckedChanged);
            // 
            // radioBtnPants
            // 
            this.radioBtnPants.AutoSize = true;
            this.radioBtnPants.Location = new System.Drawing.Point(20, 113);
            this.radioBtnPants.Name = "radioBtnPants";
            this.radioBtnPants.Size = new System.Drawing.Size(54, 19);
            this.radioBtnPants.TabIndex = 2;
            this.radioBtnPants.TabStop = true;
            this.radioBtnPants.Text = "Pants";
            this.radioBtnPants.UseVisualStyleBackColor = true;
            this.radioBtnPants.CheckedChanged += new System.EventHandler(this.radioBtnPants_CheckedChanged);
            // 
            // radioBtnJacket
            // 
            this.radioBtnJacket.AutoSize = true;
            this.radioBtnJacket.Location = new System.Drawing.Point(20, 63);
            this.radioBtnJacket.Name = "radioBtnJacket";
            this.radioBtnJacket.Size = new System.Drawing.Size(57, 19);
            this.radioBtnJacket.TabIndex = 1;
            this.radioBtnJacket.TabStop = true;
            this.radioBtnJacket.Text = "Jacket";
            this.radioBtnJacket.UseVisualStyleBackColor = true;
            this.radioBtnJacket.CheckedChanged += new System.EventHandler(this.radioBtnJacket_CheckedChanged);
            // 
            // radioBtnHelm
            // 
            this.radioBtnHelm.AutoSize = true;
            this.radioBtnHelm.Location = new System.Drawing.Point(20, 38);
            this.radioBtnHelm.Name = "radioBtnHelm";
            this.radioBtnHelm.Size = new System.Drawing.Size(64, 19);
            this.radioBtnHelm.TabIndex = 0;
            this.radioBtnHelm.TabStop = true;
            this.radioBtnHelm.Text = "Helmet";
            this.radioBtnHelm.UseVisualStyleBackColor = true;
            this.radioBtnHelm.CheckedChanged += new System.EventHandler(this.radioBtnHelm_CheckedChanged);
            // 
            // listShoppingCart
            // 
            this.listShoppingCart.FormattingEnabled = true;
            this.listShoppingCart.ItemHeight = 15;
            this.listShoppingCart.Location = new System.Drawing.Point(231, 249);
            this.listShoppingCart.Name = "listShoppingCart";
            this.listShoppingCart.Size = new System.Drawing.Size(425, 109);
            this.listShoppingCart.TabIndex = 7;
            // 
            // FormShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 561);
            this.Controls.Add(this.listShoppingCart);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.picTopLeft);
            this.Controls.Add(this.picTopRight);
            this.Controls.Add(this.txtBoxClock);
            this.Controls.Add(this.grpCartControls);
            this.Name = "FormShop";
            this.Text = "Biker\'s accessories";
            this.grpCartControls.ResumeLayout(false);
            this.grpCartControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTopRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopLeft)).EndInit();
            this.Products.ResumeLayout(false);
            this.Products.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAddItem;
        private Button btnEmptyCart;
        private GroupBox grpCartControls;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtBoxClock;
        private PictureBox picTopRight;
        private PictureBox picTopLeft;
        private Label lblPrice;
        private Label lblShowPrice;
        private GroupBox Products;
        private RadioButton radioBtnGloves;
        private RadioButton radioBtnPants;
        private RadioButton radioBtnJacket;
        private RadioButton radioBtnHelm;
        private Label labelProductColor;
        private Label lblProductSize;
        private ComboBox comboBoxSize;
        private Label lblPriceOfItem;
        private CheckBox checkBoxIsProtective;
        private CheckBox checkBoxCamera;
        private ComboBox comboBoxColor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnPreviewPrice;
        private Button btnRemoveItem;
        private ListBox listShoppingCart;
        private Button btnCheckout;
    }
}