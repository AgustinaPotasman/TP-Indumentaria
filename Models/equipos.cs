static class Equipos
{
    public static List<string> ListaEquipos { get; private set; }= new List<string>{"1Equipo", "2Equipo", "3Equipo"};
    public static List<string> ListaMedias { get; private set; } = new List<string>{"1Medias.jpg", "2Medias.jpg", "3Medias.jpg"};
    public static List<string> ListaPantalones { get; private set; } = new List<string>{"1Pantalon.jpg", "2Pantalon.jpg", "3Pantalon.jpg"};
    public static List<string> ListaRemeras { get; private set; } = new List<string>{"1Remera.jpg", "1Remera.jpg", "1Remera.jpg"};
    public static Dictionary<string, Indumentaria>EquiposIndumentaria{ get; private set; }= new Dictionary<string, Indumentaria>();




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
