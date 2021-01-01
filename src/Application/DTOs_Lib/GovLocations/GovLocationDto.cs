﻿using GM.Application.AppCore.Entities.Govbodies;
using GM.Application.AppCore.Entities.GovLocations;
using System.Collections.Generic;

namespace GM.Application.DTOs.GovLocations
{
    public class GovLocationDto
    {
        public string Name { get; set; }
        public GovlocTypes Type { get; set; }
        public string Code { get; set; }
        public GovLocation ParentLocation { get; set; }
        public List<Govbody> Govbodies { get; set; }
    }
}