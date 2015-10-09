                
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class StudySessionRepository : Repository<eRAMO.FB.Data.StudySession, eRAMO.FB.Data.IStudySession>, IStudySessionRepository
{
    private FBEntities _context;

    public StudySessionRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IStudySessionRepository.cs file
}
