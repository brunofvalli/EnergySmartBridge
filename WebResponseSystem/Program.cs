using System.Net;
using System.Net.Sockets;

public class Program
{
    static void Main(string[] args)
    {
        int port = 443;
        TcpListener server = null;
        try
        {
            IPAddress localAddr = IPAddress.Parse("192.168.2.97");
            server = new TcpListener(localAddr, port);
            server.Start();

            Byte[] bytes = new Byte[256];
            String data = null;

            while (true)
            {
                Console.Write("Waiting for a connection... ");
                TcpClient client = server.AcceptTcpClient();
                Console.WriteLine("Connected!");

                data = null;
                NetworkStream stream = client.GetStream();

                int i;
                while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                    Console.WriteLine("Received: {0}", data);
                }

                client.Close();
            }
        }
        catch (SocketException e)
        {
            Console.WriteLine("SocketException: {0}", e);
        }
        finally
        {
            server.Stop();
        }

        Console.WriteLine("\nHit enter to continue...");
        Console.Read();
    }
}
