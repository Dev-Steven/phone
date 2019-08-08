public abstract class Phone 
{
    // private string _versionNumber;
    // private int _batteryPercentage;
    // private string _carrier;
    // private string _ringTone;

    public string _VersionNumber {get;set;}
    public int _BatteryPercentage {get;set;}
    public string _Carrier {get;set;}
    public string _RingTone {get;set;}

    public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone){
        _VersionNumber = versionNumber;
        _BatteryPercentage = batteryPercentage;
        _Carrier = carrier;
        _RingTone = ringTone;
}
    // abstract method. This method will be implemented by the subclasses
    public abstract void DisplayInfo();
    // public getters and setters removed for brevity. Please implement them yourself
 
}
        