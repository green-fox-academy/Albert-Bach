using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {
            BlogPost BlogPost1 = new BlogPost();

            BlogPost1.AuthorName = "John Doe";
            BlogPost1.Title = "Lorem Ipsum";
            BlogPost1.Text = "Lorem ipsum dolor sit amet.";
            BlogPost1.PublicationDateTime.Year = 2010;
            BlogPost1.PublicationDateTime.Month = 10;
            BlogPost1.PublicationDateTime.Day = 10;

            BlogPost BlogPost2 = new BlogPost();

            BlogPost2.AuthorName = "Tim Urban";
            BlogPost2.Title = "Wait but why";
            BlogPost2.Text = "A popular long-form, stick - figure - illustrated blog about almost everything.";
            BlogPost2.PublicationDateTime.Year = 2010;
            BlogPost2.PublicationDateTime.Month = 10;
            BlogPost2.PublicationDateTime.Day = 10;

            BlogPost BlogPost3 = new BlogPost();

            BlogPost3.AuthorName = "William Turton";
            BlogPost3.Title = "One Engineer Is Trying to Get IBM to Reckon With Trump";
            BlogPost3.Text = "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. " +
                            "When I asked to take his picture outside one of IBM’s New York City offices," +
                            " he told me that he wasn’t really into the whole organizer profile thing.";
            BlogPost3.PublicationDateTime.Year = 2017;
            BlogPost3.PublicationDateTime.Month = 03;
            BlogPost3.PublicationDateTime.Day = 28;

        }
    }
}
