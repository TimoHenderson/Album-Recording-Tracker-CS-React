using RecordingTrackerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RecordingTrackerApi.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RecordingContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();

            if (context.Artists.Any()
                && context.Albums.Any()
                && context.Songs.Any()
                && context.Parts.Any()
                && context.Instruments.Any())
            {
                return;
            }

            var guitarInstrument = new Instrument { Name = "Guitar" };
            var bassInstrument = new Instrument { Name = "Bass" };
            var drumsInstrument = new Instrument { Name = "Drums" };
            var tromboneInstrument = new Instrument { Name = "Trombone" };
            var keysInstrument = new Instrument { Name = "Keys" };

            var song1GuitarPart = new Part { Name = "Guitar Part", Instrument = guitarInstrument, Completion = 20 };
            var song1BassPart = new Part { Name = "Bass Part", Instrument = bassInstrument, Completion = 20 };
            var song1DrumsPart = new Part { Name = "Drums Part", Instrument = drumsInstrument, Completion = 20 };

            var song2GuitarPart = new Part { Name = "Guitar Part2", Instrument = guitarInstrument };
            var song2BassPart = new Part { Name = "Bass Part2", Instrument = bassInstrument };
            var song2DrumsPart = new Part { Name = "Drums Part2", Instrument = drumsInstrument };

            var song1 = new Song { Name = "Song 1", Children = new List<Part> { song1GuitarPart, song1BassPart, song1DrumsPart } };
            var song2 = new Song { Name = "Song 2", Children = new List<Part> { song2GuitarPart, song2BassPart, song2DrumsPart } };

            var album1 = new Album { Name = "Album 1", Children = new List<Song> { song1, song2 } };

            var artist1 = new Artist { Name = "Artist 1", Children = new List<Album> { album1 } };

            var song3GuitarPart = new Part { Name = "Guitar Part3", Instrument = guitarInstrument, Completion = 20 };
            var song3BassPart = new Part { Name = "Bass Part3", Instrument = bassInstrument };
            var song3DrumsPart = new Part { Name = "Drums Part3", Instrument = drumsInstrument };

            var song4GuitarPart = new Part { Name = "Guitar Part4", Instrument = guitarInstrument };
            var song4BassPart = new Part { Name = "Bass Part4", Instrument = bassInstrument };
            var song4DrumsPart = new Part { Name = "Drums Part4", Instrument = drumsInstrument };

            var song3 = new Song { Name = "Song 3", Children = new List<Part> { song3GuitarPart, song3BassPart, song3DrumsPart } };
            var song4 = new Song { Name = "Song 4", Children = new List<Part> { song4GuitarPart, song4BassPart, song4DrumsPart } };

            var album2 = new Album { Name = "Album 2", Children = new List<Song> { song3, song4 } };

            var artist2 = new Artist { Name = "Artist 2", Children = new List<Album> { album2 } };

            var artist3 = new Artist { Name = "Artist 3" };

            var song5GuitarPart = new Part { Name = "Guitar Part5", Instrument = guitarInstrument, Completion = 80 };
            var song5BassPart = new Part { Name = "Bass Part5", Instrument = bassInstrument, Completion = 60 };
            var song5DrumsPart = new Part { Name = "Drums Part5", Instrument = drumsInstrument, Completion = 40 };

            var song6GuitarPart = new Part { Name = "Guitar Part6", Instrument = guitarInstrument, Completion = 100 };
            var song6BassPart = new Part { Name = "Bass Part6", Instrument = bassInstrument, Completion = 20 };
            var song6DrumsPart = new Part { Name = "Drums Part6", Instrument = drumsInstrument, Completion = 60 };
            var song6TrombonePart = new Part { Name = "Trombone Part6", Instrument = tromboneInstrument, Completion = 100 };
            var song6KeysPart = new Part { Name = "Keys Part6", Instrument = keysInstrument, Completion = 100 };

            var song7GuitarPart = new Part { Name = "Guitar Part7", Instrument = guitarInstrument, Completion = 80 };
            var song7BassPart = new Part { Name = "Bass Part7", Instrument = bassInstrument, Completion = 40 };
            var song7DrumsPart = new Part { Name = "Drums Part7", Instrument = drumsInstrument, Completion = 20 };
            var song7TrombonePart = new Part { Name = "Trombone Part7", Instrument = tromboneInstrument, Completion = 40 };
            var song7KeysPart = new Part { Name = "Keys Part7", Instrument = keysInstrument, Completion = 20 };

            var song5 = new Song { Name = "Clack, Graabes, and Renfrewshire", Children = new List<Part> { song5GuitarPart, song5BassPart, song5DrumsPart } };
            var song6 = new Song { Name = "Sexy(Stick Your Bum Out)", Children = new List<Part> { song6GuitarPart, song6BassPart, song6DrumsPart, song6KeysPart, song7TrombonePart } };
            var song7 = new Song { Name = "What's The Problem?", Children = new List<Part> { song7GuitarPart, song7BassPart, song7DrumsPart, song7TrombonePart, song7KeysPart } };

            var album3 = new Album { Name = "Are You Papylonian?", Children = new List<Song> { song5, song6, song7 } };

            var song8GuitarPart = new Part { Name = "Guitar Part8", Instrument = guitarInstrument, Completion = 80 };
            var song8BassPart = new Part { Name = "Bass Part8", Instrument = bassInstrument, Completion = 40 };
            var song8DrumsPart = new Part { Name = "Drums Part8", Instrument = drumsInstrument, Completion = 100 };
            var song8TrombonePart = new Part { Name = "Trombone Part8", Instrument = tromboneInstrument, Completion = 40 };
            var song8KeysPart = new Part { Name = "Keys Part8", Instrument = keysInstrument, Completion = 20 };

            var song9GuitarPart = new Part { Name = "Guitar Part9", Instrument = guitarInstrument, Completion = 80 };
            var song9BassPart = new Part { Name = "Bass Part9", Instrument = bassInstrument, Completion = 40 };
            var song9DrumsPart = new Part { Name = "Drums Part9", Instrument = drumsInstrument, Completion = 20 };
            var song9TrombonePart = new Part { Name = "Trombone Part9", Instrument = tromboneInstrument, Completion = 40 };
            var song9KeysPart = new Part { Name = "Keys Part9", Instrument = keysInstrument, Completion = 20 };

            var song10GuitarPart = new Part { Name = "Guitar Part10", Instrument = guitarInstrument, Completion = 80 };
            var song10BassPart = new Part { Name = "Bass Part10", Instrument = bassInstrument, Completion = 40 };
            var song10DrumsPart = new Part { Name = "Drums Part10", Instrument = drumsInstrument, Completion = 20 };
            var song10TrombonePart = new Part { Name = "Trombone Part10", Instrument = tromboneInstrument, Completion = 40 };
            var song10KeysPart = new Part { Name = "Keys Part10", Instrument = keysInstrument, Completion = 20 };

            var song11GuitarPart = new Part { Name = "Guitar Part11", Instrument = guitarInstrument, Completion = 80 };
            var song11BassPart = new Part { Name = "Bass Part11", Instrument = bassInstrument, Completion = 40 };
            var song11DrumsPart = new Part { Name = "Drums Part11", Instrument = drumsInstrument, Completion = 20 };
            var song11TrombonePart = new Part { Name = "Trombone Part11", Instrument = tromboneInstrument, Completion = 40 };
            var song11KeysPart = new Part { Name = "Keys Part11", Instrument = keysInstrument, Completion = 20 };

            var song12GuitarPart = new Part { Name = "Guitar Part12", Instrument = guitarInstrument, Completion = 80 };
            var song12BassPart = new Part { Name = "Bass Part12", Instrument = bassInstrument, Completion = 40 };
            var song12DrumsPart = new Part { Name = "Drums Part12", Instrument = drumsInstrument, Completion = 20 };
            var song12TrombonePart = new Part { Name = "Trombone Part12", Instrument = tromboneInstrument, Completion = 40 };
            var song12KeysPart = new Part { Name = "Keys Part12", Instrument = keysInstrument, Completion = 20 };

            var song13GuitarPart = new Part { Name = "Guitar Part13", Instrument = guitarInstrument, Completion = 80 };
            var song13BassPart = new Part { Name = "Bass Part13", Instrument = bassInstrument, Completion = 40 };
            var song13DrumsPart = new Part { Name = "Drums Part13", Instrument = drumsInstrument, Completion = 20 };
            var song13TrombonePart = new Part { Name = "Trombone Part13", Instrument = tromboneInstrument, Completion = 40 };
            var song13KeysPart = new Part { Name = "Keys Part13", Instrument = keysInstrument, Completion = 20 };

            var song8 = new Song { Name = "Old Tired Cold Bones", Children = new List<Part> { song8GuitarPart, song8BassPart, song8DrumsPart, song8TrombonePart, song8KeysPart } };
            var song9 = new Song { Name = "Egyptian Space Pirates", Children = new List<Part> { song9GuitarPart, song9BassPart, song9DrumsPart, song9TrombonePart, song9KeysPart } };
            var song10 = new Song { Name = "Late Night Sneaky Mama", Children = new List<Part> { song10GuitarPart, song10BassPart, song10DrumsPart, song10TrombonePart, song10KeysPart } };
            var song11 = new Song { Name = "The Ballad of the 3rd Arm", Children = new List<Part> { song11GuitarPart, song11BassPart, song11DrumsPart, song11TrombonePart, song11KeysPart } };
            var song12 = new Song { Name = "Grap", Children = new List<Part> { song12GuitarPart, song12BassPart, song12DrumsPart, song12TrombonePart, song12KeysPart } };
            var song13 = new Song { Name = "Scientific Facts", Children = new List<Part> { song13GuitarPart, song13BassPart, song13DrumsPart, song13TrombonePart, song13KeysPart } };

            var album4 = new Album { Name = "Paradigm Lost", Children = new List<Song> { song8, song9, song10, song11, song12, song13 } };
            var artist4 = new Artist { Name = "Bar Room Crawl", Children = new List<Album> { album3, album4 } };


            var artists = new Artist[] { artist1, artist2, artist3, artist4 };
            context.Artists.AddRange(artists);
            context.SaveChanges();

        }
    }
}