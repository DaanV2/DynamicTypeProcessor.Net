using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DOLATER prune namespace: DaanV2
namespace DaanV2
{
    public partial class Processor
    {
        ///DOLATER <summary>Add Description</summary>
        public DaanV2.ThreadSafe.Collections.Generic.Dictionary<Type, IProcessMethod> ProcessorMethods { get; set; }

        ///DOLATER <summary>Add Description</summary>
        public List<IProcessor> Processors { get; set; }

        ///DOLATER <summary></summary>
        public IProcessMethod DefaultProcessMethod { get; set; }
    }
}
