﻿using Microsoft.EntityFrameworkCore;
using RenoMeraApi.Domain.Models;
using RenoMeraApi.Persistence;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RenoMeraApi.Domain.Repositories
{
    public class SupplierReository : ISupplierRepository
    {
        private readonly AppDbContext context;

        public SupplierReository(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(SupplierPost supplierPost)
        {
            context.Add(supplierPost);
            context.SaveChanges();
        }

        public async Task<IEnumerable<SupplierPost>> GetAllPost()
        {
            return await context.supplierPosts.ToArrayAsync();
        }

        public async Task<IEnumerable<SupplierPost>> GetAllPostById(string Id)
        {
            return await context.supplierPosts.Where(c => c.UserId == Id).ToArrayAsync();
        }

        public void UpdateSupplierPost(SupplierPost supplierPost)
        {
            context.supplierPosts.Update(supplierPost);
            context.SaveChanges();
        }
    }
}
