namespace Homeworks
{
    public static class MyAlgorithms
    {
        #region EXTRA
        //public static void Log<T>(Action<T> action, T message)
        //{
        //    action(message);
        //}

        //public static T[] FindAllWithArray<T>(T[] array, T element)
        //{
        //    int counter = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (array[i].Equals(element))
        //            counter++;
        //    }

        //    T[] result = new T[counter];
        //    int resultIndex = 0;

        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        if (element.Equals(array[i]))
        //        {
        //            result[resultIndex] = element;
        //            resultIndex++;
        //        }
        //    }

        //    return result;
        //}


        //public static T[] SetDefaultValue<T>(T[] array)
        //{
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        array[i] = default;
        //    }

        //    return array;
        //}

        #endregion
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
        public static T[] Sort<T>(T[] array, Func<T, T, bool> comparer)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (comparer(array[j], array[i]))
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
        public static bool Any<T>(T[] array, Predicate<T> predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool All<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (!predicate(array[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public static T FirstOrDefault<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    return array[i];
                }
            }
            return default;
        }
        public static T LastOrDefault<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (predicate(array[i]))
                {
                    return array[i];
                }
            }
            return default;
        }


        public static IEnumerable<T> Where<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            List<T> result = new();

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }

            return result;
        }
        public static int FindIndex<T>(IEnumerable<T> source, Func<T, bool> predicate)
        {
            int index = 0;

            foreach (var item in source)
            {
                if (predicate(item))
                {
                    return index;
                }

                index++;
            }

            return -1;
        }


        public static int FindLastIndex<T>(T[] array, Func<T, bool> predicate)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (predicate(array[i]))
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
        public static int Sum(int[] array, Func<int, bool> predicate)
        {
            int sumResult = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (predicate(array[i]))
                {
                    sumResult += array[i];
                }
            }

            return sumResult;
        }
        public static T[] Take<T>(T[] array, int quanitity)
        {
            T[] result = new T[quanitity];

            for (int i = 0; i < quanitity; i++)
            {
                result[i] = array[i];
            }

            return result;

        }
        public static TResult[] Select<TSource, TResult>(TSource[] data, Func<TSource, TResult> selector)
        {
            TResult[] result = new TResult[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                result[i] = selector(data[i]);
            }

            return result;
        }
    }
}
