public abstract class Phone 
{
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
    public abstract void DisplayInfo();
}
        