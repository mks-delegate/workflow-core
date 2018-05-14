using System.Linq.Expressions;

namespace WorkflowCore.Models
{
    public class DataMappingStatics
    {        
        public string Source { get; set; }
                
        public LambdaExpression Target { get; set; }
    }
}
