using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled;
using Exiled.API;

namespace AddSlots
{

    public class AddSlotsPlugin : Exiled.API.Features.Plugin<Config> {
    public int InitialSlots;
        public override void OnEnabled()
        {
            InitialSlots = Exiled.API.Features.Server.MaxPlayerCount;
            //ёп куда я жмал
        }
    

        
    
            
       
        
        public override void OnDisabled()
        {
            Exiled.API.Features.Server.MaxPlayerCount = InitialSlots;
        }
    }
}
   



