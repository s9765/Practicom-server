using AutoMapper;
using MyProject.Common.DTOs;
using MyProject.Repositories.Entities;
using MyProject.Repositories.Intefaces;
using MyProject.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Services.Services
{
    public class ChildService : IChildService
    {
        private readonly IChildRepository _childRepository;
        private readonly IMapper _mapper;
        public ChildService(IChildRepository childRepository, IMapper mapper)
        {
            _mapper = mapper;
            _childRepository = childRepository;
        }
        public async Task<ChildDTO> AddAsync(ChildDTO child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.AddAsync(_mapper.Map<Child>(child)));
        }

        public async Task DeleteAsync(int id)
        {
            await _childRepository.DeleteAsync(id);

        }

        public async Task<List<ChildDTO>> GetAllAsync()
        {
            return _mapper.Map<List<ChildDTO>>(await _childRepository.GetAllAsync());
        }
        public async Task<ChildDTO> GetByIdAsync(int id)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.GetByIdAsync(id));

        }

        public async Task<ChildDTO> UpdateAsync(ChildDTO Child)
        {
            return _mapper.Map<ChildDTO>(await _childRepository.UpdateAsync(_mapper.Map<Child>(Child)));

        }
    }
}

