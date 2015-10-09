                
using eRAMO.FB.Data.Model;
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class ParentTypeRepository : Repository<eRAMO.FB.Data.Model.ParentType, eRAMO.FB.Data.Model.IParentType>, IParentTypeRepository
{
    private FBEntities _context;

    public ParentTypeRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the IParentTypeRepository.cs file
}
