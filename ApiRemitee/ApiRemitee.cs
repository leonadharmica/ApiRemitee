using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ApiRemitee
{
    public class MonedaDeCambio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCambio { get; set; }
        public double Monto { get; set; }
        public string TipoDeCambio { get; set; }
        public double MontoResultante { get; set; }
    }

    public class Fee
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCambio { get; set; }
        public double _Fee { get; set; }
        [ForeignKey("TipoDeCambio")]
        public string TipoDeCambio { get; set; }
    }

}