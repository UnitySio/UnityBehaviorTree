using System;
using UnityEngine;

public class ActionNode : INode
{
    private Func<INode.NodeState> _callback;
    
    public ActionNode(Func<INode.NodeState> callback)
    {
        _callback = callback;
    }
    
    public INode.NodeState Evaluate() => _callback?.Invoke() ?? INode.NodeState.Failure;
}
