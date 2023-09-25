using System.Collections.Generic;
using UnityEngine;

public class BTTest : MonoBehaviour
{
    private BehaviorTree _behaviorTree;
    
    private void Start()
    {
        _behaviorTree = new BehaviorTree(SetBT());
    }

    private void Update()
    {
        _behaviorTree.Tick();
    }

    private INode SetBT()
    {
        return new SelectorNode(
            new List<INode>
            {
                new SequenceNode(
                    new List<INode>
                    {
                        new ActionNode(() =>
                        {
                            Debug.Log("Sequence Node 1");
                            return INode.NodeState.Success;
                        })
                    }
                ),
                new ActionNode(() =>
                {
                    Debug.Log("Action Node 1");
                    return INode.NodeState.Success;
                })
            }
        );
    }
}
