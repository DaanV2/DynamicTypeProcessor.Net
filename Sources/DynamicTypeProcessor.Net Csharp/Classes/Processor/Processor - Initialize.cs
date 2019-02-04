using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DOLATER prune namespace: DaanV2
namespace DaanV2
{
    ///DOLATER <summary> add description for class: Processor</summary>
	[Serializable]
    public partial class Processor
    {
        /// <summary>Creates a new instance of <see cref="ProcessorDuo"/></summary>
        public Processor()
        {
            this.ProcessorMethods = new ThreadSafe.Collections.Generic.Dictionary<Type, IProcessMethod>();
            this.Processors = new List<IProcessor>();
            this.DefaultProcessMethod = null;
        }

        /// <summary>Creates a new instance of <see cref="ProcessorDuo"/></summary>
        /// <param name="processors"></param>
        public Processor(params IProcessor[] processors) : this()
        {
            for (int I = 0; I < processors.Length; I++)
            {
                this.Processors.Add(Processors[I]);
                processors[I].AddProcessMethods(this);
            }
        }
    }
}
