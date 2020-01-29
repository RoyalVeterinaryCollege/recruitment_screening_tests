using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class ClinicalCode
    {
        
        /// <summary>
        /// Unique ID of the code
        /// </summary>
        public int CodeID { get;  set; }
        public string CodeName { get;  set; }

        public override bool Equals(object obj) {
            var other = obj as ClinicalCode;
            return this.CodeID == other?.CodeID;
        }

        public override int GetHashCode() {
            return CodeID;
        }

        public override string ToString() {
            return string.Format("Clinical code with CodeID of {0}", CodeID);
        }
    }
}
