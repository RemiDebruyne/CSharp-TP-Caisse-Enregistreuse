﻿namespace Caisse_Enregistreuse.Repositories
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T? GetById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(int id);
    }
}
