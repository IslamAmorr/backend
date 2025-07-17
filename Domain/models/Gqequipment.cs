using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Gqequipment
{
    public string SerialNumber { get; set; } = null!;

    public short? KeepAlivePeriodMn { get; set; }

    public string? PrimaryServerIp { get; set; }

    public short? PrimaryPort { get; set; }

    public short? MaxFuelVoltageLevelMv { get; set; }

    public short? MinFuelVoltageLevelMv { get; set; }

    public short? TrackingDistanceM { get; set; }

    public short? TrackingAngle { get; set; }

    public short? OverSpeedEnterDelayS { get; set; }

    public short? OverSpeedDetectionThreshold { get; set; }

    public short? OverSpeedPeriodicitySendingS { get; set; }

    public string? AuthorizedNumberForSilentCall { get; set; }

    public short? StationaryPeriodWhenAccOnM { get; set; }

    public short? BaudeRateIndex { get; set; }

    public string? FirmwareVersion { get; set; }

    public long? HardwareConfigForQl { get; set; }
}
