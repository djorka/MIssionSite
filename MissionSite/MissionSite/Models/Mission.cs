using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MissionSite.Models
{
    public class Mission
    {
        public string MisName { get; set; }
        public string MisPresidentName { get; set; }
        public string MisAddress { get; set; }
        public string MisLanguage { get; set; }
        public string MisClimate { get; set; }
        public string MisDominantReligion { get; set; }
        public string MisFlagUrl { get; set; }

        public Mission(string MisName, string MisPresidentName, string MisAddress, string MisLanguage, string MisClimate, string MisDominantReligion, string MisFlagUrl)
        {
            this.MisName = MisName;
            this.MisPresidentName = MisPresidentName;
            this.MisAddress = MisAddress;
            this.MisLanguage = MisLanguage;
            this.MisClimate = MisClimate;
            this.MisDominantReligion = MisDominantReligion;
            this.MisFlagUrl = MisFlagUrl;
        }
    }
}