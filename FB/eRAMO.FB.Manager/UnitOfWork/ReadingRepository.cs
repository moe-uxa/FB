                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class ReadingRepository : Repository<eRAMO.FB.Data.Model.Reading, eRAMO.FB.Data.Model.IReading>, IReadingRepository
{
    private FBEntities _context;

    public ReadingRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IReadingRepository.cs file
}
