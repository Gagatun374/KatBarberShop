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
    
    public partial class TheEnd
    {
        public Nullable<int> IdWorker { get; set; }
        public int IdClients { get; set; }
        public int IdService { get; set; }
        public int Id { get; set; }
    
        public virtual Clients Clients { get; set; }
        public virtual Service Service { get; set; }
        public virtual Worker Worker { get; set; }
    }
}
