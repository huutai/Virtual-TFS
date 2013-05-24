using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualTFS.DAL;
using VirtualTFS.DAL.Repositories;

namespace VirtualTFS.BL
{
    public class StatusTaskImpl
    {
        public List<StatusParameter> GetListStates()
        {
            List<StatusParameter> list = new List<StatusParameter>();
            StatusParameterRepository status = new StatusParameterRepository();
            list = status.GetAllStatusParameter().ToList();
            return list;
        }
    }
}
