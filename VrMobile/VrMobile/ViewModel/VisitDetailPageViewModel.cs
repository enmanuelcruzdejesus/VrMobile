using System;
using VrMobile.Models;

namespace VrMobile.ViewModel
{
    public class VisitDetailPageViewModel
    {
        VendorVisits _visit;

        public int IdVisit
        {
            get
            {
                return _visit.IdVendorVisit;
            }
        }


        public string CompanyName
        {
            get
            {
                return _visit.Customer.CompanyName;
            }
        }


        public DateTime VisitDate
        {
            get
            {
                return _visit.CreatedDate;
            }
        }

        public string City
        {
            get
            {
                return _visit.City;

            }
        }


        public string Address
        {
            get
            {
                return _visit.Address;
            }
        }

        
        public VisitDetailPageViewModel(VendorVisits visit)
        {
            _visit = visit;
        }


    }
}
