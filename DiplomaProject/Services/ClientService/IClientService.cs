using DiplomaProject.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.ClientServiceNS
{
    public interface IClientService
    {
        Task<IEnumerable<ClientDto>> Get();
        Task<ClientDto> Get(int id);
        Task<ClientDto> Create(ClientCreateDto clientCreateDto);
        Task<ClientDto> Update(int id, ClientUpdateDto clientUpdateDto);
        Task<ClientDto> Delete(int id);
    }
}
