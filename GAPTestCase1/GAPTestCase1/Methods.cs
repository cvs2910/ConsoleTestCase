using System;
using System.Collections.Generic;
using System.Text;

namespace GAPTestCase1
{
    public class Methods
    {
        /// <summary>
        /// Método que se encarga de mezclar cadenas de caracteres, ordenando los campos según su posición en la cadena origen.
        /// </summary>
        /// <param name="stringArray">Recibe un tipo List<string></param>
        /// <returns>Retorna un cadena String, que contiene los datos mezclados en orden, de las cadenas de la lista.</returns>
        public static string StringMerge(List<string> stringArray)
        {
            string resultString = "";
            char[] array = null;
            int iterator;

            stringArray.ForEach(item => {
                array = item.ToCharArray();
                iterator = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    iterator++;
                    if (resultString.Length >= (i+iterator))
                    { 
                        resultString = resultString.Insert((i+iterator), array.GetValue(i).ToString());
                    }
                    else
                    {
                        resultString += array.GetValue(i).ToString();
                    }
                }
            }); 

            return resultString;
        }
    }
}
