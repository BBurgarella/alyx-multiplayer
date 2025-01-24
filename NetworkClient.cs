using SimpleTcp;
using System;
using System.Text;

namespace alyx_multiplayer
{
    class NetworkClient
    {
        /// <summary>
        /// Constructor which attempts to start the client.
        /// </summary>
        private string ipPort;
        private static string coords;
        private bool shouldShowPeerError = true;
        public SimpleTcpClient client;
        public NetworkClient(string ipPort)
        {
            // Attempt to connect to the server
            try
            {
                // Instantiate client
                this.ipPort = ipPort;
                client = new SimpleTcpClient(this.ipPort);

                // Set client events
                client.Events.Connected += Connected;
                client.Events.Disconnected += Disconnected;
                client.Events.DataReceived += DataReceived;

                // Actually attempt a connection
                client.Connect();
            }
            catch
            {
                // For now, don't show a server failure message (since Core.Log may not be instantiated)
            }
        }

        /// <summary>
        /// Kill the client. Brutal!
        /// </summary>
        public void Dispose()
        {
            client.Dispose();
        }

        /// <summary>
        /// Send coordinates to the NetworkServer.
        /// </summary>
        /// <param name="coords">The coordinates to send.</param>
        public void Send(string coords)
        {
            try
            {
                client.Send(coords);
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
        /// Event for when coordinate data is received from NetworkServer
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
        /// Client event for when we connect to the server.
        /// </summary>
        /// <param name="sender">The server we connected to.</param>
        /// <param name="e">Event arguments.</param>
        static void Connected(object sender, ClientConnectedEventArgs e)
        {
            Core.Log("*** Connected to the NetworkServer [" + e.IpPort + "] ", false);
        }

        /// <summary>
        /// Client event for when we disconnect from the server.
        /// </summary>
        /// <param name="sender">The server we disconnected from.</param>
        /// <param name="e">Event arguments.</param>
        static void Disconnected(object sender, ClientDisconnectedEventArgs e)
        {
            Core.Log("*** Disconnected from the NetworkServer [" + e.IpPort + "] for the reason: " + e.Reason.ToString(), false);
        }
    }
}
