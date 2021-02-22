using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Arabalar listelendi";
        public static string FailedCarAddOrUpdate = "Lütfen günlük fiyat kısmını 0'dan büyük giriniz.";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string FailedBrandAddOrUpdate = "Lütfen marka isminin uzunluğunu 2 karakterden fazla giriniz.";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string RentalAdded = "Araba kiralama işlemi başarıyla gerçekleşti";
        public static string RentalDeleted = "Araba kiralama işlemi iptal edildi";
        public static string RentalUpdated = "Araba kiralama işlemi güncellendi";
        public static string FailedRentalAddOrUpdate = "Bu araba henüz teslim edilmediği için kiralama işlemi yapamazsınız";
        public static string RentalReturned = "Kiraladığınız araç teslim edildi.";



        public static string DailyPriceInvalid = "Girdiğiniz fiyat geçersiz. Lütfen günlük fiyat kısmına 0'dan büyük bir değer giriniz. ";
        public static string MaintenanceTime = "Sistem bakımda";


    }

}
