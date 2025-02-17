using UnityEngine;
namespace Kurisu.AkiBT.Extend
{
    [AkiInfo("Action:固定返回值,运行后返回固定值,你可以将该结点放在组合逻辑的尾部保持返回值")]
    [AkiLabel("FixedReturn")]
    public class FixedReturn : Action
    {
        [SerializeField]
        private Status returnStatus;
        protected override Status OnUpdate()
        {
            return returnStatus;
        }
    }
}