using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.DataAccess
{
    public class EmpresaRepository : IEmpresaRepository
    {
        private readonly Context _context;

        public EmpresaRepository(Context context)
        {
            _context = context;
        }

        public List<Empresa> ListarEmpresas()
        {
            return _context.Empresas.ToList();
        }

        public Empresa ListarEmpresaById(int id)
        {
            return _context.Empresas.FirstOrDefault(p=>p.Id == id);
        }

        public void CadastrarEmpresa (Empresa empresa)
        {
            _context.Empresas.Add(empresa);
            _context.SaveChanges();
        }

        
    }
}
