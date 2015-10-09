                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class QuestionPoolRepository : Repository<eRAMO.FB.Data.Model.QuestionPool, eRAMO.FB.Data.Model.IQuestionPool>, IQuestionPoolRepository
{
    private FBEntities _context;

    public QuestionPoolRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IQuestionPoolRepository.cs file
}
