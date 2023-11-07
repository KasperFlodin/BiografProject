﻿using BiografProjekt.Repo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiografProjekt.Repo.Interfaces
{
    public interface ITheater
    {
        public Task<List<Theater>> getAll();

        public Task<Theater> getById(int id);

        public Task<Theater> create(Theater theater);

        public Task<Theater> update(Theater updateTheater);

        public Task<Theater> delete(int id);
    }
}
