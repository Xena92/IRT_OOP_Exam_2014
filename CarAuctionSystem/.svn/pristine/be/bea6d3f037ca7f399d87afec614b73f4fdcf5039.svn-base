using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WarehouseManagement
{
    /// <summary>
    /// Class that handles operations on verticies
    /// </summary>
    /// <typeparam name="T">Type for the identifier</typeparam>
    public struct Vertex
    {
        /// <summary>
        /// The unique identifier of the vertex
        /// </summary>
        public string ID;

        /// <summary>
        /// List of neighbor identifiers and their edgecost
        /// </summary>
        private readonly Dictionary<string, Edge> _connections;

        /// <summary>
        /// Constructer that makes sure an identifier has been assigned on instantiation
        /// </summary>
        internal Vertex(string id)
        {
            ID = id;
            _connections = new Dictionary<string, Edge>();
        }

        /// <summary>
        /// Adds a neighbor connections with a given cost
        /// </summary>
        /// <param name="key">A unique key to identify the neighboring vertex</param>
        /// <param name="weight">The weight or edgecost of the connection</param>
        internal void AddNeighbor(string key, int weight)
        {
            _connections.Add(key, new Edge(ID, key, weight));
        }

        internal Edge GetEdge(string key)
        {
            return _connections[key];
        }

        internal Edge[] GetAllEdges()
        {
            return _connections.Values.ToArray();
        }

        internal void AddNeighbor(string key, Edge edge)
        {
            if (!_connections.ContainsKey(key))
                _connections.Add(key, edge);
        }

        /// <summary>
        /// Removes a specific connection between this vertex and a neighbor
        /// </summary>
        /// <param name="key">The unique identifier of the neighbor</param>
        internal void RemoveNeighbor(string key)
        {
            _connections.Remove(key);
        }

        /// <summary>
        /// Returns an array of all neighbors to this vertex
        /// </summary>
        internal string[] GetConnections()
        {
            return _connections.Keys.ToArray();
        }

        /// <summary>
        /// Returns the edgecost of a specifik connection (edge)
        /// </summary>
        /// <param name="key">The connected vertex on the other end of the edge</param>
        internal int GetWeight(string key)
        {
            return _connections[key].Cost;
        }

        internal int GetDegree()
        {
            return _connections.Count;
        }
    }
}
