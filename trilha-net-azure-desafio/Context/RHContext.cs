﻿using Microsoft.EntityFrameworkCore;
using trilha_net_azure_desafio.Models;

namespace trilha_net_azure_desafio.Context
{
    public class RHContext : DbContext
    {
        public RHContext(DbContextOptions<RHContext> options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}