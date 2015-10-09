
    
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class ClientReviewRepository : Repository<eRAMO.FB.Data.Model.ClientReview, eRAMO.FB.Data.Model.IClientReview>, IClientReviewRepository
{
    private FBEntities _context;

    public ClientReviewRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IClientReviewRepository.cs file
}
