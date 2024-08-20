using System.ComponentModel.DataAnnotations;

namespace LogServiceYiDev.Models
{
    public class LogModel
    {
        [Key]                
        public Guid log_uuid { get; set; }                
        public string log_aplicacion { get; set; }        
        public string log_servicio { get; set; }
        public int log_cod_http { get; set; }
        public int log_cod_resp { get; set; }         
        public string log_desc_resp { get; set; }         
        public string log_endpoint { get; set; }           
        public DateTime log_fec_req { get; set; }         
        public string log_request { get; set; }           
        public DateTime log_fec_response { get; set; }         
        public string log_response { get; set; }               
        public string log_origen { get; set; }            
        public int log_estado { get; set; }             
        public int log_usuario { get; set; }            
        public DateTime log_fec_reg { get; set; }
    }
}
