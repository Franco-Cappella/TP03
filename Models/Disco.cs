namespace TP03.Models;

public class Disco{
    public string artista {get; private set;}
    public string productor {get; private set;}
    public string genero {get; private set;}
    public List  <string> listTemas {get;private set;} = new List<string>();
    public int ID {get; private set;}
    public string foto {get; private set;}

    public Disco (string pArtista, string pProductor, string pGenero, int pID, string pFoto, List<string> pListTemas){
        artista = pArtista;
        productor = pProductor;
        genero = pGenero;
        ID = pID;
        foto = pFoto;
        listTemas = pListTemas; 
    }
  
}
