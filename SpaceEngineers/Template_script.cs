#region Prelude
using System;
using System.Runtime;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

using VRageMath;
using VRage.Collections;
using VRage.Game;
using VRage.Game.Components;
using VRage.Game.ModAPI.Ingame;
using VRage.Game.ObjectBuilders.Definitions;

using Sandbox.ModAPI.Ingame;
using Sandbox.ModAPI.Interfaces;
using Sandbox.Game.EntityComponents;

using SpaceEngineers.Game.ModAPI.Ingame;


// Each script gets a single namespace
namespace SpaceEngineers.IngameScript.ProjectName {
    public sealed class Program : MyGridProgram {

#endregion // End of prelude

        public Program() {
            // Optional initialization constructor, called once per session, first

            // Allow blocks to self update

            // UpdateFrequency.Update1   = 0001
            // UpdateFrequency.Update10  = 0010
            // UpdateFrequency.Update100 = 0100

            // Bitwise combinations allow every nth tick as well as mth tick
            // Example: 
            // RuntimeInfo.UpdateFrequency = UpdateFrequency.Update1 | UpdateFrequency.Update10
            // => Every tick, and every 10th tick
            
            // RuntimeInfo.UpdateFrequency = UpdateFrequency.Update1
            // RuntimeInfo.UpdateFrequency = UpdateFrequency.Update10
            // RuntimeInfo.UpdateFrequency = UpdateFrequency.Update100
            // 
        }

        public void Save() {
            // Optional method, called when program needs to save state                    
            // Primary use is to save state to the Storage field (or other ways)
        }

        // string is required input, UpdateType is optional (tells of what caused the script to run)
        public void Main(string args, UpdateType updateSource) {
            // Required method
            
            // Main entrypoint, run every time one of the programmable block's Run actions are invoked,
            // or the script updates itself
        }
        
#region Footer
    }
}
#endregion // End of custom scripts