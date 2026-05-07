using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSubmissionAssignment
{
    public class FavoriteGame
    {
        // Creates a class called FavoriteGame with two constructors and chains the first constructor to the second
        public FavoriteGame(string name) : this(name, 2004)
        {
            // This constructor calls the second constructor
        }

        public FavoriteGame(string name, int yearReleased)
        {
            Release = yearReleased;
            Name = name;
        }

        // Declares properties for the class
        public string Name { get; set; }
        public int Release { get; set; }
    }
}
