                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class sysdiagramRepository : Repository<eRAMO.FB.Data.Model.sysdiagram, eRAMO.FB.Data.Model.Isysdiagram>, IsysdiagramRepository
{
    private FBEntities _context;

    public sysdiagramRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IsysdiagramRepository.cs file
}
