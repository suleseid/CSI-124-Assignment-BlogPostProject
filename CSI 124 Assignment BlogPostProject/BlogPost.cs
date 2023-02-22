using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CSI_124_Assignment_BlogPostProject
{
    internal class BlogPost
    {
        //Feilds
        string _header; // holds header values.
        string _body; // holds body value.
        DateTime _posted;//holds time post was created.

        //Constructor

        public BlogPost(string header, string body)
        {
            _header = header;
            _body = body;
            _posted = DateTime.Now;
        }
        //Properties
        public string Header { get => _header; set => _header = value; }
        public string Body { get => _body; set => _body = value; }
        public DateTime Posted { get => _posted;}
        
        //method

        public string post()
        {
            string date = _posted.ToShortDateString();
            string header = $"{date} _ {_header}";
            string space = $"/n/n";
            string body = _body;
            string full = header + space + body;
            return full;
        }
        public Paragraph PostFormatted()
        {
            //Date _Head
            //Body
            string date = _posted.ToShortDateString();
            string header = $"{date} _ {_header}";
            string space = $"/n/n";
            string body = _body;
            string full = header + space + body;

            //Contains the date- header- and new lines
            Run runHeader = new Run(header + space);
            runHeader.FontSize = 22; // to increase header size to 22px

            //Contains our body text.
            Run runBody = new Run(body);

            //Lets create a paragraph 
            Paragraph p = new Paragraph(); // Remove this later
            return p;

            //PostFormatted
        }
        internal object Post()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{_posted.ToShortDateString()}_ {_header}";
        }
    }
}
