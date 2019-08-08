 public class Nokia : Phone, IRingable 
{
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
        : base(versionNumber, batteryPercentage, carrier, ringTone) {}
    public string Ring() 
    {
        string ringTone = $"... {this._RingTone} ...";
        return ringTone;
    }
    public string Unlock() 
    {
        string unlock = $"Nokia {this._VersionNumber} unlocked with passcode";
        return unlock;
    }
    public override void DisplayInfo() 
    {
        System.Console.WriteLine("$$$$$$$$$$$$$$$$$");
        System.Console.WriteLine($"Galaxy {this._VersionNumber}");
        System.Console.WriteLine($"Battery Percentage: {this._BatteryPercentage}"); 
        System.Console.WriteLine($"Carrier: {this._Carrier}");
        System.Console.WriteLine($"Ring Tone: {this._RingTone}");
        System.Console.WriteLine("$$$$$$$$$$$$$$$$$");              
    }
}
       