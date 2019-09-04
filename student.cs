using System;
using System.Collections.Generic;
using System.Text;

namespace lab_11._1
{
 
        class Student
        {
            public string Name { get; set; }
            public string HomeTown { get; set; }
            public string FavoriteFood { get; set; }
            public string FavoriteColor { get; set; }
            public Student()
            {
                Name = "";
                HomeTown = "";
                FavoriteFood = "";
                FavoriteColor = "";
            }
            public Student(string _name, string _homeTown, string _favFood, string _favColor)
            {
                Name = _name;
                HomeTown = _homeTown;
                FavoriteFood = _favFood;
                FavoriteColor = _favColor;
            }
        }



    
}
