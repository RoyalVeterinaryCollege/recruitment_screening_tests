using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication1
{
    public static class DataSource {
        public static Random rnd = new Random();

        /// <summary>
        /// This generates some random dummy data to for you to work with.  Contains no duplicates.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Animal> GetSomeUniqueAnimals()
        {
            var max = rnd.Next(300, 400); // create a random number of patients
            return Enumerable.Range(1, max).Select(animalId => {
                return new Animal {
                    AnimalID = animalId,
                    Codes = CreateSomeCodes().ToList()
                };
            });
        }

        /// <summary>
        /// Create some random clinical codes
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ClinicalCode> CreateSomeCodes(int numberToCreate = 10) {
            return Enumerable.Range(1, numberToCreate).Select(codeId => {
                var clinicalCodeId = rnd.Next(1, 5);
                return new ClinicalCode {
                    CodeID = clinicalCodeId,
                    CodeName = "The name of the diagnosis"
                };
            });
        }

        /// <summary>
        /// This generates some random dummy data to for you to work with.  Contains duplicate animals.
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Animal> GetSomeDuplicateAnimals() {
            var max = rnd.Next(300, 400); //create a random number of patients
            return Enumerable.Range(1, max).Select(_ => {
                return new Animal {
                    AnimalID = rnd.Next(0,10), //only generate animalIds in the 0-10 range which will most likely create a lot of duplicate animals
                    Codes = CreateSomeCodes().ToList()
                };
            });
        }
    }
}