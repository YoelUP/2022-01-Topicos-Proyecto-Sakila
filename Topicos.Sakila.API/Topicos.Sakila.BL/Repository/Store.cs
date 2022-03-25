using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.Sakila.Model.Models;

namespace Topicos.Sakila.BL.Repository
{
    internal class Store
    {
        private readonly sakilaContext _context = new();
        private readonly int _pageNumber = 0;
        private readonly int _pagesize = 10;

        public async Task<IList<Model.Models.Store>> ListarAsync()
        {
            var result = await _context.Stores.Skip(_pagesize * _pageNumber).Take(_pagesize).
                OrderBy(c => c.AddressId).ToListAsync();
            return result;
        }
    }
}
