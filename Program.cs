namespace gession_liste_jeux;

class Program
{
    static void Main(string[] args)
    {


        Console.WriteLine("Hello, World!");
        GestionJeux l1 = new GestionJeux();
        GestionJeux l2 = new GestionJeux();
        GestionJeux l3 = new GestionJeux();

        JeuVideo j1 = new JeuVideo("Minecraft", "Mojang",29.99);
        JeuVideo j2 = new JeuVideo("Mario kart 8 delux", "Nitendo",59.99);
        JeuVideo j3 = new JeuVideo("THe Witcher 3", "CD Project",39.99);
        
        l1.AjouterJeu(j1);
        l1.AjouterJeu(j2);
        l1.AjouterJeu(j3);
        l1.AfficherJeux();

        l1.SauverCSV("GestionJeux.csv");

        l1.ChargerCSV("GestionJeux.csv");
        l1.AfficherJeux();

        


        l2.AjouterJeu(j1);
        l2.AjouterJeu(j2);
        l2.AjouterJeu(j3);
        l2.AfficherJeux();

        l2.SauverXml("GestionJeux.xml");
        l2.ChargerXml("GestionJeux.xml");
        l2.AfficherJeux();


        l3.AjouterJeu(j1);
        l3.AjouterJeu(j2);
        l3.AjouterJeu(j3);
        l3.AfficherJeux();
        l3.SauverJson("GestionJeux.json");
        l3.ChargerJson("GestionJeux.json");
        l3.AfficherJeux();
        


    }
}
