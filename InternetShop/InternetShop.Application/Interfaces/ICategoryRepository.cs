﻿using InternetShop.Domain.Entites;

namespace InternetShop.Application.Interfaces
{
    internal interface ICategoryRepository
    {
        public void Add(Category category);
    }
}