                
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class SubjectRepository : Repository<eRAMO.FB.Data.Subject, eRAMO.FB.Data.ISubject>, ISubjectRepository
{
    private FBEntities _context;

    public SubjectRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ISubjectRepository.cs file
}
