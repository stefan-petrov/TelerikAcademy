using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class IEnumarableExtensions
    {

        public static decimal Sum<T>(this IEnumerable<T> items) where T : struct, IConvertible, IComparable<T>
        {
            dynamic sum = 0;
            foreach (T item in items)
            {
                sum += item;
            }
            return sum;
        }

        public static decimal Product<T>(this IEnumerable<T> items) where T : struct, IConvertible, IComparable<T>
        {
            dynamic product = 1;
            foreach (T item in items)
            {
                product *= item;
            }
            return product;
        }

        public static decimal Min<T>(this IEnumerable<T> items) where T : struct, IConvertible, IComparable<T>
        {
            decimal min = decimal.MaxValue;
            foreach (T item in items)
            {
                if (Convert.ToDecimal(item) < min)
                {
                    min = Convert.ToDecimal(item);
                }
            }
            return min;
        }

        public static decimal Max<T>(this IEnumerable<T> items) where T : struct, IConvertible, IComparable<T>
        {
            decimal max = decimal.MinValue;
            foreach (T item in items)
            {
                if (Convert.ToDecimal(item) > max)
                {
                    max = Convert.ToDecimal(item);
                }
            }
            return max;
        }

        public static decimal Average<T>(this IEnumerable<T> items) where T : struct, IConvertible, IComparable<T>
        {
            dynamic count = 0;
            foreach (T item in items)
            {
                count++;
            }

            decimal average = Sum(items) / count;
            return average;
        }
    }
