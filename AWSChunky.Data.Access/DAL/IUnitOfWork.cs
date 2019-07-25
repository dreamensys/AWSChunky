using System;
using System.Linq;
using System.Threading.Tasks;

namespace AWSChunky.Data.Access.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        //ITransaction BeginTrasaction(IsolationLevel isolationLEvel = IsolationLEvel.Snapshot);
        void Add<T>(T obj) where T : class;
        void Update<T>(T obj) where T : class;
        void Remove<T>(T obj) where T : class;
        IQueryable<T> Query<T>() where T : class;
        void Commit();
        Task CommitAsync();
        void Attach<T>(T obj) where T : class;
    }
}
