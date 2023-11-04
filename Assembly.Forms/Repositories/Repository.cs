using Assembly.Forms.Contracts;
using Assembly.Forms.Exceptions;

namespace Assembly.Forms.Repositories
{
    public abstract class Repository<TEntity> : IRepository<TEntity>
    {
        private readonly Database _database;

        public Repository(Database database)
        {
            this._database = database;
        }

        public TEntity Add(TEntity entity)
        {
            try
            {
                // using SQLConnection

                // SQLCommand
                // Execute query
            }
            catch (Exception ex) //SQLException("Tables")
            {
                // log exception
                throw new DataException("Error contacting database");

            }

            throw new NotImplementedException();
        }

        public TEntity Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
