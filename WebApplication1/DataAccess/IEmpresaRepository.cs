using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.DataAccess
{
    public interface IEmpresaRepository
    {
        List<Empresa> ListarEmpresas();
        Empresa ListarEmpresaById(int id);
        void CadastrarEmpresa(Empresa empresa);
    }
}
