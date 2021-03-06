﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LangExt
{
    /// <summary>Funcデリゲートに対する関数を提供します。</summary>
    public static partial class Func
    {
        /// <summary>Id関数です。</summary>
        public static T Id<T>(T t) { return t; }

        /// <summary>2引数関数の引数の順番を入れ替えます。</summary>
        public static Func<T2, T1, U> Flip<T1, T2, U>(this Func<T1, T2, U> f)
        {
            return (t2, t1) => f(t1, t2);
        }

        /// <summary>カリー化関数の引数の順番を入れ替えます。</summary>
        public static Func<T2, Func<T1, U>> Flip<T1, T2, U>(this Func<T1, Func<T2, U>> f)
        {
            return t2 => t1 => f(t1)(t2);
        }
    }
}
