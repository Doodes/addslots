using CommandSystem;
using System;
using Exiled.API.Features;
using Exiled.API.Features.Pickups;
using AddSlots;

namespace AddSlots.Comands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    class ExpandSlots : ICommand
    {
        public string Command { get; } = "expandslots";

        public string[] Aliases { get; } = new[] {"es", "expsl", "уы", "учзыд", "учзфтвыдщеы"};

        public string Description { get; } = "Разширяет колличество слотов сервера до Х, если прописанно заново то возвращяет обратно.";

        public int SavedSlots { get; private set; } = 25;
        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            SavedSlots = 25;
            if (Server.MaxPlayerCount != SavedSlots)
            {
                if (Config.CanSetAmount)
                {
                    SavedSlots = Server.MaxPlayerCount;
                    Server.MaxPlayerCount = Convert.ToInt32(arguments.Array[arguments.Offset]);
                    response = $"Готово! Слоты выставлены на {arguments.Array[arguments.Offset]}.";
                    return true;
                }
                else
                {
                    SavedSlots = Server.MaxPlayerCount;
                    Server.MaxPlayerCount = Config.DefaultAmount;
                    response = $"Готово! Слоты выставлены на {Config.DefaultAmount}.";
                    return true;
                }

            }
            else if (Server.MaxPlayerCount != Config.DefaultAmount)
            {
                if (Config.CanSetAmount)
                {
                    SavedSlots = Server.MaxPlayerCount;
                    Server.MaxPlayerCount = Convert.ToInt32(arguments.Array[arguments.Offset]);
                    response = $"Готово! Слоты выставлены на {arguments.Array[arguments.Offset]}.";
                    return true;
                }
                else
                {
                    SavedSlots = Server.MaxPlayerCount;
                    Server.MaxPlayerCount = Config.DefaultAmount;
                    response = $"Готово! Слоты выставлены на {Config.DefaultAmount}.";
                    return true;
                }
            }
            else
            {
                Server.MaxPlayerCount = SavedSlots;
                response = $"Готово! Слоты возвращены в значение {SavedSlots}.";
                return true;
            }
        }
        
    }
}
