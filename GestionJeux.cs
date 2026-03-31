using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;


class GestionJeux
{
    private List<JeuVideo> jeuxliste = new List<JeuVideo>();
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
    public void SauverCSV(string nomFichier)
    {
        StreamWriter writer = new StreamWriter(nomFichier);
        foreach (JeuVideo e in jeuxliste)
        {
            writer.WriteLine(e.GetTitre() + ";"+e.GetStudio() + ";"+e.GetPrix());            
        }
        writer.Close();
    }

}




