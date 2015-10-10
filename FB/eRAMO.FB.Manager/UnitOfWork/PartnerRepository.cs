
    
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class PartnerRepository : Repository<eRAMO.FB.Data.Model.Partner, eRAMO.FB.Data.Model.IPartner>, IPartnerRepository
{
    private FBEntities _context;

    public PartnerRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IPartnerRepository.cs file
}
