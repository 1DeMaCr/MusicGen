using System;
using System.Collections.Generic;
using System.Text;

namespace MusicGen
{
    class Notes
    {
        public string NumToNote(int n)
        {
            string note = "None";
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
                case 13: note = "_"; break;
            }
            return note;
        }

        public int NoteGen(int prevNote, int genType)
        {
            int note = 0;
            var rand = new Random();
            switch (genType) {
                case 1:
                    do
                        note = rand.Next(1, 14);
                    while (NoteIncorrect(prevNote, note));
                    break;
                case 2:
                    do
                        note = rand.Next(1, 14);
                    while (NoteIncorrect2(prevNote, note));
                    break;
                case 3:
                    do
                        note = rand.Next(1, 14);
                    while (NoteIncorrect3(prevNote, note));
                    break;
            }
            
            return note;
        }

        public bool NoteIncorrect(int prevNote, int curNote)
        {
            if (curNote == 13) return false;
            else
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

        public bool NoteIncorrect2(int prevNote, int curNote)
        {
            if (curNote == 13) return false;
            else
            if (prevNote == curNote)
            {
                return false;
            }
            else if (prevNote % curNote == 0)
            {
                return false;
            }
            else if (curNote % 2 == 0) return false;
            else return true;
        }

        public bool NoteIncorrect3(int prevNote, int curNote)
        {
            if (curNote == 13) return false;
            else
            if (prevNote == curNote)
            {
                return false;
            }
            else if (prevNote > curNote)
            {
                return false;
            }
            else if (curNote % prevNote == 0) return false;
            else return true;
        }
    }
}
