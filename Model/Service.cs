//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KatBarberShop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Service
    {
        public Service()
        {
            this.TheEnd = new HashSet<TheEnd>();
        }
    
        public string ServiceName { get; set; }
        public string Price { get; set; }
        public int Id { get; set; }
        public byte[] Image { get; set; }
    
        public virtual ICollection<TheEnd> TheEnd { get; set; }
    }
}
