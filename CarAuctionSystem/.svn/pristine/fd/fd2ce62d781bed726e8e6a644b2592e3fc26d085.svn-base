using System.Collections.Generic;
using System.Linq;

namespace WarehouseManagement
{
    /// <summary>
    ///     Graph structure that implements useful functions
    /// </summary>
    public class Graph
    {
        /// <summary>
        ///     List of verticies contained within the graph
        /// </summary>
        protected Dictionary<string, Vertex> VerticeList;

        /// <summary>
        ///     Empty constructor for generating an empty graph
        /// </summary>
        public Graph()
        {
            VerticeList = new Dictionary<string, Vertex>();
        }

        /// <summary>
        ///     Constructer wich adds a previous selection of verticies and edges
        /// </summary>
        /// <param name="verticies"></param>
        public Graph(Graph source)
        {
            VerticeList = new Dictionary<string, Vertex>(source.VerticeList);
        }

        private bool HasEdge(string vert1, string vert2)
        {
            Vertex vert;
            return VerticeList.TryGetValue(vert1, out vert) && VerticeList[vert1].GetConnections().Contains(vert2);
        }

        public static Graph Merge(Graph source, Graph other)
        {
            var result = new Graph();
            foreach (string key in source.VerticeList.Keys)
            {
                foreach (string connection in source.VerticeList[key].GetConnections().Where(connection => !result.HasEdge(key, connection)))
                {
                    result.AddEdge(source.VerticeList[key].GetEdge(connection));
                }
            }

            foreach (string key in other.VerticeList.Keys)
            {
                foreach (string connection in other.VerticeList[key].GetConnections().Where(connection => !result.HasEdge(key, connection)))
                {
                    result.AddEdge(other.VerticeList[key].GetEdge(connection));
                }
            }
            return result;
        }

        /// <summary>
        ///     Adds an edge between two verticies and adds the verticies to the graph if they aren't allready in it
        /// </summary>
        /// <param name="vert1">Identifier of the first vertex</param>
        /// <param name="vert2">Identifier of the second vertex</param>
        public void AddEdge(string vert1, string vert2, int cost, EdgeType type = EdgeType.Single)
        {
            var edge = new Edge(vert1, vert2, cost, type);
            AddEdge(edge);
        }

        public void AddEdge(Edge edge)
        {
            if (!Contains(edge.Vert1))
                AddVertex(edge.Vert1);
            if (!Contains(edge.Vert2))
                AddVertex(edge.Vert2);
            VerticeList[edge.Vert1].AddNeighbor(edge.Vert2, edge);
            VerticeList[edge.Vert2].AddNeighbor(edge.Vert1, edge);
        }

        /// <summary>
        ///     Removed an edge between two verticies
        /// </summary>
        /// <param name="vert1">Identifier of the first vertex</param>
        /// <param name="vert2">Identifier of the second vertex</param>
        public virtual void RemoveEdge(string vert1, string vert2)
        {
            VerticeList[vert1].RemoveNeighbor(vert2);
            VerticeList[vert2].RemoveNeighbor(vert1);
        }

        /// <summary>
        ///     Adds a vertex to the graph
        /// </summary>
        /// <param name="vert">The identifier of the vertex to be added</param>
        private void AddVertex(string vert)
        {
            VerticeList.Add(vert, new Vertex(vert));
        }

        /// <summary>
        ///     Finds and returns a vertex from the graph with the given identifer
        /// </summary>
        /// <param name="vert">Identifier of the vertex</param>
        /// <returns>The vertex with the identifier</returns>
        public Vertex GetVertex(string vert)
        {
            return VerticeList[vert];
        }

        /// <summary>
        ///     Removes a specific vertex from the graph
        /// </summary>
        /// <param name="vert">Identifier of the vertex to be removed</param>
        private void RemoveVertex(string vert)
        {
            string[] connections = VerticeList[vert].GetConnections();
            foreach (string connection in connections)
            {
                RemoveEdge(vert, connection);
            }
            VerticeList.Remove(vert);
        }

        /// <summary>
        ///     Checks weather or not a vertex is contained within the graph
        /// </summary>
        /// <param name="vert">Identifier of the vertex that are checked for</param>
        /// <returns>returns true if a vertex with that identifier exist within the graph</returns>
        public bool Contains(string vert)
        {
            return VerticeList.ContainsKey(vert);
        }

        /// <summary>
        ///     A function that allows access to all verticies within the graph
        /// </summary>
        /// <returns>returns all vertex identifiers within the graph</returns>
        public string[] GetVertices()
        {
            return VerticeList.Keys.ToArray();
        }

        public void InsertVertex(string vert, string vertFrom, string vertTo, int distance)
        {
            int dist = VerticeList[vertFrom].GetWeight(vertTo);

            RemoveEdge(vertFrom, vertTo);
            AddEdge(vert, vertFrom, distance);
            AddEdge(vert, vertTo, dist - distance);
        }
    }
}