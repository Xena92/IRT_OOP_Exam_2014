namespace WarehouseManagement
{
    public class Edge
    {
        public Edge(string vert1, string vert2, int cost, EdgeType type = EdgeType.Single)
        {
            Vert1 = vert1;
            Vert2 = vert2;
            Cost = cost;
            AllConnections = new[] {vert1, vert2};
            EdgeType = type;
        }

        public string Vert1 { get; private set; }
        public string Vert2 { get; private set; }
        public int Cost { get; private set; }
        public string[] AllConnections { get; private set; }
        public EdgeType EdgeType { get; set; }
    }

    public enum EdgeType
    {
        None,
        Single,
        Paralell,
        UsedParalell
    }
}
