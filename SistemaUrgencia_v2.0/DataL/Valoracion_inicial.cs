//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaUrgencia_v2._0.DataL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Valoracion_inicial
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Valoracion_inicial()
        {
            this.DatosUrgencia = new HashSet<DatosUrgencia>();
        }
    
        public int id_valoracion_ini { get; set; }
        public string dolor { get; set; }
        public string tipo_dolor { get; set; }
        public string localizacion { get; set; }
        public Nullable<int> id_consVitales { get; set; }
        public Nullable<int> id_p_liquido { get; set; }
        public Nullable<int> id_anls { get; set; }
        public Nullable<int> id_Radiografias { get; set; }
        public Nullable<int> id_presc { get; set; }
    
        public virtual Analisis Analisis { get; set; }
        public virtual ConstantesVitales ConstantesVitales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DatosUrgencia> DatosUrgencia { get; set; }
        public virtual Imagenes Imagenes { get; set; }
        public virtual Perdida_liquidos Perdida_liquidos { get; set; }
        public virtual Prescripcion_Emergencia Prescripcion_Emergencia { get; set; }
    }
}
