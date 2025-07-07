using Mission.Entities.ViewModels;
using Mission.Entities.ViewModels.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IServise
{
    public interface IUserService
    {
        // Fixed spelling error in method name and removed 'async' modifier as interface methods cannot have a body.
        Task<ResponseResult> LoginUser(UserLoginRequestModel model);
    }
}
