using System.ComponentModel.DataAnnotations.Schema;

namespace pc2_antaurco.Models
{
    [Table("t_cuenta_bancaria")]
    public class CuentaBancaria
    {
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      public long Id { get; set; }
      public string? NomTitular { get; set; }
      public string? TipoCuenta { get; set; }
      public decimal SaldoInicial { get; set; }
      public string? Correo { get; set; }  
        
    }
}