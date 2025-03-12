class DABRadioCD: IMedia
{
    private IMedia ActiveDevice{get; set;} // modo play, pause, etc ...
    public Disc InsertCD {get; set;} // info
    private CDPlayer reproductor;
    private DABRadio sintonizador;

    public string MessageToDisplay{
        get { return $"MODO: niidea \n STATE{ActiveDevice}... {reproductor.ToString()}. Track "; }
    }

    public DABRadioCD(){}

    public void ExtractCD()
    {

    }

    public void SwitchMode(){}

    public void Play()
    {
        ActiveDevice.Play();
    }

    public void Stop()
    {
        ActiveDevice.Stop();
    }

    public void Pause()
    {
        ActiveDevice.Pause();
    }

    public void Next()
    {
        ActiveDevice.Next();
    }

    public void Previous()
    {
        ActiveDevice.Previous();
    }
}