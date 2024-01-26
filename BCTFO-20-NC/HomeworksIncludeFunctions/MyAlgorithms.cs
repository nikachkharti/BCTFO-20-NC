﻿namespace Homeworks
{
    public static class MyAlgorithms
    {
        public static T[] SetDefaultValue<T>(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = default;
            }

            return array;
        }
        public static T GetLastElement<T>(T[] array)
        {
            return array[array.Length - 1];
        }
        public static T[] Reverse<T>(T[] array)
        {
            T[] result = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[array.Length - 1 - i];
            }

            return result;
        }
        public static List<T> Reverse<T>(List<T> list)
        {
            Stack<T> resultStack = new();

            for (int i = 0; i < list.Count; i++)
            {
                resultStack.Push(list[i]);
            }

            return resultStack.ToList();
        }
        public static T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[i]) == -1)
                    {
                        T t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }
                }
            }

            return array;
        }
        public static T[] Copy<T>(T[] source, T[] destination)
        {
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }

            return destination;
        }
        public static bool Any<T>(T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool All<T>(T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!array[i].Equals(element))
                {
                    return false;
                }
            }
            return true;
        }
        public static T FirstOrDefault<T>(T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return element;
                }
            }
            return default;
        }
        public static T LastOrDefault<T>(T[] array, T element)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i].Equals(element))
                {
                    return element;
                }
            }
            return default;
        }
        public static T[] FindAll<T>(T[] array, T element)
        {
            List<T> result = new();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    result.Add(element);
                }
            }

            return result.ToArray();
        }
        public static T[] FindAllWithArray<T>(T[] array, T element)
        {
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                    counter++;
            }

            T[] result = new T[counter];
            int resultIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (element.Equals(array[i]))
                {
                    result[resultIndex] = element;
                    resultIndex++;
                }
            }

            return result;
        }
        public static int FindIndex<T>(T[] array, T element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int FindLastIndex<T>(T[] array, T element)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i].Equals(element))
                {
                    return i;
                }
            }

            return -1;
        }
        public static int Sum(int[] array)
        {
            int sumResult = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sumResult += array[i];
            }

            return sumResult;
        }
    }
}
