using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_e_funzioni
{
    internal class Program
    {

        //aggiunta di un elemento all'array in coda
        static int[] aggiunta_in_coda(int lenght, int[]array)
        {
            if (lenght < 99)
            {
                array[lenght] = int.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("l'array ha raggiuno la sua capacità massima");
            }
            return array;
        }

        static string fun_codice_html(int[] array)
        {
            string codice_html= "<ul>";
            for (int i = 0; i < array.Length; i++)
            {
                codice_html = codice_html + "<li>"+array[i]+ "</li>";
            }
            codice_html = codice_html + "</ul>";
            return codice_html;
        }

        static void Main(string[] args)
        {
            int[] array = new int[100];
            int lenght = 0;
            string codice_html="";

            for (int i = 0; i < 4; i++)
            {
                aggiunta_in_coda(lenght, array);
                lenght++;
            }

            codice_html=fun_codice_html(array);


            
            //funzione per cercare un elemento dell'array, restituire o la posizione o se non possibile -1
            //cancellazione di un elemento da un array
            //Inserimento di un valore in una posizione dell'array.
        }
    }
}
