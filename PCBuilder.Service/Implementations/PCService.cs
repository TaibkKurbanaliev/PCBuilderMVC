using AutoMapper;
using PCBuilder.Service.Interfaces;
using PCBuilderMVC.DAL.Interfaces;
using PCBuilderMVC.DAL.Repositories;
using PCBuilderMVC.Domain.Entities;
using PCBuilderMVC.Domain.Enums;
using PCBuilderMVC.Domain.Response;
using PCBuilderMVC.Domain.ViewModels;

namespace PCBuilder.Service.Implementations
{
    public class PCService : IPCService
    {
        private readonly IBaseRepository<PC> _repository;
        private readonly IMapper _mapper;

        public PCService(IBaseRepository<PC> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<BaseResponse<PCViewModel>> CreatePC(PCViewModel pcViewModel)
        {
            var baseResponse = new BaseResponse<PCViewModel>();

            try
            {
                var entity = new PC()
                {
                    Name = pcViewModel.Name,
                    Description = pcViewModel.Description,
                    Cost = 99999,
                    CreatedDate = DateTime.Now,
                    CPU = pcViewModel.CPU,
                    GPU = pcViewModel.GPU,
                    MotherBoard = pcViewModel.MotherBoard,
                    DRAM = pcViewModel.DRAM,
                    PowerSupply = pcViewModel.PowerSupply,
                    Case = pcViewModel.Case,
                    PCColling = pcViewModel.PCColling,
                    Storages = pcViewModel.Storages,
                    Fans = pcViewModel.Fans
                };

                baseResponse.StatusCode = StatusCode.Ok;
                baseResponse.Data = pcViewModel;

                await _repository.Create(entity);
            }
            catch (Exception ex)
            {
                baseResponse.Description = " Create Method exeption: " + ex.Message;
                baseResponse.StatusCode = StatusCode.InternalServerError;
            }

            return baseResponse;
        }

        public async Task<BaseResponse<ICollection<PCViewModel>>> GetAll()
        {
            var response = new BaseResponse<ICollection<PCViewModel>>();

            try
            {
                var data = _mapper.Map<ICollection<PCViewModel>>(await _repository.GetAll());
                response.Data = data;
                response.StatusCode = StatusCode.Ok;

            }
            catch (Exception ex)
            {
                response.Description = " GetAll Method exeption: " + ex.Message;
                response.StatusCode = StatusCode.InternalServerError;
            }

            return response;
        }

        public async Task<BaseResponse<PCViewModel>> GetById(int id)
        {
            var response = new BaseResponse<PCViewModel>();

            try
            {
                response.Data = _mapper.Map<PCViewModel>(await _repository.Get(id));

                if (response.Data != null)
                {
                    response.StatusCode = StatusCode.Ok;
                }
                else
                {
                    response.StatusCode = StatusCode.NotFound;
                    response.Description = "Model wasn't found";
                }
            }
            catch (Exception ex)
            {
                response.Description = " GetById Method exeption: " + ex.Message;
                response.StatusCode = StatusCode.InternalServerError;
            }

            return response;
        }
    }
}
