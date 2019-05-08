using Microsoft.Xna.Framework.Graphics;
using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSMAPI
{
    public class SSMAPI : Mod {

        public override void Entry(IModHelper helper) {
            Effect shader = Helper.Content.Load<Effect>("Sepia.xnb");
            Helper.Shaders.Add(shader);

            Helper.Events.GameLoop.SaveLoaded += ApplyShader;
        }

        public void ApplyShader(object sender, EventArgs e) {
            Helper.Shaders.Set(1);
        }
    }
}
