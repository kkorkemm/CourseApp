namespace CourseApp.Base
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.CourseComments = new HashSet<CourseComments>();
            this.CourseSession = new HashSet<CourseSession>();
        }

        public string FullName => Surname + " " + Name + " " + LastName;
    
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public byte GenderID { get; set; }
        public System.DateTime BirthDate { get; set; }
        public byte[] Photo { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public byte UserRoleID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseComments> CourseComments { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual UserRole UserRole { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CourseSession> CourseSession { get; set; }
    }
}
