using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace EntityCodexFixed
{
    public class EntityCodexFixed_Settings : ModSettings
    {
        public static bool alwaysShow = true;

        public override void ExposeData()
        {

            Scribe_Values.Look(ref alwaysShow, "alwaysShow", defaultValue: true, forceSave: true);


            base.ExposeData();
        }

        public void DoWindowContents(Rect inRect)
        {
            Listing_Standard listing_Standard = new Listing_Standard();
            listing_Standard.Begin(inRect);
            listing_Standard.CheckboxLabeled("EntityCodexFixed_AlwaysShowButton".Translate(), ref alwaysShow);
            listing_Standard.End();
        }
    }
}
