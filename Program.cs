using System;
using System.Collections.Generic;
using System.Linq;




namespace duplicates
{

   
    /* 3. la liste L’ qui ne contient qu’une seule fois chaque valeur (on supprime les doublons)*/

    class List
    {
        static void showList(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            List<int> L = new List<int> { 1, 2, 4, 2, 3, };
            HashSet<int> separate = new HashSet<int>(L);
            List<int> L2 = separate.ToList();
            showList(L2);
        }
    }

    /* 2. la liste L des chiffres du nombre S */

    class CharList
    {
        static void Main(string[] args)
        {
            string S = "12423";

            char[] myArray = S.ToCharArray();
            Console.WriteLine(myArray);
            Console.ReadKey();
        }
    }

    /* 4. la somme S’ des éléments de la liste L*/

    class Sum
    {
        static void showSum() {

            L = [1, 2, 4, 3];
            sum(L)
            
    } }
}