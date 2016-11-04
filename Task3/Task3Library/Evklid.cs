using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Library
{
   
    public static class Evklid
    {
        public static long Gcd(long a, long b, out long time)
        {
            System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
            st.Start();
            while (b != 0)
                b = a % (a = b);
            st.Stop();
            time = st.ElapsedMilliseconds;
            return a;
        }
        public static long GcdMany(out long time, params long[] data)
        {
            System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
            st.Start();
            long d, Time;
            d = Gcd(data[0], data[1], out Time);
            long di;
            if (data.Length>2)
            {
                for (int i = 2; i < data.Length; i++)
                {
                    di = Gcd(d, data[i], out Time);
                    d = di;
                }
            }
            st.Stop();
            time = st.ElapsedMilliseconds;
            return d;
        }

        public static long BinaryGcd(long a, long b, out long time)
        {
            System.Diagnostics.Stopwatch st = new System.Diagnostics.Stopwatch();
            st.Start();
            if (a == 0)
            {
                st.Stop();
                time = st.ElapsedMilliseconds;
                return b;
            }
            if (b == 0)
            {
                st.Stop();
                time = st.ElapsedMilliseconds;
                return a;
            }
            if (a == b)
            {
                st.Stop();
                time = st.ElapsedMilliseconds;
                return a;
            }

            if (a == 1 || b == 1)
            {
                st.Stop();
                time = st.ElapsedMilliseconds;
                return 1;
            }
            if ((a % 2 == 0) && (b % 2 == 0))
            {
                st.Stop();
                time = st.ElapsedMilliseconds;
                return 2 * Gcd(a / 2, b / 2, out time);
            }
            if ((a % 2 == 0) && (b % 2 != 0))
            {
                st.Stop();
                time = st.ElapsedMilliseconds;
                return Gcd(a / 2, b, out time);
            }
            if ((a % 2 != 0) && (b % 2 == 0))
            {
                st.Stop();
                time = st.ElapsedMilliseconds;
                return Gcd(a, b / 2, out time);
            }
            st.Stop();
            time = st.ElapsedMilliseconds;
            return Gcd(b, (long)Math.Abs(a - b), out time);
        }
    }
}
