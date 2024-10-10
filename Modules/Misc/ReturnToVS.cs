using GorillaLocomotion;
using GT_CustomMapSupportRuntime;
using UnityEngine;
namespace Grate.Modules.Misc
{
    public class ReturnToVS : GrateModule
    {
        bool FirstMakebugFix;
        public override string GetDisplayName()
        {
            return "Return To VStump";
        }

        public override string Tutorial()
        {
            return "Press to go back to the virtual stump \n Only Works when in Map (duh)";
        }

        protected override void OnEnable()
        {
            base.OnEnable();
            if (!FirstMakebugFix)
            {
                FirstMakebugFix = true;
                return;
            }
            else
            {
                if (FindObjectOfType<AccessDoorPlaceholder>() != null)
                {
                    Transform stumpT = FindObjectOfType<AccessDoorPlaceholder>().transform;
                    Player.Instance.TeleportTo(stumpT.position + new Vector3(0, .1f, 0), stumpT.rotation);
                }
            }
            this.enabled = false;
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            FirstMakebugFix = false;
        }
        protected override void Cleanup()
        {
            
        }
    }
}