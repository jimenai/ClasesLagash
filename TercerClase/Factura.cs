using System;

class Factura : DocumentoLegal
{
    public Factura(int numero) : base(numero){

    }
    
    /*public override void Imprimir(){

    }*/

    public void Pagar(){
        
    }
}
class FacturaExportacion : Factura{
    public FacturaExportacion(int numero) : base(numero){}
    public String Pais{ get; set;}
    /*public override void Imprimir(){
        Console.WriteLine("Soy la FC-E: "+ this.GetNumero());
    }*/


}

class ListaDeFacturas{
    private Factura[] lista;

    public ListaDeFacturas(Factura[] miLista){
        this.lista = miLista;
    }

    public int Total(){
        int total = 0;
        for(var f = 0; f < lista.Length; f++)
        total += lista[f].Monto;
        return total;
    }


}
