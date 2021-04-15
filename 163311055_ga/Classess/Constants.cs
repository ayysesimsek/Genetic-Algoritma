using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311055_ga.Classess
{
    public static class Constants
    {
        #region Sabit değerler tutulmaktadır.

        /// <summary>
        /// PM = 0,01 değeri
        /// </summary>
        public static double Mutation = 0.01;
        /// <summary>
        /// PC = 0,001 değeri
        /// </summary>
        public static double Crossover = 0.001;
        /// <summary>
        /// Seçkinlik Değeri = 2
        /// </summary>
        public static int Elite = 2;
        /// <summary>
        /// Populasyon Boyutu = 10
        /// </summary>
        public static int PopulationSize = 10;
        /// <summary>
        /// En küçük parametre değeri = -30
        /// </summary>
        public static int minFunctionValue = -30;
        /// <summary>
        /// En büyük parametre değeri = 30
        /// </summary>
        public static int maxFunctionValue = 30;

        #endregion

        #region Kullanıcıya bildiri mesajları tutulmaktadır.

        /// <summary>
        /// OKWarningMessaging --> "Lütfen tüm alanları doğru değerlerle doldurunuz. \nÇarprazlama ve Mutasyon değerleri 0 - 1 arasında olmalıdır."
        /// </summary>
        public static string OKWarningMessaging = "Lütfen tüm alanları doğru değerlerle doldurunuz. \nÇarprazlama ve Mutasyon değerleri 0 - 1 arasında olmalıdır.";
   
        /// <summary>
        /// Information --> "Bilgilendirme"
        /// </summary>
        public static string Information = "Bilgilendirme";
     
        /// <summary>
        /// IterationOrFunctionWarningMessaging --> "Lütfen iterasyon sayısı ya da Uygunluk Değeri işlemlerinden birisini seçiniz !!"
        /// </summary>
        public static string IterationOrFunctionWarningMessaging = "Lütfen iterasyon sayısı ya da Uygunluk Değeri işlemlerinden birisini seçiniz !! ";
       
        /// <summary>
        /// Report --> "Bildiri"
        /// </summary>
        public static string Report = "Bildiri";

        /// <summary>
        /// FormLoadOpenedOfInformationMessage -> " Hoşgeldiniz Dr. Öğr. Üy. Tahir SAĞ --> "
        /// </summary>
        public static string FormLoadOpenedOfInformationMessage = " Hoşgeldiniz Dr. Öğr. Üy. Tahir SAĞ --> ";

        /// <summary>
        /// FullScreenOpen --> "Tam Ekran Modunu Aç"
        /// </summary>
        public static string FullScreenOpen = "Tam Ekran Modunu Aç";

        /// <summary>
        /// FullScreenClose --> "Tam Ekran Modunu Kapat"
        /// </summary>
        public static string FullScreenClose = "Tam Ekran Modunu Kapat";

        /// <summary>
        /// PopulatisonSizeValueControlMessage --> "Populasyon boyutu 0 ya da o dan küçük bir sayı olamaz ! "
        /// </summary>
        public static string PopulatisonSizeValueControlMessage = "Populasyon boyutu 0 ya da o dan küçük bir sayı olamaz ! ";

        /// <summary>
        /// WouldYouLikeToLogOut --> Çıkış yapmak istiyor musunuz ? 
        /// </summary>
        public static string WouldYouLikeToLogOut = "Çıkış yapmak istiyor musunuz ? ";


        #endregion
    }
}
