using System.Collections.Generic;

namespace PolicyExample.GraphQL.DTO
{
    public class RunLogicGraphResult : CommandExecutionResult {
     
        
        public List<string> Errors { get; set; }
    
        
        public bool Success { get; set; }
    
        
        public RunReport RunReport { get; set; }
        
    }
}