class DABRadio: IMedia
{

    const float SEEK_STEP = 0.5f;
    const float MAX_FRQUENCY = 108f;
    const float MIN_FRQUENCY = 87.5f;
    private float Frecuency { get; set; }
    private MediaState State { get; set; }
    public string mensaje;

    public DABRadio(){}

    public string MessageToDisplay
    {
        get{
            mensaje = State switch{
                MediaState.Playing => $"HEARING... FM - {Frecuency}",
                MediaState.Stopped => $"... RADIO OFF",
                MediaState.Paused => $"PAUSED... FM - {Frecuency}",
                _ => throw new NotImplementedException()
                };
            return "El estado de la radio es: ";
        }
    }

    public void Play()
    {
        if (State == MediaState.Stopped)
        {
            Frecuency = MIN_FRQUENCY;
        }
        if (State == MediaState.Pause)
        {
            State = MediaState.Play;
            System.Console.WriteLine(MessageToDisplay);
        }
        
    }

    public void Stop()
    {
        State = MediaState.Stopped;
        System.Console.WriteLine(MessageToDisplay);
    }

    public void Pause()
    {
        if(State == MediaState.Playing)
        {
            State = MediaState.Paused;
        }
        else if(State == MediaState.Paused)
        {
            State = MediaState.Playing;
            
        }
    }

    public void Next()
    {
        if (Frecuency == MAX_FRQUENCY)
        {
            Frecuency = MIN_FRQUENCY;
        }
        else
            Frecuency += SEEK_STEP;

        if (State == MediaState.Pause)
        {
            State = MediaState.Playing;
        }
    }

    public void Previous()
    {
        if (Frecuency == MIN_FRQUENCY)
        {
            Frecuency = MAX_FRQUENCY;
        }
        else
            Frecuency -= SEEK_STEP;

        if (State == MediaState.Pause)
        {
            State = MediaState.Playing;
        }
    }
}
