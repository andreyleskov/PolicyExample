using System.Collections.Generic;

namespace PolicyExample.GraphQL.DTO
{
    public class CreateLogicGraphResult : CommandExecutionResult {
     
        
        public List<string> Errors { get; set; }
    
        
        public bool Success { get; set; }
    
        
        public string LogicGraphId { get; set; }
        
    }
}