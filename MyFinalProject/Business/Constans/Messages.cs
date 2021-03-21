using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi. ";
        public static string ProductNameInvalid = "Ürün Adı Geçersiz. ";
        public static string ProductList = "Ürünler Listelendi. ";
        public static string ProductListInvalid = "Ürünler Listelenemedi.";
        public static string ProductCountOfCategoryError = "Max. kategori sayısına ulaşıldı. ";
        public static string ProductNameAlreadyExists = "Bu isimde zaten bir ürün var.";
        public static string CategoryLimitExceded = "Kategori sayısı max sayıya ulaştı.";
        public static string AuthorizationDenied = "Yetkiniz Yok.";
        public static string UserRegistered = "Kullanıcı Kaydedildi.";
        public static string UserNotFound = "Kullanıcı Bulunamadı.";
        public static string PasswordError = "Şifre Geçersiz.";
        public static string SuccessfulLogin = "Giriş Başarılı.";
        public static string UserAlreadyExists = "Kullanıcı zaten var.";
        public static string AccessTokenCreated = "Access Token Oluşturuldu.";
    }
}
