                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class LevelRepository : Repository<eRAMO.FB.Data.Model.Level, eRAMO.FB.Data.Model.ILevel>, ILevelRepository
{
    private FBEntities _context;

    public LevelRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ILevelRepository.cs file
}
