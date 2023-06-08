using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_124_S23_L17_GymClassLibrary
{
    public class Exercise
    {

        private string _name;
        private int _caloriesBurned;

        public Exercise() { }

        public Exercise(string name, int caloriesBurned)
        {
            _name = name;
            _caloriesBurned = caloriesBurned;
        } // Exercise 


        public string Name { get => _name; set => _name = value; }
        public int CaloriesBurned { get => _caloriesBurned; set => _caloriesBurned = value; }
    } // class

} // namespace
