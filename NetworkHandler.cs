using SimpleTcp;
using System;
using System.Text;
using System.Threading;

namespace alyx_multiplayer
{
    class NetworkHandler
    {
        // TODO: should the variables be static?
        private string serverIP = "0.0.0.0"; // TODO: allow modifying of this?
        private string serverPort = "6655";
        private string clientIP = "127.0.0.1";
        private string clientPort = "6655";

        private bool isServer;
        private object networkInstance; // Holds either NetworkServer or NetworkClient

        public NetworkHandler()
        {
            isServer = false; // Default to client mode
            InitializeNetwork();
        }

        private void InitializeNetwork()
        {
            Dispose(); // Dispose if something exists
            if (isServer)
            {
                networkInstance = new NetworkServer(serverIP + ":" + serverPort);
            }
            else
            {
                networkInstance = new NetworkClient(clientIP + ":" + clientPort);
            }

        }

        /// <summary>
        /// Restart the network with a new server IP.
        /// </summary>
        /// <param name="newServerPort">The server IP to implement.</param>
        public void ReconfigureServerIP(string newServerIP)
        {
            serverIP = newServerIP;
            InitializeNetwork();
        }

        /// <summary>
        /// Restart the network with a new server port.
        /// </summary>
        /// <param name="newServerPort">The server port to implement.</param>
        public void ReconfigureServerPort(string newServerPort)
        {
            serverPort = newServerPort;
            InitializeNetwork();
        }

        /// <summary>
        /// Restart the network with a new client IP.
        /// </summary>
        /// <param name="newClientIP">The client IP to implement.</param>
        public void ReconfigureClientIP(string newClientIP)
        {

            clientIP = newClientIP;
            InitializeNetwork();

        }

        /// <summary>
        /// Restart the network with a new client port.
        /// </summary>
        /// <param name="newClientPort">The client port to implement.</param>
        public void ReconfigureClientPort(string newClientPort)
        {
            clientPort = newClientPort;
            InitializeNetwork();
        }

        /// <summary>
        /// Changes from client to server (or vice-versa), re-initializes
        /// </summary>
        /// <param name="newIsServer">The new server state</param>
        public void ReconfigureIsServer(bool newIsServer)
        {
            isServer = newIsServer;
            InitializeNetwork();
        }

        public void Dispose()
        {
            if (networkInstance is NetworkServer server)
            {
                server.Dispose();
            }
            else if (networkInstance is NetworkClient client)
            {
                client.Dispose();
            }
        }

        /// <summary>
        /// Pass coordinates to the client's or server's Send() implementation.
        /// </summary>
        /// <param name="coords">The coordinates to send.</param>
        public void SendCoords(string coords)
        {
            if (networkInstance is NetworkServer server)
            {
                server.Send(coords);
            }
            else if (networkInstance is NetworkClient client)
            {
                client.Send(coords);
            }

        }

        /// <summary>
        /// Get coordinates from the server's or client's RetrieveCoords() implementation.
        /// </summary>
        /// <returns>The coordinates cached in the server.</returns>
        public string GetCoords()
        {
            if (networkInstance is NetworkServer server)
            {
                return server.RetrieveCoords();
            }
            else if (networkInstance is NetworkClient client)
            {
                return client.RetrieveCoords();
            }
            else
            {
                return null; // or throw an exception

            }
        }
    }
}