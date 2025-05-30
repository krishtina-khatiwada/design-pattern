class Videoplayer
{
    public void Videoplay(string filename)
    {
        System.Console.WriteLine("playing video" + filename);
    }
}
class Audioplayer
{
    public void Audioplay(string audiofilename)
    {
        System.Console.WriteLine("playing audio" + audiofilename);
    }
}
class Multimediafacade
{
    private Videoplayer videoplayer;
    private Audioplayer audioplayer;
    public Multimediafacade()
    {
        this.videoplayer = new Videoplayer();
        this.audioplayer = new Audioplayer();

    }
    public void Playmedia(string videofile, string audiofile)
    {
        videoplayer.Videoplay(videofile);
        audioplayer.Audioplay(audiofile);
    }
}
class Program
{
    static void Main()
    {
        Multimediafacade multimediafacade = new Multimediafacade();
        multimediafacade.Playmedia("harrypotter.mp4", "audio.mp4");
    }
}