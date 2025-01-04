using RimWorld;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using Verse.Sound;

namespace EntityCodexFixed
{
    public class MainButtonWorker_AnomalyCodexTab : MainButtonWorker
    {
        public override bool Disabled
        {
            get
            {
                if (base.Disabled)
                {
                    return true;
                }
                if (!ModsConfig.AnomalyActive)
                {
                    return true;
                }
                if(Find.Anomaly.Level == 0 && !EntityCodexFixed_Settings.alwaysShow)
                {
                    return true;
                }
                return false;
            }
        }
        public override void Activate()
        {
            Find.WindowStack.Add(new Dialog_EntityCodex());
        }
        public override bool Visible => !Disabled;
    }


}
