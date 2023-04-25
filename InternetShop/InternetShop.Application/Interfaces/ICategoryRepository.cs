﻿using InternetShop.Domain.Entites;

namespace InternetShop.Application.Interfaces
{
    public interface ICategoryRepository
    {
        public void Add(Category category);
        public IEnumerable<Category> GetAll();
        public Category GetById(int id);
        public void Update(Category category);
    }
}
