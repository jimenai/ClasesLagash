using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace TercerClase
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var fc = new Factura(1);
            var nc = new NotaDeCredito(1);
            var nc2 = new NotaDeCredito(2);

            //nc.Numero = 1;
            //nc2.Numero = 2;
            nc.GetNumero();
            nc2.GetNumero();

            bool si =  (fc is Factura);
            si = (fc is DocumentoLegal);


            nc.Imprimir();
            nc2.Imprimir();

            var ncc = NotaDeCredito.LeerDeBaseDeDatos();

           //HacerAlgoConDocumento(dl) es lo mismo que esto:
           object algo = (DocumentoLegal)fc;
         
           algo = nc;
           algo = "Diego";
           algo = 3;

            object facturas = new Factura[3];
            facturas[0] = new Factura[1];
            facturas[1] = new Factura[2];
            facturas[2] = new Factura[3];

            ListaDeFacturas listaF = new ListaDeFacturas(facturas);
            listaF.Total();

            var lista = new List<DocumentoLegal>();


            //forma generica para llamar a cualquier funcion: func

            Func<int, int> f = delegate(int i){
                return i + 1;
            };

            f(4);

            Func <DocumentoLegal, bool> siEsPar = delegate(DocumentoLegal dl){
                return(dl.Monto %2) == 0;
            };
            list.Where(siEsPar);

            List.Where(delegate(DocumentoLegal dl){
                return(dl.Monto %2) == 0;
            });
    
            List.Where((dl)=> (dl.Monto % 2) == 0);


            Dictionary<int, string> ds = new Dictionary<int, string>
            ds.Add(1, "Diego");
            ds.Add(2, "Jimena");

            string s = ds[1];

            DateTime fecha = new DateTime(2019, 5, 27);
            fecha.AddMonths(3);
            fecha.AddDays(1);

            List<string> nombres = new List<string>();
            nombres.Add("Jime");
            nombres.Add("Sere");

            for(int idx = 0; idx < nombres.Count; idx++){
                var nom = nombres[idx];

                Console.WriteLine(nom);
            }
            foreach(var nom in nombres){
                Console.WriteLine(nom);
            }

            foreach(var nom in nombres.Where( (nn) => nn[0] == D)){
                Console.WriteLine(nom);
            }

            string diego = "Diego";
            foreach(var ch in diego){
                Console.WriteLine(ch);
            }


/*
Programa que escruba en un archivo de texto un listado de personas y telefonos.

El programa tiene que poder leer el archivo y cargarlo en una coleccion 

Si modifico el archivo, tengo que poder leerlo nuevamente.

 */
            try{
                var nnc = NotaDeCredito.LeerDeBaseDeDatos();
                NotaDeCredito onc = null;
                HacerAlgoConDocumento(onc);

                onc.Imprimir(); 
            }
            catch(NoHayPapelException ){
                Console.WriteLine("Hay que comprar papel");
            }
        }
        static void HacerAlgoConDocumento(DocumentoLegal dl){
            dl.Enviar();
        }
        
    }
}
