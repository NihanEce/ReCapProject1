using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string DailyPriceInvalid = "Girdiğiniz fiyat geçersiz. Lütfen günlük fiyat kısmına 0'dan büyük bir değer giriniz. ";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        internal static string MaintenanceTime ="Sistem bakımda";
        internal static string CarsListed = "Arabalar listelendi";
    }
}
