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

namespace DaanV2
{
    ///DOLATER <summary>Add Description</summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IProcessMethod
    {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="A">DOLATER FILL IN</param>
        /// <returns></returns>
        object Process(object A);
    }

    ///DOLATER <summary>Add Description</summary>
    /// <typeparam name="TResult"></typeparam>
    public interface IProcessMethod<out TResult, in TInA> : IProcessMethod
    {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="A">DOLATER FILL IN</param>
        /// <param name="B">DOLATER FILL IN</param>
        /// <returns></returns>
        TResult Process(TInA A);
    }
}
