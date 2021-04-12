using MernisServiceReference;
using Oyun.Abstract;
using Oyun.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Oyun.Adapter
{
    public class MernisServiceAdapter : IKimlikDogrulamaService
    {
        public bool KimlikDogrula(Gamer gamer)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            //Task response = client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId),
            //                                                                            gamer.FirstName.ToUpper(),
            //                                                                            gamer.LastName.ToUpper(),
            //                                                                            gamer.DateOfBirth.Year);
            //response.Wait();
            //return response.Result.Body.TCKimlikNoDogrulaResult;

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap12);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult; 


        }
    }
}
