                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class SubCategoryRepository : Repository<eRAMO.FB.Data.Model.SubCategory, eRAMO.FB.Data.Model.ISubCategory>, ISubCategoryRepository
{
    private FBEntities _context;

    public SubCategoryRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ISubCategoryRepository.cs file
}
