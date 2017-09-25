using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post_it
{
    class Program
    {

        public struct PostIt
        {
            public string BackGroundColor;
            public string Text;
            public string TextColor;
        }


        static void Main(string[] args)
        {
            PostIt postit1;
            postit1.BackGroundColor = "orange";
            postit1.Text = "Idea 1";
            postit1.TextColor = "blue";

            PostIt postit2;
            postit2.BackGroundColor = "pink";
            postit2.Text = "Awesome";
            postit2.TextColor = "black";

            PostIt postit3;
            postit3.BackGroundColor = "yellow";
            postit3.Text = "Superb!";
            postit3.TextColor = "green";
           
        }
    }
}
