using SimpleTcp;
using System;
using System.Collections.Generic;
using System.Text;

namespace alyx_multiplayer
{
    class NetworkServer
    {
        private string ipPort;
        private static string coords;
        public SimpleTcpServer server;
        private bool shouldShowPeerError = true;
        private static List<string> connectedClients = new List<string>(); // Added list for connected clients


        /// <summary>
        /// Constructor which attempts to start the server.
        /// </summary>
        /// <param name="ipPort">The server and port for the server, passed as a string with specific formatting.</param>
        public NetworkServer(string ipPort)
        {
            // Attempt to start the server
            try
            {
                // Instantiate server
                this.ipPort = ipPort;
                server = new SimpleTcpServer(this.ipPort);
                connectedClients = new List<string>();

                // Set server events
                server.Events.ClientConnected += ClientConnected;
                server.Events.ClientDisconnected += ClientDisconnected;
                server.Events.DataReceived += DataReceived;

                // Actually start the server
                server.Start();
            }
            catch
            {
                // For now, don't show a server failure message (since Core.Log may not be instantiated)
            }

        }

        /// <summary>
        /// Kill the server. No mercy!
        /// </summary>
        public void Dispose()
        {
            server.Dispose();
        }

        /// <summary>
        /// Send coordinates to all connected NetworkClients.
        /// </summary>
        /// <param name="coords">The coordinates to send.</param>
        public void Send(string coords)
        {
            try
            {
                foreach (string clientIpPort in connectedClients)
                {
                    server.Send(clientIpPort, coords);
                }
                shouldShowPeerError = true;
            }
            catch
            {
                if (shouldShowPeerError)
                {
                    shouldShowPeerError = false;
                    Core.Log("Failed to send coords to peer! Are the IP and port set correctly?", false);
                }
            }
        }

        /// <summary>
        /// Server event for when coordinate data is received from NetworkClient
        /// </summary>
        /// <param name="sender">Whoever sent us coordinates.</param>
        /// <param name="e">Event arguments.</param>
        static void DataReceived(object sender, DataReceivedEventArgs e)
        {
            coords = Encoding.UTF8.GetString(e.Data);
        }

        /// <summary>
        /// Return the cached coordinates received earlier.
        /// </summary>
        /// <returns>Those pesky coordinates.</returns>
        public string RetrieveCoords()
        {
            return coords;
        }

        /// <summary>
        /// Server event for when the client connects.
        /// </summary>
        /// <param name="sender">Whoever just connected.</param>
        /// <param name="e">Event arguments.</param>
        static void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            Core.Log("[" + e.IpPort + "] NetworkClient is now connected", false);
            connectedClients.Add(e.IpPort); // Add client to the list
        }

        /// <summary>
        /// Server event for when the client disconnects.
        /// </summary>
        /// <param name="sender">Whoever just disconnected.</param>
        /// <param name="e">Event arguments.</param>
        static void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            Core.Log("[" + e.IpPort + "] NetworkClient is now disconnected for the reason: " + e.Reason.ToString(), false);
            connectedClients.Remove(e.IpPort); // Remove client from the list
        }
    }
}
