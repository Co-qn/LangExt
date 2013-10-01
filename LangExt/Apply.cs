﻿
using System;
using System.Collections.Generic;

namespace LangExt
{
    /// <summary>
    /// 任意のモナドに対して関数を適用できる形式（Applicative）に変換する機能を提供するクラスです。
    /// </summary>
    public static class Apply
    {
        #region for the Option
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1>
        {
            Option<TArg1> m1;

            internal ApplicativeOption(Option<TArg1> m1)
            {
                this.m1 = m1;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TResult> f)
            {
                return 
                    from arg1 in m1
                    select f(arg1);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1> To<TArg1>(Option<TArg1> m1)
        {
            return new ApplicativeOption<TArg1>(m1);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2)
            {
                this.m1 = m1;
                this.m2 = m2;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    select f(arg1, arg2);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2> To<TArg1, TArg2>(Option<TArg1> m1, Option<TArg2> m2)
        {
            return new ApplicativeOption<TArg1, TArg2>(m1, m2);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    select f(arg1, arg2, arg3);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3> To<TArg1, TArg2, TArg3>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3>(m1, m2, m3);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    select f(arg1, arg2, arg3, arg4);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4> To<TArg1, TArg2, TArg3, TArg4>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4>(m1, m2, m3, m4);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    select f(arg1, arg2, arg3, arg4, arg5);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5> To<TArg1, TArg2, TArg3, TArg4, TArg5>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5>(m1, m2, m3, m4, m5);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    select f(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(m1, m2, m3, m4, m5, m6);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(m1, m2, m3, m4, m5, m6, m7);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(m1, m2, m3, m4, m5, m6, m7, m8);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;
            Option<TArg9> m9;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(m1, m2, m3, m4, m5, m6, m7, m8, m9);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;
            Option<TArg9> m9;
            Option<TArg10> m10;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;
            Option<TArg9> m9;
            Option<TArg10> m10;
            Option<TArg11> m11;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;
            Option<TArg9> m9;
            Option<TArg10> m10;
            Option<TArg11> m11;
            Option<TArg12> m12;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;
            Option<TArg9> m9;
            Option<TArg10> m10;
            Option<TArg11> m11;
            Option<TArg12> m12;
            Option<TArg13> m13;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;
            Option<TArg9> m9;
            Option<TArg10> m10;
            Option<TArg11> m11;
            Option<TArg12> m12;
            Option<TArg13> m13;
            Option<TArg14> m14;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;
            Option<TArg9> m9;
            Option<TArg10> m10;
            Option<TArg11> m11;
            Option<TArg12> m12;
            Option<TArg13> m13;
            Option<TArg14> m14;
            Option<TArg15> m15;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14, Option<TArg15> m15)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
                this.m15 = m15;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    from arg15 in m15
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14, Option<TArg15> m15)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>
        {
            Option<TArg1> m1;
            Option<TArg2> m2;
            Option<TArg3> m3;
            Option<TArg4> m4;
            Option<TArg5> m5;
            Option<TArg6> m6;
            Option<TArg7> m7;
            Option<TArg8> m8;
            Option<TArg9> m9;
            Option<TArg10> m10;
            Option<TArg11> m11;
            Option<TArg12> m12;
            Option<TArg13> m13;
            Option<TArg14> m14;
            Option<TArg15> m15;
            Option<TArg16> m16;

            internal ApplicativeOption(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14, Option<TArg15> m15, Option<TArg16> m16)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
                this.m15 = m15;
                this.m16 = m16;
            }

            public Option<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    from arg15 in m15
                    from arg16 in m16
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(Option<TArg1> m1, Option<TArg2> m2, Option<TArg3> m3, Option<TArg4> m4, Option<TArg5> m5, Option<TArg6> m6, Option<TArg7> m7, Option<TArg8> m8, Option<TArg9> m9, Option<TArg10> m10, Option<TArg11> m11, Option<TArg12> m12, Option<TArg13> m13, Option<TArg14> m14, Option<TArg15> m15, Option<TArg16> m16)
        {
            return new ApplicativeOption<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16);
        }
        
        #endregion

        #region for the Result
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1)
            {
                this.m1 = m1;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TResult> f)
            {
                return 
                    from arg1 in m1
                    select f(arg1);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArgOfMonad> To<TArg1, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1)
        {
            return new ApplicativeResult<TArg1, TArgOfMonad>(m1);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2)
            {
                this.m1 = m1;
                this.m2 = m2;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    select f(arg1, arg2);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArgOfMonad> To<TArg1, TArg2, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2)
        {
            return new ApplicativeResult<TArg1, TArg2, TArgOfMonad>(m1, m2);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    select f(arg1, arg2, arg3);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArgOfMonad> To<TArg1, TArg2, TArg3, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArgOfMonad>(m1, m2, m3);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    select f(arg1, arg2, arg3, arg4);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArgOfMonad>(m1, m2, m3, m4);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    select f(arg1, arg2, arg3, arg4, arg5);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArgOfMonad>(m1, m2, m3, m4, m5);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    select f(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArgOfMonad>(m1, m2, m3, m4, m5, m6);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;
            Result<TArg9, TArgOfMonad> m9;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8, m9);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;
            Result<TArg9, TArgOfMonad> m9;
            Result<TArg10, TArgOfMonad> m10;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;
            Result<TArg9, TArgOfMonad> m9;
            Result<TArg10, TArgOfMonad> m10;
            Result<TArg11, TArgOfMonad> m11;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;
            Result<TArg9, TArgOfMonad> m9;
            Result<TArg10, TArgOfMonad> m10;
            Result<TArg11, TArgOfMonad> m11;
            Result<TArg12, TArgOfMonad> m12;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;
            Result<TArg9, TArgOfMonad> m9;
            Result<TArg10, TArgOfMonad> m10;
            Result<TArg11, TArgOfMonad> m11;
            Result<TArg12, TArgOfMonad> m12;
            Result<TArg13, TArgOfMonad> m13;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12, Result<TArg13, TArgOfMonad> m13)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12, Result<TArg13, TArgOfMonad> m13)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;
            Result<TArg9, TArgOfMonad> m9;
            Result<TArg10, TArgOfMonad> m10;
            Result<TArg11, TArgOfMonad> m11;
            Result<TArg12, TArgOfMonad> m12;
            Result<TArg13, TArgOfMonad> m13;
            Result<TArg14, TArgOfMonad> m14;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12, Result<TArg13, TArgOfMonad> m13, Result<TArg14, TArgOfMonad> m14)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12, Result<TArg13, TArgOfMonad> m13, Result<TArg14, TArgOfMonad> m14)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;
            Result<TArg9, TArgOfMonad> m9;
            Result<TArg10, TArgOfMonad> m10;
            Result<TArg11, TArgOfMonad> m11;
            Result<TArg12, TArgOfMonad> m12;
            Result<TArg13, TArgOfMonad> m13;
            Result<TArg14, TArgOfMonad> m14;
            Result<TArg15, TArgOfMonad> m15;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12, Result<TArg13, TArgOfMonad> m13, Result<TArg14, TArgOfMonad> m14, Result<TArg15, TArgOfMonad> m15)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
                this.m15 = m15;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    from arg15 in m15
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12, Result<TArg13, TArgOfMonad> m13, Result<TArg14, TArgOfMonad> m14, Result<TArg15, TArgOfMonad> m15)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15);
        }

        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArgOfMonad>
        {
            Result<TArg1, TArgOfMonad> m1;
            Result<TArg2, TArgOfMonad> m2;
            Result<TArg3, TArgOfMonad> m3;
            Result<TArg4, TArgOfMonad> m4;
            Result<TArg5, TArgOfMonad> m5;
            Result<TArg6, TArgOfMonad> m6;
            Result<TArg7, TArgOfMonad> m7;
            Result<TArg8, TArgOfMonad> m8;
            Result<TArg9, TArgOfMonad> m9;
            Result<TArg10, TArgOfMonad> m10;
            Result<TArg11, TArgOfMonad> m11;
            Result<TArg12, TArgOfMonad> m12;
            Result<TArg13, TArgOfMonad> m13;
            Result<TArg14, TArgOfMonad> m14;
            Result<TArg15, TArgOfMonad> m15;
            Result<TArg16, TArgOfMonad> m16;

            internal ApplicativeResult(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12, Result<TArg13, TArgOfMonad> m13, Result<TArg14, TArgOfMonad> m14, Result<TArg15, TArgOfMonad> m15, Result<TArg16, TArgOfMonad> m16)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
                this.m15 = m15;
                this.m16 = m16;
            }

            /// <summary>
            /// 指定された関数をこのモナドに適用します。
            /// </summary>
            public Result<TResult, TArgOfMonad> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    from arg15 in m15
                    from arg16 in m16
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArgOfMonad> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArgOfMonad>(Result<TArg1, TArgOfMonad> m1, Result<TArg2, TArgOfMonad> m2, Result<TArg3, TArgOfMonad> m3, Result<TArg4, TArgOfMonad> m4, Result<TArg5, TArgOfMonad> m5, Result<TArg6, TArgOfMonad> m6, Result<TArg7, TArgOfMonad> m7, Result<TArg8, TArgOfMonad> m8, Result<TArg9, TArgOfMonad> m9, Result<TArg10, TArgOfMonad> m10, Result<TArg11, TArgOfMonad> m11, Result<TArg12, TArgOfMonad> m12, Result<TArg13, TArgOfMonad> m13, Result<TArg14, TArgOfMonad> m14, Result<TArg15, TArgOfMonad> m15, Result<TArg16, TArgOfMonad> m16)
        {
            return new ApplicativeResult<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TArgOfMonad>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16);
        }

        #endregion

        #region for the ISeq
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1>
        {
            ISeq<TArg1> m1;

            internal ApplicativeISeq(ISeq<TArg1> m1)
            {
                this.m1 = m1;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TResult> f)
            {
                return 
                    from arg1 in m1
                    select f(arg1);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1> To<TArg1>(ISeq<TArg1> m1)
        {
            return new ApplicativeISeq<TArg1>(m1);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2)
            {
                this.m1 = m1;
                this.m2 = m2;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    select f(arg1, arg2);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2> To<TArg1, TArg2>(ISeq<TArg1> m1, ISeq<TArg2> m2)
        {
            return new ApplicativeISeq<TArg1, TArg2>(m1, m2);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    select f(arg1, arg2, arg3);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3> To<TArg1, TArg2, TArg3>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3>(m1, m2, m3);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    select f(arg1, arg2, arg3, arg4);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4> To<TArg1, TArg2, TArg3, TArg4>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4>(m1, m2, m3, m4);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    select f(arg1, arg2, arg3, arg4, arg5);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5> To<TArg1, TArg2, TArg3, TArg4, TArg5>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5>(m1, m2, m3, m4, m5);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    select f(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>(m1, m2, m3, m4, m5, m6);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>(m1, m2, m3, m4, m5, m6, m7);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8>(m1, m2, m3, m4, m5, m6, m7, m8);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;
            ISeq<TArg9> m9;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9>(m1, m2, m3, m4, m5, m6, m7, m8, m9);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;
            ISeq<TArg9> m9;
            ISeq<TArg10> m10;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;
            ISeq<TArg9> m9;
            ISeq<TArg10> m10;
            ISeq<TArg11> m11;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;
            ISeq<TArg9> m9;
            ISeq<TArg10> m10;
            ISeq<TArg11> m11;
            ISeq<TArg12> m12;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;
            ISeq<TArg9> m9;
            ISeq<TArg10> m10;
            ISeq<TArg11> m11;
            ISeq<TArg12> m12;
            ISeq<TArg13> m13;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;
            ISeq<TArg9> m9;
            ISeq<TArg10> m10;
            ISeq<TArg11> m11;
            ISeq<TArg12> m12;
            ISeq<TArg13> m13;
            ISeq<TArg14> m14;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;
            ISeq<TArg9> m9;
            ISeq<TArg10> m10;
            ISeq<TArg11> m11;
            ISeq<TArg12> m12;
            ISeq<TArg13> m13;
            ISeq<TArg14> m14;
            ISeq<TArg15> m15;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14, ISeq<TArg15> m15)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
                this.m15 = m15;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    from arg15 in m15
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14, ISeq<TArg15> m15)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15);
        }
        
        /// <summary>
        /// 関数を適用できる形式のモナドを表すクラスです。
        /// </summary>
        public class ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>
        {
            ISeq<TArg1> m1;
            ISeq<TArg2> m2;
            ISeq<TArg3> m3;
            ISeq<TArg4> m4;
            ISeq<TArg5> m5;
            ISeq<TArg6> m6;
            ISeq<TArg7> m7;
            ISeq<TArg8> m8;
            ISeq<TArg9> m9;
            ISeq<TArg10> m10;
            ISeq<TArg11> m11;
            ISeq<TArg12> m12;
            ISeq<TArg13> m13;
            ISeq<TArg14> m14;
            ISeq<TArg15> m15;
            ISeq<TArg16> m16;

            internal ApplicativeISeq(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14, ISeq<TArg15> m15, ISeq<TArg16> m16)
            {
                this.m1 = m1;
                this.m2 = m2;
                this.m3 = m3;
                this.m4 = m4;
                this.m5 = m5;
                this.m6 = m6;
                this.m7 = m7;
                this.m8 = m8;
                this.m9 = m9;
                this.m10 = m10;
                this.m11 = m11;
                this.m12 = m12;
                this.m13 = m13;
                this.m14 = m14;
                this.m15 = m15;
                this.m16 = m16;
            }

            public ISeq<TResult> By<TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> f)
            {
                return 
                    from arg1 in m1
                    from arg2 in m2
                    from arg3 in m3
                    from arg4 in m4
                    from arg5 in m5
                    from arg6 in m6
                    from arg7 in m7
                    from arg8 in m8
                    from arg9 in m9
                    from arg10 in m10
                    from arg11 in m11
                    from arg12 in m12
                    from arg13 in m13
                    from arg14 in m14
                    from arg15 in m15
                    from arg16 in m16
                    select f(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }
        }

        /// <summary>
        /// 指定された複数のモナドを適用可能（Applicative）にします。
        /// </summary>
        public static ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16> To<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(ISeq<TArg1> m1, ISeq<TArg2> m2, ISeq<TArg3> m3, ISeq<TArg4> m4, ISeq<TArg5> m5, ISeq<TArg6> m6, ISeq<TArg7> m7, ISeq<TArg8> m8, ISeq<TArg9> m9, ISeq<TArg10> m10, ISeq<TArg11> m11, ISeq<TArg12> m12, ISeq<TArg13> m13, ISeq<TArg14> m14, ISeq<TArg15> m15, ISeq<TArg16> m16)
        {
            return new ApplicativeISeq<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16>(m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16);
        }
        
        #endregion

    }
}
