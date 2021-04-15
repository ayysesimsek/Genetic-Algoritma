using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _163311055_ga.Classess
{
    class GA
    {
        #region Properties

        /// <summary>
        /// Tüm rastgelellik işlmelerinde kullanılmak üzere static olarak tanımlanmıştır. 
        /// </summary>
        public static Random random = new Random();
        /// <summary>
        /// Pm = 0.1 -> Mutasyon Değeri
        /// </summary>
        public static double mutationRate = Constants.Mutation;
        /// <summary>
        /// PC = 0.8 -> Çarprazlama Değeri
        /// </summary>
        public static double crossoverRate = Constants.Crossover;
        /// <summary>
        /// Seçkinlik Değeri = 2
        /// </summary>
        public static int eliteCount = Constants.Elite;
        /// <summary>
        /// Populasyon Uzunluğu = 10
        /// Popülasyon Boyutu : Popülasyondaki birey sayısınınn toplamıdır. Yani bir iterasyondaki çözüm kümesi sayısıdır.
        /// </summary>
        private int populationSize = Constants.PopulationSize;
        /// <summary>
        /// population generic list
        /// </summary>
        public List<Chromosome> population = new List<Chromosome>();
        /// <summary>
        /// elites generic list
        /// </summary>
        public List<Chromosome> elites = new List<Chromosome>();

        #endregion

        #region Constructor
        /// <summary>
        /// The GA Constructor in get parameter
        /// </summary>
        /// <param name="size"></param>
        public GA(int size)
        {
            StartPopulation(size);
        }
        #endregion

        #region Method

        /// <summary>
        /// Populasyon başlama metodu.
        /// Poplasyon size 'a göre gen oluşumu gerçekleşiyor. 
        /// Mutasyona ve çarprazlamaya sokma işlemleride yer almaktadır.
        /// </summary>
        /// <param name="size"></param>
        public void StartPopulation(int size)
        {
            populationSize = size;
            population = new List<Chromosome>();
            for (int i = 0; i < size; i++)
            {
                //Populasyon genişliği kadar rastgele gen üretiliyor.
                population.Add(new Chromosome());
            }
            #region Populasyon muastayona ve çarprazlamaya sokuldu.
            MutatePopulation();
            CrossoverPopulation();
            #endregion
        }

        /// <summary>
        /// Populasyondaki tüm kromozomların mutasyon fonksiyonunu çağırır.
        /// </summary>
        private void MutatePopulation()
        {
            foreach (Chromosome chromosome in population)
                chromosome.Mutate();
        }

        /// <summary>
        /// Populasyondaki kromozomarı karıştırıp her birini bir sonraki ile çarprazlar.
        /// </summary>
        private void CrossoverPopulation()
        {
            Shuffle(population);
            for (int i = 0; i < population.Count - 1; i++)
            {
                population[i] = population[i] * population[i + 1];
            }
        }

        /// <summary>
        /// Yer Değişme olayı gerçekleşmektedir.
        /// Bu sayede çiftler oluşuyor.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void Shuffle<T>(IList<T> list)
        {
            int count = list.Count;
            while (count > 1)
            {
                count--;
                int random = GA.random.Next(count + 1);
                T value = list[random];
                list[random] = list[count];
                list[count] = value;
            }
        }

        /// <summary>
        /// Iterasyon işlemi yapılıyor. Her bir başlama butonunda baştan itere oluyor.
        /// Mutasyon ve çarprazlamaya uğruyor.
        /// </summary>
        public void Iteration()
        {
            population.Clear(); //Her iterasyonda populasyon tamamen silinir.
            population.AddRange(elites); //Seçkinlik değeri ayrı bir listede tutulup temiizlenmiş populasyona eklenir. 
            for (int i = 0; i < populationSize - elites.Count; i++)
            {
                //Seçkinlik değeri dışındaki kromozomlar yeniden üretiliyor.
                population.Add(new Chromosome());
            }
            MutatePopulation();
            CrossoverPopulation();
            SelectedElites();
        }

        /// <summary>
        /// Seçkinlik değeri oluşuyor
        /// </summary>
        public void SelectedElites()
        {
            elites.Clear();
            List<Chromosome> sorted = population.OrderBy((Chromosome ch) => ch.FitnessFunction()).ToList();
            for (int i = 0; i < GA.eliteCount; i++)
            {
                elites.Add(sorted[i]);
            }
        }

        #endregion
    }
}
