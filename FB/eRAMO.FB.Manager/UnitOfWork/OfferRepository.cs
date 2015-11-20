                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class OfferRepository : Repository<eRAMO.FB.Data.Model.Offer, eRAMO.FB.Data.Model.IOffer>, IOfferRepository
{
    private FBEntities _context;

    public OfferRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IOfferRepository.cs file
}
