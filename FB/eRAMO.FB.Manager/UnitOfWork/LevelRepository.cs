                
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class LevelRepository : Repository<eRAMO.FB.Data.Level, eRAMO.FB.Data.ILevel>, ILevelRepository
{
    private FBEntities _context;

    public LevelRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ILevelRepository.cs file
}
