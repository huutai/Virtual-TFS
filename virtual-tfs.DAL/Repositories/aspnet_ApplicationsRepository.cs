//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;
using VirtualTFS.DAL;

namespace VirtualTFS.DAL.Repositories
{
    /// <summary>
    /// Repository for table aspnet_Applications 
    /// </summary>
    public partial class aspnet_ApplicationsRepository
    {
        #region auto generate code

        #region variable define

        IUnitOfWork unitOfWork;

        #endregion


        #region Ctor

        // Default contructor that creates an instance of unit of work
        public aspnet_ApplicationsRepository()
        {
            if (null == unitOfWork)
                unitOfWork = new UnitOfWork();
        }

        // Constructor of an instance of unit of work
        public aspnet_ApplicationsRepository(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        #endregion


        #region Basic C.R.U.D. operations

        // List of all aspnet_Applications 
        public IList<aspnet_Applications> GetAllaspnet_Applications()
        {
            return unitOfWork.GetAll<aspnet_Applications>();
        }

        // Find all aspnet_Applications 
        public IList<aspnet_Applications> Findaspnet_Applications(Expression<Func<aspnet_Applications, bool>> expression)
        {
            return unitOfWork.Find<aspnet_Applications>(expression).ToList();
        }

        // Get single aspnet_Applications 
        public aspnet_Applications GetSingleaspnet_Applications(Func<aspnet_Applications, bool> expression)
        {
            return unitOfWork.GetSingle<aspnet_Applications>(expression);
        }

        // Add a new aspnet_Applications 
        public aspnet_Applications Addaspnet_Applications(aspnet_Applications _aspnet_Applications)
        {
            unitOfWork.Add<aspnet_Applications>(_aspnet_Applications);
            return _aspnet_Applications;
        }

        // Delete a existed aspnet_Applications 
        public void Deleteaspnet_Applications(aspnet_Applications _aspnet_Applications)
        {
            unitOfWork.Delete<aspnet_Applications>(_aspnet_Applications);
        }

        // Delete batch a existed aspnet_Applications 
        public void DeleteBatchaspnet_Applications(IEnumerable<aspnet_Applications> collection)
        {
        	foreach(var item in collection)
        	{
        		unitOfWork.Delete<aspnet_Applications>(item);
        	}
        }

        // Update a existed aspnet_Applications 
        public aspnet_Applications Updateaspnet_Applications(aspnet_Applications _aspnet_Applications)
        {
            unitOfWork.Update<aspnet_Applications>(_aspnet_Applications);
            return _aspnet_Applications;
        }

        // Refresh an existed aspnet_Applications 
        public aspnet_Applications Refeshaspnet_Applications(aspnet_Applications _aspnet_Applications)
        {
            unitOfWork.Refresh<aspnet_Applications>(_aspnet_Applications);
            return _aspnet_Applications;
        }

        // Refresh Allaspnet_Applications 
        public void RefreshListaspnet_Applications(IEnumerable<aspnet_Applications> list)
        {
            unitOfWork.RefreshList<aspnet_Applications>(list);
        }

        // Commit all changes 
        public void Commit()
        {
            unitOfWork.Commit();
        }

        #endregion


        #endregion


        #region all the custom code


        #endregion

    }
}
