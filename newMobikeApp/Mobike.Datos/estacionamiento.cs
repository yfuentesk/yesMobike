//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mobike.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class estacionamiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estacionamiento()
        {
            this.bicicleta = new HashSet<bicicleta>();
        }
    
        public int id_est { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int capacidad { get; set; }
        public int id_comuF { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bicicleta> bicicleta { get; set; }
        public virtual comuna comuna { get; set; }
    }
}
