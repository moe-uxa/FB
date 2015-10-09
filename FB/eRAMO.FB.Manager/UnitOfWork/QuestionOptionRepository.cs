                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class QuestionOptionRepository : Repository<eRAMO.FB.Data.Model.QuestionOption, eRAMO.FB.Data.Model.IQuestionOption>, IQuestionOptionRepository
{
    private FBEntities _context;

    public QuestionOptionRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IQuestionOptionRepository.cs file
}
