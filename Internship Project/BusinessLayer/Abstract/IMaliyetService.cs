using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IMaliyetService:IGenericService<Maliyet>
    {
        List<Maliyet> GetWithMaliyet(int id);
        
    }
}
