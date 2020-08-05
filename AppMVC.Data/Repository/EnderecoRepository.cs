﻿using System;
using System.Threading.Tasks;
using AppMVC.Business.Intefaces;
using AppMVC.Business.Models;
using AppMVC.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace AppMVC.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}