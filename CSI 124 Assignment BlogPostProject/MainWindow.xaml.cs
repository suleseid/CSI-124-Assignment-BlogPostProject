using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSI_124_Assignment_BlogPostProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<BlogPost> post = new 
            ObservableCollection<BlogPost>();

        FlowDocument fdDisplay;

        public MainWindow()
        {
            InitializeComponent();
            fdDisplay = new FlowDocument();
            //Adding Posts
            post.Add(new BlogPost("Post 1", "Post body"));
            post.Add(new BlogPost("Post 2", "Post body"));
            DisplayToFlowDocument();
            //Attaching Post to our items
            lbDisplay.ItemsSource = post;

            Paragraph para = new Paragraph();
            para.FontSize = 22;
            Run inline = new Run("Size 22 _Color Red ");
            inline.Foreground = new SolidColorBrush(Colors.Red);

            para.Inlines.Add(inline);
            fdDisplay.Blocks.Add(para);
        }
        public void DisplayToFlowDocument()
        {

            Run sentence1 = new Run("This is the new sentence");
            //Added Color
            sentence1.Foreground = new SolidColorBrush(Colors.Tomato);

            Paragraph para = new Paragraph(sentence1);
            para.Inlines.Add(sentence1);

            fdDisplay.Blocks.Add(para);
        }

        private void Add(Run sentence1)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string header = txtBoxHeader.Text; // To get the header text
            string body = runBody.Text; // To get the body text
                                        // Create new BlogPost instance, which pass in the body and header
            BlogPost bp = new BlogPost ( header, body );
            // Call our post method to return a formated post string
            //Assign it to our runDisplay 
            // runDisplay.Text = bp.Post();  this line should remove and replaced by 
            //post.Add(bp);//
            post.Add(bp);
        }

        private void lbBlogPost_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ClearBlogDisplay();

            //pull selected index from listbox
            int sellectedIndexOfBlogPost = lbDisplay.SelectedIndex;
            //pull the sellected post
            BlogPost selectedBlogPost = post[sellectedIndexOfBlogPost];
            //We should have to display the selected post to the richtextbox
            DisplayBlogPost(selectedBlogPost.PostFormatted());

        }
        private void ClearBlogDisplay()
        {
            lbDisplay.Items.Clear();
        }

        private void DisplayBlogPost(object v)
        {
            throw new NotImplementedException();
        }


    }
}
