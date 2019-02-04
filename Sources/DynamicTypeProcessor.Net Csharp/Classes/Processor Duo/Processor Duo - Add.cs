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

namespace DaanV2
{
    public partial class ProcessorDuo
    {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="Process"></param>
        public void AddProcessMethod(object A, object B, IProcessMethodDuo Process)
        {
            this.ProcessorMethods[(A.GetType(), B.GetType())] = Process;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="TInA"></typeparam>
        /// <typeparam name="TInB"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Process"></param>
        public void AddProcessMethod<TInA, TInB, TResult>(IProcessMethod<TResult, TInA, TInB> Process)
        {
            this.ProcessorMethods[(typeof(TInA), typeof(TInB))] = Process;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="TInA"></typeparam>
        /// <typeparam name="TInB"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        public void AddProcessMethod<TInA, TInB, TResult>(Func<TInA, TInB, TResult> func)
        {
            this.ProcessorMethods[(typeof(TInA), typeof(TInB))] = new ProcessMethod<TInA, TInB, TResult>(func);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        public void AddProcessor(IProcessorDuo processor)
        {
            this.Processors.Add(processor);
            processor.AddProcessMethods(this);
        }
    }
}
