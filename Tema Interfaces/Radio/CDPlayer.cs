using System.Runtime.CompilerServices;

class CDPlayer : IMedia
{
    private ushort Track { get; set; }
    private MediaState State { get; set; }
    public bool MediaIn => CompatDisc != null;
    Disc CompatDisc = new Disc();
    public string mensaje;


    public void InsertMedia(Disc media)
    {
        CompatDisc = media;
    }
    public string MessageToDisplay
    {
        get
        {
            if (MediaIn == true) // medialn??
            {
                mensaje = State switch
                {
                    MediaState.Playing => $"PLAYING... {CompatDisc.ToString()} Track {CompatDisc.NombreCancion(Track)} - ",
                    MediaState.Stopped => $"STOPPED... {CompatDisc.ToString()}",
                    MediaState.Paused => $"PAUSED... {CompatDisc.ToString()} Track {CompatDisc.NombreCancion(Track)} - ",
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

    public CDPlayer()
    {
        this.CompatDisc = new Disc();
    }



    public bool ExtractMedia()
    {
        if (MediaIn)
        {
            compactDisc = null;
            State = MediaState.Stopped;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Play()
    {
        if (State == MediaState.Stopped)
        {
            Track = 0;
        }


    }

    public void Stop()
    {
        State = MediaState.Stopped;
    }

    public void Pause()
    {
        if (State == MediaState.Playing)
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
        if (CompatDisc.NumTracks == Track)
        {
            Track = 0;
        }else
        {
            Track = (ushort)(Track + 1);
        }

        if (State == MediaState.Stopped)
        {
            State = MediaState.Playing;            
        }
        /* if (State == MediaState.Playing)
         {
             if (CompatDisc.NumTracks == Track)
             {
                 Track = 0;

             }
             else
             {
                 Track = (ushort)(Track + 1);
             }
         }
         else if (State == MediaState.Paused)
         {
             if (CompatDisc.NumTracks == Track)
             {
                 Track = 0;
                 State = MediaState.Playing;
             }
             else
             {
                 Track = (ushort)(Track + 1);
             }
         }*/

    }

    public void Previous()
    {
        if (0 == Track)
        {
            Track = CompatDisc.NumTracks;
        }else
        {
            Track = (ushort)(Track - 1);
        }

        if (State == MediaState.Stopped)
        {
            State = MediaState.Playing;            
        }
    }
}