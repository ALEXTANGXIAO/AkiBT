using System.Collections.Generic;
using UnityEngine;
namespace Kurisu.AkiBT
{
    public class BehaviorTreeTemplate
    {
        [SerializeReference]
        private List<SharedVariable> variables;
        [SerializeReference]
        private Root root;
        public List<SharedVariable> Variables=>variables;
        public Root Root=>root;
        public BehaviorTreeTemplate(IBehaviorTree behaviorTree)
        {
            variables=new List<SharedVariable>();
            foreach(var variable in behaviorTree.SharedVariables)
            {
                variables.Add(variable.Clone() as SharedVariable);
            }
            root=behaviorTree.Root;            
        }
    }
}
