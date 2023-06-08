using Prog_124_S23_L17_GymClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Prog_124_S23_L17_Final_Review
{
    /// <summary>
    /// Interaction logic for Workouts.xaml
    /// </summary>
    public partial class Workouts : Window
    {
        List<Exercise> _exercise = new List<Exercise>();

        public Workouts()
        {
            InitializeComponent();
            Preload();

            lvExercises.ItemsSource = _exercise;

        } // Workouts
        
        public void Preload()
        {
            _exercise.Add(new Exercise("Run", 1000));
            _exercise.Add(new Exercise("Weights", 400));
        } // Preload()


    } // class

} // namespace
