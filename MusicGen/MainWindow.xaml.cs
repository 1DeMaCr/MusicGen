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

namespace MusicGen
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

        string notes;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int prevNote = 4;
            int curNote;
            int numOfNotes = 10;
            Notes noteGen = new Notes();
            notes = noteGen.NumToNote(prevNote);
            for(int i = 0; i < numOfNotes; i++)
            {
                curNote = noteGen.NoteGen(prevNote);
                notes = notes + " " + noteGen.NumToNote(curNote);
                prevNote = curNote;
            }

            MessageBox.Show(notes);

        }
    }
}
