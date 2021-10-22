namespace AtelierMVVM.Model
{
    //public class Caracteristique
    //{
    //    public string type { get; set; }
    //    public Geometry geometry { get; set; }
    //    public PropertiesAdresse propertiesAdresse { get; set; }
    //}

    //public class Geometry
    //{
    //    public string type { get; set; }
    //    public float[] coordinates { get; set; }
    //}

    public class PropertiesAdresse
        {
            public string label { get; set; }
            public float score { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string postcode { get; set; }
            public string citycode { get; set; }
            public float x { get; set; }
            public float y { get; set; }
            public string city { get; set; }
            public string context { get; set; }
            public string type { get; set; }
            public float importance { get; set; }
            public string oldcitycode { get; set; }
            public string oldcity { get; set; }
        }

    
}
