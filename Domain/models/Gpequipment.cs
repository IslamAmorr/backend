using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Gpequipment
{
    public string SerialNumber { get; set; } = null!;

    public string? CallNumber1 { get; set; }

    public string? CallNumber2 { get; set; }

    public string? CallNumber3 { get; set; }

    public short CourceChange { get; set; }

    public double FixedMovingDistance { get; set; }

    public short LowestBatteryLevel { get; set; }

    public double MinTrackingSpeed { get; set; }

    public short MovingTrackingPeriod { get; set; }

    public short Port { get; set; }

    public string ServerIp { get; set; } = null!;

    public short StopTrackingPeriod { get; set; }

    public bool SupportAccstatus { get; set; }

    public bool SupportAfter30mnSystemShutDown { get; set; }

    public bool SupportAlarm { get; set; }

    public bool SupportAntiCarJacking { get; set; }

    public bool SupportAntiOpenTemperSwitch { get; set; }

    public bool SupportArming { get; set; }

    public bool SupportCourceChange { get; set; }

    public bool SupportDoorStatus { get; set; }

    public bool SupportExternalBatteryRemoved { get; set; }

    public bool SupportGeofence { get; set; }

    public bool SupportHelp { get; set; }

    public bool SupportHoodStatus { get; set; }

    public bool SupportLowBatteryLevel { get; set; }

    public bool SupportPanicMode { get; set; }

    public bool SupportSos { get; set; }

    public bool SupportTemperatureCheck { get; set; }

    public bool SupportTrunkStatus { get; set; }

    public bool SupportValetMode { get; set; }

    public short TemperatureMax { get; set; }

    public short TemperatureMin { get; set; }

    public int TrackingModeTrackingModeId { get; set; }

    public bool SupportOverSpeedDetectionThreshold { get; set; }

    public short OverSpeedDetectionThreshold { get; set; }

    public bool SupportKeepAlive { get; set; }

    public short KeepAlivePeriod { get; set; }

    public int? OverSpeedEnterDelay { get; set; }

    public double? CrashValue { get; set; }

    public bool? OverSpeedBuzzerActive { get; set; }

    public double? EmptyVoltage { get; set; }

    public double? FullVoltage { get; set; }

    public byte? LowestFuelLevel { get; set; }

    public bool? SupportFuelLevel { get; set; }

    public bool? SupportShockSensor { get; set; }

    public bool? SupportCrashSensor { get; set; }

    public bool? SupportTowedReport { get; set; }

    public int? StoppedReportDelay { get; set; }

    public long? HardwareConfigForPm { get; set; }

    public virtual ICollection<GeofenceRectangle> GeofenceRectangles { get; set; } = new List<GeofenceRectangle>();

    public virtual Equipment SerialNumberNavigation { get; set; } = null!;
}
