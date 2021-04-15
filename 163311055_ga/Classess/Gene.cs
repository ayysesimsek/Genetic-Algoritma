using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311055_ga.Classess
{
    class Gene
    {
        #region Property
        public double minValue, maxValue, value;
        #endregion

        #region Constructor
        /// <summary>
        ///The Constructor Method
        /// </summary>
        public Gene()
        {
        }
        /// <summary>
        /// The Constructor in get parameter
        /// Constructor çalıştığında rastgele değer üretiliyor.
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public Gene(double min, double max)
        {
            this.minValue = min;
            this.maxValue = max;
            GetRandomizeValue();
        }
        #endregion

        #region Method

        /// <summary>
        /// Verilen aralıklarda rastgele değer üreten Random Method
        /// </summary>
        private void GetRandomizeValue()
        {
            value = (GA.random.NextDouble() * (maxValue - minValue)) + minValue;
        }

        /// <summary>
        /// mutasyon değerine göre gen değeri oluşumu gerçekleşiyor. 
        /// </summary>
        public void Mutate()
        {
            if (GA.random.NextDouble() < GA.mutationRate)
                GetRandomizeValue();
        }

        #endregion
    }
}
