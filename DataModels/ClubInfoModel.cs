﻿using DR2Rallymaster.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR2Rallymaster.DataModels
{
    class ClubInfoModel
    {
        public string ClubName { get; set; }
        public string ClubDesc { get; set; }

        public ChampionshipMetaData[] Championships { get; set; }
    }
}