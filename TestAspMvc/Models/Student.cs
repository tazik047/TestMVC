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
    
    public partial class Student
    {
        public Student()
        {
            this.QueueGroups = new HashSet<QueueGroup>();
        }
    
        public long StudentId { get; set; }
        public long GroupId { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual ICollection<QueueGroup> QueueGroups { get; set; }
        public virtual User User { get; set; }
    }
}
