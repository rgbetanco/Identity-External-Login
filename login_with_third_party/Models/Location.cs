using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NetTopologySuite.Geometries;

namespace login_with_third_party.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationName { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public Point LocationPoint { get; set; }
    }
}
