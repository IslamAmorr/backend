using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Equipment
{
    public string SerialNumber { get; set; } = null!;

    public int EquipmentStatus { get; set; }

    public bool TrackingActive { get; set; }

    public int? Customer { get; set; }

    public string? EquipmentType { get; set; }

    public bool? ResetedByTnv { get; set; }

    public string? SimcardNumber { get; set; }

    public string? CommServer { get; set; }

    public bool? SupportSendArmingWhenOutOfCntry { get; set; }

    public int? DistanceForOutOfCntry { get; set; }

    public long? HardwareConfig { get; set; }

    public bool? EnableLogging { get; set; }

    public string? SimcardSerialNumber { get; set; }

    public short? TotalBytesForfait { get; set; }

    public double? SurconsuptionGprspercentage { get; set; }

    public DateTime? DateFirstSend { get; set; }

    public DateTime? DateContract { get; set; }

    public bool SavingIgnitionAlert { get; set; }

    public int LongStopDetectionThresholdInSec { get; set; }

    public short? ExceedDrivingTimeDetectionThresholdInSec { get; set; }

    public string? InAreaDuringPeriodParam { get; set; }

    public string? InOutOfWayDuringPeriodParam { get; set; }

    public double? FuelConsumptionThreshold { get; set; }

    public short? EngineTemperatureThreshold { get; set; }

    public short? Rpmthreshold { get; set; }

    public short? FuelLevelPercentForStolenAlarm { get; set; }

    public short? FuelLevelPercent4FillingAlarm { get; set; }

    public string? PasswordDevice { get; set; }

    public string? ServerIp { get; set; }

    public short? OverSpeedKmThresholdAlarm { get; set; }

    public short? Port { get; set; }

    public short? TrackingMvtPeriodInS { get; set; }

    public short? TrackingStpPeriodInS { get; set; }

    public short? TrackingPrdToSendAcquiredPosInS { get; set; }

    public short? StationaryPeriodWhenAccOnS { get; set; }

    public short? StationaryPeriodWhenAccOffS { get; set; }

    public string? SimCardIccidnumber { get; set; }

    public double? FuelLevelCorrectionInPercent { get; set; }

    public short? TemperatureMin { get; set; }

    public short? TemperatureMax { get; set; }

    public short? IntOutTempRangeMode { get; set; }

    public short? OverspeedMarginOnNetworkRoadKmh { get; set; }

    public string? FirmVersion { get; set; }

    public double? MileageCorrection { get; set; }

    public double? MaxAcceptedFuelLevelInPercent { get; set; }

    public short? VeryLowFuelLevelInPercentAlarm { get; set; }

    public short? LowFuelLevelInPercentAlarm { get; set; }

    public short? FuelContainerCapacity { get; set; }

    public short? MinTemperatureVoltageLevelMv { get; set; }

    public short? MaxTemperatureVoltageLevelMv { get; set; }

    public short? EmptyFuelVoltageLevelMv { get; set; }

    public short? FullFuelVoltageLevelMv { get; set; }

    public string? ClonedSerialNumber { get; set; }

    public double? BaseMileageKm { get; set; }

    public short? OverSpeedEnterDelayInS { get; set; }

    public double? SpeedToDetectMvtKmHinSpeedMethod { get; set; }

    public int? ForwardingPort { get; set; }

    public string? ForwardingIp { get; set; }

    public string? UserInsert { get; set; }

    public string? MachineInsert { get; set; }

    public string? UserUpdate { get; set; }

    public string? MachineUpdate { get; set; }

    public DateTime? DateInsert { get; set; }

    public DateTime? DateUpdate { get; set; }

    public int? CalibrationTank { get; set; }

    public virtual Customer? CustomerNavigation { get; set; }

    public virtual ICollection<DriverEquipmentCode> DriverEquipmentCodes { get; set; } = new List<DriverEquipmentCode>();

    public virtual Gaequipment? Gaequipment { get; set; }

    public virtual ICollection<GeofenceCircle> GeofenceCircles { get; set; } = new List<GeofenceCircle>();

    public virtual Glequipment? Glequipment { get; set; }

    public virtual Gpequipment? Gpequipment { get; set; }

    public virtual Grequipment? Grequipment { get; set; }

    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();

    public virtual ICollection<Mission> Missions { get; set; } = new List<Mission>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
