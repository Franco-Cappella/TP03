namespace TP03.Models;

public static class Disquera
{
    public static Dictionary<string, Disco> DicDiscos { get; private set; } = new Dictionary<string, Disco>();

    public static void InicializarDisquera()
    {
        if (DicDiscos.Count == 0)
        {
            List<string> l1 = new List<string>();
            l1.Add("El amor despues del amor");
            l1.Add("Tumbas de la gloria");
            l1.Add("Dos días en la vida");
            l1.Add("La rueda mágica");
            l1.Add("A rodar mi vida");
            Disco disco1 = new Disco("Fito Paez", "Fito Paez", "Pop/Rock", 1, "eadda.jfif", l1);
            DicDiscos.Add("El amor despues del amor", disco1);

            List<string> l2 = new List<string>();
            l2.Add("Bocanada");
            l2.Add("Puente");
            l2.Add("Beautiful");
            l2.Add("Engaña");
            l2.Add("Verbo carne");
            Disco disco2 = new Disco("Gustavo Cerati", "Gustavo Cerati", "Electrónica/Rock", 2, "bocanada.jfif", l2);
            DicDiscos.Add("Bocanada", disco2);

            List<string> l3 = new List<string>();
            l3.Add("El tesoro");
            l3.Add("Ahora imagino cosas");
            l3.Add("La noche eterna");
            l3.Add("Alguien que lo merece");
            l3.Add("Las luces");
            Disco disco3 = new Disco("El Mató a un Policía Motorizado", "Eduardo Bergallo y la banda", "Indie/Rock", 3, "lsok.jfif", l3);
            DicDiscos.Add("La Síntesis O'Konor", disco3);

            List<string> l4 = new List<string>();
            l4.Add("Muchacha(ojos de papel)");
            l4.Add("Color humano");
            l4.Add("Figuración");
            l4.Add("Ana no duerme");
            l4.Add("Fermín");
            Disco disco4 = new Disco("Almendra", "Ricardo Kleiman", "Psicodelico/Rock", 4, "almendra.jfif", l4);
            DicDiscos.Add("Almendra", disco4);

            List<string> l5 = new List<string>();
            l5.Add("Aquellas pequeñas cosas");
            l5.Add("Zamba para no morir");
            l5.Add("Barro tal vez");
            l5.Add("Nada");
            l5.Add("Zona de promesas");
            Disco disco5 = new Disco("Mercedes Sosa", "Popi Spatocco", "Folklore", 5, "cantora.jfif", l5);
            DicDiscos.Add("Cantora, un viaje íntimo", disco5);

            List<string> l6 = new List<string>();
            l6.Add("Sin sobresaltos");
            l6.Add("El rito");
            l6.Add("Prófugos");
            l6.Add("No existes");
            l6.Add("Persiana americana");
            Disco disco6 = new Disco("Soda Stereo", "Gustavo Cerati y Zeta Bosio", "Rock/Wave", 6, "signos.jfif", l6);
            DicDiscos.Add("Signos", disco6);
        }

    }
}

