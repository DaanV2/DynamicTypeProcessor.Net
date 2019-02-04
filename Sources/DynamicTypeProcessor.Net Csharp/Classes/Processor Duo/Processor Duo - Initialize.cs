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
    ///TODO <summary> add description for class: Processor</summary>
	[Serializable]
    public partial class ProcessorDuo
    {
        /// <summary>Creates a new instance of <see cref="ProcessorDuo"/></summary>
        public ProcessorDuo()
        {
            this.ProcessorMethods = new ThreadSafe.Collections.Generic.Dictionary<(Type A, Type B), IProcessMethod>();
            this.Processors = new List<IProcessor>();
            this.DefaultProcessMethod = null;
        }

        /// <summary>Creates a new instance of <see cref="ProcessorDuo"/></summary>
        /// <param name="processors"></param>
        public ProcessorDuo(params IProcessor[] processors) : this()
        {
            for (int I = 0; I < processors.Length; I++)
            {
                this.Processors.Add(Processors[I]);
                processors[I].AddProcessMethods(this);
            }
        }
    }
}