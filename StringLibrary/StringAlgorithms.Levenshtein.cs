namespace StringLibrary
{
    using System;

    public static partial class StringAlgorithms
    {
        public static int LevensteinDistance(this string a, string b)
        {
            if (string.IsNullOrEmpty(a))
                return -1;
            var aLen = a.Length;
            var bLen = b.Length;
            if (string.IsNullOrEmpty(b))
                return aLen;

            Int32 cost;
            Int32[,] d = new int[a.Length + 1, b.Length + 1];
            Int32 min1;
            Int32 min2;
            Int32 min3;


            for (int i = 0; i <= aLen; i++)
                d[i, 0] = i;

            for (int j = 0; j <= bLen; j++)
                d[0, j] = j;

            for (Int32 i = 1; i <= d.GetUpperBound(0); i += 1)
            {
                for (Int32 j = 1; j <= d.GetUpperBound(1); j += 1)
                {
                    cost = Convert.ToInt32(a[i - 1] != b[j - 1]);

                    min1 = d[i - 1, j] + 1;
                    min2 = d[i, j - 1] + 1;
                    min3 = d[i - 1, j - 1] + cost;
                    d[i, j] = Math.Min(Math.Min(min1, min2), min3);

                }
            }

            return d[aLen, bLen];
        }
    }
}