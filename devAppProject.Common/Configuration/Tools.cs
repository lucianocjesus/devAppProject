using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace devAppProject.Common.Configuration
{
    public class Tools
    {
        public static string LocalIpAddress()
        {
            var localIp = "";
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList.Where(ip => ip.AddressFamily == AddressFamily.InterNetwork))
            {
                localIp = ip.ToString();
                break;
            }
            return localIp;
        }

        public static string RemoveAccent(string param)
        {
            var toRemoveAcentos = param;
            const string strComAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç'";
            const string strSemAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc ";
            var i = 0;
            foreach (var c in strComAcentos)
            {
                toRemoveAcentos = toRemoveAcentos.Replace(c.ToString().Trim(), strSemAcentos[i].ToString().Trim());
                i++;
            }
            return toRemoveAcentos;
        }
    }
}
