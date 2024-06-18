using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Repositories.Expenses;

public interface IExpenseRepository
{
    void Add(Expense expense);
}

// 1:18:32
