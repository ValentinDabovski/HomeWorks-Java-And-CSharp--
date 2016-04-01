using System;

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] elements = new string[n];
        int numberEqualElements = 1;
        int[] arrayRepeatElements = new int[n];
        int[] startPositionRepeatElement = new int[n];
        for (int i = 0; i < n; i++)
        {
            elements[i] = Console.ReadLine();
        }
        string refrenceElement = elements[0];
        int l = 0;
        startPositionRepeatElement[l] = 0;
        for (int i = 1, k = 0; i < n; i++)
        {
            if (refrenceElement == elements[i])
            {
                l++;
                numberEqualElements++;
                startPositionRepeatElement[l] = k;
            }
            else
            {
                if (l > k)
                {
                    k = l;
                }
                l++;
                k++;
                arrayRepeatElements[i] = numberEqualElements;
                refrenceElement = elements[i];
                numberEqualElements = 1;
                startPositionRepeatElement[l] = k;
            }
        }
        for (int i = 0; i < n; i++)
        {
            if (numberEqualElements > arrayRepeatElements[i] ||
                numberEqualElements == elements.Length)
            {
                if (i == n - 1)
                {
                    Console.WriteLine(numberEqualElements);
                    for (int j = startPositionRepeatElement[i]; j < n; j++)
                    {
                        Console.WriteLine("{0}", elements[j]);
                    }
                    break;
                }
            }
            else if (numberEqualElements == arrayRepeatElements[i] && numberEqualElements == 1)
            {
                for (int j = 0; j < n; j++)
                {
                    if (refrenceElement.Length > elements[j].Length)
                    {
                        continue;
                    }
                    else
                    {
                        refrenceElement = elements[j];
                    }
                }
                Console.WriteLine(numberEqualElements);
                Console.WriteLine(refrenceElement);
                break;
            }
            else if (numberEqualElements == arrayRepeatElements[i] && numberEqualElements > 1)
            {
                Console.WriteLine(arrayRepeatElements[i]);
                refrenceElement = elements[0];
                int m = 1;
                for (; m < n; m++)
                {
                    if (refrenceElement == elements[m])
                    {
                        break;
                    }
                    else
                    {
                        refrenceElement = elements[m];
                    }
                }
                for (int j = startPositionRepeatElement[m]; j < i; j++)
                {
                    Console.WriteLine("{0}", elements[j]);
                }
                break;
            }
        }
    }
}