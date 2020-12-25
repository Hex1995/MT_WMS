using MT_WMS.Entitys;
using MT_WMS.IBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT_WMS.Business.MT
{
    public class SysObjectBusiness: BaseBusiness<UserObjects>, ISysObjectBusiness
    {
        public SysObjectBusiness()
        {
        }
        protected override string RouteUrl => "SysObject";
    }
}
