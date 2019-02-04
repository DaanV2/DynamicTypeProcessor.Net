﻿/*ISC License

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
    public partial class Processor
    {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="Process"></param>
        public void AddProcessMethod(object A, IProcessMethod Process)
        {
            this.ProcessorMethods[A.GetType()] = Process;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="TInA"></typeparam>
        /// <typeparam name="TInB"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="Process"></param>
        public void AddProcessMethod<TInA, TResult>(IProcessMethod<TResult, TInA> Process)
        {
            this.ProcessorMethods[typeof(TInA)] = Process;
        }

        ///DOLATER <summary>Add Description</summary>
        /// <typeparam name="TInA"></typeparam>
        /// <typeparam name="TInB"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        public void AddProcessMethod<TInA, TResult>(Func<TInA, TResult> func)
        {
            this.ProcessorMethods[typeof(TInA)] = new ProcessMethod<TInA, TResult>(func);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name=""></param>
        public void AddProcessor(IProcessor processor)
        {
            this.Processors.Add(processor);
            processor.AddProcessMethods(this);
        }
    }
}