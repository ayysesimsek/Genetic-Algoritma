using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311055_ga.Classess
{
    class Chromosome
    {
        #region Property
        /// <summary>
        /// Genler tutuluyor.
        /// </summary>
        public Gene[] genes = new Gene[2];

        public List<Double> listFunction = new List<double>();


        #endregion

        #region Constructor

        /// <summary>
        /// Kromozomlar otomatik olarak oluşturuluyor.. 
        /// Parametre aralığıdır.. -> Parametrelerin alabileceği en büyük ve en küçük değerlerdir.
        /// Benim problemiim test fonksiyonunun 16 numaralı fonksiyonudur ve bu fonksiyondaki
        /// parametre aralığı (-100, 100) aralığındadır.
        /// </summary>
        public Chromosome()
        {
            genes[0] = new Gene(Constants.minFunctionValue, Constants.maxFunctionValue);
            genes[1] = new Gene(Constants.minFunctionValue, Constants.maxFunctionValue);
        }
        /// <summary>
        /// Her kromozom için 2 gen oluşuyor. 
        /// </summary>
        /// <param name="gene1"></param>
        /// <param name="gene2"></param>
        public Chromosome(Gene gene1, Gene gene2)
        {
            genes[0] = gene1;
            genes[1] = gene1;
        }

        #endregion

        #region Method

        /// <summary>
        /// Problemin Ugyunluk Fonksiyonunu geri döndüren method
        /// Test functions to Problems in 15'th number.
        /// Uygunluk Fonksiyonu : Algoritmada problem için bululunan çözüm kümelerinin iyilik
        /// derecesini bulmaya yarar.
        /// </summary>
        /// <returns>
        /// 100 * Math.Pow(genes[1].value - Math.Pow(genes[0].value, 2), 2) + Math.Pow((genes[0].value - 1), 2); 
        /// Test_function da 3 numaralı fonksiyon yapılmıştır.
        /// </returns>
        public double FitnessFunction()
        {
            double result = 0;
            int d = 30;
            ///////////Toplam sembolünde form kullanılmalıdır diye düşündüm. Her defasınnda n sayısı kadar toplayarak işlemleri yaptığı için 
            //gerekli kodu for içerisine aldım ki 30 kere dönüp her defasında toplama işlemi yapsın . //////////////////////////////
            for (int i = 0; i < d; i++)
            {
                result += 100 * Math.Pow(genes[1].value - Math.Pow(genes[0].value, 2), 2) +
                    Math.Pow((genes[0].value - 1), 2);
                listFunction.Add(result);
            }

            return result;
        }

        /// <summary>
        /// Kromozomun genleri mutasyona uğruyor.
        /// </summary>
        public void Mutate()
        {
            genes[0].Mutate();
            genes[1].Mutate();
        }

        /// <summary>
        /// Çarprazlama Yapılıyor .. 
        /// </summary>
        /// <param name="chromosome1"></param>
        /// <param name="chromosome2"></param>
        /// <returns></returns>
        public static Chromosome operator *(Chromosome chromosome1, Chromosome chromosome2)
        {
            Chromosome returnObject = chromosome1;
            for (int i = 0; i < 2; i++)
            {
                #region Rastgele üretilen değerler Pc'den küçük olduğu taktirde çarprazlama işlemi gerçekleşecektir. Büyük olanlar ise çarprazlamaya tabi tutulmayacaktır.
                if (GA.random.NextDouble() < GA.crossoverRate)
                {
                    double crossResult = GA.random.NextDouble();
                    returnObject.genes[i].value = (crossResult * chromosome1.genes[i].value) + ((1 - crossResult) * chromosome2.genes[i].value);
                }
                #endregion
            }
            return returnObject;
        }

        #endregion
    }
}
