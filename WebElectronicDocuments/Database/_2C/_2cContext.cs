using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebElectronicDocuments.Database._2C
{
    public partial class _2cContext : DbContext
    {
        public _2cContext()
        {
        }

        public _2cContext(DbContextOptions<_2cContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccMails> AccMails { get; set; }
        public virtual DbSet<ActFull> ActFull { get; set; }
        public virtual DbSet<Acts> Acts { get; set; }
        public virtual DbSet<ActsAcceptance> ActsAcceptance { get; set; }
        public virtual DbSet<AdvanStatement> AdvanStatement { get; set; }
        public virtual DbSet<AdvanStatementUser> AdvanStatementUser { get; set; }
        public virtual DbSet<Attestations> Attestations { get; set; }
        public virtual DbSet<AvCalcfaks> AvCalcfaks { get; set; }
        public virtual DbSet<Branches> Branches { get; set; }
        public virtual DbSet<BufferEmailList> BufferEmailList { get; set; }
        public virtual DbSet<CalPlan> CalPlan { get; set; }
        public virtual DbSet<CalcSmeta> CalcSmeta { get; set; }
        public virtual DbSet<CalcfakToPaydoc> CalcfakToPaydoc { get; set; }
        public virtual DbSet<Calcfaks> Calcfaks { get; set; }
        public virtual DbSet<CalcfaksFull> CalcfaksFull { get; set; }
        public virtual DbSet<CalculationFulls> CalculationFulls { get; set; }
        public virtual DbSet<Calculations> Calculations { get; set; }
        public virtual DbSet<CashboxWorkerTocontrolUsers> CashboxWorkerTocontrolUsers { get; set; }
        public virtual DbSet<CashboxWorkers> CashboxWorkers { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }
        public virtual DbSet<ContractToWorkTypes> ContractToWorkTypes { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<Contracts2stages> Contracts2stages { get; set; }
        public virtual DbSet<Contracts2workSubject> Contracts2workSubject { get; set; }
        public virtual DbSet<Control> Control { get; set; }
        public virtual DbSet<ControlUserGroups> ControlUserGroups { get; set; }
        public virtual DbSet<ControlUsers> ControlUsers { get; set; }
        public virtual DbSet<Countrys> Countrys { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<DecodingSalaries> DecodingSalaries { get; set; }
        public virtual DbSet<DocsToCalplan> DocsToCalplan { get; set; }
        public virtual DbSet<DocsToDepartament> DocsToDepartament { get; set; }
        public virtual DbSet<DocsToIspolnitel> DocsToIspolnitel { get; set; }
        public virtual DbSet<DogToKp> DogToKp { get; set; }
        public virtual DbSet<Executors> Executors { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<HistoryOfIspol> HistoryOfIspol { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<KonechUser> KonechUser { get; set; }
        public virtual DbSet<License> License { get; set; }
        public virtual DbSet<License2modules> License2modules { get; set; }
        public virtual DbSet<Metodika> Metodika { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Naks> Naks { get; set; }
        public virtual DbSet<NaksFull> NaksFull { get; set; }
        public virtual DbSet<OldContracts> OldContracts { get; set; }
        public virtual DbSet<OtchetDocTypes> OtchetDocTypes { get; set; }
        public virtual DbSet<Outlays> Outlays { get; set; }
        public virtual DbSet<OutlaysSumm> OutlaysSumm { get; set; }
        public virtual DbSet<PathToFile> PathToFile { get; set; }
        public virtual DbSet<Paydocs> Paydocs { get; set; }
        public virtual DbSet<ProcessingOfRecord> ProcessingOfRecord { get; set; }
        public virtual DbSet<ProcessingOfWork> ProcessingOfWork { get; set; }
        public virtual DbSet<ProtocolRaz> ProtocolRaz { get; set; }
        public virtual DbSet<ProtocolUrelRaz> ProtocolUrelRaz { get; set; }
        public virtual DbSet<RasCalcSmeta> RasCalcSmeta { get; set; }
        public virtual DbSet<RegDocs> RegDocs { get; set; }
        public virtual DbSet<RegMailInput> RegMailInput { get; set; }
        public virtual DbSet<RegMailOutput> RegMailOutput { get; set; }
        public virtual DbSet<RegMailPostOffice> RegMailPostOffice { get; set; }
        public virtual DbSet<RegTypes> RegTypes { get; set; }
        public virtual DbSet<RegisteredMailTariff> RegisteredMailTariff { get; set; }
        public virtual DbSet<Signatures> Signatures { get; set; }
        public virtual DbSet<Signers> Signers { get; set; }
        public virtual DbSet<Standards> Standards { get; set; }
        public virtual DbSet<SupplementaryAgreement> SupplementaryAgreement { get; set; }
        public virtual DbSet<SupplementaryAgreementContext> SupplementaryAgreementContext { get; set; }
        public virtual DbSet<Test> Test { get; set; }
        public virtual DbSet<Trips> Trips { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsualMailPostOffice> UsualMailPostOffice { get; set; }
        public virtual DbSet<UsualMailTariff> UsualMailTariff { get; set; }
        public virtual DbSet<Wages> Wages { get; set; }
        public virtual DbSet<WorkSubjects> WorkSubjects { get; set; }
        public virtual DbSet<WorkTypes> WorkTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=KHARISOV\\SQLEXPRESS02;Database=2c;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccMails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acc_mails");

                entity.Property(e => e.AccMailActs).HasColumnName("acc_mail_acts");

                entity.Property(e => e.AccMailActsGet).HasColumnName("acc_mail_acts_get");

                entity.Property(e => e.AccMailAvansShetFak).HasColumnName("acc_mail_avans_shet_fak");

                entity.Property(e => e.AccMailCalcs).HasColumnName("acc_mail_calcs");

                entity.Property(e => e.AccMailContactName)
                    .HasColumnName("acc_mail_contact_name")
                    .HasMaxLength(250);

                entity.Property(e => e.AccMailContactNamePhone)
                    .HasColumnName("acc_mail_contact_name_phone")
                    .HasMaxLength(250);

                entity.Property(e => e.AccMailContractId)
                    .HasColumnName("acc_mail_contract_id")
                    .HasMaxLength(50);

                entity.Property(e => e.AccMailCustomer).HasColumnName("acc_mail_customer");

                entity.Property(e => e.AccMailDate)
                    .HasColumnName("acc_mail_date")
                    .HasMaxLength(50);

                entity.Property(e => e.AccMailDogs).HasColumnName("acc_mail_dogs");

                entity.Property(e => e.AccMailDogsGet).HasColumnName("acc_mail_dogs_get");

                entity.Property(e => e.AccMailDopText).HasColumnName("acc_mail_dop_text");

                entity.Property(e => e.AccMailDopTextGet).HasColumnName("acc_mail_dop_text_get");

                entity.Property(e => e.AccMailId)
                    .HasColumnName("acc_mail_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AccMailMailNumber)
                    .HasColumnName("acc_mail_mail_number")
                    .HasMaxLength(50);

                entity.Property(e => e.AccMailNaks).HasColumnName("acc_mail_naks");

                entity.Property(e => e.AccMailNaksGet).HasColumnName("acc_mail_naks_get");

                entity.Property(e => e.AccMailPk)
                    .HasColumnName("acc_mail_pk")
                    .HasMaxLength(250);

                entity.Property(e => e.AccMailPostAddress).HasColumnName("acc_mail_post_address");

                entity.Property(e => e.AccMailRegDoc).HasColumnName("acc_mail_reg_doc");

                entity.Property(e => e.AccMailShetFak).HasColumnName("acc_mail_shet_fak");

                entity.Property(e => e.AccMailShortList).HasColumnName("acc_mail_short_list");

                entity.Property(e => e.AccMailType)
                    .HasColumnName("acc_mail_type")
                    .HasMaxLength(250);

                entity.Property(e => e.AccMailWithDanger)
                    .HasColumnName("acc_mail_with_danger")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ActFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("act_full");

                entity.Property(e => e.ActFullActNumber)
                    .HasColumnName("act_full_act_number")
                    .HasMaxLength(50);

                entity.Property(e => e.ActFullContractId)
                    .HasColumnName("act_full_contract_id")
                    .HasMaxLength(50);

                entity.Property(e => e.ActFullId)
                    .HasColumnName("act_full_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActFullName).HasColumnName("act_full_name");

                entity.Property(e => e.ActFullNds)
                    .HasColumnName("act_full_nds")
                    .HasMaxLength(50);

                entity.Property(e => e.ActFullNdsSumm)
                    .HasColumnName("act_full_nds_summ")
                    .HasMaxLength(50);

                entity.Property(e => e.ActFullSumm)
                    .HasColumnName("act_full_summ")
                    .HasMaxLength(50);

                entity.Property(e => e.ActFullSummPlNds)
                    .HasColumnName("act_full_summ_pl_nds")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Acts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("acts");

                entity.Property(e => e.ActDate)
                    .HasColumnName("act_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActId)
                    .HasColumnName("act_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ActIsFull).HasColumnName("act_is_full");

                entity.Property(e => e.ActIspolnitel).HasColumnName("act_ispolnitel");

                entity.Property(e => e.ActNds).HasColumnName("act_nds");

                entity.Property(e => e.ActNdsSumm).HasColumnName("act_nds_summ");

                entity.Property(e => e.ActNote)
                    .HasColumnName("act_note")
                    .HasMaxLength(255);

                entity.Property(e => e.ActNumber).HasColumnName("act_number");

                entity.Property(e => e.ActSumm).HasColumnName("act_summ");

                entity.Property(e => e.ActSummPlusNds).HasColumnName("act_summ_plus_nds");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ExecutorId).HasColumnName("executor_id");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ActsAcceptance>(entity =>
            {
                entity.HasKey(e => e.ActAcceptanceId);

                entity.ToTable("acts_acceptance");

                entity.Property(e => e.ActAcceptanceId).HasColumnName("act_acceptance_id");

                entity.Property(e => e.ActAcceptanceDogId).HasColumnName("act_acceptance_dog_id");

                entity.Property(e => e.ActAcceptanceRegDocNumber)
                    .IsRequired()
                    .HasColumnName("act_acceptance_reg_doc_number");
            });

            modelBuilder.Entity<AdvanStatement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("advan_statement");

                entity.Property(e => e.AdvanStContractId)
                    .HasColumnName("advan_st_contract_id")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStDate)
                    .HasColumnName("advan_st_date")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStDocName).HasColumnName("advan_st_doc_name");

                entity.Property(e => e.AdvanStDopNds)
                    .HasColumnName("advan_st_dop_nds")
                    .HasMaxLength(50);

                entity.Property(e => e.AdvanStId)
                    .HasColumnName("advan_st_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AdvanStNds)
                    .HasColumnName("advan_st_nds")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStNumber)
                    .HasColumnName("advan_st_number")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStSumm)
                    .HasColumnName("advan_st_summ")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStSummAdd)
                    .HasColumnName("advan_st_summ_add")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStSummPlNds)
                    .HasColumnName("advan_st_summ_pl_nds")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanTripId)
                    .HasColumnName("advan_trip_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AdvanStatementUser>(entity =>
            {
                entity.HasKey(e => e.AdvanStUserId);

                entity.ToTable("advan_statement_user");

                entity.Property(e => e.AdvanStUserId).HasColumnName("advan_st_user_id");

                entity.Property(e => e.AdvanStUserContractId).HasColumnName("advan_st_user_contract_id");

                entity.Property(e => e.AdvanStUserDate)
                    .IsRequired()
                    .HasColumnName("advan_st_user_date")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStUserDocName)
                    .IsRequired()
                    .HasColumnName("advan_st_user_doc_name");

                entity.Property(e => e.AdvanStUserMove).HasColumnName("advan_st_user_move");

                entity.Property(e => e.AdvanStUserName)
                    .IsRequired()
                    .HasColumnName("advan_st_user_name");

                entity.Property(e => e.AdvanStUserNds)
                    .IsRequired()
                    .HasColumnName("advan_st_user_nds")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStUserNumber)
                    .IsRequired()
                    .HasColumnName("advan_st_user_number")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStUserSumm)
                    .IsRequired()
                    .HasColumnName("advan_st_user_summ")
                    .HasMaxLength(250);

                entity.Property(e => e.AdvanStUserSummPlNds)
                    .IsRequired()
                    .HasColumnName("advan_st_user_summ_pl_nds")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Attestations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("attestations");

                entity.Property(e => e.AttestationContractId)
                    .HasColumnName("attestation_contract_id")
                    .HasMaxLength(50);

                entity.Property(e => e.AttestationId)
                    .HasColumnName("attestation_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.AttestationP1)
                    .HasColumnName("attestation_p1")
                    .HasMaxLength(250);

                entity.Property(e => e.AttestationP2)
                    .HasColumnName("attestation_p2")
                    .HasMaxLength(250);

                entity.Property(e => e.AttestationP31)
                    .HasColumnName("attestation_p3_1")
                    .HasMaxLength(250);

                entity.Property(e => e.AttestationP32)
                    .HasColumnName("attestation_p3_2")
                    .HasMaxLength(250);

                entity.Property(e => e.AttestationP4)
                    .HasColumnName("attestation_p4")
                    .HasMaxLength(250);

                entity.Property(e => e.AttestationP5)
                    .HasColumnName("attestation_p5")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AttestationP6)
                    .HasColumnName("attestation_p6")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AttestationP7)
                    .HasColumnName("attestation_p7")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AvCalcfaks>(entity =>
            {
                entity.HasKey(e => e.AvCalcfakId);

                entity.ToTable("av_calcfaks");

                entity.Property(e => e.AvCalcfakId).HasColumnName("av_calcfak_id");

                entity.Property(e => e.AvCalcfakDate)
                    .HasColumnName("av_calcfak_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AvCalcfakNds).HasColumnName("av_calcfak_nds");

                entity.Property(e => e.AvCalcfakNote)
                    .IsRequired()
                    .HasColumnName("av_calcfak_note")
                    .HasMaxLength(255);

                entity.Property(e => e.AvCalcfakNumber)
                    .IsRequired()
                    .HasColumnName("av_calcfak_number")
                    .HasMaxLength(50);

                entity.Property(e => e.AvCalcfakPodpisIsp)
                    .IsRequired()
                    .HasColumnName("av_calcfak_podpis_isp")
                    .HasMaxLength(250);

                entity.Property(e => e.AvCalcfakSumm).HasColumnName("av_calcfak_summ");

                entity.Property(e => e.AvCalcfaksNdsSumm).HasColumnName("av_calcfaks_nds_summ");

                entity.Property(e => e.AvCalcfaksSummPlusNds).HasColumnName("av_calcfaks_summ_plus_nds");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ExecutorId).HasColumnName("executor_id");
            });

            modelBuilder.Entity<Branches>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("branches");

                entity.Property(e => e.BranchId)
                    .HasColumnName("branch_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasColumnName("branch_name")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<BufferEmailList>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Email)
                    .HasColumnName("EMail")
                    .HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<CalPlan>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cal_plan");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.DateOfWork).HasColumnName("date_of_work");

                entity.Property(e => e.DocOfWork).HasColumnName("doc_of_work");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IncludedOfWork)
                    .HasColumnName("included_of_work")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NameOfWork).HasColumnName("name_of_work");

                entity.Property(e => e.NumberOfStages).HasColumnName("number_of_stages");

                entity.Property(e => e.SummaOfWork).HasColumnName("summa_of_work");
            });

            modelBuilder.Entity<CalcSmeta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calc_smeta");

                entity.Property(e => e.CalcSmetaId)
                    .HasColumnName("calc_smeta_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CalcSmetaItog).HasColumnName("calc_smeta_itog");

                entity.Property(e => e.CalcSmetaItogNds).HasColumnName("calc_smeta_itog_nds");

                entity.Property(e => e.CalcSmetaNakRashod).HasColumnName("calc_smeta_nak_rashod");

                entity.Property(e => e.CalcSmetaNds).HasColumnName("calc_smeta_nds");

                entity.Property(e => e.CalcSmetaPribol).HasColumnName("calc_smeta_pribol");

                entity.Property(e => e.CalcSmetaRashifrovka).HasColumnName("calc_smeta_rashifrovka");

                entity.Property(e => e.CalcSmetaRashifrovkaWages).HasColumnName("calc_smeta_rashifrovka_wages");

                entity.Property(e => e.CalcSmetaStrachVz).HasColumnName("calc_smeta_strach_vz");

                entity.Property(e => e.CalcSmetaTrip).HasColumnName("calc_smeta_trip");

                entity.Property(e => e.CalcSmetaWorkType).HasColumnName("calc_smeta_work_type");

                entity.Property(e => e.CalcSmetaZarplata).HasColumnName("calc_smeta_zarplata");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");
            });

            modelBuilder.Entity<CalcfakToPaydoc>(entity =>
            {
                entity.ToTable("calcfak_to_paydoc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CalcfakDate)
                    .IsRequired()
                    .HasColumnName("calcfak_date")
                    .HasMaxLength(50);

                entity.Property(e => e.CalcfakId).HasColumnName("calcfak_id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.DocType).HasColumnName("doc_type");

                entity.Property(e => e.PaydocDate)
                    .IsRequired()
                    .HasColumnName("paydoc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.PaydocId)
                    .IsRequired()
                    .HasColumnName("paydoc_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Calcfaks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calcfaks");

                entity.Property(e => e.CalcfakDate)
                    .HasColumnName("calcfak_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalcfakId)
                    .HasColumnName("calcfak_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CalcfakIsFull).HasColumnName("calcfak_is_full");

                entity.Property(e => e.CalcfakNds).HasColumnName("calcfak_nds");

                entity.Property(e => e.CalcfakNote)
                    .HasColumnName("calcfak_note")
                    .HasMaxLength(255);

                entity.Property(e => e.CalcfakNumber).HasColumnName("calcfak_number");

                entity.Property(e => e.CalcfakPodpisIsp)
                    .HasColumnName("calcfak_podpis_isp")
                    .HasMaxLength(250);

                entity.Property(e => e.CalcfakSumm).HasColumnName("calcfak_summ");

                entity.Property(e => e.CalcfaksNdsSumm).HasColumnName("calcfaks_nds_summ");

                entity.Property(e => e.CalcfaksShortText).HasColumnName("calcfaks_short_text");

                entity.Property(e => e.CalcfaksSummPlusNds).HasColumnName("calcfaks_summ_plus_nds");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ExecutorId).HasColumnName("executor_id");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<CalcfaksFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calcfaks_full");

                entity.Property(e => e.CalcfaksFullCalcfaksNumber)
                    .IsRequired()
                    .HasColumnName("calcfaks_full_calcfaks_number")
                    .HasMaxLength(50);

                entity.Property(e => e.CalcfaksFullCount)
                    .HasColumnName("calcfaks_full_count")
                    .HasMaxLength(250);

                entity.Property(e => e.CalcfaksFullId)
                    .HasColumnName("calcfaks_full_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CalcfaksFullName).HasColumnName("calcfaks_full_name");

                entity.Property(e => e.CalcfaksFullObz)
                    .HasColumnName("calcfaks_full_obz")
                    .HasMaxLength(250);

                entity.Property(e => e.CalcfaksFullPrice)
                    .HasColumnName("calcfaks_full_price")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractId)
                    .IsRequired()
                    .HasColumnName("contract_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CalculationFulls>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calculation_fulls");

                entity.Property(e => e.CalculationFullCalcNumber)
                    .HasColumnName("calculation_full_calc_number")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculationFullContractId)
                    .HasColumnName("calculation_full_contract_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculationFullId)
                    .HasColumnName("calculation_full_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CalculationFullName).HasColumnName("calculation_full_name");

                entity.Property(e => e.CalculationFullNds)
                    .HasColumnName("calculation_full_nds")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculationFullNdsSumm)
                    .HasColumnName("calculation_full_nds_summ")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculationFullSumm)
                    .HasColumnName("calculation_full_summ")
                    .HasMaxLength(50);

                entity.Property(e => e.CalculationFullSummPlNds)
                    .HasColumnName("calculation_full_summ_pl_nds")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Calculations>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("calculations");

                entity.Property(e => e.CalculationDate)
                    .HasColumnName("calculation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CalculationId)
                    .HasColumnName("calculation_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CalculationIsFact).HasColumnName("calculation_is_fact");

                entity.Property(e => e.CalculationIsFull).HasColumnName("calculation_is_full");

                entity.Property(e => e.CalculationNds).HasColumnName("calculation_nds");

                entity.Property(e => e.CalculationNdsSumm).HasColumnName("calculation_nds_summ");

                entity.Property(e => e.CalculationNote)
                    .HasColumnName("calculation_note")
                    .HasMaxLength(255);

                entity.Property(e => e.CalculationNumber).HasColumnName("calculation_number");

                entity.Property(e => e.CalculationSumm).HasColumnName("calculation_summ");

                entity.Property(e => e.CalculationSummPlusNds).HasColumnName("calculation_summ_plus_nds");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ExecutorId).HasColumnName("executor_id");
            });

            modelBuilder.Entity<CashboxWorkerTocontrolUsers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("cashbox_workerTocontrol_users");

                entity.Property(e => e.CashboxWorkerId).HasColumnName("cashbox_worker_id");

                entity.Property(e => e.ControlUserId).HasColumnName("control_user_id");
            });

            modelBuilder.Entity<CashboxWorkers>(entity =>
            {
                entity.HasKey(e => e.CashboxWorkerId);

                entity.ToTable("cashbox_workers");

                entity.Property(e => e.CashboxWorkerId).HasColumnName("cashbox_worker_id");

                entity.Property(e => e.CashboxWorkerCreatedDate)
                    .HasColumnName("cashbox_worker_created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CashboxWorkerItemId).HasColumnName("cashbox_worker_item_id");

                entity.Property(e => e.CashboxWorkerNote).HasColumnName("cashbox_worker_note");

                entity.Property(e => e.CashboxWorkerSumm).HasColumnName("cashbox_worker_summ");

                entity.Property(e => e.CashboxWorkerType).HasColumnName("cashbox_worker_type");
            });

            modelBuilder.Entity<Contacts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contacts");

                entity.Property(e => e.ContactEmail).HasColumnName("contact_email");

                entity.Property(e => e.ContactFax).HasColumnName("contact_fax");

                entity.Property(e => e.ContactFlagForEmail)
                    .HasColumnName("contact_flag_for_email")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContactId)
                    .HasColumnName("contact_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContactName).HasColumnName("contact_name");

                entity.Property(e => e.ContactNameStatus).HasColumnName("contact_name_status");

                entity.Property(e => e.ContactNote).HasColumnName("contact_note");

                entity.Property(e => e.ContactPhone).HasColumnName("contact_phone");

                entity.Property(e => e.ContactSaveIspolnitel)
                    .HasColumnName("contact_save_ispolnitel")
                    .HasMaxLength(250);

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.MobilePhone).HasColumnName("mobile_phone");

                entity.Property(e => e.NumberContract).HasColumnName("number_contract");
            });

            modelBuilder.Entity<ContractToWorkTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contract_to_work_types");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.WorkType)
                    .IsRequired()
                    .HasColumnName("work_type")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Contracts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contracts");

                entity.Property(e => e.ContractActNumber).HasColumnName("contract_act_number");

                entity.Property(e => e.ContractAdvanceStatCheck).HasColumnName("contract_advance_stat_check");

                entity.Property(e => e.ContractAntiSaleCheck).HasColumnName("contract_anti_sale_check");

                entity.Property(e => e.ContractAntiSaleText)
                    .HasColumnName("contract_anti_sale_text")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractBranchCheck).HasColumnName("contract_branch_check");

                entity.Property(e => e.ContractBranchText).HasColumnName("contract_branch_text");

                entity.Property(e => e.ContractCalcSmeta)
                    .HasColumnName("contract_calc_smeta")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractCalcSmetaRashifr)
                    .HasColumnName("contract_calc_smeta_rashifr")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractCalendarPlan)
                    .HasColumnName("contract_calendar_plan")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractCallResults)
                    .HasColumnName("contract_call_results")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractChetFactura)
                    .HasColumnName("contract_chet_factura")
                    .HasMaxLength(255);

                entity.Property(e => e.ContractClosed).HasColumnName("contract_closed");

                entity.Property(e => e.ContractClosedMonth).HasColumnName("contract_closed_month");

                entity.Property(e => e.ContractClosedYear).HasColumnName("contract_closed_year");

                entity.Property(e => e.ContractConsumption)
                    .HasColumnName("contract_consumption")
                    .HasMaxLength(250)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractControlIspolnitel)
                    .HasColumnName("contract_control_ispolnitel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractCountry).HasColumnName("contract_country");

                entity.Property(e => e.ContractDate)
                    .HasColumnName("contract_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractDateConclusion)
                    .HasColumnName("contract_date_conclusion")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractDocsOrigin).HasColumnName("contract_docs_origin");

                entity.Property(e => e.ContractExecutorId).HasColumnName("contract_executor_id");

                entity.Property(e => e.ContractFutureCustomer)
                    .HasColumnName("contract_future_customer")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractGovContrCheck).HasColumnName("contract_gov_contr_check");

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ContractIncluding).HasColumnName("contract_including");

                entity.Property(e => e.ContractIshDate1KpText)
                    .HasColumnName("contract_ish_date1_kp_text")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractIshDate2KpText)
                    .HasColumnName("contract_ish_date2_kp_text")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractIspolnit).HasColumnName("contract_ispolnit");

                entity.Property(e => e.ContractIspolnitKp)
                    .HasColumnName("contract_ispolnit_kp")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractKonechUser)
                    .HasColumnName("contract_konech_user")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractKpLinkId).HasColumnName("contract_kp_link_id");

                entity.Property(e => e.ContractKpNumberText)
                    .HasColumnName("contract_kp_number_text")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractLastEditDate)
                    .HasColumnName("contract_last_edit_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractLicDogAvans).HasColumnName("contract_lic_dog_avans");

                entity.Property(e => e.ContractLicDogCount).HasColumnName("contract_lic_dog_count");

                entity.Property(e => e.ContractLicDogDo).HasColumnName("contract_lic_dog_do");

                entity.Property(e => e.ContractLicDogSrok).HasColumnName("contract_lic_dog_srok");

                entity.Property(e => e.ContractNds)
                    .HasColumnName("contract_nds")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractNdsSumm).HasColumnName("contract_nds_summ");

                entity.Property(e => e.ContractNerezDogDogCena).HasColumnName("contract_nerez_dog_dog_cena");

                entity.Property(e => e.ContractNerezDogNalogZak).HasColumnName("contract_nerez_dog_nalog_zak");

                entity.Property(e => e.ContractNerezDogNerezNalog).HasColumnName("contract_nerez_dog_nerez_nalog");

                entity.Property(e => e.ContractNerezDogProcentNalog).HasColumnName("contract_nerez_dog_procent_nalog");

                entity.Property(e => e.ContractNerezDogVidacha).HasColumnName("contract_nerez_dog_vidacha");

                entity.Property(e => e.ContractNerezEmail)
                    .HasColumnName("contract_nerez_email")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractNewUserCheck).HasColumnName("contract_new_user_check");

                entity.Property(e => e.ContractNewYearPriceCheck)
                    .HasColumnName("contract_new_year_price_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractNewYearPriceValue)
                    .HasColumnName("contract_new_year_price_value")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractNonresidentCheck).HasColumnName("contract_nonresident_check");

                entity.Property(e => e.ContractNonresidentCountry)
                    .HasColumnName("contract_nonresident_country")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractNote).HasColumnName("contract_note");

                entity.Property(e => e.ContractNumber)
                    .HasColumnName("contract_number")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractPaid).HasColumnName("contract_paid");

                entity.Property(e => e.ContractPayType).HasColumnName("contract_pay_type");

                entity.Property(e => e.ContractPayTypeFactDays).HasColumnName("contract_pay_type_fact_days");

                entity.Property(e => e.ContractPayTypeNote)
                    .HasColumnName("contract_pay_type_note")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractPayTypeNote2)
                    .HasColumnName("contract_pay_type_note2")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractPodpisIsp)
                    .HasColumnName("contract_podpis_isp")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractPodpisZak)
                    .HasColumnName("contract_podpis_zak")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractProtocolRaz)
                    .HasColumnName("contract_protocol_raz")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractProtocolUrelRaz)
                    .HasColumnName("contract_protocol_urel_raz")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractSaleCheck)
                    .HasColumnName("contract_sale_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractSaleText)
                    .HasColumnName("contract_sale_text")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractScanActNumber).HasColumnName("contract_scan_act_number");

                entity.Property(e => e.ContractSposobOplati)
                    .HasColumnName("contract_sposob_oplati")
                    .HasMaxLength(250);

                entity.Property(e => e.ContractSrokDate1)
                    .HasColumnName("contract_srok_date1")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractSrokDate2)
                    .HasColumnName("contract_srok_date2")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractSrokOkazUslug)
                    .HasColumnName("contract_srok_okaz_uslug")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractSrokText).HasColumnName("contract_srok_text");

                entity.Property(e => e.ContractSumm).HasColumnName("contract_summ");

                entity.Property(e => e.ContractSummPlusNds).HasColumnName("contract_summ_plus_nds");

                entity.Property(e => e.ContractSupplementaryAggrCheck)
                    .HasColumnName("contract_supplementary_aggr_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractSupportRemindDate)
                    .HasColumnName("contract_support_remind_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractTalk)
                    .HasColumnName("contract_talk")
                    .HasMaxLength(255);

                entity.Property(e => e.ContractTechInfo)
                    .HasColumnName("contract_tech_info")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractTechPodYear)
                    .HasColumnName("contract_tech_pod_year")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ContractTenderWinCheck)
                    .HasColumnName("contract_tender_win_check")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractTripCheck).HasColumnName("contract_trip_check");

                entity.Property(e => e.ContractUrgencyCheck).HasColumnName("contract_urgency_check");

                entity.Property(e => e.ContractValutaCheck).HasColumnName("contract_valuta_check");

                entity.Property(e => e.ContractValutaText)
                    .HasColumnName("contract_valuta_text")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractWithonchetdoc)
                    .HasColumnName("contract_withonchetdoc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractWorkNote).HasColumnName("contract_work_note");

                entity.Property(e => e.ContractWorkResult).HasColumnName("contract_work_result");

                entity.Property(e => e.ContractWorkType)
                    .HasColumnName("contract_work_type")
                    .HasMaxLength(100);

                entity.Property(e => e.ContractWorkdone).HasColumnName("contract_workdone");

                entity.Property(e => e.ContractWorkdoneDate)
                    .HasColumnName("contract_workdone_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractYesAct)
                    .HasColumnName("contract_yes_act")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractYesProtocol).HasColumnName("contract_yes_protocol");

                entity.Property(e => e.ContractYesScanAct)
                    .HasColumnName("contract_yes_scan_act")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractYesScanDog)
                    .HasColumnName("contract_yes_scan_dog")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ContractYesSupplementaryAggr).HasColumnName("contract_yes_supplementary_aggr");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Contracts2stages>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contracts2stages");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.StageDate)
                    .HasColumnName("stage_date")
                    .HasMaxLength(255);

                entity.Property(e => e.StageId).HasColumnName("stage_id");

                entity.Property(e => e.StageName).HasColumnName("stage_name");
            });

            modelBuilder.Entity<Contracts2workSubject>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("contracts2work_subject");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SubjectCount).HasColumnName("subject_count");

                entity.Property(e => e.WorkSubjectId).HasColumnName("work_subject_id");

                entity.Property(e => e.WorkSubjectIdTechPod).HasColumnName("work_subject_id_tech_pod");

                entity.Property(e => e.WorkSubjectTechPod).HasColumnName("work_subject_tech_pod");
            });

            modelBuilder.Entity<Control>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("control");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ControlCorol)
                    .HasColumnName("control_corol")
                    .HasMaxLength(250);

                entity.Property(e => e.ControlDate)
                    .HasColumnName("control_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ControlDateType).HasColumnName("control_date_type");

                entity.Property(e => e.ControlDoneForAdmin)
                    .HasColumnName("control_done_for_admin")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ControlId)
                    .HasColumnName("control_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ControlIspolnit)
                    .HasColumnName("control_ispolnit")
                    .HasMaxLength(255);

                entity.Property(e => e.ControlIspolnitCkeck)
                    .HasColumnName("control_ispolnit_ckeck")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ControlItapCalPlana).HasColumnName("control_itap_cal_plana");

                entity.Property(e => e.ControlLastUpdate)
                    .HasColumnName("control_last_update")
                    .HasColumnType("datetime");

                entity.Property(e => e.ControlNote)
                    .HasColumnName("control_note")
                    .HasColumnType("ntext");

                entity.Property(e => e.ControlText)
                    .HasColumnName("control_text")
                    .HasMaxLength(255);

                entity.Property(e => e.ControlType).HasColumnName("control_type");

                entity.Property(e => e.ControlWatched).HasColumnName("control_watched");

                entity.Property(e => e.ControlWorkDone)
                    .HasColumnName("control_work_done")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ControlUserGroups>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("control_user_groups");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.GroupIsCash)
                    .HasColumnName("group_is_cash")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.GroupIsShow)
                    .HasColumnName("group_is_show")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ControlUsers>(entity =>
            {
                entity.HasKey(e => e.ControlUserId);

                entity.ToTable("control_users");

                entity.Property(e => e.ControlUserId).HasColumnName("control_user_id");

                entity.Property(e => e.ControlUserEmail)
                    .HasColumnName("control_user_email")
                    .HasMaxLength(150);

                entity.Property(e => e.ControlUserGroup).HasColumnName("control_user_group");

                entity.Property(e => e.ControlUserGroupRole)
                    .HasColumnName("control_user_group_role")
                    .HasMaxLength(255);

                entity.Property(e => e.ControlUserIp)
                    .HasColumnName("control_user_ip")
                    .HasMaxLength(255);

                entity.Property(e => e.ControlUserIsActive).HasColumnName("control_user_is_active");

                entity.Property(e => e.ControlUserIsMaternity)
                    .HasColumnName("control_user_is_maternity")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ControlUserName)
                    .HasColumnName("control_user_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ControlUserNameOnPc)
                    .HasColumnName("control_user_name_on_pc")
                    .HasMaxLength(255);

                entity.Property(e => e.ControlUserPassword)
                    .IsRequired()
                    .HasColumnName("control_user_password")
                    .HasMaxLength(150)
                    .HasDefaultValueSql("((123456))");

                entity.Property(e => e.ControlUserSortNumb).HasColumnName("control_user_sort_numb");

                entity.Property(e => e.ControlUserStageId)
                    .HasColumnName("control_user_stage_id")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Countrys>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("countrys");

                entity.Property(e => e.CountryId)
                    .HasColumnName("country_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("country_name");
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customers");

                entity.Property(e => e.CustomerAddressFak).HasColumnName("customer_address_fak");

                entity.Property(e => e.CustomerAddressJur).HasColumnName("customer_address_jur");

                entity.Property(e => e.CustomerAddressPost).HasColumnName("customer_address_post");

                entity.Property(e => e.CustomerAddressShfak).HasColumnName("customer_address_shfak");

                entity.Property(e => e.CustomerBank).HasColumnName("customer_bank");

                entity.Property(e => e.CustomerBik).HasColumnName("customer_bik");

                entity.Property(e => e.CustomerElectroDoc).HasColumnName("customer_electro_doc");

                entity.Property(e => e.CustomerElectroDocItem)
                    .HasColumnName("customer_electro_doc_item")
                    .HasMaxLength(250);

                entity.Property(e => e.CustomerFutureCust)
                    .HasColumnName("customer_future_cust")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CustomerInn).HasColumnName("customer_inn");

                entity.Property(e => e.CustomerKpp).HasColumnName("customer_kpp");

                entity.Property(e => e.CustomerKs).HasColumnName("customer_ks");

                entity.Property(e => e.CustomerName).HasColumnName("customer_name");

                entity.Property(e => e.CustomerNameFull).HasColumnName("customer_name_full");

                entity.Property(e => e.CustomerNote).HasColumnName("customer_note");

                entity.Property(e => e.CustomerOtherInfo).HasColumnName("customer_other_info");

                entity.Property(e => e.CustomerRs).HasColumnName("customer_rs");

                entity.Property(e => e.CustomerTalk).HasColumnName("customer_talk");

                entity.Property(e => e.CustomerXmlCity)
                    .HasColumnName("customer_xml_city")
                    .HasMaxLength(150);

                entity.Property(e => e.CustomerXmlCode)
                    .HasColumnName("customer_xml_code")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerXmlHouse)
                    .HasColumnName("customer_xml_house")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerXmlIndex)
                    .HasColumnName("customer_xml_index")
                    .HasMaxLength(50);

                entity.Property(e => e.CustomerXmlStreet)
                    .HasColumnName("customer_xml_street")
                    .HasMaxLength(250);

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<DecodingSalaries>(entity =>
            {
                entity.HasKey(e => e.DecodSalarId);

                entity.ToTable("decoding_salaries");

                entity.Property(e => e.DecodSalarId).HasColumnName("decod_salar_id");

                entity.Property(e => e.DecodSalarName)
                    .IsRequired()
                    .HasColumnName("decod_salar_name")
                    .HasMaxLength(250);

                entity.Property(e => e.DecodSalarSum).HasColumnName("decod_salar_sum");
            });

            modelBuilder.Entity<DocsToCalplan>(entity =>
            {
                entity.ToTable("docs_to_calplan");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CalplanId).HasColumnName("calplan_id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.DocDate)
                    .IsRequired()
                    .HasColumnName("doc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.DocId).HasColumnName("doc_id");

                entity.Property(e => e.DocType).HasColumnName("doc_type");
            });

            modelBuilder.Entity<DocsToDepartament>(entity =>
            {
                entity.ToTable("docs_to_departament");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.DepartamentId).HasColumnName("departament_id");

                entity.Property(e => e.DocDate)
                    .IsRequired()
                    .HasColumnName("doc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.DocId)
                    .IsRequired()
                    .HasColumnName("doc_id")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DocsToIspolnitel>(entity =>
            {
                entity.ToTable("docs_to_ispolnitel");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.DocDate)
                    .IsRequired()
                    .HasColumnName("doc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.DocId).HasColumnName("doc_id");

                entity.Property(e => e.DocType).HasColumnName("doc_type");

                entity.Property(e => e.IspolnitelId).HasColumnName("ispolnitel_id");
            });

            modelBuilder.Entity<DogToKp>(entity =>
            {
                entity.ToTable("DogToKP");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DogId).HasColumnName("dog_id");

                entity.Property(e => e.KpId).HasColumnName("kp_id");
            });

            modelBuilder.Entity<Executors>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("executors");

                entity.Property(e => e.ExecutorId).HasColumnName("executor_id");

                entity.Property(e => e.ExecutorName)
                    .HasColumnName("executor_name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Colume).HasMaxLength(250);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Message).HasMaxLength(255);

                entity.Property(e => e.UserIp)
                    .HasColumnName("UserIP")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<HistoryOfIspol>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Message)
                    .HasColumnName("message")
                    .HasMaxLength(255);

                entity.Property(e => e.MessageFrom)
                    .HasColumnName("message_from")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("items");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("item_name")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<KonechUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("konech_user");

                entity.Property(e => e.ContractId)
                    .HasColumnName("contract_id")
                    .HasMaxLength(255);

                entity.Property(e => e.KonechUserAddress).HasColumnName("konech_user_address");

                entity.Property(e => e.KonechUserHistory).HasColumnName("konech_user_history");

                entity.Property(e => e.KonechUserId)
                    .HasColumnName("konech_user_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.KonechUserInn).HasColumnName("konech_user_inn");

                entity.Property(e => e.KonechUserModule).HasColumnName("konech_user_module");

                entity.Property(e => e.KonechUserName).HasColumnName("konech_user_name");

                entity.Property(e => e.KonechUserNumberChet).HasColumnName("konech_user_number_chet");

                entity.Property(e => e.KonechUserNumberLic).HasColumnName("konech_user_number_lic");

                entity.Property(e => e.UpsizeTs)
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<License>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("license");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ExecutorName)
                    .HasColumnName("executor_name")
                    .HasMaxLength(255);

                entity.Property(e => e.LicDate)
                    .HasColumnName("lic_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LicId)
                    .HasColumnName("lic_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LicNote)
                    .HasColumnName("lic_note")
                    .HasColumnType("ntext");

                entity.Property(e => e.LicNumber).HasColumnName("lic_number");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.WorkPlaces).HasColumnName("work_places");

                entity.Property(e => e.WorkPlacesText)
                    .HasColumnName("work_places_text")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<License2modules>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("license2modules");

                entity.Property(e => e.LicId).HasColumnName("lic_id");

                entity.Property(e => e.ModId).HasColumnName("mod_id");
            });

            modelBuilder.Entity<Metodika>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("metodika");

                entity.Property(e => e.Ispolnitel)
                    .HasColumnName("ispolnitel")
                    .HasMaxLength(255);

                entity.Property(e => e.MetodikaId)
                    .HasColumnName("metodika_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NameDoc)
                    .HasColumnName("name_doc")
                    .HasMaxLength(255);

                entity.Property(e => e.NumberContract)
                    .HasColumnName("number_contract")
                    .HasMaxLength(255);

                entity.Property(e => e.NumberId).HasColumnName("number_id");

                entity.Property(e => e.RegNumber)
                    .HasColumnName("reg_number")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("modules");

                entity.Property(e => e.ModFullName)
                    .HasColumnName("mod_full_name")
                    .HasColumnType("ntext");

                entity.Property(e => e.ModId)
                    .HasColumnName("mod_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ModName)
                    .HasColumnName("mod_name")
                    .HasMaxLength(255);

                entity.Property(e => e.ModSmallName)
                    .HasColumnName("mod_small_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Naks>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("naks");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ExecutorId).HasColumnName("executor_id");

                entity.Property(e => e.NakDate)
                    .HasColumnName("nak_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NakId)
                    .HasColumnName("nak_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NakIsFull).HasColumnName("nak_is_full");

                entity.Property(e => e.NakIspolnitel).HasColumnName("nak_ispolnitel");

                entity.Property(e => e.NakNds).HasColumnName("nak_nds");

                entity.Property(e => e.NakNdsSumm).HasColumnName("nak_nds_summ");

                entity.Property(e => e.NakNote)
                    .HasColumnName("nak_note")
                    .HasMaxLength(255);

                entity.Property(e => e.NakNumber).HasColumnName("nak_number");

                entity.Property(e => e.NakPodpisIsp)
                    .HasColumnName("nak_podpis_isp")
                    .HasMaxLength(250);

                entity.Property(e => e.NakSumm).HasColumnName("nak_summ");

                entity.Property(e => e.NakSummPlusNds).HasColumnName("nak_summ_plus_nds");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<NaksFull>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("naks_full");

                entity.Property(e => e.ContractId)
                    .IsRequired()
                    .HasColumnName("contract_id")
                    .HasMaxLength(50);

                entity.Property(e => e.NakFullCount)
                    .HasColumnName("nak_full_count")
                    .HasMaxLength(250);

                entity.Property(e => e.NakFullId)
                    .HasColumnName("nak_full_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.NakFullName).HasColumnName("nak_full_name");

                entity.Property(e => e.NakFullNumber)
                    .IsRequired()
                    .HasColumnName("nak_full_number")
                    .HasMaxLength(50);

                entity.Property(e => e.NakFullObz)
                    .HasColumnName("nak_full_obz")
                    .HasMaxLength(250);

                entity.Property(e => e.NakFullPrice)
                    .HasColumnName("nak_full_price")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<OldContracts>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("old_contracts");

                entity.Property(e => e.ContractCallResults)
                    .HasColumnName("contract_call_results")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractClosed).HasColumnName("contract_closed");

                entity.Property(e => e.ContractClosedMonth).HasColumnName("contract_closed_month");

                entity.Property(e => e.ContractClosedYear).HasColumnName("contract_closed_year");

                entity.Property(e => e.ContractDate)
                    .HasColumnName("contract_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractDocsOrigin).HasColumnName("contract_docs_origin");

                entity.Property(e => e.ContractExecutorId).HasColumnName("contract_executor_id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ContractIspolnit)
                    .HasColumnName("contract_ispolnit")
                    .HasMaxLength(255);

                entity.Property(e => e.ContractNds)
                    .HasColumnName("contract_nds")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractNote)
                    .HasColumnName("contract_note")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractNumber)
                    .HasColumnName("contract_number")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractPaid).HasColumnName("contract_paid");

                entity.Property(e => e.ContractPayType).HasColumnName("contract_pay_type");

                entity.Property(e => e.ContractPayTypeFactDays).HasColumnName("contract_pay_type_fact_days");

                entity.Property(e => e.ContractPayTypeNote)
                    .HasColumnName("contract_pay_type_note")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractPayTypeNote2)
                    .HasColumnName("contract_pay_type_note2")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractSumm)
                    .HasColumnName("contract_summ")
                    .HasMaxLength(50);

                entity.Property(e => e.ContractSupportRemindDate)
                    .HasColumnName("contract_support_remind_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractTalk)
                    .HasColumnName("contract_talk")
                    .HasMaxLength(255);

                entity.Property(e => e.ContractTechInfo)
                    .HasColumnName("contract_tech_info")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractWorkNote)
                    .HasColumnName("contract_work_note")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractWorkResult)
                    .HasColumnName("contract_work_result")
                    .HasColumnType("ntext");

                entity.Property(e => e.ContractWorkType)
                    .HasColumnName("contract_work_type")
                    .HasMaxLength(100);

                entity.Property(e => e.ContractWorkdone).HasColumnName("contract_workdone");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<OtchetDocTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("otchet_doc_types");

                entity.Property(e => e.OtchetDocTypeId)
                    .HasColumnName("otchet_doc_type_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.OtchetDocTypeName)
                    .IsRequired()
                    .HasColumnName("otchet_doc_type_name");
            });

            modelBuilder.Entity<Outlays>(entity =>
            {
                entity.HasKey(e => e.OutlayId);

                entity.ToTable("outlays");

                entity.Property(e => e.OutlayId).HasColumnName("outlay_id");

                entity.Property(e => e.OutlayName)
                    .IsRequired()
                    .HasColumnName("outlay_name");
            });

            modelBuilder.Entity<OutlaysSumm>(entity =>
            {
                entity.HasKey(e => e.OutlaySummId);

                entity.ToTable("outlays_summ");

                entity.Property(e => e.OutlaySummId).HasColumnName("outlay_summ_id");

                entity.Property(e => e.OutlaySummDepartamentId).HasColumnName("outlay_summ_departament_id");

                entity.Property(e => e.OutlaySummMonth).HasColumnName("outlay_summ_month");

                entity.Property(e => e.OutlaySummOutlayId).HasColumnName("outlay_summ_outlay_id");

                entity.Property(e => e.OutlaySummValue)
                    .IsRequired()
                    .HasColumnName("outlay_summ_value")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PathToFile>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Backup).HasMaxLength(255);

                entity.Property(e => e.BaseType).HasMaxLength(255);

                entity.Property(e => e.Basepath)
                    .HasColumnName("basepath")
                    .HasMaxLength(255);

                entity.Property(e => e.Config)
                    .HasColumnName("config")
                    .HasMaxLength(255);

                entity.Property(e => e.Config2base)
                    .HasColumnName("config2base")
                    .HasMaxLength(255);

                entity.Property(e => e.ConfigsPath).HasMaxLength(255);

                entity.Property(e => e.Contract).HasMaxLength(255);

                entity.Property(e => e.DebugBaseType)
                    .HasColumnName("debug_BaseType")
                    .HasMaxLength(255);

                entity.Property(e => e.DebugBasepath)
                    .HasColumnName("debug_basepath")
                    .HasMaxLength(255);

                entity.Property(e => e.DebugContract)
                    .HasColumnName("debug_Contract")
                    .HasMaxLength(255);

                entity.Property(e => e.DebugDirectoryExists)
                    .HasColumnName("debug_DirectoryExists")
                    .HasMaxLength(255);

                entity.Property(e => e.DirectoryExists).HasMaxLength(255);

                entity.Property(e => e.Drive)
                    .HasColumnName("drive")
                    .HasMaxLength(255);

                entity.Property(e => e.ExportDir)
                    .HasColumnName("export_dir")
                    .HasMaxLength(255);

                entity.Property(e => e.FreeInstallDir).HasMaxLength(255);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LastVersions).HasMaxLength(255);

                entity.Property(e => e.ModsDir).HasMaxLength(255);

                entity.Property(e => e.Mysqlserver)
                    .HasColumnName("mysqlserver")
                    .HasMaxLength(255);

                entity.Property(e => e.PathToLocalPc)
                    .HasColumnName("PathToLocalPC")
                    .HasMaxLength(250);

                entity.Property(e => e.ProgramFiles).HasMaxLength(255);

                entity.Property(e => e.SaveOnLocalPc).HasColumnName("SaveOnLocalPC");

                entity.Property(e => e.Servertype)
                    .HasColumnName("servertype")
                    .HasMaxLength(255);

                entity.Property(e => e.SetupsDir).HasMaxLength(255);

                entity.Property(e => e.Sitename)
                    .HasColumnName("sitename")
                    .HasMaxLength(255);

                entity.Property(e => e.TripExcelFile).HasMaxLength(250);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Paydocs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("paydocs");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.PaydocDate)
                    .HasColumnName("paydoc_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaydocDogLevel).HasColumnName("paydoc_dog_level");

                entity.Property(e => e.PaydocId)
                    .HasColumnName("paydoc_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.PaydocNote)
                    .HasColumnName("paydoc_note")
                    .HasMaxLength(255);

                entity.Property(e => e.PaydocNumber)
                    .HasColumnName("paydoc_number")
                    .HasMaxLength(255);

                entity.Property(e => e.PaydocSumm).HasColumnName("paydoc_summ");

                entity.Property(e => e.PaydocType)
                    .IsRequired()
                    .HasColumnName("paydoc_type")
                    .HasMaxLength(50);

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ProcessingOfRecord>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("processing_of_record");

                entity.Property(e => e.ProcessingCreateDate)
                    .HasColumnName("processing_create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessingType).HasColumnName("processing_type");

                entity.Property(e => e.ProcessingUserId).HasColumnName("processing_user_id");

                entity.Property(e => e.ProcessingValue).HasColumnName("processing_value");
            });

            modelBuilder.Entity<ProcessingOfWork>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("processing_of_work");

                entity.Property(e => e.ProcessingDay).HasColumnName("processing_day");

                entity.Property(e => e.ProcessingEndHour).HasColumnName("processing_end_hour");

                entity.Property(e => e.ProcessingEndMinute).HasColumnName("processing_end_minute");

                entity.Property(e => e.ProcessingStartHour).HasColumnName("processing_start_hour");

                entity.Property(e => e.ProcessingStartMinute).HasColumnName("processing_start_minute");

                entity.Property(e => e.ProcessingUserId).HasColumnName("processing_user_id");
            });

            modelBuilder.Entity<ProtocolRaz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("protocol_raz");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ProtocolRazId)
                    .HasColumnName("protocol_raz_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProtocolRazPunktDog).HasColumnName("protocol_raz_punkt_dog");

                entity.Property(e => e.ProtocolRazRedIspol).HasColumnName("protocol_raz_red_ispol");

                entity.Property(e => e.ProtocolRazRedZak).HasColumnName("protocol_raz_red_zak");
            });

            modelBuilder.Entity<ProtocolUrelRaz>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("protocol_urel_raz");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.ProtocolUrelRazId)
                    .HasColumnName("protocol_urel_raz_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProtocolUrelRazPunktDog).HasColumnName("protocol_urel_raz_punkt_dog");

                entity.Property(e => e.ProtocolUrelRazRedIspol).HasColumnName("protocol_urel_raz_red_ispol");

                entity.Property(e => e.ProtocolUrelRazRedSogl).HasColumnName("protocol_urel_raz_red_sogl");

                entity.Property(e => e.ProtocolUrelRazRedZak).HasColumnName("protocol_urel_raz_red_zak");
            });

            modelBuilder.Entity<RasCalcSmeta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ras_calc_smeta");

                entity.Property(e => e.CalcSmetaArenda).HasColumnName("calc_smeta_arenda");

                entity.Property(e => e.CalcSmetaArendaObos).HasColumnName("calc_smeta_arenda_obos");

                entity.Property(e => e.CalcSmetaAup).HasColumnName("calc_smeta_aup");

                entity.Property(e => e.CalcSmetaAupObos).HasColumnName("calc_smeta_aup_obos");

                entity.Property(e => e.CalcSmetaElectrosnab).HasColumnName("calc_smeta_electrosnab");

                entity.Property(e => e.CalcSmetaElectrosnabObos).HasColumnName("calc_smeta_electrosnab_obos");

                entity.Property(e => e.CalcSmetaEmail).HasColumnName("calc_smeta_email");

                entity.Property(e => e.CalcSmetaEmailObos).HasColumnName("calc_smeta_email_obos");

                entity.Property(e => e.CalcSmetaItog).HasColumnName("calc_smeta_itog");

                entity.Property(e => e.CalcSmetaItogNds).HasColumnName("calc_smeta_itog_nds");

                entity.Property(e => e.CalcSmetaItogNdsObos).HasColumnName("calc_smeta_itog_nds_obos");

                entity.Property(e => e.CalcSmetaItogObos).HasColumnName("calc_smeta_itog_obos");

                entity.Property(e => e.CalcSmetaNakRashod).HasColumnName("calc_smeta_nak_rashod");

                entity.Property(e => e.CalcSmetaNakRashodObos).HasColumnName("calc_smeta_nak_rashod_obos");

                entity.Property(e => e.CalcSmetaNds).HasColumnName("calc_smeta_nds");

                entity.Property(e => e.CalcSmetaNdsObos).HasColumnName("calc_smeta_nds_obos");

                entity.Property(e => e.CalcSmetaPribol).HasColumnName("calc_smeta_pribol");

                entity.Property(e => e.CalcSmetaPribolObos).HasColumnName("calc_smeta_pribol_obos");

                entity.Property(e => e.CalcSmetaShortId)
                    .HasColumnName("calc_smeta_short_id")
                    .HasMaxLength(50);

                entity.Property(e => e.CalcSmetaStrachVz).HasColumnName("calc_smeta_strach_vz");

                entity.Property(e => e.CalcSmetaStrachVzObos).HasColumnName("calc_smeta_strach_vz_obos");

                entity.Property(e => e.CalcSmetaTeplosnab).HasColumnName("calc_smeta_teplosnab");

                entity.Property(e => e.CalcSmetaTeplosnabObos).HasColumnName("calc_smeta_teplosnab_obos");

                entity.Property(e => e.CalcSmetaVodosnab).HasColumnName("calc_smeta_vodosnab");

                entity.Property(e => e.CalcSmetaVodosnabObos).HasColumnName("calc_smeta_vodosnab_obos");

                entity.Property(e => e.CalcSmetaZarplata).HasColumnName("calc_smeta_zarplata");

                entity.Property(e => e.CalcSmetaZarplataObos).HasColumnName("calc_smeta_zarplata_obos");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.RasCalcSmetaId)
                    .HasColumnName("ras_calc_smeta_id")
                    .ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RegDocs>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reg_docs");

                entity.Property(e => e.ContrId).HasColumnName("contr_id");

                entity.Property(e => e.CustName).HasColumnName("cust_name");

                entity.Property(e => e.ExecMan)
                    .HasColumnName("exec_man")
                    .HasMaxLength(255);

                entity.Property(e => e.ExecName)
                    .HasColumnName("exec_name")
                    .HasMaxLength(255);

                entity.Property(e => e.RegDate)
                    .HasColumnName("reg_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegDocType).HasColumnName("reg_doc_type");

                entity.Property(e => e.RegExec)
                    .HasColumnName("reg_exec")
                    .HasMaxLength(255);

                entity.Property(e => e.RegId)
                    .HasColumnName("reg_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegIspolnitel).HasColumnName("reg_ispolnitel");

                entity.Property(e => e.RegNote).HasColumnName("reg_note");

                entity.Property(e => e.RegNumber).HasColumnName("reg_number");

                entity.Property(e => e.RegNumberFr).HasColumnName("reg_number_fr");

                entity.Property(e => e.RegPodpisant).HasColumnName("reg_podpisant");

                entity.Property(e => e.RegPredmet).HasColumnName("reg_predmet");

                entity.Property(e => e.UpsizeTs)
                    .IsRequired()
                    .HasColumnName("upsize_ts")
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<RegMailInput>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reg_mail_input");

                entity.Property(e => e.RegMailAddress).HasColumnName("reg_mail_address");

                entity.Property(e => e.RegMailCustomer).HasColumnName("reg_mail_customer");

                entity.Property(e => e.RegMailDate)
                    .HasColumnName("reg_mail_date")
                    .HasMaxLength(250);

                entity.Property(e => e.RegMailExecType)
                    .HasColumnName("reg_mail_exec_type")
                    .HasMaxLength(10);

                entity.Property(e => e.RegMailExecutor).HasColumnName("reg_mail_executor");

                entity.Property(e => e.RegMailId)
                    .HasColumnName("reg_mail_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegMailNumber).HasColumnName("reg_mail_number");

                entity.Property(e => e.RegMailObtainmentType).HasColumnName("reg_mail_obtainment_type");

                entity.Property(e => e.RegMailOutputNumber).HasColumnName("reg_mail_output_number");

                entity.Property(e => e.RegMailOutputNumberTrue).HasColumnName("reg_mail_output_number_true");

                entity.Property(e => e.RegMailStage).HasColumnName("reg_mail_stage");
            });

            modelBuilder.Entity<RegMailOutput>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reg_mail_output");

                entity.Property(e => e.RegMailCustomer).HasColumnName("reg_mail_customer");

                entity.Property(e => e.RegMailDate)
                    .HasColumnName("reg_mail_date")
                    .HasMaxLength(250);

                entity.Property(e => e.RegMailExecType)
                    .HasColumnName("reg_mail_exec_type")
                    .HasMaxLength(10);

                entity.Property(e => e.RegMailExecutor).HasColumnName("reg_mail_executor");

                entity.Property(e => e.RegMailId)
                    .HasColumnName("reg_mail_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegMailNumber).HasColumnName("reg_mail_number");

                entity.Property(e => e.RegMailStage).HasColumnName("reg_mail_stage");

                entity.Property(e => e.RegMailText).HasColumnName("reg_mail_text");
            });

            modelBuilder.Entity<RegMailPostOffice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reg_mail_post_office");

                entity.Property(e => e.RegMailOutputId).HasColumnName("reg_mail_output_id");

                entity.Property(e => e.RegMailOutputParentId).HasColumnName("reg_mail_output_parent_id");

                entity.Property(e => e.RegMailPostOfficeAddress)
                    .IsRequired()
                    .HasColumnName("reg_mail_post_office_address");

                entity.Property(e => e.RegMailPostOfficeId)
                    .HasColumnName("reg_mail_post_office_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegMailPostOfficePrice)
                    .IsRequired()
                    .HasColumnName("reg_mail_post_office_price")
                    .HasMaxLength(50);

                entity.Property(e => e.RegMailPostOfficeWeight)
                    .IsRequired()
                    .HasColumnName("reg_mail_post_office_weight")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RegTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("reg_types");

                entity.Property(e => e.RtId).HasColumnName("rt_id");

                entity.Property(e => e.RtName)
                    .HasColumnName("rt_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RegisteredMailTariff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("registered_mail_tariff");

                entity.Property(e => e.RegisteredMailTariffId)
                    .HasColumnName("registered_mail_tariff_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RegisteredMailTariffPrice).HasColumnName("registered_mail_tariff_price");

                entity.Property(e => e.RegisteredMailTariffType).HasColumnName("registered_mail_tariff_type");

                entity.Property(e => e.RegisteredMailTariffWeight).HasColumnName("registered_mail_tariff_weight");
            });

            modelBuilder.Entity<Signatures>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("signatures");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.SignatureBase)
                    .HasColumnName("signature_base")
                    .HasMaxLength(255);

                entity.Property(e => e.SignatureId)
                    .HasColumnName("signature_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SignatureName)
                    .HasColumnName("signature_name")
                    .HasMaxLength(255);

                entity.Property(e => e.SignatureNote)
                    .HasColumnName("signature_note")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Signers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ExecutorId)
                    .HasColumnName("executor_id")
                    .HasMaxLength(50);

                entity.Property(e => e.SignerCondit)
                    .HasColumnName("signer_condit")
                    .HasMaxLength(255);

                entity.Property(e => e.SignerId)
                    .HasColumnName("signer_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SignerName)
                    .HasColumnName("signer_name")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Standards>(entity =>
            {
                entity.HasKey(e => e.StandardId);

                entity.ToTable("standards");

                entity.Property(e => e.StandardId).HasColumnName("standard_id");

                entity.Property(e => e.StandardMarker)
                    .HasColumnName("standard_marker")
                    .HasMaxLength(50);

                entity.Property(e => e.StandardName)
                    .IsRequired()
                    .HasColumnName("standard_name")
                    .HasMaxLength(250);

                entity.Property(e => e.StandardSum).HasColumnName("standard_sum");
            });

            modelBuilder.Entity<SupplementaryAgreement>(entity =>
            {
                entity.ToTable("supplementary_agreement");

                entity.Property(e => e.SupplementaryAgreementId).HasColumnName("supplementary_agreement_id");

                entity.Property(e => e.ContractId).HasColumnName("contract_id");

                entity.Property(e => e.SupplementaryAgreementDate)
                    .HasColumnName("supplementary_agreement_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SupplementaryAgreementNote)
                    .IsRequired()
                    .HasColumnName("supplementary_agreement_note");
            });

            modelBuilder.Entity<SupplementaryAgreementContext>(entity =>
            {
                entity.ToTable("supplementary_agreement_context");

                entity.Property(e => e.SupplementaryAgreementContextId).HasColumnName("supplementary_agreement_context_id");

                entity.Property(e => e.SupplementaryAgreementContextNumber)
                    .IsRequired()
                    .HasColumnName("supplementary_agreement_context_number")
                    .HasMaxLength(50);

                entity.Property(e => e.SupplementaryAgreementContextPrice).HasColumnName("supplementary_agreement_context_price");

                entity.Property(e => e.SupplementaryAgreementContextText).HasColumnName("supplementary_agreement_context_text");

                entity.Property(e => e.SupplementaryAgreementId).HasColumnName("supplementary_agreement_id");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("test");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            modelBuilder.Entity<Trips>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("trips");

                entity.Property(e => e.TripAdvenStChek).HasColumnName("trip_adven_st_chek");

                entity.Property(e => e.TripContractId)
                    .HasColumnName("trip_contract_id")
                    .HasMaxLength(50);

                entity.Property(e => e.TripDateFrom)
                    .HasColumnName("trip_date_from")
                    .HasMaxLength(250);

                entity.Property(e => e.TripDateTo)
                    .HasColumnName("trip_date_to")
                    .HasMaxLength(250);

                entity.Property(e => e.TripDocDate)
                    .HasColumnName("trip_doc_date")
                    .HasMaxLength(50);

                entity.Property(e => e.TripDocNumber)
                    .HasColumnName("trip_doc_number")
                    .HasMaxLength(50);

                entity.Property(e => e.TripExecutor)
                    .HasColumnName("trip_executor")
                    .HasMaxLength(50);

                entity.Property(e => e.TripId)
                    .HasColumnName("trip_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.TripLocation).HasColumnName("trip_location");

                entity.Property(e => e.TripManName)
                    .HasColumnName("trip_man_name")
                    .HasMaxLength(250);

                entity.Property(e => e.TripSection)
                    .HasColumnName("trip_section")
                    .HasMaxLength(250);

                entity.Property(e => e.TripSrok)
                    .HasColumnName("trip_srok")
                    .HasMaxLength(50);

                entity.Property(e => e.TripStatus)
                    .HasColumnName("trip_status")
                    .HasMaxLength(250);

                entity.Property(e => e.TripTabNumber)
                    .HasColumnName("trip_tab_number")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("users");

                entity.Property(e => e.LastLogin)
                    .HasColumnName("last_login")
                    .HasColumnType("datetime");

                entity.Property(e => e.OnOff).HasColumnName("On_Off");

                entity.Property(e => e.OnOffPodskazka)
                    .HasColumnName("On_Off_podskazka")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserCashboxAccess).HasColumnName("user_cashbox_access");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserIp)
                    .HasColumnName("user_ip")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(255);

                entity.Property(e => e.UserPassword)
                    .HasColumnName("user_password")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<UsualMailPostOffice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usual_mail_post_office");

                entity.Property(e => e.UsualMailOutputParentId).HasColumnName("usual_mail_output_parent_id");

                entity.Property(e => e.UsualMailPostOfficeCount).HasColumnName("usual_mail_post_office_count");

                entity.Property(e => e.UsualMailPostOfficeId)
                    .HasColumnName("usual_mail_post_office_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsualMailPostOfficePrice)
                    .IsRequired()
                    .HasColumnName("usual_mail_post_office_price")
                    .HasMaxLength(50);

                entity.Property(e => e.UsualMailPostOfficeWeight)
                    .IsRequired()
                    .HasColumnName("usual_mail_post_office_weight")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UsualMailTariff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("usual_mail_tariff");

                entity.Property(e => e.UsualMailTariffId)
                    .HasColumnName("usual_mail_tariff_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UsualMailTariffPrice).HasColumnName("usual_mail_tariff_price");

                entity.Property(e => e.UsualMailTariffType).HasColumnName("usual_mail_tariff_type");

                entity.Property(e => e.UsualMailTariffWeight).HasColumnName("usual_mail_tariff_weight");
            });

            modelBuilder.Entity<Wages>(entity =>
            {
                entity.ToTable("wages");

                entity.Property(e => e.WagesId).HasColumnName("wages_id");

                entity.Property(e => e.WagesCalcSmetaId).HasColumnName("wages_calc_smeta_id");

                entity.Property(e => e.WagesCount).HasColumnName("wages_count");

                entity.Property(e => e.WagesName)
                    .IsRequired()
                    .HasColumnName("wages_name")
                    .HasMaxLength(250);

                entity.Property(e => e.WagesSal).HasColumnName("wages_sal");

                entity.Property(e => e.WagesSum).HasColumnName("wages_sum");
            });

            modelBuilder.Entity<WorkSubjects>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("work_subjects");

                entity.Property(e => e.WorkSubjectId)
                    .HasColumnName("work_subject_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WorkSubjectName)
                    .HasColumnName("work_subject_name")
                    .HasMaxLength(255);

                entity.Property(e => e.WorkTypeId).HasColumnName("work_type_id");
            });

            modelBuilder.Entity<WorkTypes>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("work_types");

                entity.Property(e => e.WorkTypeId)
                    .HasColumnName("work_type_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.WorkTypeName)
                    .HasColumnName("work_type_name")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
