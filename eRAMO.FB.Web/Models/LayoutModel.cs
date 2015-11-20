using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRAMO.FB.Manager;

namespace eRAMO.FB.Web.Models
{
    public class LayoutModel
    {
        public static List<KeyValuePair<int, string>> Certificate { get; set; }
        public void GetAllCertificateMenu()
        {
            var _ctx = new UnitOfWork();
            Certificate = _ctx.Certificate.GetAll<Model.CertificatesModel>()
                .Select(item => new KeyValuePair<int, string>(item.CertificateID, item.Name)).ToList();
        }

    }
}