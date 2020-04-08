using System;
using System.Collections.Generic;
using System.Linq;
using VrMobile.Models;

namespace VrMobile.ViewModel
{
    public class VendorVisitPageViewModel
    {
        public List<VendorVisits> Visits
        {
            get
            {
                var app = (App)App.Current;
                var visits = app.Db.VendorVisits.GetAll().ToList();
                return visits;
            }
        }

        public VendorVisitPageViewModel()
        {
        }
    }
}
