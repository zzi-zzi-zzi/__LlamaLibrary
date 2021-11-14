﻿using System.Collections.Generic;
using ff14bot.Managers;

namespace LlamaLibrary.RemoteWindows
{
    //TODO Move element numbers to dictionary
    public class CollectablesShop : RemoteWindow<CollectablesShop>
    {
        private const string WindowName = "CollectablesShop";

        public int RowCount => Elements[20].TrimmedData - 1;
        public int TurninCount => Elements[4843].TrimmedData;
        public CollectablesShop() : base(WindowName)
        {
            _name = WindowName;
        }

        public void SelectJob(int job)
        {
            SendAction(2, 3, 0xE, 4, (ulong)job);
        }

        public void SelectItem(int line)
        {
            SendAction(2, 3, 0xC, 4, (ulong)line);
        }

        public void Trade()
        {
            SendAction(2, 3, 0xf, 4, 0);
        }

        public List<string> ListItems()
        {
            var count = Elements[20].TrimmedData - 1;
            var currentElements = Elements;
            var result = new List<string>();
            for (var j = 0; j < count; j++)
            {
                if (currentElements[32 + (j * 11)].TrimmedData == Elements[21].TrimmedData)
                {
                    continue; //IconID
                }

                var itemID = currentElements[34 + (j * 11)].TrimmedData;
                if (itemID == 0 || itemID > 1500000 || itemID < 500000)
                {
                    continue;
                }

                result.Add($"{j}: {DataManager.GetItem((uint)(itemID - 500000))} {itemID}");

                //Logger.Info($"{itemID}");
            }

            return result;
        }
    }
}