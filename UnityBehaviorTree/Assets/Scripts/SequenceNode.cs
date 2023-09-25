using System.Collections.Generic;
using UnityEngine;

public class SequenceNode : INode
{
    private List<INode> _nodes;
    
    public SequenceNode(List<INode> nodes)
    {
        _nodes = nodes;
    }
    
    public INode.NodeState Evaluate()
    {
        if (_nodes is null) return INode.NodeState.Failure;
        
        foreach (var node in _nodes)
        {
            switch (node.Evaluate())
            {
                case INode.NodeState.Running:
                    return INode.NodeState.Running;
                case INode.NodeState.Failure:
                    return INode.NodeState.Failure;
            }
        }
        
        return INode.NodeState.Failure;
    }
}
