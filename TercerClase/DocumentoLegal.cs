using System;

interface Imprimible{
    void Imprimir();   
}

interface Grabable{
    void Grabar();
}
abstract class DocumentoLegal : Imprimible, Grabable
{
    public int Monto {get; set;}

    protected int Numero;

    void Imprimible.Imprimir(){
        if(true/*Impresora apagada*/){
            throw new Exception();
        }else if(true /*Impresora apagada*/){
            throw new Exception();
        }else if(true/*Impresora apagada*/){
            throw new Exception();
        }


    }
    public int GetNumero(){
        return Numero;
    }

    protected void SetNumero(int numero){
        this.Numero = numero;
    }
    //public int Numero;
    private int codEnBaseDeDatos;
    protected int FechaDeAlta;

    //Asi :public DateTime Fecha{ get; set; }

    //O asi:
    public DateTime Fecha{
        get{
            return Fecha;
        }
        //portected set{
        // o private set{
            set{
            Fecha = value;
        }
    }

    public int Edad{
        get{
            //calcular edad 
            return 1;
        }
    }

    //abstract public void Imprimir();

    public void Imprimir(){

    }

    public void  Grabar(){

    }
    public void Enviar(){
        Console.WriteLine("DocumentoLegal.Enviar");
    }
/*
    virtual public void Imprimir(){
        Console.WriteLine("Soy un DL: "+ GetNumero());
    }

 */

    protected static void Hacer(){

    }

    public DocumentoLegal(int numero){
        this.Numero = numero;

    }
    private void GuardarEnBaseDeDatos(){
        Console.WriteLine("");
    }
    
}


class ListaDeDocumentoLegal{
    private DocumentoLegal[] lista;

    public ListaDeDocumentoLegal(DocumentoLegal[] miLista){
        this.lista = miLista;
    }

    public int Total(){
        int total = 0;
        for(var f = 0; f < lista.Length; f++)
        total += lista[f].Monto;
        return total;
    }


}
