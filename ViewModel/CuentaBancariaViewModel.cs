using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pc2_antaurco.Models;

namespace pc2_antaurco.ViewModel
{
    public class CuentaBancariaViewModel
    {
        public CuentaBancaria? FormCuentaBancaria { get; set; }
        public List<CuentaBancaria>? ListarCuentaBancaria { get; set; }
    }
}