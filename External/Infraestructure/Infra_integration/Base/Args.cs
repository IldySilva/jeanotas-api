using System.Collections.Generic;

namespace Infraestructure.Infra_integration.Base
{
    public class Args
    {
        public string Path { get; set; }
        public IDictionary<string, IEnumerable<string>> Headers { get; set; }
        public object [] Filters { get; set; }  
    }
}
