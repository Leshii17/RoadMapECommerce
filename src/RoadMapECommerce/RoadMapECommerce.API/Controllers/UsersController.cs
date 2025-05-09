using MediatR;
using Microsoft.AspNetCore.Mvc;
using RoadMapECommerce.Application.DTOs.Users;
using RoadMapECommerce.Application.Mediator.Users;

namespace RoadMapECommerce.API.Controllers;

[Route("api/users")]
[ApiController]
public class UsersController : ControllerBase
{
	private readonly IMediator _mediator;

	public UsersController(IMediator mediator)
	{
		_mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
	}

	[HttpGet("{id}")]
	[ProducesResponseType(typeof(GetUserDTO), 200)]
	public IActionResult Get(int id)
	{
		return BadRequest();
	}

	[HttpPost]
	public async Task<IActionResult> PostAsync([FromBody] CreateUserDTO value)
	{
		var command = new CreateUserCommand(value);

		var result = await _mediator.Send(command);

		if (result == null)
			return StatusCode(StatusCodes.Status500InternalServerError, "User creation failed.");

		// TODO : Add a mapper to convert UserEntity to GetUserDTO
		return CreatedAtAction(nameof(Get), new { id = result.Id }, value);
	}

	[HttpPut("{id}")]
	public void Put(int id, [FromBody] string value)
	{
	}

	[HttpDelete("{id}")]
	public void Delete(int id)
	{
	}
}
