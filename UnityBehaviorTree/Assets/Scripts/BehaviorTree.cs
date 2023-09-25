using UnityEngine;

public class BehaviorTree
{
    private INode _root;
    
    public BehaviorTree(INode root)
    {
        _root = root;
    }
    
    public void Tick()
    {
        _root.Evaluate();
    }
}
