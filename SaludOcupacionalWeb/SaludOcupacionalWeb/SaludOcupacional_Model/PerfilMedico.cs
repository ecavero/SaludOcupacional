//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaludOcupacional_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class PerfilMedico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PerfilMedico()
        {
            this.Cita = new HashSet<Cita>();
            this.PerfilMedicoExamen = new HashSet<PerfilMedicoExamen>();
        }
    
        public int idPerfilMedico { get; set; }
        public Nullable<int> idPersona { get; set; }
        public Nullable<int> idEmpresa { get; set; }
        public string descripcion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cita> Cita { get; set; }
        public virtual Empresa Empresa { get; set; }
        public virtual Paciente Paciente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PerfilMedicoExamen> PerfilMedicoExamen { get; set; }
    }
}
