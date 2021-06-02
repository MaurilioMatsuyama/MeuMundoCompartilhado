using MeuMundoCompartilhado.Domain.Entities;
using MeuMundoCompartilhado.Domain.Enums;
using MeuMundoCompartilhado.Domain.Repositories;
using MeuMundoCompartilhado.Domain.ValueObjects;
using MeuMundoCompartilhado.Shared.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MeuMundoCompartilhado.Domain.Services
{
    public class PessoaService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IPessoaRepository _pessoaRepository;

        public PessoaService(IUnitOfWork unitOfWork, IPessoaRepository pessoaRepository)
        {
            _unitOfWork = unitOfWork;
            _pessoaRepository = pessoaRepository;
        }

        public Pessoa GetById(int id)
        {
            try
            {
                var pessoa = _pessoaRepository.GetById(id);
                return pessoa;
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public List<Pessoa> GetAllPessoa()
        {
            try
            {
                var pessoas = _pessoaRepository.GetAll();
                return pessoas.ToList();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }

        public void InsertPessoa()
        {
            try
            {
                var pessoa = new Pessoa(nome: "Charlie", sobrenome: "Brown", dataAniversario: new DateTime(year: 2000, month: 1, day: 20), parentesco: new Parentesco(tipo: TipoParentesco.Amigo, descricao: "Amigo de infância"));
                _pessoaRepository.InsertPessoa(pessoa);
                _unitOfWork.Commit();
            }
            catch (Exception)
            {
                _unitOfWork.RollBack();
                throw;
            }
        }
    }
}
