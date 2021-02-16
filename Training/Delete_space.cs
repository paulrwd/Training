using System;
using System.Collections.Generic;
using System.Text;

namespace Training
{
    class Delete_space
    {
        public static string MassS(string s)
        {
            char[] mass = s.ToCharArray();

            int rep = 0;

            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] == '_')
                {
                    rep++;

                    if (rep > 1)
                    {
                        int j = 0;
                        while (mass[i + j] == '_')
                        {
                            j++;
                            if ((i + j) == mass.Length)
                            {
                                break;
                            }
                        }
                        if ((i + j) == mass.Length)
                        {
                            break;
                        }

                        int repS = 0;
                        while (mass[i + j + repS] != '_')
                        {
                            mass[i + repS] = mass[i + j + repS];
                            mass[i + j + repS] = '_';
                            repS++;
                            rep = 0;
                            if ((i + j + repS) == mass.Length)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    rep = 0;
                }
                
            }
            
            return new string(mass);
        }
    }
}
