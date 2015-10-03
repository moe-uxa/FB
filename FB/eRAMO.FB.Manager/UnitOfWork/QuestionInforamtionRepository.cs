                
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class QuestionInforamtionRepository : Repository<eRAMO.FB.Data.QuestionInforamtion, eRAMO.FB.Data.IQuestionInforamtion>, IQuestionInforamtionRepository
{
    private FBEntities _context;

    public QuestionInforamtionRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IQuestionInforamtionRepository.cs file
}
