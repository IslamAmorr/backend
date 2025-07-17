using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Glequipment
{
    public string SerialNumber { get; set; } = null!;

    public string? CallSimNumber { get; set; }

    public short DataPeriod { get; set; }

    public string EquipmentSimNumber { get; set; } = null!;

    public short HiddenAntennaDetectionDelay { get; set; }

    public long Identifier { get; set; }

    public short MotionDetectionDelay { get; set; }

    public short MotionDetectionThreshold { get; set; }

    public long NewIdentifier { get; set; }

    public short OverSpeedDetectionDelay { get; set; }

    public short OverSpeedDetectionThreshold { get; set; }

    public short OverSpeedPeriod { get; set; }

    public string? ServerSimNumber { get; set; }

    public string? SmscenterNumber { get; set; }

    public short Smsperiod { get; set; }

    public string? Sosnumber1 { get; set; }

    public string? Sosnumber2 { get; set; }

    public string? Sosnumber3 { get; set; }

    public short StopDetectionDelay { get; set; }

    public short StopDetectionThreshold { get; set; }

    public bool SupportData { get; set; }

    public bool SupportGpssynchroAlert { get; set; }

    public bool SupportHiddenAntennaAlert { get; set; }

    public bool SupportMotionAlert { get; set; }

    public bool SupportOverSpeedAlert { get; set; }

    public bool SupportSms { get; set; }

    public bool SupportSos { get; set; }

    public bool SupportStopAlert { get; set; }

    public short TrackingPeriod { get; set; }

    public string? Url { get; set; }

    public virtual Equipment SerialNumberNavigation { get; set; } = null!;
}
