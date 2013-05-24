using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VirtualTFS.DAL;
using VirtualTFS.DAL.Repositories;

namespace VirtualTFS.BL
{
    public class IterationImpl
    {
        public List<Iteration> GetListIteration()
        {
            List<Iteration> list = new List<Iteration>();
            IterationRepository iteration = new IterationRepository();
            list = iteration.GetAllIteration().ToList();
            return list;
        }
    }
}
