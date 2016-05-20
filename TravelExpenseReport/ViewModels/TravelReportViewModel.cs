﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelExpenseReport.ViewModels
{
    public class TravelReportViewModel
    {
        public IEnumerable<SelectListItem> TravelUsers
        {
            get; set; 
        }
        public string SelectedTravelUser
        {
            get; set;
        }


    }
}