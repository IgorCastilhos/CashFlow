using CashFlow.Application.UseCases.Expenses.Register;
using CommonTestUtilities.Requests;
using FluentAssertions;

namespace Validators.Tests.Expenses.Register;

public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        // Arrange
        var validator = new RegisterExpenseValidator();
        var request = RequestExpenseJsonBuilder.Build();

        // Act
        var result = validator.Validate(request);

        // Assert
       result.IsValid.Should().BeTrue();
    }
}
// Todo: Testar os erros 25:00
