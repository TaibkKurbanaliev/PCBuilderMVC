using PCBuilderMVC.Domain.Entities;
using PCBuilderMVC.Domain.Response;
using PCBuilderMVC.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCBuilder.Service.Interfaces
{
    public interface IPCService
    {
        Task<BaseResponse<PCViewModel>> CreatePC(PCViewModel pcViewModel);
        Task<BaseResponse<ICollection<PCViewModel>>> GetAll();
        Task<BaseResponse<PCViewModel>> GetById(int id);
    }
}
