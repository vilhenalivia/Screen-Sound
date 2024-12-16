namespace ScreenSound.Modelos;

//Internal - Visibilidade de classes -- Somente esse projeto podera utilizar
internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        if (nota < 0) nota = 0;
        if (nota > 10) nota = 10;

        Nota = nota;
    }

    public int Nota { get; }

    // Método estatico = não precisa instaciar(new) pode ser só chamado 
    public static Avaliacao Parse(string texto)
    {
        
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }


}
