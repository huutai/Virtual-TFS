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
    /// Repository for table Task 
    /// </summary>
    public partial class TaskRepository
    {
        #region auto generate code

        #region variable define

        IUnitOfWork unitOfWork;

        #endregion


        #region Ctor

        // Default contructor that creates an instance of unit of work
        public TaskRepository()
        {
            if (null == unitOfWork)
                unitOfWork = new UnitOfWork();
        }

        // Constructor of an instance of unit of work
        public TaskRepository(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        #endregion


        #region Basic C.R.U.D. operations

        // List of all Task 
        public IList<Task> GetAllTask()
        {
            return unitOfWork.GetAll<Task>();
        }

        // Find all Task 
        public IList<Task> FindTask(Expression<Func<Task, bool>> expression)
        {
            return unitOfWork.Find<Task>(expression).ToList();
        }

        // Get single Task 
        public Task GetSingleTask(Func<Task, bool> expression)
        {
            return unitOfWork.GetSingle<Task>(expression);
        }

        // Add a new Task 
        public Task AddTask(Task _task)
        {
            unitOfWork.Add<Task>(_task);
            return _task;
        }

        // Delete a existed Task 
        public void DeleteTask(Task _task)
        {
            unitOfWork.Delete<Task>(_task);
        }

        // Delete batch a existed Task 
        public void DeleteBatchTask(IEnumerable<Task> collection)
        {
        	foreach(var item in collection)
        	{
        		unitOfWork.Delete<Task>(item);
        	}
        }

        // Update a existed Task 
        public Task UpdateTask(Task _task)
        {
            unitOfWork.Update<Task>(_task);
            return _task;
        }

        // Refresh an existed Task 
        public Task RefeshTask(Task _task)
        {
            unitOfWork.Refresh<Task>(_task);
            return _task;
        }

        // Refresh AllTask 
        public void RefreshListTask(IEnumerable<Task> list)
        {
            unitOfWork.RefreshList<Task>(list);
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