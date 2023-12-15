using System;

public class detection{
    public int deviceId { get; set; }
    public int targetId { get; set; }
    public double accuracy { get; set; }
    public double latitude { get; set; }
    public double longitude { get; set; }
    public string detectedObject { get; set; }
    public Boolean verwerkt { get; set; }
    public DateTime timestamp { get; set; }
}