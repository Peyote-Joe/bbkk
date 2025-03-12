class Disc
{
    private string Album {get; set;}
    private string Artist {get; set;}
    private string[] Songs{get; set;}
    //public int NumTracks {get;} // revisar como funciona Carmen dijo algo "preguntar??"
    public int NumTracks => Songs.Length;

    public Disc(string album, string artist, string [] songs)
    {
        Album = album;
        Artist = artist;
        Songs = songs;
    }

    public string NombreCancion(in int song) => (song >= 0 && song < Songs.Length) ? Songs[song] : "Unknown"; // revisar funcionamiento ???

    public override string ToString()
    {
        return $"Album: {Album} Artist: {Artist}.";
    }
}