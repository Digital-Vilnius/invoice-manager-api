using AutoMapper;
using InvoiceManager.Contracts;
using InvoiceManager.Contracts.Account;
using InvoiceManager.Contracts.Client;
using InvoiceManager.Dtos.Account;
using InvoiceManager.Dtos.Authentication;
using InvoiceManager.Dtos.Client;
using InvoiceManager.Dtos.User;
using InvoiceManager.Models;
using InvoiceManager.Models.Filters;

namespace InvoiceManager.Services.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LoggedUser, LoggedUserDto>()
                .ForMember(
                    dest => dest.RefreshToken,
                    opt => opt.MapFrom(src => src.User.RefreshToken)
                );

            CreateMap<User, LoggedUser>()
                .ForMember(
                    dest => dest.User,
                    opt => opt.MapFrom(src => src)
                );

            CreateMap<ListRequest, Paging>();
            CreateMap<ListRequest, Sort>();
            CreateMap<ListRequest, BaseFilter>();
            
            // User
            CreateMap<User, UserDto>();

            // Accounts
            CreateMap<ListAccountsRequest, AccountsFilter>();
            CreateMap<Account, AccountDto>();
            CreateMap<Account, AccountsListItemDto>();
            
            // Clients
            CreateMap<ListClientsRequest, ClientsFilter>();
            CreateMap<Client, ClientDto>();
            CreateMap<Client, ClientsListItemDto>();
        }
    }
}