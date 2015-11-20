                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class InstructorRepository : Repository<eRAMO.FB.Data.Model.Instructor, eRAMO.FB.Data.Model.IInstructor>, IInstructorRepository
{
    private FBEntities _context;

    public InstructorRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IInstructorRepository.cs file
}
