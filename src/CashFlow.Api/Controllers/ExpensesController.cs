using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExpensesController : ControllerBase
{
    [HttpPost]
    public IActionResult Register([FromBody] RequestExpenseJson request)
    {
        try
        {
            var useCase = new RegisterExpenseUseCase();
            var response = useCase.Execute(request);
            return Created(string.Empty, response);
        }
        catch (ArgumentException e)
        {
            var errorResponse = new ResponseErrorJson(e.Message);
            return BadRequest(errorResponse);
        }
        catch
        {
            var errorResponse = new ResponseErrorJson("An error occurred while registering the expense");
            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}
// Todo: 49:40
