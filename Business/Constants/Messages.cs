using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi!";
        public static string ProductNameInvalid = "Ürün ismi geçersiz!";
        public static string MaintenanceTime = "Sistemde bakım var!";

        public static string ProductsListed = "Ürünler listelendi!";

        public static string ProductCountOfCategoryError = "Ürün miktarı aşıldı!";

        public static string ProductNameAlreadyExist = "Aynı isimde ürün mevcut!";

        public static string CategoryNumbetExceed = "Maksimum kategori sayısına ulaşıldı!";

        public static string AuthorizationDenied = "Yetkisiz erişim";

        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
