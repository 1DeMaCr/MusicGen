using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGen
{
    class Notes
    {
        public string NumToNote(int n)
        {
            string note="None";
            switch (n)
            {
                case 1: note = "C"; break;
                case 2: note = "C#"; break;
                case 3: note = "D"; break;
                case 4: note = "D#"; break;
                case 5: note = "E"; break;
                case 6: note = "F"; break;
                case 7: note = "F#"; break;
                case 8: note = "G"; break;
                case 9: note = "G#"; break;
                case 10: note = "A"; break;
                case 11: note = "A#"; break;
                case 12: note = "B"; break;
            }
            return note;
        }

        public int NoteGen(int prevNote)
        {
            int note;
            var rand = new Random();
            do
                note = rand.Next(1, 15);
            while (NoteIncorrect(prevNote, note));
            
            return note;
        }

        public bool NoteIncorrect(int prevNote, int curNote)
        {
            if (prevNote == curNote)
            {
                return false;
            }
            else if (prevNote > curNote)
            {
                return false;
            }
            else if (curNote % 2 == 0) return false;
            else return true;
        }
    }
}
