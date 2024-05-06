public class FeatureCollection {
    public List<Feature> Features { get; set; }
}

public class Feature {
    public Property Property { get; set; }
    public Geometry Geometry { get; set; }
}

public class Property {
    public string Place { get; set; }
    public double Mag { get; set; }
}

public class Geometry {
    public string Type { get; set; }
    public List<List<double>> Coordinates { get; set; }
}