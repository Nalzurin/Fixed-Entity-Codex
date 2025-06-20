using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
namespace EntityCodexFixed
{
    [StaticConstructorOnStartup]
    public static class HarmonyStarter
    {
        static HarmonyStarter()
        {
            Harmony harmony = new Harmony("EntityCodexFixed");
            harmony.PatchAll();
        }
    }
    [HarmonyPatch]
    public static class Patch_PlaySettingsRemoveAnomalyCodex
    {
        private static MethodBase TargetMethod()
        {
            return AccessTools.Method(typeof(PlaySettings), "DoPlaySettingsGlobalControls");
        }
        private static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions, ILGenerator il)
        {
            foreach (CodeInstruction instruction in instructions)
            {

                if (instruction.opcode == OpCodes.Call && instruction.Calls(AccessTools.Method(typeof(ModsConfig), "get_AnomalyActive")))
                {
                    CodeInstruction instr = new CodeInstruction(OpCodes.Ldc_I4_0);
                    instr.labels = instruction.ExtractLabels();
                    yield return instr;
                    continue;
                }
                yield return instruction;
            }
        }

    }
}