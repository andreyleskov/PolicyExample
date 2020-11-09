namespace PolicyExample.Scripting.GraphLogic
{
    /// <summary>
    /// Exposed to a script, should not have any public members more than available to a script
    /// </summary>
    public class NodeBehaviorFacade
    {
        
        /// <summary>
        /// Must hide properties and fields from Script
        /// </summary>
        internal NodeExecutionResult? Result { get; set; }
        private readonly LogicNode _node;
    
        public NodeBehaviorFacade(LogicNode node)
        {
            _node = node;
        }
        public void StopFlow()
        {
            Result = ExecutionSuccessAndStop.Instance;
        }

        public void RedirectFlowToParent()
        {
            Result = new ExecutionSuccessAndRedirect(_node.Parent);;
        }
        
        public bool RedirectFlowToChild(int index)
        {
            if (_node.Children.Count >= index)
            {
                Result = new ExecutionSuccessAndRedirect(_node.Children[index]);
                return true;
            }

            return false;
        }
    }
}