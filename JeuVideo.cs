class JeuVideo
{
    protected string titre;
    protected string studio;
    protected int prix;

    public JeuVideo(string titre, string studio, int prix)
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
    public int GetPrix()
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