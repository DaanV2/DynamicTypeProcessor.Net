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

namespace DaanV2
{
    public partial class Processor
    {
        /// <summary>The collection of <see cref="IProcessMethodDuo"/> coupled with their input types</summary>
        public DaanV2.ThreadSafe.Collections.Generic.Dictionary<Type, IProcessMethod> ProcessorMethods { get; set; }

        /// <summary>Gets or sets the <see cref="List(IProcessorDuo)"/> that holds the orginal <see cref="IProcessMethodDuo"/></summary>
        public List<IProcessor> Processors { get; set; }

        /// <summary>Gets or sets the default <see cref="IProcessMethodDuo"/> that is to be used when no discerning type has been found</summary>
        public IProcessMethod DefaultProcessMethod { get; set; }
    }
}
