                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class AboutHistoryRepository : Repository<eRAMO.FB.Data.Model.AboutHistory, eRAMO.FB.Data.Model.IAboutHistory>, IAboutHistoryRepository
{
    private FBEntities _context;

    public AboutHistoryRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IAboutHistoryRepository.cs file
}
