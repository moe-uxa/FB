                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class CEORepository : Repository<eRAMO.FB.Data.Model.CEO, eRAMO.FB.Data.Model.ICEO>, ICEORepository
{
    private FBEntities _context;

    public CEORepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ICEORepository.cs file
}
