using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using InvoiceManager.Contracts;
using InvoiceManager.Contracts.Client;
using InvoiceManager.Dtos.Client;
using InvoiceManager.Models;
using InvoiceManager.Models.Filters;
using InvoiceManager.Models.Repositories;
using InvoiceManager.Models.Services;

namespace InvoiceManager.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ClientService(IClientRepository clientRepository, IMapper mapper, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _clientRepository = clientRepository;
        }
        
        public async Task<ListResponse<ClientsListItemDto>> ListAsync(ListClientsRequest request)
        {
            var filter = _mapper.Map<ListClientsRequest, ClientsFilter>(request);
            var paging = _mapper.Map<ListClientsRequest, Paging>(request);

            var clients = await _clientRepository.GetListAsync(filter, null, paging);
            var clientsCount = await _clientRepository.CountAsync(filter);

            var clientsDtosList = _mapper.Map<List<Client>, List<ClientsListItemDto>>(clients);
            return new ListResponse<ClientsListItemDto>(clientsDtosList, clientsCount);
        }

        public async Task<ResultResponse<ClientDto>> GetAsync(int id)
        {
            var client = await _clientRepository.GetAsync(client => client.Id == id);
            if (client == null) return new ResultResponse<ClientDto>("Client is not found");

            var clientDto = _mapper.Map<Client, ClientDto>(client);
            return new ResultResponse<ClientDto>(clientDto);
        }

        public async Task<BaseResponse> AddAsync(AddClientRequest request)
        {
            var client = _mapper.Map<AddClientRequest, Client>(request);
            await _clientRepository.AddAsync(client);
            await _unitOfWork.SaveChangesAsync();
            return new BaseResponse();
        }

        public async Task<BaseResponse> EditAsync(EditClientRequest request)
        {
            var client = await _clientRepository.GetAsync(client => client.Id == request.Id);
            if (client == null) return new BaseResponse("Client is not found");
            
            client.Name = request.Name;
            client.Code = request.Code;
            client.VatCode = request.VatCode;
            client.Address = request.Address;
            client.Email = request.Email;
            client.Phone = request.Phone;
            _clientRepository.Update(client);
            await _unitOfWork.SaveChangesAsync();
            return new BaseResponse();
        }

        public async Task<BaseResponse> DeleteAsync(int id)
        {
            var client = await _clientRepository.GetAsync(client => client.Id == id);
            if (client == null) return new BaseResponse("Client is not found");

            _clientRepository.Delete(client);
            await _unitOfWork.SaveChangesAsync();
            return new BaseResponse();
        }
    }
}