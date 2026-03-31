class JeuVideo
{
    protected string titre;
    protected string studio;
    protected double prix;

    public JeuVideo(string titre, string studio, double prix)
    {
        this.titre = titre;
        this.studio = studio;
        this.prix = prix;
    }
    public JeuVideo()
    {
    }
    public string GetTitre()
    {
        return titre;
    }
    public string GetStudio()
    {
        return studio;
    }
    public double GetPrix()
    {
        return prix;
    }
    public void SetTitre(string titre)
    {
        this.titre = titre;
    }
    public void SetStudio(string studio)
    {
        this.studio = studio;
    }
    public void SetPrix(int prix)
    {
        this.prix = prix;
    }
     


    
}