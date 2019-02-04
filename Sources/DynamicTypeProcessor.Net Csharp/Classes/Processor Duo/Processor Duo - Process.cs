/*ISC License

Copyright (c) 2019, Daan Verstraten, daanverstraten@hotmail.com

Permission to use, copy, modify, and/or distribute this software for any
purpose with or without fee is hereby granted, provided that the above
copyright notice and this permission notice appear in all copies.

THE SOFTWARE IS PROVIDED "AS IS" AND THE AUTHOR DISCLAIMS ALL WARRANTIES
WITH REGARD TO THIS SOFTWARE INCLUDING ALL IMPLIED WARRANTIES OF
MERCHANTABILITY AND FITNESS. IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR
ANY SPECIAL, DIRECT, INDIRECT, OR CONSEQUENTIAL DAMAGES OR ANY DAMAGES
WHATSOEVER RESULTING FROM LOSS OF USE, DATA OR PROFITS, WHETHER IN AN
ACTION OF CONTRACT, NEGLIGENCE OR OTHER TORTIOUS ACTION, ARISING OUT OF
OR IN CONNECTION WITH THE USE OR PERFORMANCE OF THIS SOFTWARE.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaanV2
{
    public partial class ProcessorDuo
    {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <exception cref="ArgumentException" />
        /// <returns></returns>
        public object Process(object A, object B)
        {
            (Type A, Type B) Key = (A.GetType(), B.GetType());

            if (this.ProcessorMethods.ContainsKey(Key))
                return this.ProcessorMethods[Key].Process(A, B);

            else if (this.DefaultProcessMethod != null)
                return this.DefaultProcessMethod.Process(A, B);

            else
                throw new ArgumentException($"Processor for type: {Key.A.Name} and {Key.B.Name}");
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <exception cref="ArgumentException" />
        /// <returns></returns>
        public TResult Process<TInA, TInB, TResult>(TInA A, TInB B)
        {
            (Type A, Type B) Key = (typeof(TInA), typeof(TInB));

            if (this.ProcessorMethods.ContainsKey(Key))
                return (TResult)this.ProcessorMethods[Key].Process(A, B);

            else if (this.DefaultProcessMethod != null)
                return this.DefaultProcessMethod.Process(A, B);

            else
                throw new ArgumentException($"Processor for type: {Key.A.Name} and {Key.B.Name}");
        }
    }
}
