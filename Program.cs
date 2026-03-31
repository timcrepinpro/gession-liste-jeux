namespace gession_liste_jeux;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        GestionJeux l1 = new GestionJeux();

        JeuVideo j1 = new JeuVideo("Minecraft", "Mojang",29.99);
        JeuVideo j2 = new JeuVideo("Mario kart 8 delux", "Nitendo",59.99);
        JeuVideo j3 = new JeuVideo("THe Witcher 3", "CD Project",39.99);
        l1.AjouterJeu(j1);
        l1.AjouterJeu(j2);
        l1.AjouterJeu(j3);
        l1.AfficherJeux();
        





    }
}
