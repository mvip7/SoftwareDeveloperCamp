using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    // static => new'lenemez 
    public static class Messages
    {
        public static string ProductDeleted = "Urun Silindi.";
        public static string ProductUpdated = "Urun Guncellendi.";
        public static string ProductAddedError = "Urun Ekleme Islemi Basarisiz.";
        public static string ProductAddedSuccess = "Urun Ekleme Islemi Basarili.";
        public static string ProductNameInvalid = "Urun Ismi Gecersiz.";
        public static string MaintenanceTime = "Sistem Şuan Bakımdadır";
        public static string ProductListed = "Urunler Tamamen Listelendi";
        public static string ProductCountOfCategoryError="Bir Kategoride En Fazla 10 Ürün Olabilir";
        public static string ProductNameAlreadyExists="Bu Ürün İsmi Zaten Kullanılıyor";
    }
}
