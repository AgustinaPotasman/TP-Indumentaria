static class Equipos
{
    public static List<string> ListaEquipos { get; private set; }
    public static List<string> ListaMedias { get; private set; }
    public static List<string> ListaPantalones { get; private set; }
    public static List<string> ListaRemeras { get; private set; }
    public static Dictionary<string, Indumentaria>EquiposIndumentaria{ get; private set; }

    static Equipos()
    {
        ListaEquipos = new List<string>{"Equipo1", "Equipo2", "Equipo3", "Equipo4", "Equipo5"};
        ListaMedias = new List<string>{"media1.jpg", "media2.jpg", "media3.jpg", "media4.jpg", "media5.jpg"};
        ListaPantalones = new List<string>{"pantalon1.jpg", "pantalon2.jpg", "pantalon3.jpg", "pantalon4.jpg", "pantalon5.jpg"};
        ListaRemeras = new List<string>{"remera1.jpg", "remera2.jpg", "remera3.jpg", "remera4.jpg", "remera5.jpg"};
        EquiposIndumentaria = new Dictionary<string, Indumentaria>();
    }

    public static bool IngresarIndumentaria(string equipoSeleccionado, Indumentaria item)
    {
        if (EquiposIndumentaria.ContainsKey(equipoSeleccionado))
        {
            return false;
        }
        EquiposIndumentaria.Add(equipoSeleccionado, item);
        return true;
    }


}
