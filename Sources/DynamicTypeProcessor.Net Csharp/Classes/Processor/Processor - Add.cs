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

namespace DaanV2 {
    public partial class Processor {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="A">DOLATER FILL IN</param>
        /// <param name="B">DOLATER FILL IN</param>
        /// <param name="Process">DOLATER FILL IN</param>
        public void AddProcessMethod(Object A, IProcessMethod Process) {
            this.ProcessorMethods[A.GetType()] = Process;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="TInA"></typeparam>
        /// <typeparam name="TInB"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Process">DOLATER FILL IN</param>
        public void AddProcessMethod<TInA, TResult>(IProcessMethod<TResult, TInA> Process) {
            this.ProcessorMethods[typeof(TInA)] = Process;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="TInA"></typeparam>
        /// <typeparam name="TInB"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func">DOLATER FILL IN</param>
        public void AddProcessMethod<TInA, TResult>(Func<TInA, TResult> func) {
            this.ProcessorMethods[typeof(TInA)] = new ProcessMethod<TInA, TResult>(func);
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="">DOLATER FILL IN</param>
        public void AddProcessor(IProcessor processor) {
            this.Processors.Add(processor);
            processor.AddProcessMethods(this);
        }
    }
}
