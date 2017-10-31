﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public abstract class BaseRepository<T> : JSONData<T>, IRepository<T> where T : class
    {
        public BaseRepository()
        {
            GetAll();
        }
        public virtual void Add(T record)
        {
            Liste.Add(record);
            Save();
        }

        public void Delete(T record)
        {
            Liste.Remove(record);
            Save();
        }

        public List<T> GetAll()
        {
            Load();
            return Liste;
        }

        public T GetRecord()
        {
            throw new NotImplementedException();
        }

        public void Update(T record)
        {
            throw new NotImplementedException();
        }
    }
}