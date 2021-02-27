using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi.";
        public static string ProductNameInvalid = "Ürün ismi geçersiz !";
        public static string MaintenanceTime = "Sistem bakımda.";
        public static string ProductsListed = "Ürünler listelendi. ";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir !";
        public static string ProductNameAlreadyExists = "Böyle bir ürün adı zaten mevcut .";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor !";
        public static string AuthorizationDenied = "Yetkiniz yok !";
        public static string UserRegistered = "Kayıt başarılı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Hatalı parola girişi.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        internal static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu.";
    }
}
