﻿namespace LlamaLibrary.RemoteWindows
{
    //TODO Move element numbers to dictionary
    public class GoldSaucerReward : RemoteWindow<GoldSaucerReward>
    {
        private const string WindowName = "GoldSaucerReward";

        public GoldSaucerReward() : base(WindowName)
        {
            _name = WindowName;
        }

        public int MGPReward => Elements[1].TrimmedData;
    }
}