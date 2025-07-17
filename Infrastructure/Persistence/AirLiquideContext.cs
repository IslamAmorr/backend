using System;
using System.Collections.Generic;
using Domain.models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence;

public partial class AirLiquideContext : DbContext
{
    public AirLiquideContext()
    {
    }

    public AirLiquideContext(DbContextOptions<AirLiquideContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccidentDetail> AccidentDetails { get; set; }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<AccountEquipment> AccountEquipments { get; set; }

    public virtual DbSet<AccountPage> AccountPages { get; set; }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<AlertClient> AlertClients { get; set; }

    public virtual DbSet<AlertConfiguration> AlertConfigurations { get; set; }

    public virtual DbSet<AlertType> AlertTypes { get; set; }

    public virtual DbSet<Anomaly> Anomalies { get; set; }

    public virtual DbSet<Approbation> Approbations { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AutomaticReportMailConfig> AutomaticReportMailConfigs { get; set; }

    public virtual DbSet<BorrowedRentalCarContract> BorrowedRentalCarContracts { get; set; }

    public virtual DbSet<BorrowedRentalCarInvoice> BorrowedRentalCarInvoices { get; set; }

    public virtual DbSet<BtSmsEmail> BtSmsEmails { get; set; }

    public virtual DbSet<BuscandataOld> BuscandataOlds { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<CarDocumentLog> CarDocumentLogs { get; set; }

    public virtual DbSet<CarDocumentReminder> CarDocumentReminders { get; set; }

    public virtual DbSet<CardCoupon> CardCoupons { get; set; }

    public virtual DbSet<CardCouponLog> CardCouponLogs { get; set; }

    public virtual DbSet<CardCouponReminder> CardCouponReminders { get; set; }

    public virtual DbSet<Cclscommand> Cclscommands { get; set; }

    public virtual DbSet<Changement> Changements { get; set; }

    public virtual DbSet<Changement2> Changement2s { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerInput> CustomerInputs { get; set; }

    public virtual DbSet<CustomerJocker> CustomerJockers { get; set; }

    public virtual DbSet<CustomerLicence> CustomerLicences { get; set; }

    public virtual DbSet<CustomerOperationLog> CustomerOperationLogs { get; set; }

    public virtual DbSet<CustomerStatus> CustomerStatuses { get; set; }

    public virtual DbSet<DateTest> DateTests { get; set; }

    public virtual DbSet<Delegation> Delegations { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Driver> Drivers { get; set; }

    public virtual DbSet<DriverEquipmentCode> DriverEquipmentCodes { get; set; }

    public virtual DbSet<Equipment> Equipment { get; set; }

    public virtual DbSet<EquipmentLicence> EquipmentLicences { get; set; }

    public virtual DbSet<EquipmentOperationLog> EquipmentOperationLogs { get; set; }

    public virtual DbSet<EquipmentStatus> EquipmentStatuses { get; set; }

    public virtual DbSet<EquipmentType> EquipmentTypes { get; set; }

    public virtual DbSet<G1> G1s { get; set; }

    public virtual DbSet<Gaequipment> Gaequipments { get; set; }

    public virtual DbSet<GeofenceArea> GeofenceAreas { get; set; }

    public virtual DbSet<GeofenceCircle> GeofenceCircles { get; set; }

    public virtual DbSet<GeofenceRectangle> GeofenceRectangles { get; set; }

    public virtual DbSet<GeofenceRectangleNew> GeofenceRectangleNews { get; set; }

    public virtual DbSet<GeometricShape> GeometricShapes { get; set; }

    public virtual DbSet<Ggequipment> Ggequipments { get; set; }

    public virtual DbSet<Glequipment> Glequipments { get; set; }

    public virtual DbSet<Governorate> Governorates { get; set; }

    public virtual DbSet<GparcEquipment> GparcEquipments { get; set; }

    public virtual DbSet<Gpequipment> Gpequipments { get; set; }

    public virtual DbSet<GpsdataByDrvCd> GpsdataByDrvCds { get; set; }

    public virtual DbSet<Gpsdatum> Gpsdata { get; set; }

    public virtual DbSet<Gqequipment> Gqequipments { get; set; }

    public virtual DbSet<Grequipment> Grequipments { get; set; }

    public virtual DbSet<Gsequipment> Gsequipments { get; set; }

    public virtual DbSet<Gstdequipment> Gstdequipments { get; set; }

    public virtual DbSet<Gtequipment> Gtequipments { get; set; }

    public virtual DbSet<Gtftequipment> Gtftequipments { get; set; }

    public virtual DbSet<Gxequipment> Gxequipments { get; set; }

    public virtual DbSet<Hc> Hcs { get; set; }

    public virtual DbSet<Intervention> Interventions { get; set; }

    public virtual DbSet<Ioelement> Ioelements { get; set; }

    public virtual DbSet<Line> Lines { get; set; }

    public virtual DbSet<Localite> Localites { get; set; }

    public virtual DbSet<Mail> Mail { get; set; }

    public virtual DbSet<MailConfig> MailConfigs { get; set; }

    public virtual DbSet<Maintenance> Maintenances { get; set; }

    public virtual DbSet<Map> Maps { get; set; }

    public virtual DbSet<Message> Messages { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<Mission> Missions { get; set; }

    public virtual DbSet<MissionDef> MissionDefs { get; set; }

    public virtual DbSet<MissionOrder> MissionOrders { get; set; }

    public virtual DbSet<MonthlyStatsticDatum> MonthlyStatsticData { get; set; }

    public virtual DbSet<NvalidGpsdatum> NvalidGpsdata { get; set; }

    public virtual DbSet<Offer> Offers { get; set; }

    public virtual DbSet<OutOfCountryDateW> OutOfCountryDateWs { get; set; }

    public virtual DbSet<PersonneGp> PersonneGps { get; set; }

    public virtual DbSet<Place> Places { get; set; }

    public virtual DbSet<Place3> Place3s { get; set; }

    public virtual DbSet<PlannedMission> PlannedMissions { get; set; }

    public virtual DbSet<PlannedStation> PlannedStations { get; set; }

    public virtual DbSet<Point> Points { get; set; }

    public virtual DbSet<Polygon> Polygons { get; set; }

    public virtual DbSet<PreviousPassword> PreviousPasswords { get; set; }

    public virtual DbSet<ProblemResolved> ProblemResolveds { get; set; }

    public virtual DbSet<QueryState> QueryStates { get; set; }

    public virtual DbSet<QueryStatus> QueryStatuses { get; set; }

    public virtual DbSet<QueryType> QueryTypes { get; set; }

    public virtual DbSet<RecordType> RecordTypes { get; set; }

    public virtual DbSet<Refresh> Refreshes { get; set; }

    public virtual DbSet<RefreshStatisticDatum> RefreshStatisticData { get; set; }

    public virtual DbSet<RepairMaintenanceLog> RepairMaintenanceLogs { get; set; }

    public virtual DbSet<Requête> Requêtes { get; set; }

    public virtual DbSet<ServerQuery> ServerQueries { get; set; }

    public virtual DbSet<Smsconfig> Smsconfigs { get; set; }

    public virtual DbSet<SmsmailChange> SmsmailChanges { get; set; }

    public virtual DbSet<SmsmailConfig> SmsmailConfigs { get; set; }

    public virtual DbSet<SmsstateOfSendingAlert> SmsstateOfSendingAlerts { get; set; }

    public virtual DbSet<StandardPlace> StandardPlaces { get; set; }

    public virtual DbSet<StandardPlace1> StandardPlace1s { get; set; }

    public virtual DbSet<StandardPlaceBackUp> StandardPlaceBackUps { get; set; }

    public virtual DbSet<StatisticAnomaly> StatisticAnomalies { get; set; }

    public virtual DbSet<StatisticDataold> StatisticDataolds { get; set; }

    public virtual DbSet<StatisticDatum> StatisticData { get; set; }

    public virtual DbSet<StatisticHour> StatisticHours { get; set; }

    public virtual DbSet<StatisticsFuelConsumption> StatisticsFuelConsumptions { get; set; }

    public virtual DbSet<StopRun> StopRuns { get; set; }

    public virtual DbSet<Supplier> Suppliers { get; set; }

    public virtual DbSet<TankFullConsumption> TankFullConsumptions { get; set; }

    public virtual DbSet<TankLog> TankLogs { get; set; }

    public virtual DbSet<TankPump> TankPumps { get; set; }

    public virtual DbSet<TelNumber> TelNumbers { get; set; }

    public virtual DbSet<TelTonikaBuscandatum> TelTonikaBuscandata { get; set; }

    public virtual DbSet<TempRefresh> TempRefreshes { get; set; }

    public virtual DbSet<TestWithError> TestWithErrors { get; set; }

    public virtual DbSet<TestWithoutError> TestWithoutErrors { get; set; }

    public virtual DbSet<Domain.models.TimeZone> TimeZones { get; set; }

    public virtual DbSet<TrackingMode> TrackingModes { get; set; }

    public virtual DbSet<TrackingTarget> TrackingTargets { get; set; }

    public virtual DbSet<Trip> Trips { get; set; }

    public virtual DbSet<TripOfCustomer> TripOfCustomers { get; set; }

    public virtual DbSet<Way> Ways { get; set; }

    public virtual DbSet<Wt> Wts { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("French_CS_AI");

        modelBuilder.Entity<AccidentDetail>(entity =>
        {
            entity.Property(e => e.AccidentDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("AccidentDateGMT");
            entity.Property(e => e.AccidentLocationFullName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AccidentReportRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Dammage)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Details)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LastGeneratedAlertByExternAppGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastGeneratedAlertByExternAppGMT");
        });

        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");

            entity.Property(e => e.DepName)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LastConnectionDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastConnectionDateGMT");
            entity.Property(e => e.LastConnectionInfo)
                .HasMaxLength(300)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Login)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.MinPeriodToDetectStpInS).HasDefaultValue((short)-1);
            entity.Property(e => e.MinStopPeriodInS).HasDefaultValue(-1.0);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PasswordClr)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PasswordCrpt)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Role)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ShowedAlarmInRtcfg).HasColumnName("ShowedAlarmInRTCfg");
            entity.Property(e => e.TrackPageConfigStr)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UitrackingPageConfig1).HasColumnName("UITrackingPageConfig1");
            entity.Property(e => e.UitrackingPageConfig2).HasColumnName("UITrackingPageConfig2");
            entity.Property(e => e.UitrackingPageConfig3).HasColumnName("UITrackingPageConfig3");

            entity.HasOne(d => d.CustomerNavigation).WithMany(p => p.Accounts)
                .HasForeignKey(d => d.Customer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_Customer");

            entity.HasMany(d => d.Departments).WithMany(p => p.Accounts)
                .UsingEntity<Dictionary<string, object>>(
                    "AccountDepartment",
                    r => r.HasOne<Department>().WithMany()
                        .HasForeignKey("Department")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Account_Department_Department"),
                    l => l.HasOne<Account>().WithMany()
                        .HasForeignKey("Account")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Account_Department_Account"),
                    j =>
                    {
                        j.HasKey("Account", "Department");
                        j.ToTable("Account_Department");
                    });
        });

        modelBuilder.Entity<AccountEquipment>(entity =>
        {
            entity.HasKey(e => new { e.Account, e.Equipment });

            entity.ToTable("Account_Equipment");

            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.AccountEquipments)
                .HasForeignKey(d => d.Account)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Account_E__Accou__1C247F71");
        });

        modelBuilder.Entity<AccountPage>(entity =>
        {
            entity.HasKey(e => new { e.Account, e.PageId });

            entity.ToTable("Account_Page");

            entity.Property(e => e.PageId).HasColumnName("Page_Id");

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.AccountPages)
                .HasForeignKey(d => d.Account)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Account_Account_Page");
        });

        modelBuilder.Entity<Alert>(entity =>
        {
            entity.ToTable("Alert");

            entity.HasIndex(e => new { e.Id, e.Customer }, "IX_Alert_Id_Customer");

            entity.HasIndex(e => new { e.AcquisitionTime, e.Equipment, e.AlertType }, "IX_Alert_dt_eqp_type");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.EquipmentIsTrackingTarget).HasDefaultValue(false);
            entity.Property(e => e.Gpslevel).HasColumnName("GPSLevel");
            entity.Property(e => e.Gsmlevel).HasColumnName("GSMLevel");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OtherInfo).HasDefaultValue(0L);
            entity.Property(e => e.PressureC1a).HasColumnName("pressureC1A");
            entity.Property(e => e.PressureC1v).HasColumnName("pressureC1V");
            entity.Property(e => e.PressureC2a).HasColumnName("pressureC2A");
            entity.Property(e => e.PressureC2v).HasColumnName("pressureC2V");
            entity.Property(e => e.Rpm).HasColumnName("RPM");
            entity.Property(e => e.RunTrace)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Voie1).HasColumnName("voie1");
            entity.Property(e => e.Voie2).HasColumnName("voie2");
            entity.Property(e => e.Voie3).HasColumnName("voie3");
            entity.Property(e => e.Voie4).HasColumnName("voie4");
            entity.Property(e => e.Voie5).HasColumnName("voie5");
            entity.Property(e => e.Voie6).HasColumnName("voie6");
            entity.Property(e => e.Voie7).HasColumnName("voie7");
        });

        modelBuilder.Entity<AlertClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlertClient");

            entity.Property(e => e.LastExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.MachineName)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<AlertConfiguration>(entity =>
        {
            entity.HasKey(e => new { e.AlertType, e.Equipment });

            entity.ToTable("AlertConfiguration");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NotifiedBySms).HasColumnName("NotifiedBySMS");
            entity.Property(e => e.Param)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<AlertType>(entity =>
        {
            entity.ToTable("AlertType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Anomaly>(entity =>
        {
            entity.ToTable("Anomaly");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.GeneratedDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("GeneratedDateGMT");
            entity.Property(e => e.LastConnectionDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastConnectionDateGMT");
            entity.Property(e => e.ResolvedDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("ResolvedDateGMT");
        });

        modelBuilder.Entity<Approbation>(entity =>
        {
            entity.ToTable("Approbation");

            entity.Property(e => e.BenefIdTt).HasColumnName("BenefIdTT");
            entity.Property(e => e.Context)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Deadline).HasColumnType("datetime");
            entity.Property(e => e.Object)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.RequestDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AutomaticReportMailConfig>(entity =>
        {
            entity.ToTable("AutomaticReportMailConfig");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<BorrowedRentalCarContract>(entity =>
        {
            entity.ToTable("BorrowedRentalCarContract");

            entity.Property(e => e.BeginStartRecurringDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("BeginStartRecurringDateGMT");
            entity.Property(e => e.CarInDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("CarInDateGMT");
            entity.Property(e => e.CarOutDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("CarOutDateGMT");
            entity.Property(e => e.ContractEndDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("ContractEndDateGMT");
            entity.Property(e => e.ContractRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ContractStartDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("ContractStartDateGMT");
            entity.Property(e => e.EnableAlertEndRenewContractConfirmedByWt).HasColumnName("EnableAlertEndRenewContractConfirmedByWT");
            entity.Property(e => e.EnableGenerateAlertPaymentExpiredByWt).HasColumnName("EnableGenerateAlertPaymentExpiredByWT");
            entity.Property(e => e.EndRenewedDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("EndRenewedDateGMT");
            entity.Property(e => e.ExpiryDatePaymentGmtforExernApp)
                .HasColumnType("datetime")
                .HasColumnName("ExpiryDatePaymentGMTForExernApp");
            entity.Property(e => e.ExpiryDatePaymentGmtforWt)
                .HasColumnType("datetime")
                .HasColumnName("ExpiryDatePaymentGMTForWT");
            entity.Property(e => e.LastConfirmedAlertPayementByWtgmt)
                .HasColumnType("datetime")
                .HasColumnName("LastConfirmedAlertPayementByWTGMT");
            entity.Property(e => e.LastGeneratedAlertEndRenewConfirmedByWt)
                .HasColumnType("datetime")
                .HasColumnName("LastGeneratedAlertEndRenewConfirmedByWT");
            entity.Property(e => e.LastGenratedAlertEndRenewContractByApp).HasColumnType("datetime");
            entity.Property(e => e.WarnMeBeforeNday).HasColumnName("WarnMeBeforeNDay");
        });

        modelBuilder.Entity<BorrowedRentalCarInvoice>(entity =>
        {
            entity.ToTable("BorrowedRentalCarInvoice");

            entity.Property(e => e.DateInvoiceGmt)
                .HasColumnType("datetime")
                .HasColumnName("DateInvoiceGMT");
            entity.Property(e => e.InvoiceFromGmt)
                .HasColumnType("datetime")
                .HasColumnName("InvoiceFromGMT");
            entity.Property(e => e.InvoiceRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.InvoiceToGmt)
                .HasColumnType("datetime")
                .HasColumnName("InvoiceToGMT");
            entity.Property(e => e.PaidDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("PaidDateGMT");
        });

        modelBuilder.Entity<BtSmsEmail>(entity =>
        {
            entity.Property(e => e.DateEnvoi)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DateInsertion)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Destinataire)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.EtatEnvoie)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.HeurEnvoi)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.HeurInsertion)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TextAlerte)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TypeMessage)
                .HasMaxLength(1)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<BuscandataOld>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_BUSCANData");

            entity.ToTable("BUSCANDataOLd");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.ToTable("Car");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AdcUse)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("ADC_Use");
            entity.Property(e => e.CarType)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Matricule)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Car)
                .HasForeignKey<Car>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Car_TrackingTarget");
        });

        modelBuilder.Entity<CarDocumentLog>(entity =>
        {
            entity.ToTable("CarDocumentLog");

            entity.Property(e => e.DateAvailableFromGmt)
                .HasColumnType("datetime")
                .HasColumnName("DateAvailableFromGMT");
            entity.Property(e => e.DateAvailableToGmt)
                .HasColumnType("datetime")
                .HasColumnName("DateAvailableToGMT");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.InvoiceReference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PaidDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("PaidDateGMT");
            entity.Property(e => e.Supplier)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<CarDocumentReminder>(entity =>
        {
            entity.ToTable("CarDocumentReminder");

            entity.Property(e => e.BeginStartRecurringDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("BeginStartRecurringDateGMT");
            entity.Property(e => e.EnableGenerateAlertByWt).HasColumnName("EnableGenerateAlertByWT");
            entity.Property(e => e.ExpiryDateGmtforExernApp)
                .HasColumnType("datetime")
                .HasColumnName("ExpiryDateGMTForExernApp");
            entity.Property(e => e.ExpiryDateGmtforWt)
                .HasColumnType("datetime")
                .HasColumnName("ExpiryDateGMTForWT");
            entity.Property(e => e.LastConfirmedAlertByWtgmt)
                .HasColumnType("datetime")
                .HasColumnName("LastConfirmedAlertByWTGMT");
            entity.Property(e => e.LastDueDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastDueDateGMT");
            entity.Property(e => e.LastGenerateAlertByExternAppGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastGenerateAlertByExternAppGMT");
            entity.Property(e => e.WarnMeBeforeNday).HasColumnName("WarnMeBeforeNDay");
        });

        modelBuilder.Entity<CardCoupon>(entity =>
        {
            entity.ToTable("CardCoupon");

            entity.Property(e => e.CardCouponRef)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DateGmt)
                .HasColumnType("datetime")
                .HasColumnName("DateGMT");
        });

        modelBuilder.Entity<CardCouponLog>(entity =>
        {
            entity.ToTable("CardCouponLog");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ForMissionEndDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("ForMissionEndDateGMT");
            entity.Property(e => e.ForMissionStartDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("ForMissionStartDateGMT");
        });

        modelBuilder.Entity<CardCouponReminder>(entity =>
        {
            entity.ToTable("CardCouponReminder");

            entity.Property(e => e.BeginStartRecurringDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("BeginStartRecurringDateGMT");
            entity.Property(e => e.CreatedReminderDate).HasColumnType("datetime");
            entity.Property(e => e.EnableGenerateAlertByWt).HasColumnName("EnableGenerateAlertByWT");
            entity.Property(e => e.ExpiredDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("ExpiredDateGMT");
            entity.Property(e => e.ExpiryDateGmtforExernApp)
                .HasColumnType("datetime")
                .HasColumnName("ExpiryDateGMTForExernApp");
            entity.Property(e => e.LastConfirmedAlertByWtgmt)
                .HasColumnType("datetime")
                .HasColumnName("LastConfirmedAlertByWTGMT");
            entity.Property(e => e.LastGenerateAlertByExternAppGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastGenerateAlertByExternAppGMT");
            entity.Property(e => e.WarnMeBeforNday).HasColumnName("WarnMeBeforNDay");
        });

        modelBuilder.Entity<Cclscommand>(entity =>
        {
            entity.ToTable("CCLSCommand");

            entity.Property(e => e.Description)
                .UseCollation("French_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.Hcs)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("HCS");
            entity.Property(e => e.PostingTime).HasColumnType("datetime");
            entity.Property(e => e.Response)
                .UseCollation("French_CI_AS")
                .HasColumnType("text");
            entity.Property(e => e.Wt)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("WT");
        });

        modelBuilder.Entity<Changement>(entity =>
        {
            entity.ToTable("Changement");

            entity.Property(e => e.Description)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ObjectName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OperationType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PostingTime).HasColumnType("datetime");
            entity.Property(e => e.StringId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Changement2>(entity =>
        {
            entity.ToTable("Changement2");

            entity.Property(e => e.ObjectName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OperationType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PostingTime).HasColumnType("datetime");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.StringId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.ToTable("Customer");

            entity.Property(e => e.Adress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AuthorizedSmscount).HasColumnName("AuthorizedSMSCount");
            entity.Property(e => e.DateInsert).HasColumnType("datetime");
            entity.Property(e => e.DateUpdate).HasColumnType("datetime");
            entity.Property(e => e.DownloadPassword)
                .HasMaxLength(20)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Email1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Email2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Email3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ExpirationDate).HasColumnType("datetime");
            entity.Property(e => e.ExpirationDateForResellerGmt)
                .HasColumnType("datetime")
                .HasColumnName("ExpirationDateForResellerGMT");
            entity.Property(e => e.Fax)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Gmt)
                .HasDefaultValue((short)0)
                .HasColumnName("GMT");
            entity.Property(e => e.LastConnectionDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastConnectionDateGMT");
            entity.Property(e => e.LastConnectionInfo)
                .HasMaxLength(300)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.MessageToShow).UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NbrEqConnectedFromXtime).HasColumnName("NbrEqConnectedFromXTime");
            entity.Property(e => e.NbrEqDisconnectedMoreThanXtime).HasColumnName("NbrEqDisconnectedMoreThanXTime");
            entity.Property(e => e.SiteName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SubscriptionDate).HasColumnType("datetime");
            entity.Property(e => e.Tel1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Tel2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Tel3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TimeZone)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Url)
                .UseCollation("French_CI_AS")
                .HasColumnName("URL");
            entity.Property(e => e.Website)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<CustomerInput>(entity =>
        {
            entity.HasKey(e => new { e.Customer, e.Input });

            entity.ToTable("Customer_Inputs");
        });

        modelBuilder.Entity<CustomerJocker>(entity =>
        {
            entity.HasKey(e => e.Customer);

            entity.ToTable("Customer_Jocker");

            entity.Property(e => e.Customer).ValueGeneratedNever();
        });

        modelBuilder.Entity<CustomerLicence>(entity =>
        {
            entity.ToTable("CustomerLicence");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DateContractWorkForce).HasColumnType("datetime");
            entity.Property(e => e.DateContractWt).HasColumnType("datetime");
            entity.Property(e => e.DateExpireWorkForce).HasColumnType("datetime");
            entity.Property(e => e.DateExpireWt).HasColumnType("datetime");
            entity.Property(e => e.TimeRenewSubscription).HasColumnType("datetime");
            entity.Property(e => e.WarrantyDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CustomerOperationLog>(entity =>
        {
            entity.ToTable("CustomerOperationLog");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LoginAccount)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OperationDateGmt).HasColumnType("datetime");
            entity.Property(e => e.OtherInfo).UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<CustomerStatus>(entity =>
        {
            entity.ToTable("CustomerStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<DateTest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_LastTest");

            entity.ToTable("DateTest");

            entity.Property(e => e.DateStandardTest).HasColumnType("datetime");
        });

        modelBuilder.Entity<Delegation>(entity =>
        {
            entity.ToTable("Delegation");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.GovId).HasColumnName("Gov_Id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.ToTable("Department");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.CustomerNavigation).WithMany(p => p.Departments)
                .HasForeignKey(d => d.Customer)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Department_Customer");
        });

        modelBuilder.Entity<Driver>(entity =>
        {
            entity.ToTable("Driver");

            entity.Property(e => e.DriverCode)
                .HasMaxLength(16)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.FixTelphoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.MobileTelephoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.Drivers)
                .HasForeignKey(d => d.Department)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Driver_Department");
        });

        modelBuilder.Entity<DriverEquipmentCode>(entity =>
        {
            entity.HasKey(e => new { e.Equipment, e.CodeIndex }).HasName("PK_DriverCode");

            entity.ToTable("DriverEquipmentCode");

            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.DriverNavigation).WithMany(p => p.DriverEquipmentCodes)
                .HasForeignKey(d => d.Driver)
                .HasConstraintName("FK_DriverEquipmentCode_Driver");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.DriverEquipmentCodes)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DriverCode_Equipment");
        });

        modelBuilder.Entity<Equipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber).HasName("PK_Equipment_1");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ClonedSerialNumber)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.CommServer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DateContract).HasColumnType("datetime");
            entity.Property(e => e.DateFirstSend).HasColumnType("datetime");
            entity.Property(e => e.DateInsert).HasColumnType("datetime");
            entity.Property(e => e.DateUpdate).HasColumnType("datetime");
            entity.Property(e => e.EmptyFuelVoltageLevelMv).HasColumnName("EmptyFuelVoltageLevelMV");
            entity.Property(e => e.EngineTemperatureThreshold).HasDefaultValue((short)-1);
            entity.Property(e => e.EquipmentType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.FirmVersion)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ForwardingIp)
                .HasMaxLength(60)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ForwardingPort).HasDefaultValue(0);
            entity.Property(e => e.FuelConsumptionThreshold).HasDefaultValue(0.0);
            entity.Property(e => e.FuelLevelPercent4FillingAlarm).HasDefaultValue((short)-1);
            entity.Property(e => e.FuelLevelPercentForStolenAlarm).HasDefaultValue((short)-1);
            entity.Property(e => e.FullFuelVoltageLevelMv).HasColumnName("FullFuelVoltageLevelMV");
            entity.Property(e => e.InAreaDuringPeriodParam)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.InOutOfWayDuringPeriodParam)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.IntOutTempRangeMode).HasDefaultValue((short)2);
            entity.Property(e => e.MaxTemperatureVoltageLevelMv).HasColumnName("MaxTemperatureVoltageLevelMV");
            entity.Property(e => e.MinTemperatureVoltageLevelMv).HasColumnName("MinTemperatureVoltageLevelMV");
            entity.Property(e => e.OverSpeedKmThresholdAlarm).HasDefaultValue((short)-1);
            entity.Property(e => e.OverspeedMarginOnNetworkRoadKmh).HasDefaultValue((short)0);
            entity.Property(e => e.PasswordDevice)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Port).HasDefaultValue((short)0);
            entity.Property(e => e.ResetedByTnv)
                .HasDefaultValue(false)
                .HasColumnName("ResetedByTNV");
            entity.Property(e => e.Rpmthreshold)
                .HasDefaultValue((short)-1)
                .HasColumnName("RPMThreshold");
            entity.Property(e => e.SavingIgnitionAlert).HasDefaultValue(true);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS")
                .HasColumnName("ServerIP");
            entity.Property(e => e.SimCardIccidnumber)
                .HasMaxLength(30)
                .UseCollation("French_CI_AS")
                .HasColumnName("SimCardICCIDNumber");
            entity.Property(e => e.SimcardNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("SIMCardNumber");
            entity.Property(e => e.SimcardSerialNumber)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS")
                .HasColumnName("SIMCardSerialNumber");
            entity.Property(e => e.SpeedToDetectMvtKmHinSpeedMethod).HasColumnName("SpeedToDetectMvtKmHInSpeedMethod");
            entity.Property(e => e.SurconsuptionGprspercentage).HasColumnName("SurconsuptionGPRSPercentage");
            entity.Property(e => e.TemperatureMax).HasDefaultValue((short)-1);
            entity.Property(e => e.TemperatureMin).HasDefaultValue((short)-1);
            entity.Property(e => e.TrackingMvtPeriodInS).HasDefaultValue((short)0);
            entity.Property(e => e.TrackingPrdToSendAcquiredPosInS).HasDefaultValue((short)0);
            entity.Property(e => e.TrackingStpPeriodInS).HasDefaultValue((short)0);

            entity.HasOne(d => d.CustomerNavigation).WithMany(p => p.Equipment)
                .HasForeignKey(d => d.Customer)
                .HasConstraintName("FK_Equipment_Customer");
        });

        modelBuilder.Entity<EquipmentLicence>(entity =>
        {
            entity.HasKey(e => e.SerialNumber).HasName("PK_EquipementLicence");

            entity.ToTable("EquipmentLicence");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DateContract).HasColumnType("datetime");
            entity.Property(e => e.DateDeliveryOrder).HasColumnType("datetime");
            entity.Property(e => e.DateEquipmentAllocation).HasColumnType("datetime");
            entity.Property(e => e.DateInvoice).HasColumnType("datetime");
            entity.Property(e => e.DateUpService).HasColumnType("datetime");
            entity.Property(e => e.NumDeliveryOrder)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumInvoice)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SerialBoxEquipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<EquipmentOperationLog>(entity =>
        {
            entity.ToTable("EquipmentOperationLog");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.EquipmentName)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LoginAccount)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NewValue)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OldValue)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OperationDateGmt).HasColumnType("datetime");
            entity.Property(e => e.OtherInfo).UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<EquipmentStatus>(entity =>
        {
            entity.ToTable("EquipmentStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<EquipmentType>(entity =>
        {
            entity.ToTable("EquipmentType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<G1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("g1");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.AdcVoltage).HasColumnName("ADC_Voltage");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Gpslevel).HasColumnName("GPSLevel");
            entity.Property(e => e.Gsmlevel).HasColumnName("GSMLevel");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OriginalEquipment)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Rpm).HasColumnName("RPM");
            entity.Property(e => e.TachographData)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.VehiculeWeight)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Gaequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GAEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AuthorizedNumberForSilentCall)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AuthorizedNumberForSosCall)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("AuthorizedNumberForSOS_Call");
            entity.Property(e => e.AuthorizedNumberForSosSms)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("AuthorizedNumberForSOS_SMS");
            entity.Property(e => e.GeofenceName)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LowerLeft)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SendGpsblindAreaAlarm).HasColumnName("SendGPSBlindAreaAlarm");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("ServerIP");
            entity.Property(e => e.SupportSosalarm).HasColumnName("SupportSOSAlarm");
            entity.Property(e => e.UpperRight)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.SerialNumberNavigation).WithOne(p => p.Gaequipment)
                .HasForeignKey<Gaequipment>(d => d.SerialNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GAEquipment_Equipment");
        });

        modelBuilder.Entity<GeofenceArea>(entity =>
        {
            entity.ToTable("GeofenceArea");

            entity.Property(e => e.AreaName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DownLatitude).HasColumnName("Down_Latitude");
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LeftLongitude).HasColumnName("Left_Longitude");
            entity.Property(e => e.RightLongitude).HasColumnName("Right_Longitude");
            entity.Property(e => e.UpLatitude).HasColumnName("Up_Latitude");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.GeofenceAreas)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GeofenceArea_Equipment");
        });

        modelBuilder.Entity<GeofenceCircle>(entity =>
        {
            entity.ToTable("GeofenceCircle");

            entity.Property(e => e.CircleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.GeofenceCircles)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GeofenceCircle_Equipments");
        });

        modelBuilder.Entity<GeofenceRectangle>(entity =>
        {
            entity.ToTable("GeofenceRectangle");

            entity.Property(e => e.DownLeft)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.RectangleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UpRight)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.GeofenceRectangles)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GeofenceRectangle_Equipment");
        });

        modelBuilder.Entity<GeofenceRectangleNew>(entity =>
        {
            entity.ToTable("GeofenceRectangleNew");

            entity.Property(e => e.DownRight)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.RectangleName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TopLeft)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.GeofenceRectangleNews)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GeofenceRectangleNew_Equipment1");
        });

        modelBuilder.Entity<GeometricShape>(entity =>
        {
            entity.ToTable("GeometricShape");

            entity.Property(e => e.Name)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Ggequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GGEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AuhthorizedNumber1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AuhthorizedNumber2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AuhthorizedNumber3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Glequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GLEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.CallSimNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.EquipmentSimNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ServerSimNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SmscenterNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("SMSCenterNumber");
            entity.Property(e => e.Smsperiod).HasColumnName("SMSPeriod");
            entity.Property(e => e.Sosnumber1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("SOSNumber1");
            entity.Property(e => e.Sosnumber2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("SOSNumber2");
            entity.Property(e => e.Sosnumber3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("SOSNumber3");
            entity.Property(e => e.SupportGpssynchroAlert).HasColumnName("SupportGPSSynchroAlert");
            entity.Property(e => e.SupportSms).HasColumnName("SupportSMS");
            entity.Property(e => e.SupportSos).HasColumnName("SupportSOS");
            entity.Property(e => e.Url)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("URL");

            entity.HasOne(d => d.SerialNumberNavigation).WithOne(p => p.Glequipment)
                .HasForeignKey<Glequipment>(d => d.SerialNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GLEquipment_Equipment1");
        });

        modelBuilder.Entity<Governorate>(entity =>
        {
            entity.ToTable("Governorate");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<GparcEquipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GParcEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Gpequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GPEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.CallNumber1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.CallNumber2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.CallNumber3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.HardwareConfigForPm).HasColumnName("HardwareConfigForPM");
            entity.Property(e => e.KeepAlivePeriod).HasDefaultValue((short)900);
            entity.Property(e => e.LowestBatteryLevel).HasDefaultValue((short)-1);
            entity.Property(e => e.ServerIp)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasDefaultValue("")
                .UseCollation("French_CI_AS")
                .HasColumnName("ServerIP");
            entity.Property(e => e.SupportAccstatus).HasColumnName("SupportACCStatus");
            entity.Property(e => e.SupportSos).HasColumnName("SupportSOS");
            entity.Property(e => e.TemperatureMax).HasDefaultValue((short)-1);
            entity.Property(e => e.TemperatureMin).HasDefaultValue((short)-1);
            entity.Property(e => e.TrackingModeTrackingModeId).HasColumnName("TrackingMode_TrackingModeId");

            entity.HasOne(d => d.SerialNumberNavigation).WithOne(p => p.Gpequipment)
                .HasForeignKey<Gpequipment>(d => d.SerialNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GPEquipment_Equipment");
        });

        modelBuilder.Entity<GpsdataByDrvCd>(entity =>
        {
            entity.ToTable("GPSDataByDrvCd");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.DriverCode).HasMaxLength(25);
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Gpslevel).HasColumnName("GPSLevel");
            entity.Property(e => e.Gsmlevel).HasColumnName("GSMLevel");
            entity.Property(e => e.Message).HasMaxLength(255);
            entity.Property(e => e.OriginalEquipment)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Rpm).HasColumnName("RPM");
            entity.Property(e => e.TachographData).HasMaxLength(1);
        });

        modelBuilder.Entity<Gpsdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GPSData1TempNew8");

            entity.ToTable("GPSData");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.AdcVoltage).HasColumnName("ADC_Voltage");
            entity.Property(e => e.BottleHpa).HasColumnName("BottleHPA");
            entity.Property(e => e.BoxTemp).HasColumnName("boxTemp");
            entity.Property(e => e.C1aoffAlarm).HasColumnName("C1AOffAlarm");
            entity.Property(e => e.C2aoffAlarm).HasColumnName("C2AOffAlarm");
            entity.Property(e => e.C4aoffHpa).HasColumnName("C4AOffHPA");
            entity.Property(e => e.C5aoffHpb).HasColumnName("C5AOffHPB");
            entity.Property(e => e.C6aoffCo2).HasColumnName("C6AOffCO2");
            entity.Property(e => e.C7aoffCo).HasColumnName("C7AOffCO");
            entity.Property(e => e.C8aoff).HasColumnName("C8AOff");
            entity.Property(e => e.C9aoffO2).HasColumnName("C9AOffO2");
            entity.Property(e => e.COexterneAlarm).HasColumnName("cOExterneAlarm");
            entity.Property(e => e.Co2ExterneBalarm).HasColumnName("co2ExterneBAlarm");
            entity.Property(e => e.Co2alarm).HasColumnName("CO2Alarm");
            entity.Property(e => e.Co2sansorAlarm).HasColumnName("CO2SansorAlarm");
            entity.Property(e => e.Coalarm).HasColumnName("COAlarm");
            entity.Property(e => e.CompressorOna).HasColumnName("CompressorONA");
            entity.Property(e => e.CompressorOnb).HasColumnName("CompressorONB");
            entity.Property(e => e.CompressorOnc).HasColumnName("CompressorONC");
            entity.Property(e => e.CompressorOnd).HasColumnName("CompressorOND");
            entity.Property(e => e.CompressorOne).HasColumnName("CompressorONE");
            entity.Property(e => e.CompressorOnf).HasColumnName("CompressorONF");
            entity.Property(e => e.CosansorAlarm).HasColumnName("COSansorAlarm");
            entity.Property(e => e.CutedEnergy).HasColumnName("cutedEnergy");
            entity.Property(e => e.CutedExtensionCard).HasColumnName("cutedExtensionCard");
            entity.Property(e => e.DefautAlimentation).HasColumnName("defautAlimentation");
            entity.Property(e => e.DefautBoutonInhibition).HasColumnName("defautBoutonInhibition");
            entity.Property(e => e.DefautBoutonTest).HasColumnName("defautBoutonTest");
            entity.Property(e => e.DefautBuzzer).HasColumnName("defautBuzzer");
            entity.Property(e => e.DefautCapaciteBuzzer).HasColumnName("defautCapaciteBuzzer");
            entity.Property(e => e.DefautClavierOutil).HasColumnName("defautClavierOutil");
            entity.Property(e => e.DefautCommunicationBoitierBoucle).HasColumnName("defautCommunicationBoitierBoucle");
            entity.Property(e => e.DefautCommunicationBoitierTimeout).HasColumnName("defautCommunicationBoitierTimeout");
            entity.Property(e => e.DefautConvertisseurAnalog).HasColumnName("defautConvertisseurAnalog");
            entity.Property(e => e.DefautHorloge).HasColumnName("defautHorloge");
            entity.Property(e => e.Depassementseuilbasvoie1).HasColumnName("depassementseuilbasvoie1");
            entity.Property(e => e.Depassementseuilbasvoie2).HasColumnName("depassementseuilbasvoie2");
            entity.Property(e => e.Depassementseuilbasvoie3).HasColumnName("depassementseuilbasvoie3");
            entity.Property(e => e.Depassementseuilbasvoie4).HasColumnName("depassementseuilbasvoie4");
            entity.Property(e => e.Depassementseuilbasvoie5).HasColumnName("depassementseuilbasvoie5");
            entity.Property(e => e.Depassementseuilbasvoie6).HasColumnName("depassementseuilbasvoie6");
            entity.Property(e => e.Depassementseuilbasvoie7).HasColumnName("depassementseuilbasvoie7");
            entity.Property(e => e.Depassementseuilhautvoie1).HasColumnName("depassementseuilhautvoie1");
            entity.Property(e => e.Depassementseuilhautvoie2).HasColumnName("depassementseuilhautvoie2");
            entity.Property(e => e.Depassementseuilhautvoie3).HasColumnName("depassementseuilhautvoie3");
            entity.Property(e => e.Depassementseuilhautvoie4).HasColumnName("depassementseuilhautvoie4");
            entity.Property(e => e.Depassementseuilhautvoie5).HasColumnName("depassementseuilhautvoie5");
            entity.Property(e => e.Depassementseuilhautvoie6).HasColumnName("depassementseuilhautvoie6");
            entity.Property(e => e.Depassementseuilhautvoie7).HasColumnName("depassementseuilhautvoie7");
            entity.Property(e => e.DriverCode).HasMaxLength(30);
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EvflexoPompA).HasColumnName("EVFlexoPompA");
            entity.Property(e => e.EvflexoPompB).HasColumnName("EVFlexoPompB");
            entity.Property(e => e.EvflexoPompC).HasColumnName("EVFlexoPompC");
            entity.Property(e => e.EvflexoPompD).HasColumnName("EVFlexoPompD");
            entity.Property(e => e.EvflexoPompE).HasColumnName("EVFlexoPompE");
            entity.Property(e => e.EvflexoPompF).HasColumnName("EVFlexoPompF");
            entity.Property(e => e.Gpslevel).HasColumnName("GPSLevel");
            entity.Property(e => e.Gsmlevel).HasColumnName("GSMLevel");
            entity.Property(e => e.HighNetworkC2v).HasColumnName("highNetworkC2V");
            entity.Property(e => e.HighTempFaultA).HasColumnName("highTempFaultA");
            entity.Property(e => e.HighTempFaultB).HasColumnName("highTempFaultB");
            entity.Property(e => e.HighTempFaultC).HasColumnName("highTempFaultC");
            entity.Property(e => e.HighTempFaultD).HasColumnName("highTempFaultD");
            entity.Property(e => e.HighTempFaultE).HasColumnName("highTempFaultE");
            entity.Property(e => e.HighTempFaultF).HasColumnName("highTempFaultF");
            entity.Property(e => e.HighTemperatureAlarm).HasColumnName("highTemperatureAlarm");
            entity.Property(e => e.HighVoltage).HasColumnName("highVoltage");
            entity.Property(e => e.HightLocalTemp).HasColumnName("hightLocalTemp");
            entity.Property(e => e.HightNetworkBar5).HasColumnName("hightNetworkBar5");
            entity.Property(e => e.HightNetworkBar9).HasColumnName("hightNetworkBar9");
            entity.Property(e => e.HightNetworkPressureBar5).HasColumnName("hightNetworkPressureBar5");
            entity.Property(e => e.HightNetworkPressureBar9).HasColumnName("hightNetworkPressureBar9");
            entity.Property(e => e.HightO2airAmbiant).HasColumnName("hightO2AirAmbiant");
            entity.Property(e => e.HightO2airMedical).HasColumnName("hightO2AirMedical");
            entity.Property(e => e.Hpaalarm).HasColumnName("HPAAlarm");
            entity.Property(e => e.Hpbalarm).HasColumnName("HPBAlarm");
            entity.Property(e => e.HsboxTempSansor).HasColumnName("HSBoxTempSansor");
            entity.Property(e => e.Hygrometry).HasColumnName("hygrometry");
            entity.Property(e => e.HygrometryLineA).HasColumnName("hygrometryLineA");
            entity.Property(e => e.HygrometryLineB).HasColumnName("hygrometryLineB");
            entity.Property(e => e.HygrometryLineC).HasColumnName("hygrometryLineC");
            entity.Property(e => e.HygrometryLineD).HasColumnName("hygrometryLineD");
            entity.Property(e => e.InputAuboosterHp).HasColumnName("inputAUBoosterHp");
            entity.Property(e => e.InputBekoFaultA).HasColumnName("inputBekoFaultA");
            entity.Property(e => e.InputBekoFaultB).HasColumnName("inputBekoFaultB");
            entity.Property(e => e.InputBekoFaultC).HasColumnName("inputBekoFaultC");
            entity.Property(e => e.InputBekoFaultD).HasColumnName("inputBekoFaultD");
            entity.Property(e => e.InputDefaultTempDryerA).HasColumnName("inputDefaultTempDryerA");
            entity.Property(e => e.InputDefaultTempDryerB).HasColumnName("inputDefaultTempDryerB");
            entity.Property(e => e.InputDefaultTempDryerC).HasColumnName("inputDefaultTempDryerC");
            entity.Property(e => e.InputDefaultTempDryerD).HasColumnName("inputDefaultTempDryerD");
            entity.Property(e => e.InputExternalCo2fault).HasColumnName("inputExternalCO2Fault");
            entity.Property(e => e.InputExternalCofault).HasColumnName("inputExternalCOFault");
            entity.Property(e => e.InputMaboosterHp).HasColumnName("inputMABoosterHp");
            entity.Property(e => e.InputPca).HasColumnName("InputPCA");
            entity.Property(e => e.LowLocalTemp).HasColumnName("lowLocalTemp");
            entity.Property(e => e.LowNetworkBar5).HasColumnName("lowNetworkBar5");
            entity.Property(e => e.LowNetworkBar9).HasColumnName("lowNetworkBar9");
            entity.Property(e => e.LowNetworkC2v).HasColumnName("lowNetworkC2V");
            entity.Property(e => e.LowNetworkPressureBar5).HasColumnName("lowNetworkPressureBar5");
            entity.Property(e => e.LowNetworkPressureBar9).HasColumnName("lowNetworkPressureBar9");
            entity.Property(e => e.LowO2airAmbiant).HasColumnName("lowO2AirAmbiant");
            entity.Property(e => e.LowO2airMedical).HasColumnName("lowO2AirMedical");
            entity.Property(e => e.LowTempFaultA).HasColumnName("lowTempFaultA");
            entity.Property(e => e.LowTempFaultB).HasColumnName("lowTempFaultB");
            entity.Property(e => e.LowTempFaultC).HasColumnName("lowTempFaultC");
            entity.Property(e => e.LowTempFaultD).HasColumnName("lowTempFaultD");
            entity.Property(e => e.LowTempFaultE).HasColumnName("lowTempFaultE");
            entity.Property(e => e.LowTempFaultF).HasColumnName("lowTempFaultF");
            entity.Property(e => e.LowTemperatureAlarm).HasColumnName("lowTemperatureAlarm");
            entity.Property(e => e.LowVoltage).HasColumnName("lowVoltage");
            entity.Property(e => e.Message).HasMaxLength(255);
            entity.Property(e => e.NOalarm).HasColumnName("nOAlarm");
            entity.Property(e => e.Network5Bar).HasColumnName("network5Bar");
            entity.Property(e => e.No2alarm).HasColumnName("NO2Alarm");
            entity.Property(e => e.No2offAlarm).HasColumnName("NO2OffAlarm");
            entity.Property(e => e.NooffAlarm).HasColumnName("NOOffAlarm");
            entity.Property(e => e.OffScaleC3a).HasColumnName("OffScaleC3A");
            entity.Property(e => e.OilLvlFaultOrAuxa).HasColumnName("OilLvlFaultOrAUXA");
            entity.Property(e => e.OilLvlFaultOrAuxb).HasColumnName("OilLvlFaultOrAUXB");
            entity.Property(e => e.OilLvlFaultOrAuxc).HasColumnName("OilLvlFaultOrAUXC");
            entity.Property(e => e.OriginalEquipment).HasMaxLength(50);
            entity.Property(e => e.OtherInfo).HasDefaultValue(0L);
            entity.Property(e => e.PlafonnementAlarm).HasColumnName("plafonnementAlarm");
            entity.Property(e => e.PompAon).HasColumnName("PompAON");
            entity.Property(e => e.PompBon).HasColumnName("PompBON");
            entity.Property(e => e.PompCon).HasColumnName("PompCON");
            entity.Property(e => e.PompDon).HasColumnName("PompDON");
            entity.Property(e => e.PompEon).HasColumnName("PompEON");
            entity.Property(e => e.PompFon).HasColumnName("PompFON");
            entity.Property(e => e.PressureBouteilleAvalue).HasColumnName("PressureBouteilleAValue");
            entity.Property(e => e.PressureBouteilleBvalue).HasColumnName("PressureBouteilleBValue");
            entity.Property(e => e.PressureC1a).HasColumnName("pressureC1A");
            entity.Property(e => e.PressureC1v).HasColumnName("pressureC1V");
            entity.Property(e => e.PressureC2a).HasColumnName("pressureC2A");
            entity.Property(e => e.PressureC2v).HasColumnName("pressureC2V");
            entity.Property(e => e.PressureC3a).HasColumnName("PressureC3A");
            entity.Property(e => e.PressureC4a).HasColumnName("pressureC4A");
            entity.Property(e => e.PressureC5a).HasColumnName("pressureC5A");
            entity.Property(e => e.ReturnCompressorOna).HasColumnName("returnCompressorONA");
            entity.Property(e => e.ReturnCompressorOnb).HasColumnName("returnCompressorONB");
            entity.Property(e => e.ReturnCompressorOnc).HasColumnName("returnCompressorONC");
            entity.Property(e => e.ReturnCompressorOnd).HasColumnName("returnCompressorOND");
            entity.Property(e => e.ReturnCompressorOne).HasColumnName("ReturnCompressorONE");
            entity.Property(e => e.ReturnCompressorOnf).HasColumnName("ReturnCompressorONF");
            entity.Property(e => e.RotationDefaultCompressorXy).HasColumnName("RotationDefaultCompressorXY");
            entity.Property(e => e.Rpm).HasColumnName("RPM");
            entity.Property(e => e.S1aoffHygromtry).HasColumnName("S1AOffHygromtry");
            entity.Property(e => e.SansorCo).HasColumnName("sansorCO");
            entity.Property(e => e.SansorCo2).HasColumnName("sansorCO2");
            entity.Property(e => e.SensorCo2ambiant).HasColumnName("SensorCO2Ambiant");
            entity.Property(e => e.SensorCo2medical).HasColumnName("SensorCO2Medical");
            entity.Property(e => e.SensorNo).HasColumnName("SensorNO");
            entity.Property(e => e.SensorNo2).HasColumnName("SensorNO2");
            entity.Property(e => e.SensorSo2).HasColumnName("SensorSO2");
            entity.Property(e => e.So2alarm).HasColumnName("SO2Alarm");
            entity.Property(e => e.So2offAlarm).HasColumnName("SO2OffAlarm");
            entity.Property(e => e.TachographData).HasMaxLength(50);
            entity.Property(e => e.Temperature0).HasDefaultValue((short)-32768);
            entity.Property(e => e.TrapBekoProblemA).HasColumnName("trapBekoProblemA");
            entity.Property(e => e.TrapBekoProblemB).HasColumnName("trapBekoProblemB");
            entity.Property(e => e.TrapBekoProblemC).HasColumnName("trapBekoProblemC");
            entity.Property(e => e.TrapBekoProblemD).HasColumnName("trapBekoProblemD");
            entity.Property(e => e.VacuostatPsXalarm).HasColumnName("VacuostatPsXAlarm");
            entity.Property(e => e.VacuostatPsYalarm).HasColumnName("VacuostatPsYAlarm");
            entity.Property(e => e.VehiculeWeight).HasMaxLength(50);
            entity.Property(e => e.Voie1).HasColumnName("voie1");
            entity.Property(e => e.Voie2).HasColumnName("voie2");
            entity.Property(e => e.Voie3).HasColumnName("voie3");
            entity.Property(e => e.Voie4).HasColumnName("voie4");
            entity.Property(e => e.Voie5).HasColumnName("voie5");
            entity.Property(e => e.Voie6).HasColumnName("voie6");
            entity.Property(e => e.Voie7).HasColumnName("voie7");
        });

        modelBuilder.Entity<Gqequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GQEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AuthorizedNumberForSilentCall)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.FirmwareVersion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.HardwareConfigForQl).HasColumnName("HardwareConfigForQL");
            entity.Property(e => e.MaxFuelVoltageLevelMv).HasColumnName("MaxFuelVoltageLevelMV");
            entity.Property(e => e.MinFuelVoltageLevelMv).HasColumnName("MinFuelVoltageLevelMV");
            entity.Property(e => e.PrimaryServerIp)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Grequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GREquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AdcAboveOrBelow).HasColumnName("ADC_AboveOrBelow");
            entity.Property(e => e.AdcInputDelay).HasColumnName("ADC_InputDelay");
            entity.Property(e => e.AdcInputTriggerLevel).HasColumnName("ADC_InputTriggerLevel");

            entity.HasOne(d => d.SerialNumberNavigation).WithOne(p => p.Grequipment)
                .HasForeignKey<Grequipment>(d => d.SerialNumber)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GREquipment_Equipment1");
        });

        modelBuilder.Entity<Gsequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GSEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.MobileName)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Sim1number)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS")
                .HasColumnName("SIM1Number");
            entity.Property(e => e.Sim2number)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS")
                .HasColumnName("SIM2Number");
        });

        modelBuilder.Entity<Gstdequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber).HasName("PK_GTSDEquipment");

            entity.ToTable("GSTDEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Gtequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GTEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.CallNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Rpmthreshold).HasColumnName("RPMThreshold");
        });

        modelBuilder.Entity<Gtftequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GTFTEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Gxequipment>(entity =>
        {
            entity.HasKey(e => e.SerialNumber);

            entity.ToTable("GXEquipment");

            entity.Property(e => e.SerialNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ServerIp)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS")
                .HasColumnName("ServerIP");
        });

        modelBuilder.Entity<Hc>(entity =>
        {
            entity.ToTable("HCS");

            entity.Property(e => e.Id)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Dblogin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("DBLogin");
            entity.Property(e => e.Dbname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("DBName");
            entity.Property(e => e.Dbpassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("DBPassword");
            entity.Property(e => e.Dbserver)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("DBServer");
            entity.Property(e => e.FirstExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.Hcsaddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("HCSAddress");
            entity.Property(e => e.Hcsport).HasColumnName("HCSPort");
            entity.Property(e => e.HcstoHslastExecutionDate)
                .HasColumnType("datetime")
                .HasColumnName("HCSToHSLastExecutionDate");
            entity.Property(e => e.LastExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.MachineName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TnvAddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Intervention>(entity =>
        {
            entity.ToTable("Intervention");

            entity.Property(e => e.DateIntervetion).HasColumnType("datetime");
            entity.Property(e => e.FixedBy)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Panne)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PanneDescr)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Ioelement>(entity =>
        {
            entity.ToTable("IOElement");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.IoelementProp).HasColumnName("IOElementProp");
        });

        modelBuilder.Entity<Line>(entity =>
        {
            entity.ToTable("Line");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Localite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Localite");

            entity.Property(e => e.LatLoc).HasColumnName("latLoc");
            entity.Property(e => e.LonLoc).HasColumnName("lonLoc");
            entity.Property(e => e.NomLoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Mail>(entity =>
        {
            entity.Property(e => e.MailAdress)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<MailConfig>(entity =>
        {
            entity.ToTable("MailConfig");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Maintenance>(entity =>
        {
            entity.ToTable("Maintenance");

            entity.Property(e => e.BeginStartRecurringDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("BeginStartRecurringDateGMT");
            entity.Property(e => e.EnableGenerateAlertByWt).HasColumnName("EnableGenerateAlertByWT");
            entity.Property(e => e.ExpiryDateGmtforExernApp)
                .HasColumnType("datetime")
                .HasColumnName("ExpiryDateGMTForExernApp");
            entity.Property(e => e.ExpiryDateGmtforWt)
                .HasColumnType("datetime")
                .HasColumnName("ExpiryDateGMTForWT");
            entity.Property(e => e.LastConfirmedAlertByWtgmt)
                .HasColumnType("datetime")
                .HasColumnName("LastConfirmedAlertByWTGMT");
            entity.Property(e => e.LastDueDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastDueDateGMT");
            entity.Property(e => e.LastGenerateAlertByExternAppGmt)
                .HasColumnType("datetime")
                .HasColumnName("LastGenerateAlertByExternAppGMT");
            entity.Property(e => e.MaintenanceDate).HasColumnType("datetime");
            entity.Property(e => e.NextWarnedDueMileageForWt).HasColumnName("NextWarnedDueMileageForWT");
            entity.Property(e => e.WarnMeBeforeNdayKm).HasColumnName("WarnMeBeforeNDayKm");
        });

        modelBuilder.Entity<Map>(entity =>
        {
            entity.ToTable("Map");

            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Message>(entity =>
        {
            entity.ToTable("Message");

            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.MessageText)
                .HasMaxLength(100)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ReceivedOrSent)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SentTime).HasColumnType("datetime");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.Messages)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Message_Equipment");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.ProductVersion).HasMaxLength(32);
        });

        modelBuilder.Entity<Mission>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Mission1");

            entity.ToTable("Mission");

            entity.HasIndex(e => new { e.DriverCode, e.AcquisitionTime }, "IX_MissionDriverCodeAcquisi").IsUnique();

            entity.HasIndex(e => new { e.Equipment, e.AcquisitionTime }, "IX_MissionEquipAcquisi").IsUnique();

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.DriverCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.Missions)
                .HasForeignKey(d => d.Equipment)
                .HasConstraintName("FK_Mission1_Equipment");
        });

        modelBuilder.Entity<MissionDef>(entity =>
        {
            entity.HasKey(e => new { e.Customer, e.MissionCode }).HasName("PK_MissionDef_1");

            entity.ToTable("MissionDef");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<MissionOrder>(entity =>
        {
            entity.ToTable("MissionOrder");

            entity.Property(e => e.EnableGenerateAlertByWt).HasColumnName("EnableGenerateAlertByWT");
            entity.Property(e => e.EnableGenerateAlertPayementExpiredByWt).HasColumnName("EnableGenerateAlertPayementExpiredByWT");
            entity.Property(e => e.EndMissionDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("EndMissionDateGMT");
            entity.Property(e => e.MissionDescription)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumberStr)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PlaceEndDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("PlaceEndDateGMT");
            entity.Property(e => e.PlaceStartDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("PlaceStartDateGMT");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.StartMissionDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("StartMissionDateGMT");
        });

        modelBuilder.Entity<MonthlyStatsticDatum>(entity =>
        {
            entity.HasKey(e => new { e.Month, e.Year, e.Equipment }).HasName("PK_MonthlyStatisticData");

            entity.HasIndex(e => new { e.Equipment, e.Month, e.Year }, "IX_MonthlyStatsticData");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TotalReceivedBytesFromServer).HasDefaultValue(0);
        });

        modelBuilder.Entity<NvalidGpsdatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_GPSData1");

            entity.ToTable("NValidGPSData");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.AdcVoltage).HasColumnName("ADC_Voltage");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Gpslevel).HasColumnName("GPSLevel");
            entity.Property(e => e.Gsmlevel).HasColumnName("GSMLevel");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.OriginalEquipment)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Rpm).HasColumnName("RPM");
            entity.Property(e => e.TachographData)
                .HasMaxLength(250)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TemperatureI).HasDefaultValueSql("('-32768')");
            entity.Property(e => e.VehiculeWeight)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Offer>(entity =>
        {
            entity.ToTable("Offer");

            entity.Property(e => e.ApprobationReference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Details)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Object)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SaveDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<OutOfCountryDateW>(entity =>
        {
            entity.HasKey(e => e.Equipment).HasName("PK2_OutOfCountryDate");

            entity.ToTable("OutOfCountryDateW");

            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DateOfLastOutOfCountry).HasColumnType("datetime");
        });

        modelBuilder.Entity<PersonneGp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Personne_gps");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.FixTelphoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.MobileTelephoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.PersonneGp)
                .HasForeignKey<PersonneGp>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PersonneGps_TrackingTarget");
        });

        modelBuilder.Entity<Place>(entity =>
        {
            entity.ToTable("Place");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.AccountNavigation).WithMany(p => p.Places)
                .HasForeignKey(d => d.Account)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Place_Account");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Place)
                .HasForeignKey<Place>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Place_StandardPlace");
        });

        modelBuilder.Entity<Place3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Place3");

            entity.Property(e => e.Account)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.PlaceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SymbolPath)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<PlannedMission>(entity =>
        {
            entity.ToTable("PlannedMission");

            entity.Property(e => e.BeginMissionEstimatedDateGmt).HasColumnType("datetime");
            entity.Property(e => e.BeginMissionRealDateGmt).HasColumnType("datetime");
            entity.Property(e => e.MaxEndMissionDateGmt).HasColumnType("datetime");
            entity.Property(e => e.NumberStr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Purpose)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.StartingEstimatedDateGmt).HasColumnType("datetime");
            entity.Property(e => e.StartingRealDateGmt).HasColumnType("datetime");
        });

        modelBuilder.Entity<PlannedStation>(entity =>
        {
            entity.ToTable("PlannedStation");

            entity.Property(e => e.ArrivalDate).HasColumnType("datetime");
            entity.Property(e => e.DepartureDate).HasColumnType("datetime");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.RecurrenceInfo)
                .UseCollation("French_CI_AS")
                .HasColumnType("ntext");
        });

        modelBuilder.Entity<Point>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WayPoint");

            entity.ToTable("Point");

            entity.HasOne(d => d.GeometricShapeNavigation).WithMany(p => p.Points)
                .HasForeignKey(d => d.GeometricShape)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WayPoint_GeometricShape");
        });

        modelBuilder.Entity<Polygon>(entity =>
        {
            entity.ToTable("Polygon");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Polygon)
                .HasForeignKey<Polygon>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Polygon_GeometricShape");
        });

        modelBuilder.Entity<PreviousPassword>(entity =>
        {
            entity.HasKey(e => new { e.PasswordHash, e.UserId }).HasName("PK_dbo.PreviousPasswords");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.PasswordHash).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.PreviousPasswords)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.PreviousPasswords_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<ProblemResolved>(entity =>
        {
            entity.ToTable("ProblemResolved");

            entity.Property(e => e.DateSave).HasColumnType("datetime");
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Value).UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<QueryState>(entity =>
        {
            entity.ToTable("QueryState");

            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<QueryStatus>(entity =>
        {
            entity.ToTable("QueryStatus");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<QueryType>(entity =>
        {
            entity.ToTable("QueryType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<RecordType>(entity =>
        {
            entity.ToTable("RecordType");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Refresh>(entity =>
        {
            entity.HasKey(e => e.Equipment);

            entity.ToTable("Refresh");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AccelerationPosition).HasDefaultValue(0);
            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.AdcVoltage)
                .HasDefaultValue(0)
                .HasColumnName("ADC_Voltage");
            entity.Property(e => e.AxleIndex).HasDefaultValue(0);
            entity.Property(e => e.AxleWeight).HasDefaultValue(0);
            entity.Property(e => e.BottleHpa).HasColumnName("BottleHPA");
            entity.Property(e => e.BoxTemp).HasColumnName("boxTemp");
            entity.Property(e => e.C1aoffAlarm).HasColumnName("C1AOffAlarm");
            entity.Property(e => e.C2aoffAlarm).HasColumnName("C2AOffAlarm");
            entity.Property(e => e.C4aoffHpa).HasColumnName("C4AOffHPA");
            entity.Property(e => e.C5aoffHpb).HasColumnName("C5AOffHPB");
            entity.Property(e => e.C6aoffCo2).HasColumnName("C6AOffCO2");
            entity.Property(e => e.C7aoffCo).HasColumnName("C7AOffCO");
            entity.Property(e => e.C8aoff).HasColumnName("C8AOff");
            entity.Property(e => e.C9aoffO2).HasColumnName("C9AOffO2");
            entity.Property(e => e.COexterneAlarm).HasColumnName("cOExterneAlarm");
            entity.Property(e => e.Co2ExterneBalarm).HasColumnName("co2ExterneBAlarm");
            entity.Property(e => e.Co2alarm).HasColumnName("CO2Alarm");
            entity.Property(e => e.Co2sansorAlarm).HasColumnName("CO2SansorAlarm");
            entity.Property(e => e.Coalarm).HasColumnName("COAlarm");
            entity.Property(e => e.CompressorOna).HasColumnName("CompressorONA");
            entity.Property(e => e.CompressorOnb).HasColumnName("CompressorONB");
            entity.Property(e => e.CompressorOnc).HasColumnName("CompressorONC");
            entity.Property(e => e.CompressorOnd).HasColumnName("CompressorOND");
            entity.Property(e => e.CompressorOne).HasColumnName("CompressorONE");
            entity.Property(e => e.CompressorOnf).HasColumnName("CompressorONF");
            entity.Property(e => e.Connected).HasDefaultValue(false);
            entity.Property(e => e.CosansorAlarm).HasColumnName("COSansorAlarm");
            entity.Property(e => e.CutedEnergy).HasColumnName("cutedEnergy");
            entity.Property(e => e.CutedExtensionCard).HasColumnName("cutedExtensionCard");
            entity.Property(e => e.DefautAlimentation).HasColumnName("defautAlimentation");
            entity.Property(e => e.DefautBoutonInhibition).HasColumnName("defautBoutonInhibition");
            entity.Property(e => e.DefautBoutonTest).HasColumnName("defautBoutonTest");
            entity.Property(e => e.DefautBuzzer).HasColumnName("defautBuzzer");
            entity.Property(e => e.DefautCapaciteBuzzer).HasColumnName("defautCapaciteBuzzer");
            entity.Property(e => e.DefautClavierOutil).HasColumnName("defautClavierOutil");
            entity.Property(e => e.DefautCommunicationBoitierBoucle).HasColumnName("defautCommunicationBoitierBoucle");
            entity.Property(e => e.DefautCommunicationBoitierTimeout).HasColumnName("defautCommunicationBoitierTimeout");
            entity.Property(e => e.DefautConvertisseurAnalog).HasColumnName("defautConvertisseurAnalog");
            entity.Property(e => e.DefautHorloge).HasColumnName("defautHorloge");
            entity.Property(e => e.Depassementseuilbasvoie1).HasColumnName("depassementseuilbasvoie1");
            entity.Property(e => e.Depassementseuilbasvoie2).HasColumnName("depassementseuilbasvoie2");
            entity.Property(e => e.Depassementseuilbasvoie3).HasColumnName("depassementseuilbasvoie3");
            entity.Property(e => e.Depassementseuilbasvoie4).HasColumnName("depassementseuilbasvoie4");
            entity.Property(e => e.Depassementseuilbasvoie5).HasColumnName("depassementseuilbasvoie5");
            entity.Property(e => e.Depassementseuilbasvoie6).HasColumnName("depassementseuilbasvoie6");
            entity.Property(e => e.Depassementseuilbasvoie7).HasColumnName("depassementseuilbasvoie7");
            entity.Property(e => e.Depassementseuilhautvoie1).HasColumnName("depassementseuilhautvoie1");
            entity.Property(e => e.Depassementseuilhautvoie2).HasColumnName("depassementseuilhautvoie2");
            entity.Property(e => e.Depassementseuilhautvoie3).HasColumnName("depassementseuilhautvoie3");
            entity.Property(e => e.Depassementseuilhautvoie4).HasColumnName("depassementseuilhautvoie4");
            entity.Property(e => e.Depassementseuilhautvoie5).HasColumnName("depassementseuilhautvoie5");
            entity.Property(e => e.Depassementseuilhautvoie6).HasColumnName("depassementseuilhautvoie6");
            entity.Property(e => e.Depassementseuilhautvoie7).HasColumnName("depassementseuilhautvoie7");
            entity.Property(e => e.DriverCode).HasMaxLength(30);
            entity.Property(e => e.EngineHours).HasDefaultValue(0.0);
            entity.Property(e => e.EngineTemperature).HasDefaultValue(-32768);
            entity.Property(e => e.EvflexoPompA).HasColumnName("EVFlexoPompA");
            entity.Property(e => e.EvflexoPompB).HasColumnName("EVFlexoPompB");
            entity.Property(e => e.EvflexoPompC).HasColumnName("EVFlexoPompC");
            entity.Property(e => e.EvflexoPompD).HasColumnName("EVFlexoPompD");
            entity.Property(e => e.EvflexoPompE).HasColumnName("EVFlexoPompE");
            entity.Property(e => e.EvflexoPompF).HasColumnName("EVFlexoPompF");
            entity.Property(e => e.Gpslevel).HasColumnName("GPSLevel");
            entity.Property(e => e.Gsmlevel).HasColumnName("GSMLevel");
            entity.Property(e => e.HighNetworkC2v).HasColumnName("highNetworkC2V");
            entity.Property(e => e.HighTempFaultA).HasColumnName("highTempFaultA");
            entity.Property(e => e.HighTempFaultB).HasColumnName("highTempFaultB");
            entity.Property(e => e.HighTempFaultC).HasColumnName("highTempFaultC");
            entity.Property(e => e.HighTempFaultD).HasColumnName("highTempFaultD");
            entity.Property(e => e.HighTempFaultE).HasColumnName("highTempFaultE");
            entity.Property(e => e.HighTempFaultF).HasColumnName("highTempFaultF");
            entity.Property(e => e.HighTemperatureAlarm).HasColumnName("highTemperatureAlarm");
            entity.Property(e => e.HighVoltage).HasColumnName("highVoltage");
            entity.Property(e => e.HightLocalTemp).HasColumnName("hightLocalTemp");
            entity.Property(e => e.HightNetworkBar5).HasColumnName("hightNetworkBar5");
            entity.Property(e => e.HightNetworkBar9).HasColumnName("hightNetworkBar9");
            entity.Property(e => e.HightNetworkPressureBar5).HasColumnName("hightNetworkPressureBar5");
            entity.Property(e => e.HightNetworkPressureBar9).HasColumnName("hightNetworkPressureBar9");
            entity.Property(e => e.HightO2airAmbiant).HasColumnName("hightO2AirAmbiant");
            entity.Property(e => e.HightO2airMedical).HasColumnName("hightO2AirMedical");
            entity.Property(e => e.Hpaalarm).HasColumnName("HPAAlarm");
            entity.Property(e => e.Hpbalarm).HasColumnName("HPBAlarm");
            entity.Property(e => e.HsboxTempSansor).HasColumnName("HSBoxTempSansor");
            entity.Property(e => e.Hygrometry).HasColumnName("hygrometry");
            entity.Property(e => e.HygrometryLineA).HasColumnName("hygrometryLineA");
            entity.Property(e => e.HygrometryLineB).HasColumnName("hygrometryLineB");
            entity.Property(e => e.HygrometryLineC).HasColumnName("hygrometryLineC");
            entity.Property(e => e.HygrometryLineD).HasColumnName("hygrometryLineD");
            entity.Property(e => e.InputAuboosterHp).HasColumnName("inputAUBoosterHp");
            entity.Property(e => e.InputBekoFaultA).HasColumnName("inputBekoFaultA");
            entity.Property(e => e.InputBekoFaultB).HasColumnName("inputBekoFaultB");
            entity.Property(e => e.InputBekoFaultC).HasColumnName("inputBekoFaultC");
            entity.Property(e => e.InputBekoFaultD).HasColumnName("inputBekoFaultD");
            entity.Property(e => e.InputDefaultTempDryerA).HasColumnName("inputDefaultTempDryerA");
            entity.Property(e => e.InputDefaultTempDryerB).HasColumnName("inputDefaultTempDryerB");
            entity.Property(e => e.InputDefaultTempDryerC).HasColumnName("inputDefaultTempDryerC");
            entity.Property(e => e.InputDefaultTempDryerD).HasColumnName("inputDefaultTempDryerD");
            entity.Property(e => e.InputExternalCo2fault).HasColumnName("inputExternalCO2Fault");
            entity.Property(e => e.InputExternalCofault).HasColumnName("inputExternalCOFault");
            entity.Property(e => e.InputMaboosterHp).HasColumnName("inputMABoosterHp");
            entity.Property(e => e.InputPca).HasColumnName("InputPCA");
            entity.Property(e => e.IsKeepAlive).HasDefaultValue(false);
            entity.Property(e => e.LastAlertType).HasDefaultValue(-1);
            entity.Property(e => e.LowLocalTemp).HasColumnName("lowLocalTemp");
            entity.Property(e => e.LowNetworkBar5).HasColumnName("lowNetworkBar5");
            entity.Property(e => e.LowNetworkBar9).HasColumnName("lowNetworkBar9");
            entity.Property(e => e.LowNetworkC2v).HasColumnName("lowNetworkC2V");
            entity.Property(e => e.LowNetworkPressureBar5).HasColumnName("lowNetworkPressureBar5");
            entity.Property(e => e.LowNetworkPressureBar9).HasColumnName("lowNetworkPressureBar9");
            entity.Property(e => e.LowO2airAmbiant).HasColumnName("lowO2AirAmbiant");
            entity.Property(e => e.LowO2airMedical).HasColumnName("lowO2AirMedical");
            entity.Property(e => e.LowTempFaultA).HasColumnName("lowTempFaultA");
            entity.Property(e => e.LowTempFaultB).HasColumnName("lowTempFaultB");
            entity.Property(e => e.LowTempFaultC).HasColumnName("lowTempFaultC");
            entity.Property(e => e.LowTempFaultD).HasColumnName("lowTempFaultD");
            entity.Property(e => e.LowTempFaultE).HasColumnName("lowTempFaultE");
            entity.Property(e => e.LowTempFaultF).HasColumnName("lowTempFaultF");
            entity.Property(e => e.LowTemperatureAlarm).HasColumnName("lowTemperatureAlarm");
            entity.Property(e => e.LowVoltage).HasColumnName("lowVoltage");
            entity.Property(e => e.NOalarm).HasColumnName("nOAlarm");
            entity.Property(e => e.Network5Bar).HasColumnName("network5Bar");
            entity.Property(e => e.No2alarm).HasColumnName("NO2Alarm");
            entity.Property(e => e.No2offAlarm).HasColumnName("NO2OffAlarm");
            entity.Property(e => e.NooffAlarm).HasColumnName("NOOffAlarm");
            entity.Property(e => e.OffScaleC3a).HasColumnName("OffScaleC3A");
            entity.Property(e => e.OilLvlFaultOrAuxa).HasColumnName("OilLvlFaultOrAUXA");
            entity.Property(e => e.OilLvlFaultOrAuxb).HasColumnName("OilLvlFaultOrAUXB");
            entity.Property(e => e.OilLvlFaultOrAuxc).HasColumnName("OilLvlFaultOrAUXC");
            entity.Property(e => e.OtherInfo).HasDefaultValue(0L);
            entity.Property(e => e.PlafonnementAlarm).HasColumnName("plafonnementAlarm");
            entity.Property(e => e.PompAon).HasColumnName("PompAON");
            entity.Property(e => e.PompBon).HasColumnName("PompBON");
            entity.Property(e => e.PompCon).HasColumnName("PompCON");
            entity.Property(e => e.PompDon).HasColumnName("PompDON");
            entity.Property(e => e.PompEon).HasColumnName("PompEON");
            entity.Property(e => e.PompFon).HasColumnName("PompFON");
            entity.Property(e => e.PressureBouteilleAvalue).HasColumnName("PressureBouteilleAValue");
            entity.Property(e => e.PressureBouteilleBvalue).HasColumnName("PressureBouteilleBValue");
            entity.Property(e => e.PressureC1a).HasColumnName("pressureC1A");
            entity.Property(e => e.PressureC1v).HasColumnName("pressureC1V");
            entity.Property(e => e.PressureC2a).HasColumnName("pressureC2A");
            entity.Property(e => e.PressureC2v).HasColumnName("pressureC2V");
            entity.Property(e => e.PressureC3a).HasColumnName("PressureC3A");
            entity.Property(e => e.PressureC4a).HasColumnName("pressureC4A");
            entity.Property(e => e.PressureC5a).HasColumnName("pressureC5A");
            entity.Property(e => e.ReturnCompressorOna).HasColumnName("returnCompressorONA");
            entity.Property(e => e.ReturnCompressorOnb).HasColumnName("returnCompressorONB");
            entity.Property(e => e.ReturnCompressorOnc).HasColumnName("returnCompressorONC");
            entity.Property(e => e.ReturnCompressorOnd).HasColumnName("returnCompressorOND");
            entity.Property(e => e.ReturnCompressorOne).HasColumnName("ReturnCompressorONE");
            entity.Property(e => e.ReturnCompressorOnf).HasColumnName("ReturnCompressorONF");
            entity.Property(e => e.RotationDefaultCompressorXy).HasColumnName("RotationDefaultCompressorXY");
            entity.Property(e => e.Rpm)
                .HasDefaultValue(0)
                .HasColumnName("RPM");
            entity.Property(e => e.S1aoffHygromtry).HasColumnName("S1AOffHygromtry");
            entity.Property(e => e.SansorCo).HasColumnName("sansorCO");
            entity.Property(e => e.SansorCo2).HasColumnName("sansorCO2");
            entity.Property(e => e.SensorCo2ambiant).HasColumnName("SensorCO2Ambiant");
            entity.Property(e => e.SensorCo2medical).HasColumnName("SensorCO2Medical");
            entity.Property(e => e.SensorNo).HasColumnName("SensorNO");
            entity.Property(e => e.SensorNo2).HasColumnName("SensorNO2");
            entity.Property(e => e.SensorSo2).HasColumnName("SensorSO2");
            entity.Property(e => e.So2alarm).HasColumnName("SO2Alarm");
            entity.Property(e => e.So2offAlarm).HasColumnName("SO2OffAlarm");
            entity.Property(e => e.TachographData)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TempMileage).HasDefaultValue(0.0);
            entity.Property(e => e.TotalFuel).HasDefaultValue(0.0);
            entity.Property(e => e.TotalReceivedBytesFromServer).HasDefaultValue(0);
            entity.Property(e => e.TotalSendBytes).HasDefaultValue(0);
            entity.Property(e => e.TrapBekoProblemA).HasColumnName("trapBekoProblemA");
            entity.Property(e => e.TrapBekoProblemB).HasColumnName("trapBekoProblemB");
            entity.Property(e => e.TrapBekoProblemC).HasColumnName("trapBekoProblemC");
            entity.Property(e => e.TrapBekoProblemD).HasColumnName("trapBekoProblemD");
            entity.Property(e => e.TripLot).HasDefaultValue(0L);
            entity.Property(e => e.VacuostatPsXalarm).HasColumnName("VacuostatPsXAlarm");
            entity.Property(e => e.VacuostatPsYalarm).HasColumnName("VacuostatPsYAlarm");
            entity.Property(e => e.VehiculeWeight)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Voie1).HasColumnName("voie1");
            entity.Property(e => e.Voie2).HasColumnName("voie2");
            entity.Property(e => e.Voie3).HasColumnName("voie3");
            entity.Property(e => e.Voie4).HasColumnName("voie4");
            entity.Property(e => e.Voie5).HasColumnName("voie5");
            entity.Property(e => e.Voie6).HasColumnName("voie6");
            entity.Property(e => e.Voie7).HasColumnName("voie7");
        });

        modelBuilder.Entity<RefreshStatisticDatum>(entity =>
        {
            entity.HasKey(e => e.Equipment);

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.BeginStatisticDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<RepairMaintenanceLog>(entity =>
        {
            entity.ToTable("RepairMaintenanceLog");

            entity.Property(e => e.DateCompletionGmt)
                .HasColumnType("datetime")
                .HasColumnName("DateCompletionGMT");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.InvoiceReference)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PaidDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("PaidDateGMT");
            entity.Property(e => e.Supplier)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Requête>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Requête");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.AdcVoltage).HasColumnName("ADC_Voltage");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<ServerQuery>(entity =>
        {
            entity.ToTable("ServerQuery");

            entity.HasIndex(e => new { e.Equipment, e.QueryState, e.QueryType }, "IX_ServerQuery");

            entity.Property(e => e.Csport).HasColumnName("CSPort");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Hcsname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("HCSName");
            entity.Property(e => e.Param1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Param2)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Param3)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Param4)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Param5)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Param6)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PostingTime).HasColumnType("datetime");
            entity.Property(e => e.ResponseMessage)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SenderId)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Smsconfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SMSConfig_1");

            entity.ToTable("SMSConfig");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<SmsmailChange>(entity =>
        {
            entity.ToTable("SMSMailChange");

            entity.Property(e => e.PostingTime).HasColumnType("datetime");
            entity.Property(e => e.SmsmailConfig).HasColumnName("SMSMailConfig");
        });

        modelBuilder.Entity<SmsmailConfig>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SMSConfig");

            entity.ToTable("SMSMailConfig");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SendOrNot)
                .IsRequired()
                .HasDefaultValueSql("('0')");

            entity.HasMany(d => d.Mail).WithMany(p => p.SmsmailConfigs)
                .UsingEntity<Dictionary<string, object>>(
                    "SmsmailConfigMail",
                    r => r.HasOne<Mail>().WithMany()
                        .HasForeignKey("Mail")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SMSMailCon__Mail__57E03940"),
                    l => l.HasOne<SmsmailConfig>().WithMany()
                        .HasForeignKey("SmsmailConfig")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__SMSMailCo__SMSMa__56EC1507"),
                    j =>
                    {
                        j.HasKey("SmsmailConfig", "Mail").HasName("PK_SMSMailConfig_MAIL_1");
                        j.ToTable("SMSMailConfig_MAIL");
                        j.IndexerProperty<int>("SmsmailConfig").HasColumnName("SMSMailConfig");
                    });

            entity.HasMany(d => d.TelNumbers).WithMany(p => p.SmsmailConfigs)
                .UsingEntity<Dictionary<string, object>>(
                    "SmsmailConfigTellNumber",
                    r => r.HasOne<TelNumber>().WithMany()
                        .HasForeignKey("TelNumber")
                        .HasConstraintName("FK__SMSMailCo__TelNu__5BB0CA24"),
                    l => l.HasOne<SmsmailConfig>().WithMany()
                        .HasForeignKey("SmsmailConfig")
                        .HasConstraintName("FK__SMSMailCo__SMSMa__5ABCA5EB"),
                    j =>
                    {
                        j.HasKey("SmsmailConfig", "TelNumber");
                        j.ToTable("SMSMailConfig_TellNumber");
                        j.IndexerProperty<int>("SmsmailConfig").HasColumnName("SMSMailConfig");
                    });
        });

        modelBuilder.Entity<SmsstateOfSendingAlert>(entity =>
        {
            entity.ToTable("SMSStateOfSendingAlert");

            entity.HasIndex(e => new { e.Customer, e.SendingTimeGmt, e.TelNumber }, "IX_SMSStateOfSendingAlert");

            entity.HasIndex(e => new { e.Customer, e.SendingTimeGmt, e.TelNumberType, e.State }, "IX_SMSState_Cust_Equ_State_TelType");

            entity.Property(e => e.SendingTimeGmt)
                .HasColumnType("datetime")
                .HasColumnName("SendingTimeGMT");
            entity.Property(e => e.Smscontent)
                .HasMaxLength(200)
                .UseCollation("French_CI_AS")
                .HasColumnName("SMSContent");
            entity.Property(e => e.TelNumberStr)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<StandardPlace>(entity =>
        {
            entity.ToTable("StandardPlace");

            entity.Property(e => e.DelegId).HasColumnName("Deleg_Id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.GovId).HasColumnName("Gov_Id");
            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<StandardPlace1>(entity =>
        {
            entity.ToTable("StandardPlace1");

            entity.Property(e => e.DelegId).HasColumnName("Deleg_Id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.GovId).HasColumnName("Gov_Id");
            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<StandardPlaceBackUp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StandardPlace2");

            entity.ToTable("StandardPlaceBackUp");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.DelegId).HasColumnName("Deleg_Id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.GovId).HasColumnName("Gov_Id");
            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<StatisticAnomaly>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Statistic");

            entity.ToTable("StatisticAnomaly");
        });

        modelBuilder.Entity<StatisticDataold>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StatisticData");

            entity.ToTable("StatisticDataold");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<StatisticDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StatisticData1");

            entity.HasIndex(e => new { e.AcquisitionTime, e.Equipment }, "IX_StatisticData_Acqu_Eq");

            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<StatisticHour>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_StatisticHour_1");

            entity.ToTable("StatisticHour");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.TrackingTargetNavigation).WithMany(p => p.StatisticHours)
                .HasForeignKey(d => d.TrackingTarget)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_StatisticHour_Car");
        });

        modelBuilder.Entity<StatisticsFuelConsumption>(entity =>
        {
            entity.ToTable("StatisticsFuelConsumption");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.MaxFuelLevelDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("MaxFuelLevelDateGMT");
            entity.Property(e => e.MaxTemperatureDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("MaxTemperatureDateGMT");
            entity.Property(e => e.MinFuelLevelDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("MinFuelLevelDateGMT");
            entity.Property(e => e.MinTemperatureDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("MinTemperatureDateGMT");
            entity.Property(e => e.StatisticsDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("StatisticsDateGMT");
        });

        modelBuilder.Entity<StopRun>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Table_2");

            entity.ToTable("StopRun");

            entity.Property(e => e.BeginDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Equipment)
                .HasMaxLength(250)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.TrackingTargetNavigation).WithMany(p => p.StopRuns)
                .HasForeignKey(d => d.TrackingTarget)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Table_2_Car");
        });

        modelBuilder.Entity<Supplier>(entity =>
        {
            entity.ToTable("Supplier");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SaveDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TankFullConsumption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TankFullConception_1");

            entity.ToTable("TankFullConsumption");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TankLog>(entity =>
        {
            entity.ToTable("TankLog");

            entity.Property(e => e.OperationDateGmt)
                .HasColumnType("datetime")
                .HasColumnName("OperationDateGMT");
        });

        modelBuilder.Entity<TankPump>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Tank");

            entity.ToTable("TankPump");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NameProduct)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.NameVoie1)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameVoie2)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameVoie3)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameVoie4)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameVoie5)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameVoie6)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NameVoie7)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PeriodOfDistribution)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PeriodOfOperation)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceTank).HasMaxLength(50);
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TelNumber>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TelNumbers");

            entity.ToTable("TelNumber");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Tel)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<TelTonikaBuscandatum>(entity =>
        {
            entity.ToTable("TelTonikaBUSCANData");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EngineRpm).HasColumnName("EngineRPM");
        });

        modelBuilder.Entity<TempRefresh>(entity =>
        {
            entity.HasKey(e => e.Equipment);

            entity.ToTable("TempRefresh");

            entity.Property(e => e.Equipment)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AcquisitionTime).HasColumnType("datetime");
            entity.Property(e => e.AdcVoltage).HasColumnName("ADC_Voltage");
        });

        modelBuilder.Entity<TestWithError>(entity =>
        {
            entity.ToTable("TestWithError");

            entity.Property(e => e.CorrectedValue).UseCollation("French_CI_AS");
            entity.Property(e => e.DataEquipment).UseCollation("French_CI_AS");
            entity.Property(e => e.DataInBase).UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.InvalidData).UseCollation("French_CI_AS");
            entity.Property(e => e.SavedDate).HasColumnType("datetime");
            entity.Property(e => e.ShowType).UseCollation("French_CI_AS");
            entity.Property(e => e.StandardValue).UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<TestWithoutError>(entity =>
        {
            entity.ToTable("TestWithoutError");

            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SavedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Domain.models.TimeZone>(entity =>
        {
            entity.HasKey(e => e.Name);

            entity.ToTable("TimeZone");

            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Period)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<TrackingMode>(entity =>
        {
            entity.ToTable("TrackingMode");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<TrackingTarget>(entity =>
        {
            entity.ToTable("TrackingTarget");

            entity.Property(e => e.Icon)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TrajectoryHexColor)
                .HasMaxLength(8)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.VisitingCustomerParam).UseCollation("French_CI_AS");

            entity.HasOne(d => d.DepartmentNavigation).WithMany(p => p.TrackingTargets)
                .HasForeignKey(d => d.Department)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TrackingTarget_Department");
        });

        modelBuilder.Entity<Trip>(entity =>
        {
            entity.ToTable("Trip");

            entity.Property(e => e.DestinationName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.GpFixedMovingDistance).HasColumnName("GP_FixedMovingDistance");
            entity.Property(e => e.GpStopTrackingPeriod).HasColumnName("GP_StopTrackingPeriod");
            entity.Property(e => e.GrOfflineTrackingPeriod).HasColumnName("GR_OfflineTrackingPeriod");
            entity.Property(e => e.Mission)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PrimaryEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.PrimaryStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.RealEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.RealStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.SourceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((1))")
                .UseCollation("French_CI_AS");

            entity.HasOne(d => d.DriverNavigation).WithMany(p => p.Trips)
                .HasForeignKey(d => d.Driver)
                .HasConstraintName("FK_Trip_Driver");

            entity.HasOne(d => d.EquipmentNavigation).WithMany(p => p.Trips)
                .HasForeignKey(d => d.Equipment)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trip_Equipment1");

            entity.HasOne(d => d.GeometricShapeNavigation).WithMany(p => p.Trips)
                .HasForeignKey(d => d.GeometricShape)
                .HasConstraintName("FK_Trip_GeometricShape");

            entity.HasOne(d => d.TrackingTargetNavigation).WithMany(p => p.Trips)
                .HasForeignKey(d => d.TrackingTarget)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Trip_Equipment");
        });

        modelBuilder.Entity<TripOfCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TripOfCustomer");

            entity.Property(e => e.DestinationName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Equipment)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.GpFixedMovingDistance).HasColumnName("GP_FixedMovingDistance");
            entity.Property(e => e.GpStopTrackingPeriod).HasColumnName("GP_StopTrackingPeriod");
            entity.Property(e => e.GrOfflineTrackingPeriod).HasColumnName("GR_OfflineTrackingPeriod");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Mission)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PrimaryEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.PrimaryStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.RealEndDateTime).HasColumnType("datetime");
            entity.Property(e => e.RealStartDateTime).HasColumnType("datetime");
            entity.Property(e => e.SourceName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Way>(entity =>
        {
            entity.ToTable("Way");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Way)
                .HasForeignKey<Way>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Way_GeometricShape");
        });

        modelBuilder.Entity<Wt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_WTId");

            entity.ToTable("WT");

            entity.Property(e => e.Id)
                .HasMaxLength(500)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Dblogin)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("DBLogin");
            entity.Property(e => e.Dbname)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("DBName");
            entity.Property(e => e.Dbpassword)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("DBPassword");
            entity.Property(e => e.Dbserver)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("DBServer");
            entity.Property(e => e.FirstExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.Hcsaddress)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("HCSAddress");
            entity.Property(e => e.Hcsport).HasColumnName("HCSPort");
            entity.Property(e => e.LastExecutionDate).HasColumnType("datetime");
            entity.Property(e => e.MachineName)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .IsUnicode(false)
                .UseCollation("French_CI_AS");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
