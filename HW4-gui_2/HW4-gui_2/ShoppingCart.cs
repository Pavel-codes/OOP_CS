using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_gui_2
{
    internal class ShoppingCart
    {
        private Clothing[] clothes;
        private Helmet[] helmets;
        private string[] itemsInCart;
        private static int totalItems = 0;
        private static float totalPrice = 0;

        public ShoppingCart()
        {
            clothes = new Clothing[1];
            helmets = new Helmet[1];
            itemsInCart = new string[1];
        }
        public int TotalItems 
        { 
            get { return totalItems; }
        }

        public string[] ItemsInCart 
        {
            get { return itemsInCart; }
        }

        public Helmet FindHelmet(string s)
        {
            foreach (Helmet item in helmets)
            {
                if (item.ToString().Equals(s)) return item;
                
            }
            return null;
        }

        public Clothing FindClothing(string s)
        {
            foreach (Clothing item in clothes)
            {
                if (item.ToString().Equals(s)) return item;

            }
            return null;
        }

        public float TotalPrice
        {
            get { return totalPrice; }
        }

        public void AddItem(Product p)
        {
            if (p is Helmet)
            {
                if (helmets[helmets.Length - 1] != null)
                {
                    totalItems++;
                    Helmet[] temp = new Helmet[helmets.Length + 1];
                    helmets.CopyTo(temp, 0);
                    temp[helmets.Length] = (Helmet)p;
                    Array.Resize(ref helmets, temp.Length);
                    Array.Resize(ref itemsInCart, TotalItems);
                    itemsInCart[itemsInCart.Length - 1] = p.ToString();
                    helmets = temp;
                    totalPrice += p.Price;
                }
                else
                {
                    totalItems++;
                    helmets[helmets.Length - 1] = (Helmet)p;
                    Array.Resize(ref itemsInCart, TotalItems);
                    itemsInCart[itemsInCart.Length-1] = p.ToString();
                    totalPrice += p.Price;
                }
            }
            else
            {
                if (clothes[clothes.Length - 1] != null)
                {
                    totalItems++;
                    Clothing[] temp = new Clothing[clothes.Length + 1];
                    clothes.CopyTo(temp, 0);
                    temp[clothes.Length] = (Clothing)p;
                    Array.Resize(ref clothes, temp.Length);
                    Array.Resize(ref itemsInCart, TotalItems);
                    itemsInCart[itemsInCart.Length - 1] = p.ToString();
                    clothes = temp;
                    totalPrice += p.Price;
                }
                else
                {
                    totalItems++;
                    clothes[clothes.Length - 1] = (Clothing)p;
                    Array.Resize(ref itemsInCart, TotalItems);
                    itemsInCart[itemsInCart.Length - 1] = p.ToString();
                    totalPrice += p.Price;
                }
            }
        }

        public void RemoveItem(Product p)
        {
            int idx = 0;
            int countItem = 0;
            if (p is Helmet)
            {
                string[] tempCart = new string[totalItems - 1];
                for (int i = 0; i < totalItems; i++)
                {
                    if (itemsInCart[i] == p.ToString() && countItem == 0)
                    {
                        countItem++;
                        continue;
                    }
                    tempCart[idx++] = itemsInCart[i];
                }
                if (helmets.Length == 1)
                {
                    Helmet[] tempHelmets = new Helmet[1];
                    helmets = tempHelmets;
                }
                else
                {
                    idx = 0;
                    Helmet[] temp = new Helmet[helmets.Length-1];
                    
                    for (int i = 0; i < helmets.Length; i++)
                    {
                        if (helmets[i] == p) continue;
                        temp[idx++] = helmets[i];
                    }
                    Array.Resize(ref helmets, temp.Length);
                    temp.CopyTo(helmets, 0);
                    
                }
                Array.Resize(ref itemsInCart, tempCart.Length);
                tempCart.CopyTo(itemsInCart, 0);
                totalPrice -= p.Price;
                totalItems--;
            }
            else
            {
                string[] tempCart = new string[totalItems - 1];
                for (int i = 0; i < totalItems; i++)
                {
                    if (itemsInCart[i] == p.ToString() && countItem == 0)
                    {
                        countItem++;
                        continue;
                    }
                    tempCart[idx++] = itemsInCart[i];
                }
                if (clothes.Length == 1)
                {
                    Clothing[] tempClothes = new Clothing[1];
                    clothes = tempClothes;
                }
                else
                {
                    idx = 0;
                    Clothing[] temp = new Clothing[clothes.Length - 1];
                    
                    for (int i = 0; i < clothes.Length; i++)
                    {
                        if (clothes[i] == p) continue;
                        temp[idx++] = clothes[i];
 
                    }
                    Array.Resize(ref clothes, temp.Length);
                    temp.CopyTo(clothes, 0);
                }
                Array.Resize(ref itemsInCart, tempCart.Length);
                tempCart.CopyTo(itemsInCart, 0);
                totalPrice -= p.Price;
                totalItems--;
            }
        }

        public void EmptyCart()
        {
            Clothing[] tempClothes = new Clothing[1];
            Helmet[] tempHelmets = new Helmet[1];
            string[] tempItemsInCart = new string[1];
            clothes = tempClothes;
            helmets = tempHelmets;
            itemsInCart = tempItemsInCart;
            totalPrice = 0;
            totalItems = 0;
        }

        public bool isEmpty()
        {
            bool empty = false;
            if (clothes[0] is null && helmets[0] is null) return true;
            return empty;
        }
    }
}
