using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    public class Animal
    {
        /// <summary>
        /// Unique Id of the animal
        /// </summary>
        public int AnimalID { get;  set; }

        /// <summary>
        /// Clinical codes that the animal has been diagnosed with
        /// </summary>
        public List<ClinicalCode> Codes { get;  set; }

        public override bool Equals(object obj)
        {
            var other = obj as Animal;
            return this.AnimalID == other?.AnimalID;
        }

        public override int GetHashCode()
        {
            return AnimalID;
        }

        public override string ToString() {
            return string.Format("Animal with AnimalID {0} and {1} codes", AnimalID, Codes.Count);
        }
    }
}
