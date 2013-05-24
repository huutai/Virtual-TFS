using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

public interface IUnitOfWork
{
    //Basic C.R.U.D. operations
    void Add<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    void Update<T>(T entity) where T : class;
    void Refresh<T>(T source) where T : class;
    void RefreshList<T>(IEnumerable<T> list) where T : class;
    void Commit();

    //Basic Select operations
    IEnumerable<T> Take<T>(int skip, int count, Func<T, object> sorter) where T : class;
    IList<T> GetAll<T>() where T : class;
    IEnumerable<T> Find<T>(Expression<Func<T, bool>> expression) where T : class;
    IQueryable<T> GetQuery<T>(Expression<Func<T, bool>> expression) where T : class;
    T GetSingle<T>(Func<T, bool> expression) where T : class;
    int CountBy<T>(Expression<Func<T, bool>> expression) where T : class;
}
