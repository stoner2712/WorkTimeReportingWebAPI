using AutoMapper;
using DiplomaProject.DataTransferObjects;
using DiplomaProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiplomaProject.Services.ClientServiceNS
{
    public class ClientService : IClientService

    {
        private IMapper mapper;
        private readonly DiplomaProjectDbContext diplomaProjectDbContext;

        public ClientService(IMapper mapper, DiplomaProjectDbContext diplomaProjectDbContext)
        {
            this.mapper = mapper;
            this.diplomaProjectDbContext = diplomaProjectDbContext;
        }

        public async Task<IEnumerable<ClientDto>> Get()
        {
            var allClients = await this.diplomaProjectDbContext.Clients.ToListAsync();
            return this.mapper.Map<List<Client>, List<ClientDto>>(allClients);
        }

        public async Task<ClientDto> Get(int id)
        {
            var client = await this.diplomaProjectDbContext.Clients.FirstOrDefaultAsync(c => c.ClientId == id);
            if (client == null)
            {
                throw new ArgumentException("Id not existing");
            }
            return this.mapper.Map<ClientDto>(client);
        }

        public async Task<ClientDto> Create(ClientCreateDto clientDto)
        {
            var client = this.mapper.Map<Client>(clientDto);
            await this.diplomaProjectDbContext.AddAsync(client);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<ClientDto>(client); // nadaje numer Id nowemu klientowi
        }

        public async Task<ClientDto> Update(int id, ClientUpdateDto clientUpdateDto)
        {
            var client = await this.diplomaProjectDbContext.Clients.FirstOrDefaultAsync(c => c.ClientId == id);
            if (client == null)
            {
                throw new ArgumentException("Id not existing");
            }
            client.BuildingNumber = clientUpdateDto.BuildingNumber;
            client.StreetName = clientUpdateDto.StreetName;
            client.PostCode = clientUpdateDto.PostCode;
            client.City = clientUpdateDto.City;
            client.Country = clientUpdateDto.Country;
            this.diplomaProjectDbContext.Update(client);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return null;
        }

        public async Task<ClientDto> Delete(int id)
        {
            var client = await this.diplomaProjectDbContext.Clients.FirstOrDefaultAsync(c => c.ClientId == id);
            if (client == null)
            {
                throw new ArgumentException("Id not existing");
            }
            this.diplomaProjectDbContext.Remove(client);
            await this.diplomaProjectDbContext.SaveChangesAsync();
            return this.mapper.Map<ClientDto>(client);
        }
    }
}
