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
        static int[] aggiunta_in_coda(ref int lenght, int[]array, int elemento)
        {
            if (lenght < array.Length-1)
            {
                array[lenght] = elemento;
                lenght++;
            }
            else
            {
                Console.WriteLine("l'array ha raggiuno la sua capacità massima");
            }
            return array;
        }

        static string fun_codice_html(int[] array, int lenght)
        {
            string codice_html = "<ul>";
            for (int i = 0; i < lenght+1; i++)
            {
                codice_html = codice_html + "<li>" + array[i] + "</li>";
            }
            codice_html = codice_html + "</ul>";
            return codice_html;
        }

        //funzione per cercare un elemento dell'array, restituire o la posizione o se non possibile -1
        static int fun_posizione(int[] array, int ricerca, int lenght)
        {
            int posizione = -1;

            for (int i = 0; i < lenght+1; i++)
            {
               if (array[i] == ricerca)
                {
                    posizione=i;
                }
            }
            return posizione;
        }

        //cancellazione di un elemento da un array
        static int[] remove(int[] array, int rem, ref int lenght)
        {

            for (int i = rem-1; i <= lenght; i++)
            {
                array[i] = array[i+1];
            }
            lenght--;
            return array;
        }

        static void Main(string[] args)
        {
            int[] array = new int[100];
            int lenght = 0, ricerca, posizione, elemento, rem;
            string codice_html="";

            for (int i = 0; i < 4; i++)
            {
                if (lenght < 99)
                {
                    elemento = int.Parse(Console.ReadLine());
                    aggiunta_in_coda(ref lenght, array, elemento);
                }
                else
                {
                    Console.WriteLine("l'array ha raggiuno la sua capacità massima");
                }
            }


            codice_html=fun_codice_html(array, lenght);


            ricerca=int.Parse(Console.ReadLine());
            posizione=fun_posizione(array, ricerca, lenght);


            rem = int.Parse(Console.ReadLine());
            array = remove(array, rem, ref lenght);

            
            //Inserimento di un valore in una posizione dell'array.
        }
    }
}
