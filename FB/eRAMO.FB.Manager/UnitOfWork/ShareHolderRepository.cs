                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class ShareHolderRepository : Repository<eRAMO.FB.Data.Model.ShareHolder, eRAMO.FB.Data.Model.IShareHolder>, IShareHolderRepository
{
    private FBEntities _context;

    public ShareHolderRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IShareHolderRepository.cs file
}
