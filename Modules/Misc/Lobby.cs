using Grate.GUI;
using GorillaNetworking;

namespace Grate.Modules.Misc
{
    public class Lobby : GrateModule
    {

        public static readonly string DisplayName = "Join Grate Code";

        protected override void OnEnable()
        {
            if (!MenuController.Instance.Built) return;
            base.OnEnable();
            Plugin.Instance.JoinLobby("GRATE_MOD", "MODDED_MODDED_CASUALCASUAL");
            this.enabled = false;
        }
        public override string GetDisplayName()
        {
            return DisplayName;
        }

        public override string Tutorial()
        {
            return "Joins the official Grate Mod code";
        }

        protected override void Cleanup() { }   
    }
}
