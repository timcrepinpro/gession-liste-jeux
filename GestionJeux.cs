class GestionJeux
{
    private List<JeuVideo> jeuxliste;
    public GestionJeux()
    {
        jeuxliste = new List<JeuVideo>();
    }
    public void AjouterJeu(JeuVideo jeu)
    {
        jeuxliste.Add(jeu);
    }
    public void SupprimerJeu(JeuVideo jeu)
    {
        jeuxliste.Remove(jeu);
    }
    public void AfficherJeux()
    {
        Console.WriteLine("Liste des jeux :");
        foreach (JeuVideo jeu in jeuxliste)
        {
            Console.WriteLine(jeu.GetTitre() );
            Console.WriteLine(jeu.GetStudio() );
            Console.WriteLine(jeu.GetPrix() );
        }
    }

}




