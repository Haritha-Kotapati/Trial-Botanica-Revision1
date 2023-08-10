using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Passion_project.Models.ViewModel
{
    public class PlantDetails
    {

        public PlantDto SelectedPlant { get; set; }
        public IEnumerable<TrailDto> TrailPlants { get; set; }

    }
}