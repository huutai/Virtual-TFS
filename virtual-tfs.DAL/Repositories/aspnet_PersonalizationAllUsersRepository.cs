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
    /// Repository for table aspnet_PersonalizationAllUsers 
    /// </summary>
    public partial class aspnet_PersonalizationAllUsersRepository
    {
        #region auto generate code

        #region variable define

        IUnitOfWork unitOfWork;

        #endregion


        #region Ctor

        // Default contructor that creates an instance of unit of work
        public aspnet_PersonalizationAllUsersRepository()
        {
            if (null == unitOfWork)
                unitOfWork = new UnitOfWork();
        }

        // Constructor of an instance of unit of work
        public aspnet_PersonalizationAllUsersRepository(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        #endregion


        #region Basic C.R.U.D. operations

        // List of all aspnet_PersonalizationAllUsers 
        public IList<aspnet_PersonalizationAllUsers> GetAllaspnet_PersonalizationAllUsers()
        {
            return unitOfWork.GetAll<aspnet_PersonalizationAllUsers>();
        }

        // Find all aspnet_PersonalizationAllUsers 
        public IList<aspnet_PersonalizationAllUsers> Findaspnet_PersonalizationAllUsers(Expression<Func<aspnet_PersonalizationAllUsers, bool>> expression)
        {
            return unitOfWork.Find<aspnet_PersonalizationAllUsers>(expression).ToList();
        }

        // Get single aspnet_PersonalizationAllUsers 
        public aspnet_PersonalizationAllUsers GetSingleaspnet_PersonalizationAllUsers(Func<aspnet_PersonalizationAllUsers, bool> expression)
        {
            return unitOfWork.GetSingle<aspnet_PersonalizationAllUsers>(expression);
        }

        // Add a new aspnet_PersonalizationAllUsers 
        public aspnet_PersonalizationAllUsers Addaspnet_PersonalizationAllUsers(aspnet_PersonalizationAllUsers _aspnet_PersonalizationAllUsers)
        {
            unitOfWork.Add<aspnet_PersonalizationAllUsers>(_aspnet_PersonalizationAllUsers);
            return _aspnet_PersonalizationAllUsers;
        }

        // Delete a existed aspnet_PersonalizationAllUsers 
        public void Deleteaspnet_PersonalizationAllUsers(aspnet_PersonalizationAllUsers _aspnet_PersonalizationAllUsers)
        {
            unitOfWork.Delete<aspnet_PersonalizationAllUsers>(_aspnet_PersonalizationAllUsers);
        }

        // Delete batch a existed aspnet_PersonalizationAllUsers 
        public void DeleteBatchaspnet_PersonalizationAllUsers(IEnumerable<aspnet_PersonalizationAllUsers> collection)
        {
        	foreach(var item in collection)
        	{
        		unitOfWork.Delete<aspnet_PersonalizationAllUsers>(item);
        	}
        }

        // Update a existed aspnet_PersonalizationAllUsers 
        public aspnet_PersonalizationAllUsers Updateaspnet_PersonalizationAllUsers(aspnet_PersonalizationAllUsers _aspnet_PersonalizationAllUsers)
        {
            unitOfWork.Update<aspnet_PersonalizationAllUsers>(_aspnet_PersonalizationAllUsers);
            return _aspnet_PersonalizationAllUsers;
        }

        // Refresh an existed aspnet_PersonalizationAllUsers 
        public aspnet_PersonalizationAllUsers Refeshaspnet_PersonalizationAllUsers(aspnet_PersonalizationAllUsers _aspnet_PersonalizationAllUsers)
        {
            unitOfWork.Refresh<aspnet_PersonalizationAllUsers>(_aspnet_PersonalizationAllUsers);
            return _aspnet_PersonalizationAllUsers;
        }

        // Refresh Allaspnet_PersonalizationAllUsers 
        public void RefreshListaspnet_PersonalizationAllUsers(IEnumerable<aspnet_PersonalizationAllUsers> list)
        {
            unitOfWork.RefreshList<aspnet_PersonalizationAllUsers>(list);
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
