using System;
using WsServiceProxy;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var authentication = new WSAuthentication();
            var documentoProtocollato = new DocumentoProtocollato();

            ProtocolloWebServiceClient wsProxy = new ProtocolloWebServiceClient();
            var serviceResponse = wsProxy.protocolla(authentication, documentoProtocollato);

            Console.WriteLine("Hello World!");
        }
    }
}
