                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class NewsRepository : Repository<eRAMO.FB.Data.Model.News, eRAMO.FB.Data.Model.INews>, INewsRepository
{
    private FBEntities _context;

    public NewsRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the INewsRepository.cs file
}
