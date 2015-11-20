using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eRAMO.FB.Manager;

namespace eRAMO.FB.Web.Models
{
    public class CEOsModel
    {
        public List<Model.CEOsModel> CEOs { get; set; }
        readonly UnitOfWork _ctx;

        public CEOsModel()
        {
            _ctx= new UnitOfWork();
            CEOs = _ctx.CEO.GetAll<Model.CEOsModel>().ToList();
        }
    }
}