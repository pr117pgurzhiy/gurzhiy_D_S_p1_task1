//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Florist
{
    using System;
    using System.Collections.Generic;
    
    public partial class zakazy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public zakazy()
        {
            this.orderproduct = new HashSet<orderproduct>();
        }
    
        public int Номер_заказа { get; set; }
        public string Состав_заказа { get; set; }
        public System.DateTime Дата_заказа { get; set; }
        public System.DateTime Дата_доставки { get; set; }
        public int Пункт_выдачи { get; set; }
        public string ФИО_клиента { get; set; }
        public int Код_для_получения { get; set; }
        public int код_статуса_заказа { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<orderproduct> orderproduct { get; set; }
        public virtual punktyvydachi punktyvydachi { get; set; }
        public virtual statuszak statuszak { get; set; }
    }
}
