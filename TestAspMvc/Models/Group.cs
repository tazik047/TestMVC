//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestAspMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Group
    {
        public Group()
        {
            this.Students = new HashSet<Student>();
        }
    
        public long GroupId { get; set; }
        public long Steward { get; set; }
        public string Title { get; set; }
    
        public virtual ICollection<Student> Students { get; set; }
    }
}