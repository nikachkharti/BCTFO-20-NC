namespace Homeworks
{
    public static class MyAlgorithms
    {
        public static int[] SetDefaultValue(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }

            return array;
        }
        public static int GetLastElement(int[] array)
        {
            return array[array.Length - 1];
        }
        public static int[] Reverse(int[] array)
        {
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[array.Length - 1 - i];
            }

            return result;
        }
        public static List<int> Reverse(List<int> intList)
        {
            Stack<int> resultStack = new();

            for (int i = 0; i < intList.Count; i++)
            {
                resultStack.Push(intList[i]);
            }

            return resultStack.ToList();
        }
        public static int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int t = array[j];
                        array[j] = array[i];
                        array[i] = t;
                    }
                }
            }

            return array;
        }
        public static int[] Copy(int[] source, int[] destination)
        {
            for (int i = 0; i < source.Length; i++)
            {
                destination[i] = source[i];
            }

            return destination;
        }
        public static bool Any(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool All(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != element)
                {
                    return false;
                }
            }
            return true;
        }
        public static int FirstOrDefault(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return element;
                }
            }
            return default;
        }
        public static int LastOrDefault(int[] array, int element)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == element)
                {
                    return element;
                }
            }
            return default;
        }
        public static int[] FindAll(int[] array, int element)
        {
            List<int> result = new();

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    result.Add(element);
                }
            }

            return result.ToArray();
        }

        //public static int[] FindAllWithArray(int[] array, int element)
        //{
        //    int counter = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i] == element)
        //            counter++;
        //    }

        //    int[] result = new int[counter];
        //    int resultIndex = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (element == array[i])
        //        {
        //            result[resultIndex] = element;
        //            resultIndex++;
        //        }
        //    }

        //    return result;
        //}


        public static int FindIndex(int[] array, int element)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == element)
                {
                    return i;
                }
            }

            return -1;
        }
        public static int FindLastIndex(int[] array, int element)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == element)
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
