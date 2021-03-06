﻿using HomeBudgetCalculator.Core.Domains;
using HomeBudgetCalculator.Infrastructure.EntityFramework.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HomeBudgetCalculator.Infrastructure.Repositories.Interfaces
{
    public interface IExpenseRepository : IRepository, ISqlRepository
    {
        Task AddAsync(Expense expense);

        Task DeleteAsync(Expense expense);

        Task UpdateAsync(Expense expense);

        Task<Expense> GetAsync(Guid id);

        IQueryable<Expense> GetAll();
    }
}
