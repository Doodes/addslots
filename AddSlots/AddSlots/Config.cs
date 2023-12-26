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

    }
}
