using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRAMO.FB.Manager;

namespace eRAMO.FB.Web.Models
{
    public class AboutHistoriesModel:LayoutModel
    {
        public List<Model.AboutHistoriesModel> AboutHistories { get; set; }
        public AboutHistoriesModel()
        {
            GetAllCertificateMenu();
            var ctx = new UnitOfWork();
            AboutHistories = ctx.AboutHistory.GetAll<Model.AboutHistoriesModel>().ToList();
        }
    }
}