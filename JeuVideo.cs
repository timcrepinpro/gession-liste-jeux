public class JeuVideo
{
    public string Titre{ get; set; }
    public string Studio{ get; set; }
    public double Prix{ get; set; }



    public JeuVideo(string titre, string studio, double prix)
    {
        this.Titre = titre;
        this.Studio = studio;
        this.Prix = prix;
    }
    public JeuVideo()
    {
        Titre = "";
        Studio = "";
        Prix = 0;
    }



    
}