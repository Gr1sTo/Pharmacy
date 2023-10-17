using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    //Інтерфейс для отримання інформації про покупця
    public interface ICustomerInfo
    {
        string PhoneNum { get; set; }
        string IDDiscountCard { get; set; }
    }

    // Інтерфейс для обробки знижок для покупця
    public interface IDiscountable
    {
        float DiscountValue { get; set; }

        // Метод для застосування знижки
        void ApplyDiscount(float discountAmount);
    }

    public class Shopper : ICustomerInfo, IDiscountable
    {
        public string PhoneNum { get; set; }
        public float DiscountValue { get; set; }
        public string IDDiscountCard { get; set; }

        public void ApplyDiscount(float discountAmount)
        {
            // Реалізація застосування знижки
            DiscountValue -= discountAmount;
        }
    }
    // Клас, що реалізує функціональність управління покупцями
    public class ShopperManager
    {
        private List<Shopper> shoppers;

        public ShopperManager()
        {
            shoppers = new List<Shopper>();
        }

        public void AddShopper(Shopper shopper)
        {
            shoppers.Add(shopper);
        }

        public bool RemoveShopper(string phoneNum)
        {
            var shopperToRemove = shoppers.Find(s => s.PhoneNum == phoneNum);
            if (shopperToRemove != null)
            {
                shoppers.Remove(shopperToRemove);
                return true;
            }
            return false;
        }

        public Shopper GetShopperByPhone(string phoneNum)
        {
            return shoppers.Find(s => s.PhoneNum == phoneNum);
        }

        public List<Shopper> GetAllShoppers()
        {
            return shoppers;
        }
    }

}
