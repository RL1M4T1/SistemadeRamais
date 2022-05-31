using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemadeRamais.Models
{
    public class CadastroModel
    {


        public int ID { get; set; }

        
        public string COLABORADOR_VC_RAMAL { get; set; }
        public string SETOR_VC_RAMAL { get; set; }
        public string RAMAL_CH_RAMAL { get; set; }
        public string FILIAL_VC_RAMAL { get; set; }


    }
}
