using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    // static => new'lenemez 
    public static class Messages
    {
        // CAR //
        public static string CarAddedError = "Arac Ekleme Islemi Basarisiz.";
        public static string CarAddedSuccess = "Arac Ekleme Islemi Basarili.";
        public static string CarDeletedError = "Arac Silme Islemi Basarisiz.";
        public static string CarDeletedSuccess = "Arac Silme Islemi Basarili.";
        public static string CarUpdatedError = "Arac Güncelleme Islemi Basarisiz.";
        public static string CarUpdatedSuccess = "Arac Güncelleme Islemi Basarili.";
        public static string CarNameInvalid = "Arac Ismi Gecersiz.";
        public static string CarListed = "Arac Bilgileri Listelendi";

        // BRAND //
        public static string BrandAddedError = "Marka Ekleme Islemi Basarisiz.";
        public static string BrandAddedSuccess = "Marka Ekleme Islemi Basarili.";
        public static string BrandDeletedError = "Marka Silme Islemi Basarisiz.";
        public static string BrandDeletedSuccess = "Marka Silme Islemi Basarili.";
        public static string BrandUpdatedError = "Marka Güncelleme Islemi Basarisiz.";
        public static string BrandUpdatedSuccess = "Marka Güncelleme Islemi Basarili.";
        public static string BrandNameInvalid = "Marka Ismi Gecersiz.";
        public static string BrandListed = "Marka Bilgileri Listelendi";

        // COLOR //
        public static string ColorAddedError = "Renk Ekleme Islemi Basarisiz.";
        public static string ColorAddedSuccess = "Renk Ekleme Islemi Basarili.";
        public static string ColorDeletedError = "Renk Silme Islemi Basarisiz.";
        public static string ColorDeletedSuccess = "Renk Silme Islemi Basarili.";
        public static string ColorUpdatedError = "Renk Güncelleme Islemi Basarisiz.";
        public static string ColorUpdatedSuccess = "Renk Güncelleme Islemi Basarili.";
        public static string ColorNameInvalid = "Renk Ismi Gecersiz.";
        public static string ColorListed = "Renk Bilgileri Listelendi";
        
        // USER //
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserNameInvalid = "Kullanıcı adı geçersiz";
        public static string UserListed = "Kullanıcılar listelendi";

        // CUSTOMER//
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri geçersiz";
        public static string CustomerCompanynameInvalid = "Müşteri şirket adı geçersiz";
        public static string CustomerListed = "Müşteriler listelendi";

        // RENTAL //
        public static string RentalInvalid = "Kiralama hatası oluştu";
        public static string RentalAdded = "KiralamaEklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
        public static string RentalListed = "Kiralamalar listelendi";

        public static string MaintenanceTime = "Sistem Şuan Bakımdadır";
    }
}
