﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Gordon360.Models.CCT;

namespace Gordon360.Models.CCT.Context
{
    public partial class CCTContext : DbContext
    {
        public CCTContext()
        {
        }

        public CCTContext(DbContextOptions<CCTContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ACCOUNT> ACCOUNT { get; set; }
        public virtual DbSet<ACT_INFO> ACT_INFO { get; set; }
        public virtual DbSet<ADMIN> ADMIN { get; set; }
        public virtual DbSet<AccountPhotoURL> AccountPhotoURL { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityStatus> ActivityStatus { get; set; }
        public virtual DbSet<ActivityType> ActivityType { get; set; }
        public virtual DbSet<Affiliation> Affiliation { get; set; }
        public virtual DbSet<AffiliationPoints> AffiliationPoints { get; set; }
        public virtual DbSet<Alumni> Alumni { get; set; }
        public virtual DbSet<Birthdays> Birthdays { get; set; }
        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<CM_SESSION_MSTR> CM_SESSION_MSTR { get; set; }
        public virtual DbSet<CUSTOM_PROFILE> CUSTOM_PROFILE { get; set; }
        public virtual DbSet<ChapelEvent> ChapelEvent { get; set; }
        public virtual DbSet<Clifton_Strengths> Clifton_Strengths { get; set; }
        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<CustomParticipant> CustomParticipant { get; set; }
        public virtual DbSet<DiningInfo> DiningInfo { get; set; }
        public virtual DbSet<Dining_Meal_Choice_Desc> Dining_Meal_Choice_Desc { get; set; }
        public virtual DbSet<Dining_Meal_Plan_Change_History> Dining_Meal_Plan_Change_History { get; set; }
        public virtual DbSet<Dining_Meal_Plan_Id_Mapping> Dining_Meal_Plan_Id_Mapping { get; set; }
        public virtual DbSet<Dining_Mealplans> Dining_Mealplans { get; set; }
        public virtual DbSet<Dining_Student_Meal_Choice> Dining_Student_Meal_Choice { get; set; }
        public virtual DbSet<ERROR_LOG> ERROR_LOG { get; set; }
        public virtual DbSet<EmergencyContact> EmergencyContact { get; set; }
        public virtual DbSet<FacStaff> FacStaff { get; set; }
        public virtual DbSet<Graduation> Graduation { get; set; }
        public virtual DbSet<Health_Question> Health_Question { get; set; }
        public virtual DbSet<Health_Status> Health_Status { get; set; }
        public virtual DbSet<Health_Status_CTRL> Health_Status_CTRL { get; set; }
        public virtual DbSet<Housing_Applicants> Housing_Applicants { get; set; }
        public virtual DbSet<Housing_Applications> Housing_Applications { get; set; }
        public virtual DbSet<Housing_HallChoices> Housing_HallChoices { get; set; }
        public virtual DbSet<Housing_Halls> Housing_Halls { get; set; }
        public virtual DbSet<Information_Change_Request> Information_Change_Request { get; set; }
        public virtual DbSet<Internships_as_Involvements> Internships_as_Involvements { get; set; }
        public virtual DbSet<InvolvementOffering> InvolvementOffering { get; set; }
        public virtual DbSet<JENZ_ACT_CLUB_DEF> JENZ_ACT_CLUB_DEF { get; set; }
        public virtual DbSet<JNZB_ACTIVITIES> JNZB_ACTIVITIES { get; set; }
        public virtual DbSet<MEMBERSHIP> MEMBERSHIP { get; set; }
        public virtual DbSet<MYSCHEDULE> MYSCHEDULE { get; set; }
        public virtual DbSet<Mailboxes> Mailboxes { get; set; }
        public virtual DbSet<Majors> Majors { get; set; }
        public virtual DbSet<Match> Match { get; set; }
        public virtual DbSet<MatchBracket> MatchBracket { get; set; }
        public virtual DbSet<MatchParticipant> MatchParticipant { get; set; }
        public virtual DbSet<MatchStatus> MatchStatus { get; set; }
        public virtual DbSet<MatchTeam> MatchTeam { get; set; }
        public virtual DbSet<MatchTeamStatus> MatchTeamStatus { get; set; }
        public virtual DbSet<MembershipView> MembershipView { get; set; }
        public virtual DbSet<Message_Rooms> Message_Rooms { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Minors> Minors { get; set; }
        public virtual DbSet<PART_DEF> PART_DEF { get; set; }
        public virtual DbSet<Participant> Participant { get; set; }
        public virtual DbSet<ParticipantActivity> ParticipantActivity { get; set; }
        public virtual DbSet<ParticipantNotification> ParticipantNotification { get; set; }
        public virtual DbSet<ParticipantStatus> ParticipantStatus { get; set; }
        public virtual DbSet<ParticipantStatusHistory> ParticipantStatusHistory { get; set; }
        public virtual DbSet<ParticipantTeam> ParticipantTeam { get; set; }
        public virtual DbSet<ParticipantView> ParticipantView { get; set; }
        public virtual DbSet<Police> Police { get; set; }
        public virtual DbSet<PrivType> PrivType { get; set; }
        public virtual DbSet<REQUEST> REQUEST { get; set; }
        public virtual DbSet<RequestView> RequestView { get; set; }
        public virtual DbSet<RoleType> RoleType { get; set; }
        public virtual DbSet<RoomAssign> RoomAssign { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Save_Bookings> Save_Bookings { get; set; }
        public virtual DbSet<Save_Rides> Save_Rides { get; set; }
        public virtual DbSet<ScheduleCourses> ScheduleCourses { get; set; }
        public virtual DbSet<ScheduleTerms> ScheduleTerms { get; set; }
        public virtual DbSet<Schedule_Control> Schedule_Control { get; set; }
        public virtual DbSet<Series> Series { get; set; }
        public virtual DbSet<SeriesSchedule> SeriesSchedule { get; set; }
        public virtual DbSet<SeriesStatus> SeriesStatus { get; set; }
        public virtual DbSet<SeriesSurface> SeriesSurface { get; set; }
        public virtual DbSet<SeriesTeam> SeriesTeam { get; set; }
        public virtual DbSet<SeriesTeamView> SeriesTeamView { get; set; }
        public virtual DbSet<SeriesType> SeriesType { get; set; }
        public virtual DbSet<Slider_Images> Slider_Images { get; set; }
        public virtual DbSet<Sport> Sport { get; set; }
        public virtual DbSet<States> States { get; set; }
        public virtual DbSet<Statistic> Statistic { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentNewsExpiration> StudentNewsExpiration { get; set; }
        public virtual DbSet<Surface> Surface { get; set; }
        public virtual DbSet<Team> Team { get; set; }
        public virtual DbSet<TeamStatus> TeamStatus { get; set; }
        public virtual DbSet<Timesheets_Clock_In_Out> Timesheets_Clock_In_Out { get; set; }
        public virtual DbSet<UserCourses> UserCourses { get; set; }
        public virtual DbSet<User_Connection_Ids> User_Connection_Ids { get; set; }
        public virtual DbSet<User_Rooms> User_Rooms { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACCOUNT>(entity =>
            {
                entity.ToView("ACCOUNT");
            });

            modelBuilder.Entity<ACT_INFO>(entity =>
            {
                entity.HasKey(e => e.ACT_CDE)
                    .HasName("PK_Activity_Info");

                entity.Property(e => e.ACT_CDE).IsFixedLength();

                entity.Property(e => e.ACT_DESC).IsFixedLength();

                entity.Property(e => e.ACT_TYPE).IsFixedLength();

                entity.Property(e => e.ACT_TYPE_DESC).IsFixedLength();
            });

            modelBuilder.Entity<ADMIN>(entity =>
            {
                entity.HasKey(e => e.ADMIN_ID)
                    .HasName("PK_Admin");
            });

            modelBuilder.Entity<AccountPhotoURL>(entity =>
            {
                entity.ToView("AccountPhotoURL");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasOne(d => d.SeriesSchedule)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.SeriesScheduleID)
                    .HasConstraintName("FK_Activity_SeriesSchedule");

                entity.HasOne(d => d.Sport)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.SportID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_Sport");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_ActivityStatus");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.TypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_ActivityType");
            });

            modelBuilder.Entity<Affiliation>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PK_Affiliations");
            });

            modelBuilder.Entity<AffiliationPoints>(entity =>
            {
                entity.HasKey(e => new { e.AffiliationName, e.TeamID, e.SeriesID });

                entity.HasOne(d => d.AffiliationNameNavigation)
                    .WithMany(p => p.AffiliationPoints)
                    .HasForeignKey(d => d.AffiliationName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AffiliationPoints_Affiliations");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.AffiliationPoints)
                    .HasForeignKey(d => d.SeriesID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AffiliationPoints_Series");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.AffiliationPoints)
                    .HasForeignKey(d => d.TeamID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AffiliationPoints_Team");
            });

            modelBuilder.Entity<Alumni>(entity =>
            {
                entity.ToView("Alumni");

                entity.Property(e => e.grad_student).IsFixedLength();
            });

            modelBuilder.Entity<Birthdays>(entity =>
            {
                entity.ToView("Birthdays");
            });

            modelBuilder.Entity<Buildings>(entity =>
            {
                entity.ToView("Buildings");

                entity.Property(e => e.BLDG_CDE).IsFixedLength();

                entity.Property(e => e.BUILDING_DESC).IsFixedLength();
            });

            modelBuilder.Entity<CM_SESSION_MSTR>(entity =>
            {
                entity.ToView("CM_SESSION_MSTR");

                entity.Property(e => e.SESS_CDE).IsFixedLength();
            });

            modelBuilder.Entity<ChapelEvent>(entity =>
            {
                entity.ToView("ChapelEvent");
            });

            modelBuilder.Entity<Clifton_Strengths>(entity =>
            {
                entity.HasKey(e => new { e.ID_NUM, e.ACCESS_CODE })
                    .HasName("PK_CliftonStrengths");

                entity.Property(e => e.Private).HasComment("Whether the user wants their strengths to be private (not shown to other users)");
            });

            modelBuilder.Entity<Countries>(entity =>
            {
                entity.ToView("Countries");

                entity.Property(e => e.CTY).IsFixedLength();
            });

            modelBuilder.Entity<CustomParticipant>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__CustomPa__536C85E5A0FDE2AE");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.HasOne(d => d.UsernameNavigation)
                    .WithOne(p => p.CustomParticipant)
                    .HasForeignKey<CustomParticipant>(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CustomPar__Usern__70D3A237");
            });

            modelBuilder.Entity<DiningInfo>(entity =>
            {
                entity.ToView("DiningInfo");

                entity.Property(e => e.ChoiceDescription).IsFixedLength();

                entity.Property(e => e.SessionCode).IsFixedLength();
            });

            modelBuilder.Entity<Dining_Meal_Choice_Desc>(entity =>
            {
                entity.ToView("Dining_Meal_Choice_Desc");

                entity.Property(e => e.Meal_Choice_Desc).IsFixedLength();

                entity.Property(e => e.Meal_Choice_Id).IsFixedLength();
            });

            modelBuilder.Entity<Dining_Meal_Plan_Change_History>(entity =>
            {
                entity.ToView("Dining_Meal_Plan_Change_History");

                entity.Property(e => e.OLD_PLAN_DESC).IsFixedLength();
            });

            modelBuilder.Entity<Dining_Meal_Plan_Id_Mapping>(entity =>
            {
                entity.ToView("Dining_Meal_Plan_Id_Mapping");
            });

            modelBuilder.Entity<Dining_Mealplans>(entity =>
            {
                entity.ToView("Dining_Mealplans");
            });

            modelBuilder.Entity<Dining_Student_Meal_Choice>(entity =>
            {
                entity.ToView("Dining_Student_Meal_Choice");

                entity.Property(e => e.MEAL_CHOICE_ID).IsFixedLength();

                entity.Property(e => e.SESS_CDE).IsFixedLength();
            });

            modelBuilder.Entity<EmergencyContact>(entity =>
            {
                entity.ToView("EmergencyContact");

                entity.Property(e => e.AddressAddrCode).IsFixedLength();

                entity.Property(e => e.ApprowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();

                entity.Property(e => e.EmailAddrCode).IsFixedLength();

                entity.Property(e => e.HomeAddrCode).IsFixedLength();

                entity.Property(e => e.HomeExt).IsFixedLength();

                entity.Property(e => e.HomePhone).IsFixedLength();

                entity.Property(e => e.MobileAddrCode).IsFixedLength();

                entity.Property(e => e.MobileExt).IsFixedLength();

                entity.Property(e => e.MobilePhone).IsFixedLength();

                entity.Property(e => e.WorkAddrCode).IsFixedLength();

                entity.Property(e => e.WorkExr).IsFixedLength();

                entity.Property(e => e.WorkPhone).IsFixedLength();
            });

            modelBuilder.Entity<FacStaff>(entity =>
            {
                entity.ToView("FacStaff");

                entity.Property(e => e.BuildingDescription).IsFixedLength();
            });

            modelBuilder.Entity<Graduation>(entity =>
            {
                entity.ToView("Graduation");
            });

            modelBuilder.Entity<Health_Status>(entity =>
            {
                entity.HasKey(e => new { e.Created, e.ID_Num })
                    .HasName("PK__Health_S__6CC83B6815B808A2");

                entity.HasOne(d => d.HealthStatus)
                    .WithMany(p => p.Health_Status)
                    .HasForeignKey(d => d.HealthStatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Health_Status_HealthStatus_CTRL");
            });

            modelBuilder.Entity<Housing_Applicants>(entity =>
            {
                entity.HasKey(e => new { e.HousingAppID, e.Username });

                entity.Property(e => e.SESS_CDE).IsFixedLength();

                entity.HasOne(d => d.HousingApp)
                    .WithMany(p => p.Housing_Applicants)
                    .HasForeignKey(d => d.HousingAppID)
                    .HasConstraintName("FK_Applicants_HousingAppID");
            });

            modelBuilder.Entity<Information_Change_Request>(entity =>
            {
                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Internships_as_Involvements>(entity =>
            {
                entity.ToView("Internships_as_Involvements");

                entity.Property(e => e.SESS_CDE).IsFixedLength();

                entity.Property(e => e.TRM_CDE).IsFixedLength();

                entity.Property(e => e.YR_CDE).IsFixedLength();
            });

            modelBuilder.Entity<InvolvementOffering>(entity =>
            {
                entity.ToView("InvolvementOffering");

                entity.Property(e => e.ActivityCode).IsFixedLength();

                entity.Property(e => e.ActivityDescription).IsFixedLength();

                entity.Property(e => e.ActivityType).IsFixedLength();

                entity.Property(e => e.ActivityTypeDescription).IsFixedLength();

                entity.Property(e => e.SessionCode).IsFixedLength();
            });

            modelBuilder.Entity<JENZ_ACT_CLUB_DEF>(entity =>
            {
                entity.ToView("JENZ_ACT_CLUB_DEF");

                entity.Property(e => e.ACT_CDE).IsFixedLength();

                entity.Property(e => e.ACT_DESC).IsFixedLength();

                entity.Property(e => e.ACT_TYPE).IsFixedLength();

                entity.Property(e => e.ACT_TYPE_DESC).IsFixedLength();
            });

            modelBuilder.Entity<JNZB_ACTIVITIES>(entity =>
            {
                entity.Property(e => e.ACT_CDE).IsFixedLength();

                entity.Property(e => e.INCL_PROFILE_RPT).IsFixedLength();

                entity.Property(e => e.JOB_NAME).IsFixedLength();

                entity.Property(e => e.MEMBERSHIP_STS).IsFixedLength();

                entity.Property(e => e.PART_CDE).IsFixedLength();

                entity.Property(e => e.SESS_CDE).IsFixedLength();

                entity.Property(e => e.TRACK_MTG_ATTEND).IsFixedLength();

                entity.Property(e => e.USER_NAME).IsFixedLength();
            });

            modelBuilder.Entity<MEMBERSHIP>(entity =>
            {
                entity.HasKey(e => e.MEMBERSHIP_ID)
                    .HasName("PK_Membership");

                entity.Property(e => e.ACT_CDE).IsFixedLength();

                entity.Property(e => e.JOB_NAME).IsFixedLength();

                entity.Property(e => e.PART_CDE).IsFixedLength();

                entity.Property(e => e.SESS_CDE).IsFixedLength();
            });

            modelBuilder.Entity<MYSCHEDULE>(entity =>
            {
                entity.HasKey(e => new { e.EVENT_ID, e.GORDON_ID });
            });

            modelBuilder.Entity<Mailboxes>(entity =>
            {
                entity.ToView("Mailboxes");
            });

            modelBuilder.Entity<Majors>(entity =>
            {
                entity.ToView("Majors");
            });

            modelBuilder.Entity<Match>(entity =>
            {
                entity.Property(e => e.SurfaceID).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Series)
                    .WithMany(p => p.Match)
                    .HasForeignKey(d => d.SeriesID)
                    .HasConstraintName("FK_Match_Series");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Match)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_MatchStatus");

                entity.HasOne(d => d.Surface)
                    .WithMany(p => p.Match)
                    .HasForeignKey(d => d.SurfaceID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Match_Surface");
            });

            modelBuilder.Entity<MatchBracket>(entity =>
            {
                entity.Property(e => e.MatchID).ValueGeneratedNever();

                entity.HasOne(d => d.Match)
                    .WithOne(p => p.MatchBracket)
                    .HasForeignKey<MatchBracket>(d => d.MatchID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatchBracket_Match");
            });

            modelBuilder.Entity<MatchParticipant>(entity =>
            {
                entity.HasOne(d => d.Match)
                    .WithMany(p => p.MatchParticipant)
                    .HasForeignKey(d => d.MatchID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatchParticipant_Match");

                entity.HasOne(d => d.ParticipantUsernameNavigation)
                    .WithMany(p => p.MatchParticipant)
                    .HasForeignKey(d => d.ParticipantUsername)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatchParticipant_Participant");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.MatchParticipant)
                    .HasForeignKey(d => d.TeamID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatchParticipant_Team");
            });

            modelBuilder.Entity<MatchTeam>(entity =>
            {
                entity.HasOne(d => d.Match)
                    .WithMany(p => p.MatchTeam)
                    .HasForeignKey(d => d.MatchID)
                    .HasConstraintName("FK_MatchTeam_Match");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.MatchTeam)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatchTeam_MatchTeamStatus");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.MatchTeam)
                    .HasForeignKey(d => d.TeamID)
                    .HasConstraintName("FK_MatchTeam_Team");
            });

            modelBuilder.Entity<MembershipView>(entity =>
            {
                entity.ToView("MembershipView");

                entity.Property(e => e.ActivityDescription).IsFixedLength();
            });

            modelBuilder.Entity<Message_Rooms>(entity =>
            {
                entity.HasKey(e => e.room_id)
                    .HasName("PK__Message___19675A8A3E781488");
            });

            modelBuilder.Entity<Minors>(entity =>
            {
                entity.ToView("Minors");
            });

            modelBuilder.Entity<PART_DEF>(entity =>
            {
                entity.ToView("PART_DEF");

                entity.Property(e => e.PART_CDE).IsFixedLength();

                entity.Property(e => e.PART_DESC).IsFixedLength();
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.Property(e => e.AllowEmails).HasDefaultValueSql("((1))");

                entity.Property(e => e.ID).ValueGeneratedOnAdd();

                entity.Property(e => e.SpecifiedGender).IsFixedLength();
            });

            modelBuilder.Entity<ParticipantActivity>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ParticipantActivity)
                    .HasForeignKey(d => d.ActivityID)
                    .HasConstraintName("FK_ParticipantActivity_Activity");

                entity.HasOne(d => d.ParticipantUsernameNavigation)
                    .WithMany(p => p.ParticipantActivity)
                    .HasForeignKey(d => d.ParticipantUsername)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParticipantActivity_Participant");

                entity.HasOne(d => d.PrivType)
                    .WithMany(p => p.ParticipantActivity)
                    .HasForeignKey(d => d.PrivTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PrivType_ParticipantActivity");
            });

            modelBuilder.Entity<ParticipantNotification>(entity =>
            {
                entity.HasOne(d => d.ParticipantUsernameNavigation)
                    .WithMany(p => p.ParticipantNotification)
                    .HasForeignKey(d => d.ParticipantUsername)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParticipantNotification_Participant");
            });

            modelBuilder.Entity<ParticipantStatusHistory>(entity =>
            {
                entity.HasOne(d => d.ParticipantUsernameNavigation)
                    .WithMany(p => p.ParticipantStatusHistory)
                    .HasForeignKey(d => d.ParticipantUsername)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParticipantStatusHistory_Participant");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ParticipantStatusHistory)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParticipantStatusHistory_ParticipantStatus");
            });

            modelBuilder.Entity<ParticipantTeam>(entity =>
            {
                entity.HasOne(d => d.ParticipantUsernameNavigation)
                    .WithMany(p => p.ParticipantTeam)
                    .HasForeignKey(d => d.ParticipantUsername)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ParticipantTeam_Participant");

                entity.HasOne(d => d.RoleType)
                    .WithMany(p => p.ParticipantTeam)
                    .HasForeignKey(d => d.RoleTypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleType_ParticipantTeam");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.ParticipantTeam)
                    .HasForeignKey(d => d.TeamID)
                    .HasConstraintName("FK_ParticipantTeam_Team");
            });

            modelBuilder.Entity<ParticipantView>(entity =>
            {
                entity.ToView("ParticipantView", "RecIM");

                entity.Property(e => e.SpecifiedGender).IsFixedLength();
            });

            modelBuilder.Entity<Police>(entity =>
            {
                entity.ToView("Police");
            });

            modelBuilder.Entity<REQUEST>(entity =>
            {
                entity.HasKey(e => e.REQUEST_ID)
                    .HasName("PK_Request");

                entity.Property(e => e.ACT_CDE).IsFixedLength();

                entity.Property(e => e.PART_CDE).IsFixedLength();

                entity.Property(e => e.SESS_CDE).IsFixedLength();
            });

            modelBuilder.Entity<RequestView>(entity =>
            {
                entity.ToView("RequestView");

                entity.Property(e => e.ActivityDescription).IsFixedLength();

                entity.Property(e => e.ParticipationDescription).IsFixedLength();
            });

            modelBuilder.Entity<RoomAssign>(entity =>
            {
                entity.ToView("RoomAssign");

                entity.Property(e => e.BLDG_CDE).IsFixedLength();

                entity.Property(e => e.BLDG_LOC_CDE).IsFixedLength();

                entity.Property(e => e.ROOM_ASSIGN_STS).IsFixedLength();

                entity.Property(e => e.ROOM_CDE).IsFixedLength();

                entity.Property(e => e.ROOM_TYPE).IsFixedLength();

                entity.Property(e => e.SESS_CDE).IsFixedLength();
            });

            modelBuilder.Entity<Save_Bookings>(entity =>
            {
                entity.HasKey(e => new { e.ID, e.rideID });

                entity.HasOne(d => d.ride)
                    .WithMany(p => p.Save_Bookings)
                    .HasForeignKey(d => d.rideID)
                    .HasConstraintName("FK_booking_rides");
            });

            modelBuilder.Entity<ScheduleCourses>(entity =>
            {
                entity.ToView("ScheduleCourses");

                entity.Property(e => e.BLDG_CDE).IsFixedLength();

                entity.Property(e => e.CRS_CDE).IsFixedLength();

                entity.Property(e => e.CRS_TITLE).IsFixedLength();

                entity.Property(e => e.FRIDAY_CDE).IsFixedLength();

                entity.Property(e => e.MONDAY_CDE).IsFixedLength();

                entity.Property(e => e.ROOM_CDE).IsFixedLength();

                entity.Property(e => e.SATURDAY_CDE).IsFixedLength();

                entity.Property(e => e.SUBTERM_CDE).IsFixedLength();

                entity.Property(e => e.SUNDAY_CDE).IsFixedLength();

                entity.Property(e => e.THURSDAY_CDE).IsFixedLength();

                entity.Property(e => e.TRM_CDE).IsFixedLength();

                entity.Property(e => e.TUESDAY_CDE).IsFixedLength();

                entity.Property(e => e.WEDNESDAY_CDE).IsFixedLength();

                entity.Property(e => e.YR_CDE).IsFixedLength();
            });

            modelBuilder.Entity<ScheduleTerms>(entity =>
            {
                entity.ToView("ScheduleTerms");

                entity.Property(e => e.SubTermCode).IsFixedLength();

                entity.Property(e => e.SubTermDescription).IsFixedLength();

                entity.Property(e => e.TermCode).IsFixedLength();

                entity.Property(e => e.YearCode).IsFixedLength();
            });

            modelBuilder.Entity<Schedule_Control>(entity =>
            {
                entity.Property(e => e.IsSchedulePrivate).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Series>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.ActivityID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Series_Activity");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.ScheduleID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeriesSchedule_Series");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SeriesStatus_Series");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.TypeID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Series_SeriesType");

                entity.HasOne(d => d.Winner)
                    .WithMany(p => p.Series)
                    .HasForeignKey(d => d.WinnerID)
                    .HasConstraintName("FK_Series_Team");
            });

            modelBuilder.Entity<SeriesSurface>(entity =>
            {
                entity.HasOne(d => d.Series)
                    .WithMany(p => p.SeriesSurface)
                    .HasForeignKey(d => d.SeriesID)
                    .HasConstraintName("FK_SeriesSurface_Series");

                entity.HasOne(d => d.Surface)
                    .WithMany(p => p.SeriesSurface)
                    .HasForeignKey(d => d.SurfaceID)
                    .HasConstraintName("FK_SeriesSurface_Surface");
            });

            modelBuilder.Entity<SeriesTeam>(entity =>
            {
                entity.HasOne(d => d.Series)
                    .WithMany(p => p.SeriesTeam)
                    .HasForeignKey(d => d.SeriesID)
                    .HasConstraintName("FK_SeriesTeam_Series");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.SeriesTeam)
                    .HasForeignKey(d => d.TeamID)
                    .HasConstraintName("FK_SeriesTeam_Team");
            });

            modelBuilder.Entity<SeriesTeamView>(entity =>
            {
                entity.ToView("SeriesTeamView", "RecIM");
            });

            modelBuilder.Entity<States>(entity =>
            {
                entity.ToView("States");
            });

            modelBuilder.Entity<Statistic>(entity =>
            {
                entity.HasOne(d => d.ParticipantTeam)
                    .WithMany(p => p.Statistic)
                    .HasForeignKey(d => d.ParticipantTeamID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Statistic_ParticipantTeam");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToView("Student");

                entity.Property(e => e.BuildingDescription).IsFixedLength();
            });

            modelBuilder.Entity<StudentNewsExpiration>(entity =>
            {
                entity.HasKey(e => e.SNID)
                    .HasName("PK_StudentNewsExpiration_SNID");

                entity.Property(e => e.SNID).ValueGeneratedNever();
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.ActivityID)
                    .HasConstraintName("FK_Team_Activity");

                entity.HasOne(d => d.AffiliationNavigation)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.Affiliation)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Team_Affiliations");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Team)
                    .HasForeignKey(d => d.StatusID)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Team_TeamStatus");
            });

            modelBuilder.Entity<UserCourses>(entity =>
            {
                entity.ToView("UserCourses");

                entity.Property(e => e.BLDG_CDE).IsFixedLength();

                entity.Property(e => e.CRS_CDE).IsFixedLength();

                entity.Property(e => e.CRS_TITLE).IsFixedLength();

                entity.Property(e => e.FRIDAY_CDE).IsFixedLength();

                entity.Property(e => e.MONDAY_CDE).IsFixedLength();

                entity.Property(e => e.ROOM_CDE).IsFixedLength();

                entity.Property(e => e.SATURDAY_CDE).IsFixedLength();

                entity.Property(e => e.SUBTERM_DESC).IsFixedLength();

                entity.Property(e => e.SUNDAY_CDE).IsFixedLength();

                entity.Property(e => e.THURSDAY_CDE).IsFixedLength();

                entity.Property(e => e.TRM_CDE).IsFixedLength();

                entity.Property(e => e.TUESDAY_CDE).IsFixedLength();

                entity.Property(e => e.WEDNESDAY_CDE).IsFixedLength();

                entity.Property(e => e.YR_CDE).IsFixedLength();
            });

            modelBuilder.HasSequence("Information_Change_Request_Seq");

            OnModelCreatingGeneratedProcedures(modelBuilder);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}