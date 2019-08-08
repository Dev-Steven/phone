public interface IRingable 
{
    string _VersionNumber {get;set;}
    int _BatteryPercentage {get;set;}
    string _Carrier {get;set;}
    string _RingTone {get;set;}
    string Ring();
    string Unlock();
}
        