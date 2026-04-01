using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text.Json;



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
            Console.WriteLine(jeu.Titre );
            Console.WriteLine(jeu.Studio );
            Console.WriteLine(jeu.Prix );
        }
    }
    public void SauverCSV(string nomFichier)
    {
        StreamWriter writer = new StreamWriter(nomFichier);
        foreach (JeuVideo e in jeuxliste)
        {
            writer.WriteLine(e.Titre + ";"+e.Studio + ";"+e.Prix);            
        }
        writer.Close();
    }
    public void ChargerCSV(string nomFichier)
    {
        jeuxliste.Clear();
        if (File.Exists(nomFichier))
        {
            StreamReader reader = new StreamReader(nomFichier);
            while (!reader.EndOfStream)
            {
                string ligne = reader.ReadLine();
                string[] morceaux = ligne.Split(';');
                JeuVideo e = new JeuVideo(morceaux[0], morceaux[1], double.Parse(morceaux[2]));
                jeuxliste.Add(e);
            }
            reader.Close();
        }
    }
    public void SauverXml(string nomFichier)
    {
        XmlSerializer xs = new XmlSerializer(typeof(List<JeuVideo>));
        StreamWriter writer = new StreamWriter(nomFichier);
        xs.Serialize(writer, jeuxliste);
        writer.Close();
    }
    public void ChargerXml(string nomFichier)
    {
        if (File.Exists(nomFichier))
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<JeuVideo>));
            StreamReader reader = new StreamReader(nomFichier);
            jeuxliste = (List<JeuVideo>)xs.Deserialize(reader);
            reader.Close();
        }
    }
    public void SauverJson(string nomFichier)
    {
        string json = JsonSerializer.Serialize(jeuxliste);
        File.WriteAllText(nomFichier, json);
    }
    public void ChargerJson(string nomFichier)
    {
        if (File.Exists(nomFichier))
        {
            string json = File.ReadAllText(nomFichier);
            jeuxliste = JsonSerializer.Deserialize<List<JeuVideo>>(json);
        }
    }
    public void prixMoyen()
    {
        double somme = 0;
        int comte = 0;
        double moyenne = 0;
        foreach (JeuVideo jeu in jeuxliste)
        {
            somme += jeu.Prix;
            comte++;
        
        }
        moyenne = somme / comte;
        Console.WriteLine(moyenne);
    }
    public void JeuPlusCher()
    {
        double somme = 0;
        string jeux = "";
        foreach (JeuVideo jeu in jeuxliste)
        {
            if (jeu.Prix > somme)
            {
                somme = jeu.Prix;
                jeux = jeu.Titre;

            }
           
        }
        Console.WriteLine("ce jeux est le plus chere");
        Console.WriteLine(jeux);
        Console.WriteLine(somme);
    }
        


}




