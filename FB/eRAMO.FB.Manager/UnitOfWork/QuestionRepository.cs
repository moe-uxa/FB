                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class QuestionRepository : Repository<eRAMO.FB.Data.Model.Question, eRAMO.FB.Data.Model.IQuestion>, IQuestionRepository
{
    private FBEntities _context;

    public QuestionRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IQuestionRepository.cs file
}
