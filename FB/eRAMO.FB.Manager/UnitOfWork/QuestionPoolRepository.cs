                
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class QuestionPoolRepository : Repository<eRAMO.FB.Data.QuestionPool, eRAMO.FB.Data.IQuestionPool>, IQuestionPoolRepository
{
    private FBEntities _context;

    public QuestionPoolRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IQuestionPoolRepository.cs file
}
