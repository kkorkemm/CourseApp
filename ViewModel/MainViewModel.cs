namespace CourseApp.ViewModel
{
    using MVVMCore;
    using ViewModel.AdminViewModel;

    class MainViewModel : INotify
    {
        private object currentView;

        public object CurrentView
        {
            get { return currentView; }
            set 
            { 
                currentView = value;
                OnPropertyChanged();
            }
        }

        public BaseCommand AdminCourseCommand { get; set; }
        public BaseCommand AdminUsersCommand { get; set; }
        public BaseCommand AdminSettingsCommand { get; set; }


        public AdminCourseViewModel CourseVM { get; set; }
        public AdminUsersViewModel UsersVM { get; set; }
        public AdminSettingsViewModel SettingsVM { get; set; }

        public MainViewModel()
        {
            CourseVM = new AdminCourseViewModel();
            UsersVM = new AdminUsersViewModel();
            SettingsVM = new AdminSettingsViewModel();

            CurrentView = CourseVM;

            AdminCourseCommand = new BaseCommand(o =>
            {
                CurrentView = CourseVM;
            });
            AdminUsersCommand = new BaseCommand(o =>
            {
                CurrentView = UsersVM;
            });
            AdminSettingsCommand = new BaseCommand(o =>
            {
                CurrentView = SettingsVM;
            });
        }
    }
}
