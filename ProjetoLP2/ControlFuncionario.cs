using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLP2
{
    class ControlFuncionario
    {
        public void Create(ModelFuncionario funcionario)
        {
            DAOFuncionario dao = new DAOFuncionario();
            dao.Create(funcionario);
        }
    }
}
