using System.Runtime.CompilerServices;

class CDPlayer: IMedia
{
    private ushort Track {get; set;}
    private MediaState State {get; set;}
    public bool Medialn => CompatDisc != null;
    Disc CompatDisc;
    public string mensaje;

    public string MessageToDisplay
    {
        get {
            if (Medialn== true) // medialn??
            {
                mensaje = State switch{
                MediaState.Playing => $"PLAYING... {CompatDisc.ToString()} Track {Track} - ",
                MediaState.Stopped => $"STOPPED... {CompatDisc.ToString()}",
                MediaState.Paused => $"PAUSED... {CompatDisc.ToString()} Track {Track} - ",
                _ => throw new NotImplementedException()
                };
            }
            else
            {
                mensaje = "NO DISC";
            }

            return mensaje;
        }
    }

    public CDPlayer(){
        this.CompatDisc = CompatDisc;
    }

    public void InsertMedia(Disc media){}

    public bool ExtractMedia(){
        return true;
    }

    public void Play()
    {
        if (State == MediaState.Stopped)
        {
            Track = 1;
        }
        Track = Track;

    }

    public void Stop()
    {
        throw new NotImplementedException();
    }

    public void Pause()
    {
        if(State == MediaState.Playing)
        {
            State = MediaState.Paused;
        }
        else if (State == MediaState.Paused)
        {
            State = MediaState.Playing;
        }
    }

    public void Next()
    {
        if(State == MediaState.Playing)
        {
            //Track = (ushort)(Track +1);
        }
        else if (State == MediaState.Paused)
        {
            Track = (ushort)(Track +1);
        }

    }

    public void Previous()
    {
        throw new NotImplementedException();
    }
}