using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Customer_View_Classes
{
    public class clsUserCart
    {

        public List<clsItem> lstUserCart = new List<clsItem>();
        public int orderID;

        public decimal Subtotal { get; set; }
        public decimal Discount { get; set; }
        public decimal DiscountedTotal { get; set; }
        public decimal Tax { get; set; }
        public decimal Total { get; set; }
        public int TotalItems { get; set; }

        public void AddNewItem(clsInventory inventory, clsShoeSize size, int quantityUserBought)
        {
            // if item and the size is same then just increase the size
            clsItem tempItem = lstUserCart.Find(x => x.inventory == inventory && x.size == size);
            
            if(tempItem != null)
            {
                tempItem.quantity += quantityUserBought;
            } else
            {
                clsItem item = new clsItem(inventory, size, quantityUserBought);
                lstUserCart.Add(item);
            }

            // update prices and other
            Subtotal += (inventory.decCost * quantityUserBought);
            Tax = Subtotal * (decimal)0.0825;
            Total = Subtotal + Tax;
            TotalItems += quantityUserBought;
        }

        internal void ChangeQuantity(clsItem item, decimal quantity)
        {
            // check if user subtracted the item or added the item
            if(item.quantity > quantity)
            {
                // user subtracted
                Subtotal -= item.inventory.decCost * (item.quantity - quantity);
                TotalItems -= (int)(item.quantity - quantity);
            }
            else
            {
                // user added the item
                Subtotal += item.inventory.decCost * (quantity - item.quantity);
                TotalItems += (int)(quantity - item.quantity);
            }

            Tax = Subtotal * (decimal)0.0825;
            Total = Subtotal + Tax;

            // change the quantity here
            item.quantity = (int)quantity;

        }

        internal void DeleteItem(clsItem item)
        {
            try
            {
                lstUserCart.Remove(item);

                // update pricing/subtotal etc
                Subtotal -= (item.inventory.decCost * item.quantity);
                Tax = Subtotal * (decimal)0.0825;
                Total = Subtotal + Tax;
                TotalItems -= item.quantity;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot Delete. See error below:\n\n" + ex.Message, "Error Deleting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    public class clsItem
    {
        public clsInventory inventory;
        public clsShoeSize size;
        public int quantity;

        public clsItem(clsInventory inventory, clsShoeSize size, int quantity)
        {
            this.inventory = inventory;
            this.size = size;
            this.quantity = quantity;
        }
    }
}
