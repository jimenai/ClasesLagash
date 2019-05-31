using System;

namespace Quinta_Clase
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

           //HacerAlgoConDocumento(dl);
            
            }

        static void HacerAlgoConDocumento(DocumentoLegal dl){
            dl.Enviar();
        }
        }
    }
}
