                
using eRAMO.FB.Data;
using System.Collections.Generic;
using System.Linq;
        
public class CertificateRepository : Repository<eRAMO.FB.Data.Certificate, eRAMO.FB.Data.ICertificate>, ICertificateRepository
{
    private FBEntities _context;

    public CertificateRepository(FBEntities context) : base(context)
    {
        _context = context;
    }

    //Override any generic method for your own custom implemention, add new repository methods to the ICertificateRepository.cs file
}
