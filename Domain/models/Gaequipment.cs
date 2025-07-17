using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Gaequipment
{
    public string SerialNumber { get; set; } = null!;

    public short? TrackingPeriod { get; set; }

    public short? CourceChange { get; set; }

    public double? FixedMovingDistance { get; set; }

    public short? KeepAlivePeriod { get; set; }

    public short? OverSpeedDetectionThreshold { get; set; }

    public string? ServerIp { get; set; }

    public short? Port { get; set; }

    public string? AuthorizedNumberForSosSms { get; set; }

    public string? AuthorizedNumberForSosCall { get; set; }

    public short? SquareArea { get; set; }

    public string? LowerLeft { get; set; }

    public string? UpperRight { get; set; }

    public bool? GeofenceIn { get; set; }

    public bool? ReplayBySmsAfterCall { get; set; }

    public bool? InterpretAsNormalText { get; set; }

    public bool? AutomaticHangUpToCall { get; set; }

    public bool? SendAlarmWhenTrackerOn { get; set; }

    public bool? SendGpsblindAreaAlarm { get; set; }

    public bool? SendAlarmWhenLedStopFlashing { get; set; }

    public bool? SendExtraPowerRemoved { get; set; }

    public bool? BuzzerWhenIncomingCall { get; set; }

    public bool? SupportSosalarm { get; set; }

    public bool? SleepModeActive { get; set; }

    public string? AuthorizedNumberForSilentCall { get; set; }

    public bool? SupportCourseChange { get; set; }

    public string? GeofenceName { get; set; }

    public virtual Equipment SerialNumberNavigation { get; set; } = null!;
}
