using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace EntityCodexFixed
{
    public class EntityCodexFixed_Mod : Mod
    {
        public static EntityCodexFixed_Settings settings;

        public EntityCodexFixed_Mod(ModContentPack content)
            : base(content)
        {
            settings = GetSettings<EntityCodexFixed_Settings>();
        }

        public override string SettingsCategory()
        {
            return "Fixed! - Entity Codex";
        }

        public override void DoSettingsWindowContents(Rect inRect)
        {
            settings.DoWindowContents(inRect);
        }
    }
}
