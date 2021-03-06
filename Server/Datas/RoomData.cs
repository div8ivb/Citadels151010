﻿using Server.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Datas
{
   public class RoomData
    {
        public List<PlayerData> PlayerDataList{set; get;}
        public List<Building> BackB { set; get; }
        public List<Hero> BackH { set; get; }
        public List<Building> TableB { set; get; }
        public List<Hero> TableH { set; get; }
        public Dictionary<int, int> Hero2PlayerDic { set; get; }
        public string Status{set; get;}
        public int FinishCount { get; set; }
        public int KilledNum { get; set; }
        public RoomData()
        {
            BackB = new List<Building>();
            BackH = new List<Hero>();
            CardRes cardRes = new CardRes();
            BackB = cardRes.Buildings;
            cardRes.Heros.ForEach(i => BackH.Add(i));
            TableB = new List<Building>();
            TableH = new List<Hero>();
            Hero2PlayerDic = new Dictionary<int, int>();
            PlayerDataList = new List<PlayerData>();
            Status = "未开始";
            FinishCount = 0;
            KilledNum = -1;
        }
    }
}
