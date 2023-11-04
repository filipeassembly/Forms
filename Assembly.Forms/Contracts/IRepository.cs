namespace Assembly.Forms.Contracts;

public interface IRepository<TEntity>
{
    List<TEntity> GetAll();
    TEntity GetById(int id);
    TEntity Add(TEntity entity);
    TEntity Update(TEntity entity);
    TEntity Delete(TEntity entity);
    TEntity Delete(int id);
}

