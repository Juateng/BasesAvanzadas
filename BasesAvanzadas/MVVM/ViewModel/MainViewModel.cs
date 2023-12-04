using BasesAvanzadas.Core;
using BasesAvanzadas.MVVM.Model;
using System.Linq;

namespace BasesAvanzadas.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        CoursesDBDataContext dc = new CoursesDBDataContext(Properties.Settings.Default.LearnHubConnectionString);

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand CourseViewCommand { get; set; }
        public RelayCommand AssignmentViewCommand { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public CourseViewModel CourseVM { get; set; }
        public AssignmentViewModel AssignmentVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            CourseVM = new CourseViewModel();
            AssignmentVM = new AssignmentViewModel();
            CurrentView = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });
            CourseViewCommand = new RelayCommand(o =>
            {
                CurrentView = CourseVM;
            });
            AssignmentViewCommand = new RelayCommand(o =>
            {
                CurrentView = AssignmentVM;
            });
        }
    }
}
