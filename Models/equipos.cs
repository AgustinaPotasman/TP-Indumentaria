static class Equipos
{
    public static List<string> ListaEquipos { get; private set; }
    public static List<string> ListaMedias { get; private set; }
    public static List<string> ListaPantalones { get; private set; }
    public static List<string> ListaRemeras { get; private set; }
    public static Dictionary<string, Indumentaria>EquiposIndumentaria{ get; private set; }

    static Equipos()
    {
        ListaEquipos = new List<string>{"1Equipo", "2Equipo", "3Equipo"};
        ListaMedias = new List<string>{"1Medias.jpg", "2Medias.jpg", "3Medias.jpg"};
        ListaPantalones = new List<string>{"1Pantalon.jpg", "2Pantalon.jpg", "3Pantalon.jpg"};
        ListaRemeras = new List<string>{"1Remera.jpg", "1Remera.jpg", "1Remera.jpg"};
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
