using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Domain.Enums;
using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Exceptions.ExceptionsBase;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseUseCase : IRegisterExpenseUseCase
{
    private readonly IExpenseRepository _repository;

    public RegisterExpenseUseCase(IExpenseRepository repository)
    {
        _repository = repository;
    }

    public ResponseRegisteredExpenseJson Execute(RequestExpenseJson request)
    {
        Validate(request);

        var entity = new Expense
        {
            Amount = request.Amount,
            Date = request.Date,
            Description = request.Description,
            Title = request.Title,
            PaymentType = (PaymentType)request.PaymentType,
        };

        _repository.Add(entity);

        return new ResponseRegisteredExpenseJson();
    }

    private void Validate(RequestExpenseJson request)
    {
        var validator = new RegisterExpenseValidator();
        var result = validator.Validate(request);
        if (result.IsValid == false)
        {
            var errorMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ErrorOnValidationException(errorMessages);
        }
    }
}
