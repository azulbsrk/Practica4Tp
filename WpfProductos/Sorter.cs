using System.Collections.Generic;

namespace WpfProductos
{
    public static class Sorter
    {
        public static List<Product> QuickSort(List<Product> list)
        {
            if (list.Count <= 1) return list;

            var pivot = list[0];
            var menores = new List<Product>();
            var mayores = new List<Product>();

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].Precio < pivot.Precio) menores.Add(list[i]);
                else mayores.Add(list[i]);
            }

            var result = QuickSort(menores);
            result.Add(pivot);
            result.AddRange(QuickSort(mayores));
            return result;
        }

        public static List<Product> MergeSort(List<Product> list)
        {
            if (list.Count <= 1) return list;

            int mid = list.Count / 2;
            var left = MergeSort(list.GetRange(0, mid));
            var right = MergeSort(list.GetRange(mid, list.Count - mid));

            return Merge(left, right);
        }

        private static List<Product> Merge(List<Product> a, List<Product> b)
        {
            var result = new List<Product>();
            int i = 0, j = 0;

            while (i < a.Count && j < b.Count)
            {
                if (a[i].Precio < b[j].Precio)
                    result.Add(a[i++]);
                else
                    result.Add(b[j++]);
            }

            while (i < a.Count) result.Add(a[i++]);
            while (j < b.Count) result.add(b[j++]);

            return result;
        }
    }
}
