using Newtonsoft.Json.Linq;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ApiCreate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            RestClient restClient = new RestClient();

            restClient.endPoint = TextBox1.Text;
            
            string strResponse = string.Empty;

            strResponse = restClient.makeRequest();
            //TextBox2.Text = strResponse;
            JArray response = JArray.Parse(strResponse);
            List<Post> posts = Post.FromJsonArray(response);
            listview2.ItemsSource=posts;

    }       
    }
}
