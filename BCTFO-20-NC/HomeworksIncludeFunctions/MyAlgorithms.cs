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
        public static IEnumerable<T> MyDistinct<T>(IEnumerable<T> source, IEqualityComparer<T> comparer = null)
        {
            HashSet<T> set = new(comparer);

            foreach (var item in source)
            {
                set.Add(item);
            }

            return set;
        }
        public static IEnumerable<T> MyReverse<T>(this IEnumerable<T> source)
        {
            Stack<T> stack = new();
            foreach (var item in source)
            {
                stack.Push(item);
            }

            return stack;
        }
        public static List<T> MyReverse<T>(List<T> list)
        {
            Stack<T> resultStack = new();

            for (int i = 0; i < list.Count; i++)
            {
                resultStack.Push(list[i]);
            }

            return resultStack.ToList();
        }
        public static IList<T> MySort<T>(this IList<T> collection, Func<T, T, bool> comparer)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (comparer(collection[j], collection[i]))
                    {
                        T t = collection[j];
                        collection[j] = collection[i];
                        collection[i] = t;
                    }
                }
            }

            return collection;
        }
        public static bool MyAny<T>(T[] array, Predicate<T> predicate)
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
        public static bool MyAll<T>(T[] array, Func<T, bool> predicate)
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
        public static T MyFirstOrDefault<T>(T[] array, Func<T, bool> predicate)
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
        public static T MyLastOrDefault<T>(T[] array, Func<T, bool> predicate)
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
        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> source, Func<T, bool> predicate)
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
        public static int MyFindIndex<T>(IEnumerable<T> source, Func<T, bool> predicate)
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
        public static int MyFindLastIndex<T>(T[] array, Func<T, bool> predicate)
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
        public static int MySum(int[] array)
        {
            int sumResult = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sumResult += array[i];
            }

            return sumResult;
        }
        public static int MySum(int[] array, Func<int, bool> predicate)
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
        public static T[] MyTake<T>(T[] array, int quanitity)
        {
            T[] result = new T[quanitity];

            for (int i = 0; i < quanitity; i++)
            {
                result[i] = array[i];
            }

            return result;

        }
        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
        {
            foreach (var item in source)
                yield return selector(item);
        }
    }
}
