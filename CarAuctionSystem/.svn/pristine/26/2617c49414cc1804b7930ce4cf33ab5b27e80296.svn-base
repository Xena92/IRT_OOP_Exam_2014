using System;
using System.Collections.Generic;
using System.Linq;

namespace WarehouseManagement
{
    public class ShortestPath
    {
        private const int UnitsPrAisle = 2;
        private readonly int _aisles;
        private readonly int _spaces;
        private readonly Graph _baseGraph;

        private Graph _instanceGraph;
        private int _vertIndex;
        private string _dockID = "v0";

        private void SetDockingLocation(int aisle, string id = "dock")
        {
            _dockID = id;
            InsertItem(aisle - 1, 0, id);
        }

        /// <summary>
        /// Inserts multiple items into the graph.
        /// </summary>
        /// <param name="items">The collection of items to be inserted.</param>
        public void InsertItems(IEnumerable<Item> items)
        {
            foreach (var item in items)
            {
                InsertItem(item.Adress, item.ToString());
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortestPath"/> class.
        /// </summary>
        /// <param name="aisles">The number of aisles in the warehouse.</param>
        /// <param name="spaces">The number of spaces in the warehouse.</param>
        /// <param name="shippingarea">The aisle number where the shipping area is placed.</param>
        public ShortestPath(int aisles, int spaces, int shippingarea)
        {
            _aisles = aisles;
            _spaces = spaces;
            _baseGraph = CreateBaseGraph(aisles, spaces);
            _instanceGraph = new Graph(_baseGraph);
            SetDockingLocation(shippingarea);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShortestPath"/> class.
        /// </summary>
        /// <param name="warehouse">The warehouse in where to find the shortest path.</param>
        public ShortestPath(Warehouse warehouse) : this(warehouse.Aisles, warehouse.Spaces, warehouse.ShipLocation)
        {
        }

        private Graph CreateBaseGraph(int aisles, int spaces)
        {
            var graph = new Graph();
            graph.AddEdge("a0", "b0", spaces);
            for (int i = 1; i < aisles; i++)
            {
                graph.AddEdge("a" + i, "b" + i, spaces);
                graph.AddEdge("a" + i, "a" + (i - 1), UnitsPrAisle);
            }
            return graph;
        }

        /// <summary>
        /// Inserts the item to the graph.
        /// </summary>
        /// <param name="adress">The adress of the item location.</param>
        public void InsertItem(Adress adress)
        {
            InsertItem(adress.Aisle - 1, (adress.Shelf + 1)/2, "v" + _vertIndex++);
        }

        /// <summary>
        /// Inserts the item to the graph.
        /// </summary>
        /// <param name="adress">The adress of the item location.</param>
        /// <param name="id">The identifier of the item.</param>
        public void InsertItem(Adress adress, string id)
        {
            InsertItem(adress.Aisle - 1, (adress.Shelf + 1)/2, id);
        }

        public void InsertItem(int aisle, int space)
        {
            InsertItem(aisle, space, "v" + _vertIndex++);
        }
        
        public void InsertItem(int aisle, int space, string id)
        {
            var vertFrom = "a" + aisle;
            var vertTo = "b" + aisle;
            string previous = "";

            var vert = _instanceGraph.GetVertex(vertFrom);
            var connections = vert.GetConnections();

            while (!connections.Contains(vertTo))
            {
                var connection = connections.FirstOrDefault(s => !_baseGraph.Contains(s) && s != previous);
                if (String.IsNullOrEmpty(connection))
                    throw new Exception("Connections must be invalid or something.");

                if (vert.GetWeight(connection) > space)
                {
                    vertTo = connection;
                }
                else
                {
                    previous = vertFrom;
                    vertFrom = connection;
                    space -= vert.GetWeight(connection);
                }
                vert = _instanceGraph.GetVertex(vertFrom);
                connections = vert.GetConnections();
            }

            _instanceGraph.InsertVertex(id, vertFrom, vertTo, space);
        }

        public int GetLength(int configuration, int aisle)
        {
            switch (configuration)
            {
                case 1:
                    return DistanceOnAisle("a" + aisle, "b" + aisle);                   
                case 2:
                    var a = _instanceGraph.GetVertex("a" + aisle);
                    var conA = a.GetConnections().FirstOrDefault(s => !s.Contains('a'));
                    var resultA = (_spaces - a.GetWeight(conA))*2;
                    return resultA == 0 ? 1000000 : resultA;
                case 3:
                    var b = _instanceGraph.GetVertex("b" + aisle);
                    var conB = b.GetConnections().FirstOrDefault(s => !s.Contains('b'));
                    var resultB = (_spaces - b.GetWeight(conB))*2;
                    return resultB == 0 ? 1000000 : resultB;
                case 4:
                    var gap = GreatestGap(aisle);
                    var result = (_spaces - _instanceGraph.GetVertex(gap[0]).GetWeight(gap[1])) * 2;
                    return result == 0 ? 1000000 : result;
                case 5:
                    return DistanceOnAisle("a" + aisle, "b" + aisle)*2;
                case 6:
                    return ContainsItems(aisle) ? 1000000 : 0;

                case 11: case 12: case 13:
                    return UnitsPrAisle*2;
                case 14:
                    return UnitsPrAisle*4;
                case 15:
                    return 0;

                default:
                    return 1000000;
            }
        }

        private PartialTourGraph GraphOnAisle(string from, string to, EdgeType type)
        {
            var result = new PartialTourGraph();
            string previous = "";

            while (from != to)
            {
                string next =
                    _instanceGraph.GetVertex(from)
                        .GetConnections()
                        .FirstOrDefault(s => s == to || (s != previous && !_baseGraph.Contains(s)));

                var distance = DistanceOnAisle(from, next);

                if (type == EdgeType.Paralell)
                    distance *= 2;

                result.AddEdge(from, next, distance, type);
                result.Length += distance;

                previous = from;
                from = next;
            }
            return result;
        }

        private PartialTourGraph BuildConfiguration(int configuration, int aisle)
        {
            var result = new PartialTourGraph();
            switch (configuration)
            {
                case 1:
                    result = GraphOnAisle("a" + aisle, "b" + aisle, EdgeType.Single);
                    break;
                case 2:
                    string to2 =
                        _instanceGraph.GetVertex("a" + aisle)
                            .GetConnections()
                            .FirstOrDefault(s => !s.Contains('a'));
                    result = GraphOnAisle("b" + aisle, to2, EdgeType.Paralell);
                    break;
                case 3:
                    string to3 =
                        _instanceGraph.GetVertex("b" + aisle)
                            .GetConnections()
                            .FirstOrDefault(s => !s.Contains('b'));
                    result = GraphOnAisle("a" + aisle, to3, EdgeType.Paralell);
                    break;
                case 4:
                    string[] gap = GreatestGap(aisle);
                    result = GraphOnAisle("a" + aisle, gap[0], EdgeType.Paralell);
                    result = PartialTourGraph.Merge(result, GraphOnAisle("b" + aisle, gap[1], EdgeType.Paralell));
                    break;
                case 5:
                    result = GraphOnAisle("a" + aisle, "b" + aisle, EdgeType.Paralell);
                    break;
                case 6:
                    result.Length = ContainsItems(aisle) ? 1000000 : 0;
                    break;

                case 11:
                    string afrom = "a" + aisle;
                    string ato = "a" + (aisle + 1);
                    string bfrom = "b" + aisle;
                    string bto = "b" + (aisle + 1);
                    result.AddEdge(afrom, ato, UnitsPrAisle);
                    result.AddEdge(bfrom, bto, UnitsPrAisle);
                    result.Length = 2*UnitsPrAisle;
                    break;
                case 12:
                    string from13 = "b" + aisle;
                    string to13 = "b" + (aisle + 1);
                    result.AddEdge(from13, to13, UnitsPrAisle, EdgeType.Paralell);
                    result.Length = 2*UnitsPrAisle;
                    break;
                case 13:
                    string from12 = "a" + aisle;
                    string to12 = "a" + (aisle + 1);
                    result.AddEdge(from12, to12, UnitsPrAisle, EdgeType.Paralell);
                    result.Length = 2*UnitsPrAisle;
                    break;
                case 14:
                    string from14a = "a" + aisle;
                    string to14a = "a" + (aisle + 1);
                    string from14b = "b" + aisle;
                    string to14b = "b" + (aisle + 1);
                    result.AddEdge(from14a, to14a, UnitsPrAisle, EdgeType.Paralell);
                    result.AddEdge(from14b, to14b, UnitsPrAisle, EdgeType.Paralell);
                    result.Length = 4*UnitsPrAisle;
                    break;
                case 15:
                    break;
            }
            return result;
        }

        private PartialTourGraph[] CalculateConfigurations(int aisle)
        {
            var result = new PartialTourGraph[16];
            for (int i = 1; i < 16; i++)
            {
                result[i] = BuildConfiguration(i, aisle);
            }
            return result;
        }

        private PartialTourGraph[] CalculateLPositive(PartialTourGraph[] previous, int aisle)
        {
            var configurations = CalculateConfigurations(aisle);
            var result = new PartialTourGraph[7];

            if (previous[0] != null)
            {
                if (result[3] == null || result[3].Length > previous[0].Length + configurations[1].Length)
                    result[3] = PartialTourGraph.Merge(previous[0], configurations[1]);
                if (result[0] == null || result[0].Length > previous[0].Length + configurations[2].Length)
                    result[0] = PartialTourGraph.Merge(previous[0], configurations[2]);
                if (result[0].Length > previous[0].Length + configurations[3].Length)
                    result[0] = PartialTourGraph.Merge(previous[0], configurations[3]);
                if (result[0].Length > previous[0].Length + configurations[4].Length)
                    result[0] = PartialTourGraph.Merge(previous[0], configurations[4]);
                if (result[0].Length > previous[0].Length + configurations[5].Length)
                    result[0] = PartialTourGraph.Merge(previous[0], configurations[5]);
                if (result[0].Length > previous[0].Length + configurations[6].Length)
                    result[0] = PartialTourGraph.Merge(previous[0], configurations[6]);
            }
            if (previous[1] != null)
            {
                if (result[0] == null || result[0].Length > previous[1].Length + configurations[1].Length)
                    result[0] = PartialTourGraph.Merge(previous[1], configurations[1]);
                if (result[1] == null || result[1].Length > previous[1].Length + configurations[2].Length)
                    result[1] = PartialTourGraph.Merge(previous[1], configurations[2]);
                if (result[4] == null || result[4].Length > previous[1].Length + configurations[3].Length)
                    result[4] = PartialTourGraph.Merge(previous[1], configurations[3]);
                if (result[4].Length > previous[1].Length + configurations[4].Length)
                    result[4] = PartialTourGraph.Merge(previous[1], configurations[4]);
                if (result[3] == null || result[3].Length > previous[1].Length + configurations[5].Length)
                    result[3] = PartialTourGraph.Merge(previous[1], configurations[5]);
                if (result[1].Length > previous[1].Length + configurations[6].Length)
                    result[1] = PartialTourGraph.Merge(previous[1], configurations[6]);
            }
            if (previous[2] != null)
            {
                if (result[0] == null || result[0].Length > previous[2].Length + configurations[1].Length)
                    result[0] = PartialTourGraph.Merge(previous[2], configurations[1]);
                if (result[4] == null || result[4].Length > previous[2].Length + configurations[2].Length)
                    result[4] = PartialTourGraph.Merge(previous[2], configurations[2]);
                if (result[2] == null || result[2].Length > previous[2].Length + configurations[3].Length)
                    result[2] = PartialTourGraph.Merge(previous[2], configurations[3]);
                if (result[4].Length > previous[2].Length + configurations[4].Length)
                    result[4] = PartialTourGraph.Merge(previous[2], configurations[4]);
                if (result[3] == null || result[3].Length > previous[2].Length + configurations[5].Length)
                    result[3] = PartialTourGraph.Merge(previous[2], configurations[5]);
                if (result[2].Length > previous[2].Length + configurations[6].Length)
                    result[2] = PartialTourGraph.Merge(previous[2], configurations[6]);
            }
            if (previous[3] != null)
            {
                if (result[0] == null || result[0].Length > previous[3].Length + configurations[1].Length)
                    result[0] = PartialTourGraph.Merge(previous[3], configurations[1]);
                if (result[3] == null || result[3].Length > previous[3].Length + configurations[2].Length)
                    result[3] = PartialTourGraph.Merge(previous[3], configurations[2]);
                if (result[3].Length > previous[3].Length + configurations[3].Length)
                    result[3] = PartialTourGraph.Merge(previous[3], configurations[3]);
                if (result[3].Length > previous[3].Length + configurations[4].Length)
                    result[3] = PartialTourGraph.Merge(previous[3], configurations[4]);
                if (result[3].Length > previous[3].Length + configurations[5].Length)
                    result[3] = PartialTourGraph.Merge(previous[3], configurations[5]);
                if (result[3].Length > previous[3].Length + configurations[6].Length)
                    result[3] = PartialTourGraph.Merge(previous[3], configurations[6]);
            }
            if (previous[4] != null)
            {
                if (result[0] == null || result[0].Length > previous[4].Length + configurations[1].Length)
                    result[0] = PartialTourGraph.Merge(previous[4], configurations[1]);
                if (result[4] == null || result[4].Length > previous[4].Length + configurations[2].Length)
                    result[4] = PartialTourGraph.Merge(previous[4], configurations[2]);
                if (result[4].Length > previous[4].Length + configurations[3].Length)
                    result[4] = PartialTourGraph.Merge(previous[4], configurations[3]);
                if (result[4].Length > previous[4].Length + configurations[4].Length)
                    result[4] = PartialTourGraph.Merge(previous[4], configurations[4]);
                if (result[3] == null || result[3].Length > previous[4].Length + configurations[5].Length)
                    result[3] = PartialTourGraph.Merge(previous[4], configurations[5]);
                if (result[4].Length > previous[4].Length + configurations[6].Length)
                    result[4] = PartialTourGraph.Merge(previous[4], configurations[6]);
            }
            if (previous[5] != null)
            {
                if (result[0] == null || result[0].Length > previous[5].Length + configurations[1].Length)
                    result[0] = PartialTourGraph.Merge(previous[5], configurations[1]);
                if (result[1] == null || result[1].Length > previous[5].Length + configurations[2].Length)
                    result[1] = PartialTourGraph.Merge(previous[5], configurations[2]);
                if (result[2] == null || result[2].Length > previous[5].Length + configurations[3].Length)
                    result[2] = PartialTourGraph.Merge(previous[5], configurations[3]);
                if (result[4] == null || result[4].Length > previous[5].Length + configurations[4].Length)
                    result[4] = PartialTourGraph.Merge(previous[5], configurations[4]);
                if (result[3] == null || result[3].Length > previous[5].Length + configurations[5].Length)
                    result[3] = PartialTourGraph.Merge(previous[5], configurations[5]);
                if (result[5] == null || result[5].Length > previous[5].Length + configurations[6].Length)
                    result[5] = PartialTourGraph.Merge(previous[5], configurations[6]);
            }
            if (previous[6] != null)
            {
                if (result[6] == null || result[4].Length > previous[6].Length + configurations[6].Length)
                    result[6] = PartialTourGraph.Merge(previous[6], configurations[6]);
            }

            return result;
        }

        private PartialTourGraph[] CalculateLNegative(PartialTourGraph[] previous, int aisle)
        {
            var configurations = CalculateConfigurations(aisle);
            var result = new PartialTourGraph[7];

            if (previous[0] != null)
            {
                if (result[0] == null || result[0].Length > previous[0].Length + configurations[11].Length)
                    result[0] = PartialTourGraph.Merge(previous[0], configurations[11]);
            }
            if (previous[1] != null)
            {
                if (result[1] == null || result[1].Length > previous[1].Length + configurations[12].Length)
                    result[1] = PartialTourGraph.Merge(previous[1], configurations[12]);
                if (result[4] == null || result[4].Length > previous[1].Length + configurations[14].Length)
                    result[4] = PartialTourGraph.Merge(previous[1], configurations[14]);
                if (result[6] == null || result[6].Length > previous[1].Length + configurations[15].Length)
                    result[6] = PartialTourGraph.Merge(previous[1], configurations[15]);
            }
            if (previous[2] != null)
            {
                if (result[2] == null || result[2].Length > previous[2].Length + configurations[13].Length)
                    result[2] = PartialTourGraph.Merge(previous[2], configurations[13]);
                if (result[4] == null || result[4].Length > previous[2].Length + configurations[14].Length)
                    result[4] = PartialTourGraph.Merge(previous[2], configurations[14]);
                if (result[6] == null || result[6].Length > previous[2].Length + configurations[15].Length)
                    result[6] = PartialTourGraph.Merge(previous[2], configurations[15]);
            }
            if (previous[3] != null)
            {
                if (result[1] == null || result[1].Length > previous[3].Length + configurations[12].Length)
                    result[1] = PartialTourGraph.Merge(previous[3], configurations[12]);
                if (result[2] == null || result[2].Length > previous[3].Length + configurations[13].Length)
                    result[2] = PartialTourGraph.Merge(previous[3], configurations[13]);
                if (result[3] == null || result[3].Length > previous[3].Length + configurations[14].Length)
                    result[3] = PartialTourGraph.Merge(previous[3], configurations[14]);
                if (result[6] == null || result[6].Length > previous[3].Length + configurations[15].Length)
                    result[6] = PartialTourGraph.Merge(previous[3], configurations[15]);
            }
            if (previous[4] != null)
            {
                if (result[4] == null || result[4].Length > previous[4].Length + configurations[14].Length)
                    result[4] = PartialTourGraph.Merge(previous[4], configurations[14]);
            }
            if (previous[5] != null)
            {
                if (result[5] == null || result[5].Length > previous[5].Length + configurations[15].Length)
                    result[5] = PartialTourGraph.Merge(previous[5], configurations[15]);
            }
            if (previous[6] != null)
            {
                if (result[6] == null || result[6].Length > previous[6].Length + configurations[15].Length)
                    result[6] = PartialTourGraph.Merge(previous[6], configurations[15]);
            }

            return result;
        }

        private PartialTourGraph SelectTour(PartialTourGraph[] ptg)
        {
            PartialTourGraph tour = null;
            if (ptg[1] != null)
                tour = ptg[1];
            if (ptg[2] != null && (tour == null || tour.Length > ptg[2].Length))
                tour = ptg[2];
            if (ptg[3] != null && (tour == null || tour.Length > ptg[3].Length))
                tour = ptg[3];
            if (ptg[5] != null && (tour == null || tour.Length > ptg[5].Length))
                tour = ptg[5];
            if (ptg[6] != null && (tour == null || tour.Length > ptg[6].Length))
                tour = ptg[6];

            return tour;
        }

        /// <summary>
        /// Finds the shortest path in the given warehouse configuration
        /// </summary>
        /// <returns>Returns an array of item IDs, sorted by the order they should be picked</returns>
        public string[] GetResult()
        {
            var ptg = new PartialTourGraph[7];

            //Instantiates an empty graph on the equvalience class (0, 0, 0C)
            ptg[5] = new PartialTourGraph();

            for (int i = 0; i < _aisles; i++)
            {
                ptg = CalculateLPositive(ptg, i);

                if (i == _aisles - 1) break;
                ptg = CalculateLNegative(ptg, i);

            }
            PartialTourGraph tour = SelectTour(ptg);
            return Route(tour);
        }

        /// <summary>
        /// Clears items from list, to make the next calculation possible
        /// </summary>
        public void Clear()
        {
            _instanceGraph = new Graph(_baseGraph);
            _vertIndex = 0;
        }

        public int DistanceOnAisle(string vert1, string vert2, string mask = "")
        {
            if(!_instanceGraph.Contains(vert1) || !_instanceGraph.Contains(vert2))
                throw new ArgumentException("Vertex was not found within the graph");

            var checkedList = new List<string>();
            string vert = vert1;
            string previous = mask;
            int distance = 0;

            while (true)
            {
                var connections =
                    _instanceGraph.GetVertex(vert)
                        .GetConnections()
                        .Where(s => s != previous && !checkedList.Contains(s))
                        .ToArray();

                if (connections.Contains(vert2))
                {
                    distance += _instanceGraph.GetVertex(vert).GetWeight(vert2);
                    break;
                }

                var nextVert = connections.FirstOrDefault(s => !_baseGraph.Contains(s));

                if (String.IsNullOrEmpty(nextVert))
                {
                    distance = 0;
                    nextVert = vert1;
                }
                else
                {
                    distance += _instanceGraph.GetVertex(vert).GetWeight(nextVert);
                }

                checkedList.Add(vert);
                previous = vert;
                vert = nextVert;
            }
            return distance;
        }

        /// <summary>
        /// Checks weather or not the aisle contains any verticies of interest
        /// </summary>
        private bool ContainsItems(int aisle)
        {
            return !_instanceGraph.GetVertex("a" + aisle).GetConnections().Contains("b" + aisle);
        }

        public string[] GreatestGap(int aisle)
        {
            var gap = new string[2];
            int gapSize = -1;
            string previous = "a" + aisle;
            string vert =
                _instanceGraph.GetVertex(previous).GetConnections().FirstOrDefault(s => !s.Contains('a'));
            while (!String.IsNullOrEmpty(vert))
            {
                int iGap = DistanceOnAisle(previous, vert);
                if (iGap > gapSize)
                {
                    gapSize = iGap;
                    gap[0] = previous;
                    gap[1] = vert;
                }

                var nextVert =
                    _instanceGraph.GetVertex(vert)
                        .GetConnections()
                        .FirstOrDefault(s => !_baseGraph.Contains(s) && s != previous);
                previous = vert;
                vert = nextVert;
            }
            return gap;
        }

        /// <summary>
        /// Finds a route throught the tour that goes through each item in turn
        /// </summary>
        /// <param name="tour">The tour graph in with to find the route</param>
        /// <returns>Returns a sorted array of integers, these integers are item IDs which needs to be picked in this order to go through the tour</returns>
        private string[] Route(Graph tour)
        {
            var v = tour.GetVertex(_dockID); //starting point
            var result = new List<string>();

            while (true)
            {
                var edge = v.GetAllEdges().FirstOrDefault(e => e.EdgeType == EdgeType.Paralell);
                if (edge != null)
                {
                    var other = edge.AllConnections.First(c => c != v.ID);
                    result.Add(other);
                    edge.EdgeType = EdgeType.UsedParalell;
                    v = tour.GetVertex(other);
                    continue;
                }
                edge = v.GetAllEdges().FirstOrDefault(e => e.EdgeType == EdgeType.Single);
                if (edge != null)
                {
                    var other = edge.AllConnections.First(c => c != v.ID);
                    result.Add(other);
                    edge.EdgeType = EdgeType.None;
                    v = tour.GetVertex(other);
                    continue;
                }
                edge = v.GetAllEdges().FirstOrDefault(e => e.EdgeType == EdgeType.UsedParalell);
                if (edge != null)
                {
                    var other = edge.AllConnections.First(c => c != v.ID);
                    result.Add(other);
                    edge.EdgeType = EdgeType.None;
                    v = tour.GetVertex(other);
                    continue;
                }
                break;
            }

            return result.Where(s => !_baseGraph.Contains(s) && s != _dockID).ToArray();
        }

        private class PartialTourGraph : Graph
        {
            public PartialTourGraph()
            {
            }

            private PartialTourGraph(Graph source) : base(source)
            {
            }

            public static PartialTourGraph Merge(PartialTourGraph source, PartialTourGraph other)
            {
                var result = new PartialTourGraph(Graph.Merge(source, other)) {Length = source.Length + other.Length};
                return result;
            }

            public int Length { get; set; }

            public override string ToString()
            {
                return string.Format("{0}", Length);
            }
        }
    }
}