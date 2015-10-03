                
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class QuestionRepository : Repository<eRAMO.FB.Data.Question, eRAMO.FB.Data.IQuestion>, IQuestionRepository
{
    private FBEntities _context;

    public QuestionRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IQuestionRepository.cs file
}
