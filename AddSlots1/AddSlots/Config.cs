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
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; }
        [Description("Можно ли поставить своё колличество слотов в команду")]
        public static bool CanSetAmount { get; set; } = false;
        [Description("Если нелзя, то какое число поставить")]
        public static int DefaultAmount { get; set; } = 30;
    }
}
