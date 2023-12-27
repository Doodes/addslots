using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using System.ComponentModel;
namespace AddSlots
{
    public sealed class Config:IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }
        [Description("Можно ли указать количество слотов при написании команды")]
        public bool CanChangeAmountOfSlotsSet {get; set;} = false;
        [Description("Если указать количество слотов нельзя, то какое количество будет ставить команда")]
        public int DefaultAmountSet {get; set;} = 30;
    }
}
