using eRAMO.FB.Manager;
using eRAMO.FB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eRAMO.FB.Web.Models.Home
{
    public class HeaderModel
    {
        UnitOfWork ctx = new UnitOfWork();

        public List<CertificatesModel> Certificates { get; set; }

        public List<CertificatesModel> GetFeaturedCertificates()
        {
            Certificates= ctx.Certificate.GetAll<CertificatesModel>().Where(c => c.IsFeatured != null && c.IsFeatured.Value).Take(3).ToList();
            return Certificates;
        }
    }



}