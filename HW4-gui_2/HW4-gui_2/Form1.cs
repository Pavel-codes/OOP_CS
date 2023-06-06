using System.CodeDom.Compiler;
using System.Linq.Expressions;
using System.Windows.Forms.VisualStyles;

namespace HW4_gui_2
{
    public partial class FormShop : Form
    {

        ShoppingCart cart = new ShoppingCart();
        float[] pricesArr = new float[] { 200, 150, 100, 50 };
        public FormShop()
        {
            InitializeComponent();
            lblPrice.Text = cart.TotalPrice.ToString() + "$";
            comboBoxSize.DataSource = Enum.GetValues(typeof(MeasurementSize));
            comboBoxColor.DataSource = Enum.GetValues(typeof(ColorOfProduct));
            checkBoxIsProtective.Enabled = false;
            checkBoxCamera.Enabled = false;
            listShoppingCart.Items.Add("The cart is empty");
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                bool isChecked;
                if (radioBtnHelm.Checked)
                {
                    isChecked = checkBoxCamera.Checked;
                    Helmet item = new Helmet(radioBtnHelm.Text, pricesArr[0], (ColorOfProduct)comboBoxColor.SelectedItem, (MeasurementSize)comboBoxSize.SelectedItem, isChecked);
                    cart.AddItem(item);
                }
                else if (radioBtnJacket.Checked)
                {
                    isChecked = checkBoxIsProtective.Checked;
                    Clothing item = new Clothing(radioBtnJacket.Text, pricesArr[1], (ColorOfProduct)comboBoxColor.SelectedItem, (MeasurementSize)comboBoxSize.SelectedItem, isChecked);
                    cart.AddItem(item);
                }
                else if (radioBtnPants.Checked)
                {
                    isChecked = checkBoxIsProtective.Checked;
                    Clothing item = new Clothing(radioBtnPants.Text, pricesArr[2], (ColorOfProduct)comboBoxColor.SelectedItem, (MeasurementSize)comboBoxSize.SelectedItem, isChecked);
                    cart.AddItem(item);
                }
                else if (radioBtnGloves.Checked)
                {
                    isChecked = checkBoxIsProtective.Checked;
                    Clothing item = new Clothing(radioBtnGloves.Text, pricesArr[3], (ColorOfProduct)comboBoxColor.SelectedItem, (MeasurementSize)comboBoxSize.SelectedItem, isChecked);
                    cart.AddItem(item);
                }
                else
                {
                    throw new NoItemSelectedException("No item selected, please select an item");
                }
            }
            catch(NoItemSelectedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                lblPrice.Text = cart.TotalPrice.ToString() + "$";
                updateListBox();
            }
        }

        private void updateListBox()
        {
            if (cart.isEmpty())
            {
                listShoppingCart.Items.Clear();
                listShoppingCart.Items.Add("The cart is empty");
            }
            else
            {
                listShoppingCart.Items.Clear();
                listShoppingCart.Items.AddRange(cart.ItemsInCart);
            }
        }

        private void btnEmptyCart_Click(object sender, EventArgs e)
        {
            cart.EmptyCart();
            updateListBox();
            lblPrice.Text = cart.TotalPrice.ToString() + "$";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            txtBoxClock.Font = new Font("seguo UI", 9, FontStyle.Bold);
            txtBoxClock.Text = dateTime.ToString();
        }

        private void createTempItem()
        {
            bool isChecked;
            if (radioBtnHelm.Checked)
            {
                isChecked = checkBoxCamera.Checked;
                Helmet temp = new Helmet(radioBtnHelm.Text, pricesArr[0], (ColorOfProduct)comboBoxColor.SelectedItem, (MeasurementSize)comboBoxSize.SelectedItem, isChecked);
                lblPriceOfItem.Text = temp.Price.ToString() + "$";
            }
            else if(radioBtnJacket.Checked)
            {
                isChecked = checkBoxIsProtective.Checked;
                Clothing temp = new Clothing(radioBtnJacket.Text, pricesArr[1], (ColorOfProduct)comboBoxColor.SelectedItem, (MeasurementSize)comboBoxSize.SelectedItem, isChecked);
                lblPriceOfItem.Text = temp.Price.ToString() + "$";
            }
            else if (radioBtnPants.Checked)
            {
                isChecked = checkBoxIsProtective.Checked;
                Clothing temp = new Clothing(radioBtnPants.Text, pricesArr[2], (ColorOfProduct)comboBoxColor.SelectedItem, (MeasurementSize)comboBoxSize.SelectedItem, isChecked);
                lblPriceOfItem.Text = temp.Price.ToString() + "$";
            }
            else if(radioBtnGloves.Checked)
            {
                isChecked = checkBoxIsProtective.Checked;
                Clothing temp = new Clothing(radioBtnGloves.Text, pricesArr[3], (ColorOfProduct)comboBoxColor.SelectedItem, (MeasurementSize)comboBoxSize.SelectedItem, isChecked);
                lblPriceOfItem.Text = temp.Price.ToString() + "$";
            }
            else
            {
                throw new NoItemSelectedException("No item selected, please select an item");
            }
        }

        private void radioBtnHelm_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxIsProtective.Enabled = false;
            checkBoxCamera.Enabled = true;
        }

        private void radioBtnJacket_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxIsProtective.Enabled = true;
            checkBoxCamera.Enabled = false;
        }

        private void radioBtnGloves_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxIsProtective.Enabled = true;
            checkBoxCamera.Enabled = false;
        }

        private void radioBtnPants_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxIsProtective.Enabled = true;
            checkBoxCamera.Enabled = false;
        }

        private void btnPreviewPrice_Click(object sender, EventArgs e)
        {
            try
            {
                createTempItem();
            }
            catch (NoItemSelectedException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (listShoppingCart.SelectedItem == null)
                {
                    throw new NoItemSelectedException("No item selected, please select an item to delete");
                }
                else if(listShoppingCart.SelectedItem.ToString().Equals("The cart is empty"))
                {
                    throw new ArgumentNullException(string.Empty ,"Cannot remove items from empty cart");
                }
                else if (listShoppingCart.SelectedItem.ToString().Contains("Helmet"))
                {
                    cart.RemoveItem(cart.FindHelmet(listShoppingCart.SelectedItem.ToString()));
                    lblPrice.Text = cart.TotalPrice.ToString() + "$";
                }
                else
                {
                    cart.RemoveItem(cart.FindClothing(listShoppingCart.SelectedItem.ToString()));
                    lblPrice.Text = cart.TotalPrice.ToString() + "$";
                }
            }
            catch(NoItemSelectedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(ArgumentNullException ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            finally
            {
                updateListBox();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            string message = $"Total items {cart.TotalItems}\nTotal cost {cart.TotalPrice}$\nThank you for your purchase";
            DialogResult result;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            result = MessageBox.Show(message,"Checkout", buttons);
            if (result == DialogResult.OK)
            {
                cart.EmptyCart();
                updateListBox();
                lblPrice.Text = cart.TotalPrice.ToString() + "$";
            }
        }

        private void btnPreviewPrice_MouseHover(object sender, EventArgs e)
        {
            btnPreviewPrice.Font = new Font("seguo UI", 9, FontStyle.Bold);
        }

        private void btnPreviewPrice_MouseLeave(object sender, EventArgs e)
        {
            btnPreviewPrice.Font = new Font("seguo UI", 9, FontStyle.Regular);
        }

        private void btnCheckout_MouseHover(object sender, EventArgs e)
        {
            btnCheckout.Font = new Font("seguo UI", 10, FontStyle.Bold);
        }

        private void btnCheckout_MouseLeave(object sender, EventArgs e)
        {
            btnCheckout.Font = new Font("seguo UI", 9, FontStyle.Regular);
        }
    }
}