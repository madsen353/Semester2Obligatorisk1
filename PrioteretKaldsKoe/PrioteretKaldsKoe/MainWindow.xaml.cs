using System;
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

namespace PrioteretKaldsKoe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PriorityQueue<int> myQueue = new PriorityQueue<int>();
        //List<int> callerID = new List<int>();
        private string currentCallPickUpTimestamp;
        private int currentCall;


        int i = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_TakeCall_Click(object sender, RoutedEventArgs e)
        {
            //if (currentCall == 0)
            //{
                //currentCall = myQueue.First();
                myQueue.Dequeue();
                currentCallPickUpTimestamp = DateTime.Now.ToString();
           // }

        }

        private void btn_EndCall_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_MakeCall_Click(object sender, RoutedEventArgs e)
        {

            //callerID.Add(i++);
            myQueue.Enqueue(callerID.Count);
        }


    }
}
