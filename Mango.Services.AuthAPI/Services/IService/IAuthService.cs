using Mango.Services.AuthAPI.Models.Dto;

namespace Mango.Services.AuthAPI.Services.IService;

public interface IAuthService
{
    Task<string> Register(RegistrationRequestDto registrationRequestDto);
    Task<LoginRequestDto> Login(LoginRequestDto loginRequestDto);
}
