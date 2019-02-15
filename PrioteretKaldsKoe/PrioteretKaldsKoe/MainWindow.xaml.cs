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
        private PriorityQueue<Opkald> myQueue = new PriorityQueue<Opkald>();
        private PriorityQueue<PrioriteretOpkald> myPriorityQueue = new PriorityQueue<PrioriteretOpkald>();
        int i = 0;
        private int kaldNummer = 0;
        private int prioriteretKaldNummer = 0;
        private int antalOpkaldIkoe =0 ;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_TakeCall_Click(object sender, RoutedEventArgs e)
        {
            if (prioriteretKaldNummer > 0)
            {
                    myQueue.Dequeue(myPriorityQueue.GetOldestCall());
                    prioriteretKaldNummer--;
            }
            else
            {
                    myQueue.Dequeue();
            }           
        }

        private void btn_MakeCall_Click(object sender, RoutedEventArgs e)
        {
            //callerID.Add(i++);
            Opkald nytOpkald = new Opkald(kaldNummer);
            myQueue.Enqueue(nytOpkald);
            kaldNummer++;
            antalOpkaldIkoe++;
        }

        private void btn_MakePriorityCall_Click(object sender, RoutedEventArgs e)
        {
            Opkald nytOpkald = new PrioriteretOpkald(kaldNummer);
            PrioriteretOpkald nytPrioriteretOpkald = new PrioriteretOpkald(kaldNummer);
            myQueue.Enqueue(nytOpkald);
            myPriorityQueue.Enqueue(nytPrioriteretOpkald);
            kaldNummer++;
            prioriteretKaldNummer++;
            antalOpkaldIkoe++;
        }
    }
}
