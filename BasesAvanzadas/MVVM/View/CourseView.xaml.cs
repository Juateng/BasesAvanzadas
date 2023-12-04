using BasesAvanzadas.MVVM.Model;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BasesAvanzadas.MVVM.View
{
    public partial class CourseView : UserControl
    {
        CoursesDBDataContext dc = new CoursesDBDataContext(Properties.Settings.Default.LearnHubConnectionString);
        public CourseView()
        {
            InitializeComponent();
            LoadCourses();
        }

        public void LoadCourses()
        {
            var courses = dc.cursos.ToList();

            foreach (var course in courses)
            {
                AddCourseBorder(course.nombre_del_curso);
            }
        }

        public void AddCourseBorder(string courseName)
        {
            Border border = new Border
            {
                Width = 150,
                Height = 150,
                Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4e99ff")),
                CornerRadius = new CornerRadius(10),
                Margin = new Thickness(15, 0, 0, 0)
            };

            TextBlock textBlock = new TextBlock
            {
                Text = courseName,
                Foreground = Brushes.White,
                FontSize = 18,
                TextWrapping = TextWrapping.Wrap,
                TextTrimming = TextTrimming.CharacterEllipsis,
                TextAlignment = TextAlignment.Left,
                Margin = new Thickness(10)
            };

            border.Child = textBlock;
            CourseList.Children.Add(border);
        }
    }
}
