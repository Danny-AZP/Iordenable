using system
public class Colores:IOrdenable<Colores>
{
    paleta=newPaleta();

    public int comparar (color c1, color c2)
    {
        color=["azul", "amarillo", "rojo", "negro", "blanco", "Rosado", "Gris", "Verde"]
        var varchar nombre = 0;
        if(c1.nombre<c2.nombre)
        {
            return -1;
        }
        if(c1.nombre==c2.nombre)
        {
            return 0;
        }
        return 1:
    }
}