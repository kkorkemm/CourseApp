namespace CourseApp.Base
{
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CourseDBEntities : DbContext
    {
        public CourseDBEntities()
            : base("name=CourseDBEntities")
        {
        }

        private static CourseDBEntities context;
        public static CourseDBEntities GetContext()
        {
            if (context == null)
                context = new CourseDBEntities();
            return context;
        }

        public static User currentUser;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseCategory> CourseCategory { get; set; }
        public virtual DbSet<CourseComments> CourseComments { get; set; }
        public virtual DbSet<CourseSession> CourseSession { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
    }
}
