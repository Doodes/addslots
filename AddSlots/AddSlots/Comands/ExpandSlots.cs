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

        public string Description { get; } = "Разширяет колличество слотов сервера до 30, если прописанно заново то возвращяет обратно.";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            int SavedSlots = 25;
            if (Server.MaxPlayerCount != 30)
            {
                SavedSlots = Server.MaxPlayerCount;
                Server.MaxPlayerCount = 30;
                response = "Готово! Слоты выставлены на 30.";
                return true;
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
