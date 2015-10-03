                
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class SubCategoryRepository : Repository<eRAMO.FB.Data.SubCategory, eRAMO.FB.Data.ISubCategory>, ISubCategoryRepository
{
    private FBEntities _context;

    public SubCategoryRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ISubCategoryRepository.cs file
}
