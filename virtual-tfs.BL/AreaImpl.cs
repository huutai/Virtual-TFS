using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualTFS.DAL;
using VirtualTFS.DAL.Repositories;

namespace VirtualTFS.BL
{
    public class AreaImpl
    {
        public List<Area> GetListArea()
        {
            List<Area> list = new List<Area>();
            AreaRepository area = new AreaRepository();
            list = area.GetAllArea().ToList();
            return list;
        }
    }
}
