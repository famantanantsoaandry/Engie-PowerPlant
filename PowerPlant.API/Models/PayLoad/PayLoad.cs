﻿// <copyright company="Avengers">
// Copyright (c) 2021 All Rights Reserved
// </copyright>
// <author>Andry Famantanantsoa OELIHARIVONY</author>
//<email>a.famantanantsoa@gmail.com</>
// <date>16/02/2021 09:15:00 AM </date>
using System.Collections.Generic;

namespace PowerPlant.API.Models
{
    public class PayLoad
    {
        public PayLoad()
        {
        }

        public float Load { get; set; }

        public IList<Fuel> Fuels { get; set; }


        public IList<GenericPowerPlant> PowerPlants {get;set;}

    }
}
