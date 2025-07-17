using System;
using System.Collections.Generic;

namespace Domain.models;

public partial class Refresh
{
    public string Equipment { get; set; } = null!;

    public DateTime AcquisitionTime { get; set; }

    public int? AdcVoltage { get; set; }

    public short Direction { get; set; }

    public double Latitude { get; set; }

    public double Longitude { get; set; }

    public short Speed { get; set; }

    public long Status { get; set; }

    public double? Temperature { get; set; }

    public short? FuelLevel { get; set; }

    public double? X { get; set; }

    public double? Y { get; set; }

    public bool? Connected { get; set; }

    public int RecordType { get; set; }

    public bool? Sent { get; set; }

    public double? Mileage { get; set; }

    public bool? OnMove { get; set; }

    public double? TempMileage { get; set; }

    public bool? IsKeepAlive { get; set; }

    public int? Customer { get; set; }

    public double? TotalFuel { get; set; }

    public int? AccelerationPosition { get; set; }

    public int? Rpm { get; set; }

    public double? EngineHours { get; set; }

    public string? VehiculeWeight { get; set; }

    public string? TachographData { get; set; }

    public int? EngineTemperature { get; set; }

    public bool? IsValid { get; set; }

    public int? AxleIndex { get; set; }

    public int? AxleWeight { get; set; }

    public int? TotalSendBytes { get; set; }

    public int? TotalReceivedBytesFromServer { get; set; }

    public bool? IgnOn { get; set; }

    public short? Gpslevel { get; set; }

    public short? Gsmlevel { get; set; }

    public int? LastAlertType { get; set; }

    public long? OtherInfo { get; set; }

    public double? FuelConsumptionPerDay { get; set; }

    public double? Level1 { get; set; }

    public double? Pressure1 { get; set; }

    public double? Level2 { get; set; }

    public double? Pressure2 { get; set; }

    public double? Level3 { get; set; }

    public double? Pressure3 { get; set; }

    public double? Level4 { get; set; }

    public double? Pressure4 { get; set; }

    public double? Level5 { get; set; }

    public double? Pressure5 { get; set; }

    public double? Level6 { get; set; }

    public double? Pressure6 { get; set; }

    public string? DriverCode { get; set; }

    public long? TripLot { get; set; }

    public bool? Input1 { get; set; }

    public bool? Input2 { get; set; }

    public bool? Input3 { get; set; }

    public double? Humidity { get; set; }

    public double? PressureReg { get; set; }

    public bool? CycliqueProbMoteurA { get; set; }

    public bool? CycliqueProbMoteurB { get; set; }

    public bool? CycliqueProbMoteurC { get; set; }

    public bool? CycliqueGeneralAlert { get; set; }

    public bool? CycliqueTempBasse { get; set; }

    public bool? CycliquePressionBasse { get; set; }

    public bool? CycliqueAlertPressionReg { get; set; }

    public bool? CycliquePlafMoteurA { get; set; }

    public bool? CycliquePlafMoteurB { get; set; }

    public bool? CycliquePlafMoteurC { get; set; }

    public bool? CycliqueTemphaute { get; set; }

    public bool? CycliquePressionHaute { get; set; }

    public bool? HumidityA { get; set; }

    public bool? HumidityB { get; set; }

    public bool? MemorizedAlert { get; set; }

    public bool? UnderPressure { get; set; }

    public bool? FaultSynthesis { get; set; }

    public bool? PressureBouteilleA { get; set; }

    public bool? PressureBouteilleB { get; set; }

    public double? PressureBouteilleAvalue { get; set; }

    public double? PressureBouteilleBvalue { get; set; }

    public bool? CycliquePlafToutMoteurs { get; set; }

    public double? Voie1 { get; set; }

    public double? Voie2 { get; set; }

    public double? Voie3 { get; set; }

    public double? Voie4 { get; set; }

    public double? Voie5 { get; set; }

    public double? Voie6 { get; set; }

    public double? Voie7 { get; set; }

    public bool? DefautBuzzer { get; set; }

    public bool? DefautHorloge { get; set; }

    public bool? DefautClavierOutil { get; set; }

    public bool? DefautBoutonInhibition { get; set; }

    public bool? DefautBoutonTest { get; set; }

    public bool? DefautAlimentation { get; set; }

    public bool? DefautConvertisseurAnalog { get; set; }

    public bool? DefautCapaciteBuzzer { get; set; }

    public bool? DefautCommunicationBoitierBoucle { get; set; }

    public bool? DefautCommunicationBoitierTimeout { get; set; }

    public bool? Depassementseuilbasvoie7 { get; set; }

    public bool? Depassementseuilbasvoie6 { get; set; }

    public bool? Depassementseuilbasvoie5 { get; set; }

    public bool? Depassementseuilbasvoie4 { get; set; }

    public bool? Depassementseuilbasvoie3 { get; set; }

    public bool? Depassementseuilbasvoie2 { get; set; }

    public bool? Depassementseuilbasvoie1 { get; set; }

    public bool? Depassementseuilhautvoie7 { get; set; }

    public bool? Depassementseuilhautvoie6 { get; set; }

    public bool? Depassementseuilhautvoie5 { get; set; }

    public bool? Depassementseuilhautvoie4 { get; set; }

    public bool? Depassementseuilhautvoie3 { get; set; }

    public bool? Depassementseuilhautvoie2 { get; set; }

    public bool? Depassementseuilhautvoie1 { get; set; }

    public bool? AlarmeVoie7 { get; set; }

    public bool? AlarmeVoie6 { get; set; }

    public bool? AlarmeVoie5 { get; set; }

    public bool? AlarmeVoie4 { get; set; }

    public bool? AlarmeVoie3 { get; set; }

    public bool? AlarmeVoie2 { get; set; }

    public bool? AlarmeVoie1 { get; set; }

    public bool? PreAlarmTempPumpA { get; set; }

    public bool? PreAlarmTempPumpB { get; set; }

    public bool? PreAlarmTempPumpC { get; set; }

    public bool? PreAlarmTempPumpD { get; set; }

    public bool? PreAlarmTempPumpE { get; set; }

    public bool? PreAlarmTempPumpF { get; set; }

    public bool? OilLvlFaultA { get; set; }

    public bool? OilLvlFaultB { get; set; }

    public bool? OilLvlFaultC { get; set; }

    public bool? OilLvlFaultD { get; set; }

    public bool? OilLvlFaultE { get; set; }

    public bool? OilLvlFaultF { get; set; }

    public bool? HighTempFaultA { get; set; }

    public bool? HighTempFaultB { get; set; }

    public bool? HighTempFaultC { get; set; }

    public bool? HighTempFaultD { get; set; }

    public bool? CommunicationExtensionFault { get; set; }

    public bool? CommunicationCentraleMesureFault { get; set; }

    public bool? AuxiliaryFaultA { get; set; }

    public bool? AuxiliaryFaultB { get; set; }

    public bool? AuxiliaryFaultC { get; set; }

    public bool? AuxiliaryFaultD { get; set; }

    public bool? AuxiliaryFaultE { get; set; }

    public bool? AuxiliaryFaultF { get; set; }

    public bool? HighTempFaultE { get; set; }

    public bool? HighTempFaultF { get; set; }

    public bool? LowTempFaultA { get; set; }

    public bool? LowTempFaultB { get; set; }

    public bool? LowTempFaultC { get; set; }

    public bool? LowTempFaultD { get; set; }

    public bool? LowTempFaultE { get; set; }

    public bool? LowTempFaultF { get; set; }

    public bool? RegulationAlarm { get; set; }

    public bool? HighNetworkC2v { get; set; }

    public bool? LowNetworkC2v { get; set; }

    public bool? HighTemperatureAlarm { get; set; }

    public bool? LowTemperatureAlarm { get; set; }

    public bool? CloggingFilter { get; set; }

    public bool? CappingAlarm { get; set; }

    public bool? VacuostatAlarm { get; set; }

    public bool? DisjonctionFaultA { get; set; }

    public bool? DisjonctionFaultB { get; set; }

    public bool? DisjonctionFaultC { get; set; }

    public bool? DisjonctionFaultD { get; set; }

    public bool? DisjonctionFaultE { get; set; }

    public bool? DisjonctionFaultF { get; set; }

    public bool? PompReturnedOnA { get; set; }

    public bool? PompReturnedOnB { get; set; }

    public bool? PompReturnedOnC { get; set; }

    public bool? OilLvlFaultOrAuxa { get; set; }

    public bool? OilLvlFaultOrAuxb { get; set; }

    public bool? OilLvlFaultOrAuxc { get; set; }

    public bool? VacuostatPsXalarm { get; set; }

    public bool? VacuostatPsYalarm { get; set; }

    public bool? SpeedVariatorDefault { get; set; }

    public bool? PompAon { get; set; }

    public bool? PompBon { get; set; }

    public bool? PompCon { get; set; }

    public bool? EvflexoPompA { get; set; }

    public bool? EvflexoPompB { get; set; }

    public bool? EvflexoPompC { get; set; }

    public bool? LowNetWorkPression { get; set; }

    public bool? HightNetWorkPression { get; set; }

    public bool? Fan { get; set; }

    public bool? SynthesisAlarm { get; set; }

    public double? PressureC2v { get; set; }

    public double? PressureC1v { get; set; }

    public double? TempPompA { get; set; }

    public double? TempPompB { get; set; }

    public double? TempPompC { get; set; }

    public double? TempLocal { get; set; }

    public double? Tension { get; set; }

    public double? Intensity { get; set; }

    public double? Power { get; set; }

    public double? Colmatage { get; set; }

    public double? HourCounterPompA { get; set; }

    public double? HourCounterPompB { get; set; }

    public double? HourCounterPompC { get; set; }

    public bool? No2alarm { get; set; }

    public bool? So2alarm { get; set; }

    public bool? HighVoltage { get; set; }

    public bool? LowVoltage { get; set; }

    public bool? CutedEnergy { get; set; }

    public bool? CutedExtensionCard { get; set; }

    public bool? NOalarm { get; set; }

    public bool? Co2ExterneBalarm { get; set; }

    public bool? COexterneAlarm { get; set; }

    public bool? CompressorProblemAlarmA { get; set; }

    public bool? CompressorProblemAlarmB { get; set; }

    public bool? CompressorProblemAlarmC { get; set; }

    public bool? TrapBekoProblemA { get; set; }

    public bool? TrapBekoProblemB { get; set; }

    public bool? TrapBekoProblemC { get; set; }

    public bool? DryerTemperatureProblemA { get; set; }

    public bool? DryerTemperatureProblemB { get; set; }

    public bool? DryerTemperatureProblemC { get; set; }

    public bool? HygrometryLineA { get; set; }

    public bool? HygrometryLineB { get; set; }

    public bool? HygrometryLineC { get; set; }

    public bool? HightNetworkBar9 { get; set; }

    public bool? LowNetworkBar9 { get; set; }

    public bool? HightNetworkBar5 { get; set; }

    public bool? LowNetworkBar5 { get; set; }

    public bool? PlafonnementAlarm { get; set; }

    public bool? HightLocalTemp { get; set; }

    public bool? LowLocalTemp { get; set; }

    public bool? BottlePassage { get; set; }

    public bool? BottleHpa { get; set; }

    public bool? HightO2airAmbiant { get; set; }

    public bool? LowO2airAmbiant { get; set; }

    public bool? HightO2airMedical { get; set; }

    public bool? LowO2airMedical { get; set; }

    public bool? Co2sansorAlarm { get; set; }

    public bool? CosansorAlarm { get; set; }

    public bool? C1aoffAlarm { get; set; }

    public bool? C2aoffAlarm { get; set; }

    public bool? HsboxTempSansor { get; set; }

    public bool? S1aoffHygromtry { get; set; }

    public bool? C4aoffHpa { get; set; }

    public bool? C5aoffHpb { get; set; }

    public bool? C6aoffCo2 { get; set; }

    public bool? C7aoffCo { get; set; }

    public bool? NetworkSpeedAlarm { get; set; }

    public bool? C8aoff { get; set; }

    public bool? C9aoffO2 { get; set; }

    public bool? No2offAlarm { get; set; }

    public bool? So2offAlarm { get; set; }

    public bool? NooffAlarm { get; set; }

    public bool? ReturnCompressorOna { get; set; }

    public bool? ReturnCompressorOnb { get; set; }

    public bool? ReturnCompressorOnc { get; set; }

    public bool? InputBekoFaultA { get; set; }

    public bool? InputBekoFaultB { get; set; }

    public bool? InputBekoFaultC { get; set; }

    public bool? InputDefaultTempDryerA { get; set; }

    public bool? InputDefaultTempDryerB { get; set; }

    public bool? InputDefaultTempDryerC { get; set; }

    public bool? InputExternalCo2fault { get; set; }

    public bool? InputExternalCofault { get; set; }

    public bool? InputMaboosterHp { get; set; }

    public bool? InputAuboosterHp { get; set; }

    public bool? CompressorOna { get; set; }

    public bool? CompressorOnb { get; set; }

    public bool? CompressorOnc { get; set; }

    public bool? HightNetworkPressureBar9 { get; set; }

    public bool? LowNetworkPressureBar9 { get; set; }

    public bool? HightNetworkPressureBar5 { get; set; }

    public bool? LowNetworkPressureBar5 { get; set; }

    public bool? Shutter { get; set; }

    public bool? Co2alarm { get; set; }

    public bool? Coalarm { get; set; }

    public bool? HygrometryAlarm { get; set; }

    public bool? Hpaalarm { get; set; }

    public bool? Hpbalarm { get; set; }

    public double? PressureC1a { get; set; }

    public double? PressureC2a { get; set; }

    public double? Hygrometry { get; set; }

    public double? PressureC4a { get; set; }

    public double? PressureC5a { get; set; }

    public double? SansorCo2 { get; set; }

    public double? SansorCo { get; set; }

    public double? BoxTemp { get; set; }

    public double? Network5Bar { get; set; }

    public double? SensorCo2ambiant { get; set; }

    public double? SensorCo2medical { get; set; }

    public double? SensorNo2 { get; set; }

    public double? SensorSo2 { get; set; }

    public double? SensorNo { get; set; }

    public bool? CompressorProblemAlarmD { get; set; }

    public bool? TrapBekoProblemD { get; set; }

    public bool? DryerTemperatureProblemD { get; set; }

    public bool? ReturnCompressorOnd { get; set; }

    public bool? InputBekoFaultD { get; set; }

    public bool? InputDefaultTempDryerD { get; set; }

    public bool? CompressorOnd { get; set; }

    public double? TempPompD { get; set; }

    public double? TempPompE { get; set; }

    public double? TempPompF { get; set; }

    public double? HourCounterPompD { get; set; }

    public double? HourCounterPompE { get; set; }

    public double? HourCounterPompF { get; set; }

    public bool? PompDon { get; set; }

    public bool? PompEon { get; set; }

    public bool? PompFon { get; set; }

    public bool? OffScaleTempPompD { get; set; }

    public bool? OffScaleTempPompE { get; set; }

    public bool? OffScaleTempPompF { get; set; }

    public bool? EvflexoPompD { get; set; }

    public bool? EvflexoPompE { get; set; }

    public bool? EvflexoPompF { get; set; }

    public bool? PompReturnedOnD { get; set; }

    public bool? PompReturnedOnE { get; set; }

    public bool? PompReturnedOnF { get; set; }

    public bool? OverVoltageAlarm { get; set; }

    public bool? UnderVoltageAlarm { get; set; }

    public bool? OffScaleC1v { get; set; }

    public bool? OffScaleC2v { get; set; }

    public bool? OffScaleTempAmbient { get; set; }

    public bool? OffScaleTempPompA { get; set; }

    public bool? OffScaleTempPompB { get; set; }

    public bool? OffScaleTempPompC { get; set; }

    public bool? OverCurrentAlarm { get; set; }

    public bool? AllPompAreWorking { get; set; }

    public bool? BatteryFaultAlarm { get; set; }

    public bool? VeryHighTempAlarm { get; set; }

    public bool? IntensityAlarm { get; set; }

    public bool? HighDeltaBoxTemp { get; set; }

    public bool? DefaultPurgerX { get; set; }

    public bool? DefaultPurgerY { get; set; }

    public bool? DefaultTempX { get; set; }

    public bool? DefaultTempY { get; set; }

    public bool? ActivePressureSwitchX { get; set; }

    public bool? ActivePressureSwitchY { get; set; }

    public bool? RotationDefaultCompressorXy { get; set; }

    public bool? OffScaleC3a { get; set; }

    public bool? ReturnCompressorOne { get; set; }

    public bool? ReturnCompressorOnf { get; set; }

    public bool? InputPressureSwitchX { get; set; }

    public bool? InputPressureSwitchY { get; set; }

    public bool? CompressorOne { get; set; }

    public bool? CompressorOnf { get; set; }

    public bool? OnDryerX { get; set; }

    public bool? OnDryerY { get; set; }

    public bool? InputRotationDirection { get; set; }

    public bool? InputPca { get; set; }

    public double? PressureC3a { get; set; }

    public double? SensorO2 { get; set; }

    public double? HourCounterDryerX { get; set; }

    public double? HourCounterDryerY { get; set; }

    public bool? HygrometryLineD { get; set; }
}
