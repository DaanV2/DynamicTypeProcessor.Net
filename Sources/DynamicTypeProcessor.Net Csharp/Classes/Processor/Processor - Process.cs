using System;

namespace DaanV2
{
    public partial class Processor
    {
        ///DOLATER <summary>Add Description</summary>
        /// <param name="A">DOLATER FILL IN</param>
        /// <param name="B">DOLATER FILL IN</param>
        /// <exception cref="ArgumentException" />
        /// <returns></returns>
        public object Process(object A)
        {
            Type Key = A.GetType();

            if (this.ProcessorMethods.ContainsKey(Key))
                return this.ProcessorMethods[Key].Process(A);

            else if (this.DefaultProcessMethod != null)
                return this.DefaultProcessMethod.Process(A);

            else
                throw new ArgumentException($"Processor for type: {Key.Name}");
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="A">DOLATER FILL IN</param>
        /// <param name="B">DOLATER FILL IN</param>
        /// <exception cref="ArgumentException" />
        /// <returns></returns>
        public TResult Process<TInA, TResult>(TInA A)
        {
            Type Key = typeof(TInA);

            if (this.ProcessorMethods.ContainsKey(Key))
                return (TResult)this.ProcessorMethods[Key].Process(A);

            else if (this.DefaultProcessMethod != null)
                return (TResult)this.DefaultProcessMethod.Process(A);

            else
                throw new ArgumentException($"Processor for type: {Key.Name}");
        }

        ///DOLATER <summary>Add Description</summary>
        /// <param name="A">DOLATER FILL IN</param>
        /// <param name="B">DOLATER FILL IN</param>
        /// <exception cref="ArgumentException" />
        /// <returns></returns>
        public TResult Process<TResult>(object A)
        {
            Type Key = A.GetType();

            if (this.ProcessorMethods.ContainsKey(Key))
                return (TResult)this.ProcessorMethods[Key].Process(A);

            else if (this.DefaultProcessMethod != null)
                return (TResult)this.DefaultProcessMethod.Process(A);

            else
                throw new ArgumentException($"Processor for type: {Key.Name}");
        }
    }
}
