using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    /// <summary>
    /// Your task is to implement the 5 functions in this class.  
    /// Only make changes to THIS file!  
    /// You can add extra methods or classes you like, but don't alter the signatures of the existing methods.  
    /// The project is runnable, so you can use the compiler/debugger etc
    /// You can use any c# code or .net framework functions you think are useful.
    /// Feel free to use google to research your answers or to look for sample code.  BUT...
    /// *** IMPORTANT : If you do find something via Google that you end up using, write the URL in a comment. ***
    /// </summary>
    public static class Implementation
    {
        //a count of the number of animals who have a clinical code with CodeID == 1
        public static int CountOfCode1(List<Animal> animals)
        {
            throw new NotImplementedException();
        }

        //return a new list with only unique codes (codes are considered duplicates if they have the same value for their CodeID property)
        public static List<ClinicalCode> ReturnUniqueCodes(List<ClinicalCode> list) {
            throw new NotImplementedException();
        }

        //list the animalIDs which are contained in BOTH listA AND listB
        public static List<int> AnimalsInBothLists(List<Animal> listA, List<Animal> listB) 
        {
            throw new NotImplementedException();
        }

        //list the animalIDs in listA that are not in listB
        public static List<int> AnimalsOnlyInA(List<Animal> listA, List<Animal> listB)
        {
            throw new NotImplementedException();
        }

        //a count of the number of animals who have BOTH : 
        //  a CLINICAL CODE with CodeID == 1 
        //  AND a CLINICAL CODE with CodeID == 2 
        public static int CountOfCode1And2(List<Animal> animals)
        {
            throw new NotImplementedException();
        }
    }
}
