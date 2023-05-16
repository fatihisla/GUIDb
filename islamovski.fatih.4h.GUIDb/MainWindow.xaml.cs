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
using SQLite;


namespace islamovski.fatih._4h.GUIDb
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Count=0;
        public MainWindow()
        {
            InitializeComponent();
     
        }
        private void OnConterClicker(object sender,EventArgs e)
        {
            if(!FileStyleUriParser.Exiist(targetFile))
            {
                using (Stream fileStream = FileSystem.Current.OpenAppPackageFileAsync("chinook.db")) 
                    

            }
            SQLiteConnection cn1 = new SQLiteConnection (targetFile,sium)

            List<Artist> tblArtist;
            tblArtist = cn1.Query<tblArtist>("select * from artist where name like 'b%'");

            CounterBtn.Text = $"In questo database ci sono {tblArtist.Count()}artisti.";
            dgDati.ItemsSource = tblArtist;
        }
    }
}
