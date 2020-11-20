
namespace Gordon360.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class CCTEntities1 : DbContext
    {
        public CCTEntities1()
            : base("name=CCTEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AA_ApartmentApplications> AA_ApartmentApplications { get; set; }
        public virtual DbSet<ACT_INFO> ACT_INFO { get; set; }
        public virtual DbSet<ADMIN> ADMIN { get; set; }
        public virtual DbSet<Clifton_Strengths> Clifton_Strengths { get; set; }
        public virtual DbSet<CUSTOM_PROFILE> CUSTOM_PROFILE { get; set; }
        public virtual DbSet<ERROR_LOG> ERROR_LOG { get; set; }
        public virtual DbSet<JNZB_ACTIVITIES> JNZB_ACTIVITIES { get; set; }
        public virtual DbSet<MEMBERSHIP> MEMBERSHIP { get; set; }
        public virtual DbSet<MYSCHEDULE> MYSCHEDULE { get; set; }
        public virtual DbSet<REQUEST> REQUEST { get; set; }
        public virtual DbSet<Save_Bookings> Save_Bookings { get; set; }
        public virtual DbSet<Save_Rides> Save_Rides { get; set; }
        public virtual DbSet<Schedule_Control> Schedule_Control { get; set; }
        public virtual DbSet<StudentNewsExpiration> StudentNewsExpiration { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<AA_ApartmentChoices> AA_ApartmentChoices { get; set; }
        public virtual DbSet<AA_Applicants> AA_Applicants { get; set; }
        public virtual DbSet<Health_Check> Health_Check { get; set; }
        public virtual DbSet<Health_Check_Updated> Health_Check_Updated { get; set; }
        public virtual DbSet<Health_Override> Health_Override { get; set; }
        public virtual DbSet<Health_Question> Health_Question { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Rooms> Rooms { get; set; }
        public virtual DbSet<Timesheets_Clock_In_Out> Timesheets_Clock_In_Out { get; set; }
        public virtual DbSet<User_Rooms> User_Rooms { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<C360_SLIDER> C360_SLIDER { get; set; }
        public virtual DbSet<ACCOUNT> ACCOUNT { get; set; }
        public virtual DbSet<Alumni> Alumni { get; set; }
        public virtual DbSet<Buildings> Buildings { get; set; }
        public virtual DbSet<ChapelEvent> ChapelEvent { get; set; }
        public virtual DbSet<CM_SESSION_MSTR> CM_SESSION_MSTR { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<Dining_Meal_Choice_Desc> Dining_Meal_Choice_Desc { get; set; }
        public virtual DbSet<Dining_Meal_Plan_Id_Mapping> Dining_Meal_Plan_Id_Mapping { get; set; }
        public virtual DbSet<Dining_Mealplans> Dining_Mealplans { get; set; }
        public virtual DbSet<Dining_Student_Meal_Choice> Dining_Student_Meal_Choice { get; set; }
        public virtual DbSet<DiningInfo> DiningInfo { get; set; }
        public virtual DbSet<FacStaff> FacStaff { get; set; }
        public virtual DbSet<JENZ_ACT_CLUB_DEF> JENZ_ACT_CLUB_DEF { get; set; }
        public virtual DbSet<PART_DEF> PART_DEF { get; set; }
        public virtual DbSet<RoomAssign> RoomAssign { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    
        public virtual ObjectResult<ACTIVE_CLUBS_PER_SESS_ID_Result> ACTIVE_CLUBS_PER_SESS_ID(string sESS_CDE)
        {
            var sESS_CDEParameter = sESS_CDE != null ?
                new ObjectParameter("SESS_CDE", sESS_CDE) :
                new ObjectParameter("SESS_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ACTIVE_CLUBS_PER_SESS_ID_Result>("ACTIVE_CLUBS_PER_SESS_ID", sESS_CDEParameter);
        }
    
        public virtual ObjectResult<ADVISOR_EMAILS_PER_ACT_CDE_Result> ADVISOR_EMAILS_PER_ACT_CDE(string aCT_CDE, string sESS_CDE)
        {
            var aCT_CDEParameter = aCT_CDE != null ?
                new ObjectParameter("ACT_CDE", aCT_CDE) :
                new ObjectParameter("ACT_CDE", typeof(string));
    
            var sESS_CDEParameter = sESS_CDE != null ?
                new ObjectParameter("SESS_CDE", sESS_CDE) :
                new ObjectParameter("SESS_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ADVISOR_EMAILS_PER_ACT_CDE_Result>("ADVISOR_EMAILS_PER_ACT_CDE", aCT_CDEParameter, sESS_CDEParameter);
        }
    
        public virtual ObjectResult<ADVISOR_SEPARATE_Result> ADVISOR_SEPARATE(Nullable<int> sTUDENT_ID)
        {
            var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
                new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
                new ObjectParameter("STUDENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ADVISOR_SEPARATE_Result>("ADVISOR_SEPARATE", sTUDENT_IDParameter);
        }
    
        public virtual ObjectResult<ALL_BASIC_INFO_Result> ALL_BASIC_INFO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_BASIC_INFO_Result>("ALL_BASIC_INFO");
        }
    
        public virtual ObjectResult<ALL_BASIC_INFO_NOT_ALUMNI_Result> ALL_BASIC_INFO_NOT_ALUMNI()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_BASIC_INFO_NOT_ALUMNI_Result>("ALL_BASIC_INFO_NOT_ALUMNI");
        }
    
        public virtual ObjectResult<ALL_MEMBERSHIPS_Result> ALL_MEMBERSHIPS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_MEMBERSHIPS_Result>("ALL_MEMBERSHIPS");
        }
    
        public virtual ObjectResult<ALL_REQUESTS_Result> ALL_REQUESTS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ALL_REQUESTS_Result>("ALL_REQUESTS");
        }
    
        public virtual int ALL_SUPERVISORS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ALL_SUPERVISORS");
        }
    
        public virtual int CANCEL_RIDE(Nullable<int> sTUDENT_ID, string rIDE_ID)
        {
            var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
                new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
                new ObjectParameter("STUDENT_ID", typeof(int));
    
            var rIDE_IDParameter = rIDE_ID != null ?
                new ObjectParameter("RIDE_ID", rIDE_ID) :
                new ObjectParameter("RIDE_ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CANCEL_RIDE", sTUDENT_IDParameter, rIDE_IDParameter);
        }
    
        public virtual ObjectResult<COURSES_FOR_PROFESSOR_Result> COURSES_FOR_PROFESSOR(Nullable<int> professor_id, string sess_cde)
        {
            var professor_idParameter = professor_id.HasValue ?
                new ObjectParameter("professor_id", professor_id) :
                new ObjectParameter("professor_id", typeof(int));
    
            var sess_cdeParameter = sess_cde != null ?
                new ObjectParameter("sess_cde", sess_cde) :
                new ObjectParameter("sess_cde", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<COURSES_FOR_PROFESSOR_Result>("COURSES_FOR_PROFESSOR", professor_idParameter, sess_cdeParameter);
        }
    
        public virtual int CREATE_BOOKING(string iD, string rIDEID, Nullable<byte> iSDRIVER)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var rIDEIDParameter = rIDEID != null ?
                new ObjectParameter("RIDEID", rIDEID) :
                new ObjectParameter("RIDEID", typeof(string));
    
            var iSDRIVERParameter = iSDRIVER.HasValue ?
                new ObjectParameter("ISDRIVER", iSDRIVER) :
                new ObjectParameter("ISDRIVER", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CREATE_BOOKING", iDParameter, rIDEIDParameter, iSDRIVERParameter);
        }
    
        public virtual int CREATE_MESSAGE_ROOM(Nullable<int> p_id, string name, Nullable<bool> group, Nullable<System.DateTime> createdAt, Nullable<System.DateTime> lastUpdated, byte[] roomImage)
        {
            var p_idParameter = p_id.HasValue ?
                new ObjectParameter("p_id", p_id) :
                new ObjectParameter("p_id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var groupParameter = group.HasValue ?
                new ObjectParameter("group", group) :
                new ObjectParameter("group", typeof(bool));
    
            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("createdAt", createdAt) :
                new ObjectParameter("createdAt", typeof(System.DateTime));
    
            var lastUpdatedParameter = lastUpdated.HasValue ?
                new ObjectParameter("lastUpdated", lastUpdated) :
                new ObjectParameter("lastUpdated", typeof(System.DateTime));
    
            var roomImageParameter = roomImage != null ?
                new ObjectParameter("roomImage", roomImage) :
                new ObjectParameter("roomImage", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CREATE_MESSAGE_ROOM", p_idParameter, nameParameter, groupParameter, createdAtParameter, lastUpdatedParameter, roomImageParameter);
        }
    
        public virtual int CREATE_MYSCHEDULE(string eVENTID, string gORDONID, string lOCATION, string dESCRIPTION, string mON_CDE, string tUE_CDE, string wED_CDE, string tHU_CDE, string fRI_CDE, string sAT_CDE, string sUN_CDE, Nullable<int> iS_ALLDAY, Nullable<System.TimeSpan> bEGINTIME, Nullable<System.TimeSpan> eNDTIME)
        {
            var eVENTIDParameter = eVENTID != null ?
                new ObjectParameter("EVENTID", eVENTID) :
                new ObjectParameter("EVENTID", typeof(string));
    
            var gORDONIDParameter = gORDONID != null ?
                new ObjectParameter("GORDONID", gORDONID) :
                new ObjectParameter("GORDONID", typeof(string));
    
            var lOCATIONParameter = lOCATION != null ?
                new ObjectParameter("LOCATION", lOCATION) :
                new ObjectParameter("LOCATION", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var mON_CDEParameter = mON_CDE != null ?
                new ObjectParameter("MON_CDE", mON_CDE) :
                new ObjectParameter("MON_CDE", typeof(string));
    
            var tUE_CDEParameter = tUE_CDE != null ?
                new ObjectParameter("TUE_CDE", tUE_CDE) :
                new ObjectParameter("TUE_CDE", typeof(string));
    
            var wED_CDEParameter = wED_CDE != null ?
                new ObjectParameter("WED_CDE", wED_CDE) :
                new ObjectParameter("WED_CDE", typeof(string));
    
            var tHU_CDEParameter = tHU_CDE != null ?
                new ObjectParameter("THU_CDE", tHU_CDE) :
                new ObjectParameter("THU_CDE", typeof(string));
    
            var fRI_CDEParameter = fRI_CDE != null ?
                new ObjectParameter("FRI_CDE", fRI_CDE) :
                new ObjectParameter("FRI_CDE", typeof(string));
    
            var sAT_CDEParameter = sAT_CDE != null ?
                new ObjectParameter("SAT_CDE", sAT_CDE) :
                new ObjectParameter("SAT_CDE", typeof(string));
    
            var sUN_CDEParameter = sUN_CDE != null ?
                new ObjectParameter("SUN_CDE", sUN_CDE) :
                new ObjectParameter("SUN_CDE", typeof(string));
    
            var iS_ALLDAYParameter = iS_ALLDAY.HasValue ?
                new ObjectParameter("IS_ALLDAY", iS_ALLDAY) :
                new ObjectParameter("IS_ALLDAY", typeof(int));
    
            var bEGINTIMEParameter = bEGINTIME.HasValue ?
                new ObjectParameter("BEGINTIME", bEGINTIME) :
                new ObjectParameter("BEGINTIME", typeof(System.TimeSpan));
    
            var eNDTIMEParameter = eNDTIME.HasValue ?
                new ObjectParameter("ENDTIME", eNDTIME) :
                new ObjectParameter("ENDTIME", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CREATE_MYSCHEDULE", eVENTIDParameter, gORDONIDParameter, lOCATIONParameter, dESCRIPTIONParameter, mON_CDEParameter, tUE_CDEParameter, wED_CDEParameter, tHU_CDEParameter, fRI_CDEParameter, sAT_CDEParameter, sUN_CDEParameter, iS_ALLDAYParameter, bEGINTIMEParameter, eNDTIMEParameter);
        }
    
        public virtual int CREATE_RIDE(string rIDEID, string dESTINATION, string mEETINGPOINT, Nullable<System.DateTime> sTARTTIME, Nullable<System.DateTime> eNDTIME, Nullable<int> cAPACITY, string nOTES, Nullable<byte> cANCELED)
        {
            var rIDEIDParameter = rIDEID != null ?
                new ObjectParameter("RIDEID", rIDEID) :
                new ObjectParameter("RIDEID", typeof(string));
    
            var dESTINATIONParameter = dESTINATION != null ?
                new ObjectParameter("DESTINATION", dESTINATION) :
                new ObjectParameter("DESTINATION", typeof(string));
    
            var mEETINGPOINTParameter = mEETINGPOINT != null ?
                new ObjectParameter("MEETINGPOINT", mEETINGPOINT) :
                new ObjectParameter("MEETINGPOINT", typeof(string));
    
            var sTARTTIMEParameter = sTARTTIME.HasValue ?
                new ObjectParameter("STARTTIME", sTARTTIME) :
                new ObjectParameter("STARTTIME", typeof(System.DateTime));
    
            var eNDTIMEParameter = eNDTIME.HasValue ?
                new ObjectParameter("ENDTIME", eNDTIME) :
                new ObjectParameter("ENDTIME", typeof(System.DateTime));
    
            var cAPACITYParameter = cAPACITY.HasValue ?
                new ObjectParameter("CAPACITY", cAPACITY) :
                new ObjectParameter("CAPACITY", typeof(int));
    
            var nOTESParameter = nOTES != null ?
                new ObjectParameter("NOTES", nOTES) :
                new ObjectParameter("NOTES", typeof(string));
    
            var cANCELEDParameter = cANCELED.HasValue ?
                new ObjectParameter("CANCELED", cANCELED) :
                new ObjectParameter("CANCELED", typeof(byte));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CREATE_RIDE", rIDEIDParameter, dESTINATIONParameter, mEETINGPOINTParameter, sTARTTIMEParameter, eNDTIMEParameter, cAPACITYParameter, nOTESParameter, cANCELEDParameter);
        }
    
        public virtual int CREATE_SOCIAL_LINKS(string uSERNAME, string fACEBOOK, string tWITTER, string iNSTAGRAM, string lINKEDIN)
        {
            var uSERNAMEParameter = uSERNAME != null ?
                new ObjectParameter("USERNAME", uSERNAME) :
                new ObjectParameter("USERNAME", typeof(string));
    
            var fACEBOOKParameter = fACEBOOK != null ?
                new ObjectParameter("FACEBOOK", fACEBOOK) :
                new ObjectParameter("FACEBOOK", typeof(string));
    
            var tWITTERParameter = tWITTER != null ?
                new ObjectParameter("TWITTER", tWITTER) :
                new ObjectParameter("TWITTER", typeof(string));
    
            var iNSTAGRAMParameter = iNSTAGRAM != null ?
                new ObjectParameter("INSTAGRAM", iNSTAGRAM) :
                new ObjectParameter("INSTAGRAM", typeof(string));
    
            var lINKEDINParameter = lINKEDIN != null ?
                new ObjectParameter("LINKEDIN", lINKEDIN) :
                new ObjectParameter("LINKEDIN", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CREATE_SOCIAL_LINKS", uSERNAMEParameter, fACEBOOKParameter, tWITTERParameter, iNSTAGRAMParameter, lINKEDINParameter);
        }
    
        public virtual ObjectResult<string> CURRENT_SESSION()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("CURRENT_SESSION");
        }
    
        public virtual int DELETE_BOOKING(string rIDE_ID, string iD)
        {
            var rIDE_IDParameter = rIDE_ID != null ?
                new ObjectParameter("RIDE_ID", rIDE_ID) :
                new ObjectParameter("RIDE_ID", typeof(string));
    
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_BOOKING", rIDE_IDParameter, iDParameter);
        }
    
        public virtual int DELETE_BOOKINGS(string rIDE_ID)
        {
            var rIDE_IDParameter = rIDE_ID != null ?
                new ObjectParameter("RIDE_ID", rIDE_ID) :
                new ObjectParameter("RIDE_ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_BOOKINGS", rIDE_IDParameter);
        }
    
        public virtual int DELETE_CLOCK_IN(string iD_Num)
        {
            var iD_NumParameter = iD_Num != null ?
                new ObjectParameter("ID_Num", iD_Num) :
                new ObjectParameter("ID_Num", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_CLOCK_IN", iD_NumParameter);
        }
    
        public virtual int DELETE_MYSCHEDULE(string eVENTID, string gORDONID)
        {
            var eVENTIDParameter = eVENTID != null ?
                new ObjectParameter("EVENTID", eVENTID) :
                new ObjectParameter("EVENTID", typeof(string));
    
            var gORDONIDParameter = gORDONID != null ?
                new ObjectParameter("GORDONID", gORDONID) :
                new ObjectParameter("GORDONID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_MYSCHEDULE", eVENTIDParameter, gORDONIDParameter);
        }
    
        public virtual int DELETE_NEWS_ITEM(Nullable<int> sNID, string username)
        {
            var sNIDParameter = sNID.HasValue ?
                new ObjectParameter("SNID", sNID) :
                new ObjectParameter("SNID", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_NEWS_ITEM", sNIDParameter, usernameParameter);
        }
    
        public virtual int DELETE_RIDE(string rIDE_ID)
        {
            var rIDE_IDParameter = rIDE_ID != null ?
                new ObjectParameter("RIDE_ID", rIDE_ID) :
                new ObjectParameter("RIDE_ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_RIDE", rIDE_IDParameter);
        }
    
        public virtual ObjectResult<string> DINING_INFO_BY_STUDENT_ID(Nullable<int> sTUDENT_ID, string sESS_CDE)
        {
            var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
                new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
                new ObjectParameter("STUDENT_ID", typeof(int));
    
            var sESS_CDEParameter = sESS_CDE != null ?
                new ObjectParameter("SESS_CDE", sESS_CDE) :
                new ObjectParameter("SESS_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("DINING_INFO_BY_STUDENT_ID", sTUDENT_IDParameter, sESS_CDEParameter);
        }
    
        public virtual ObjectResult<string> DISTINCT_ACT_TYPE(string sESS_CDE)
        {
            var sESS_CDEParameter = sESS_CDE != null ?
                new ObjectParameter("SESS_CDE", sESS_CDE) :
                new ObjectParameter("SESS_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("DISTINCT_ACT_TYPE", sESS_CDEParameter);
        }
    
        public virtual ObjectResult<EMAILS_PER_ACT_CDE_Result> EMAILS_PER_ACT_CDE(string aCT_CDE, string sESS_CDE)
        {
            var aCT_CDEParameter = aCT_CDE != null ?
                new ObjectParameter("ACT_CDE", aCT_CDE) :
                new ObjectParameter("ACT_CDE", typeof(string));
    
            var sESS_CDEParameter = sESS_CDE != null ?
                new ObjectParameter("SESS_CDE", sESS_CDE) :
                new ObjectParameter("SESS_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EMAILS_PER_ACT_CDE_Result>("EMAILS_PER_ACT_CDE", aCT_CDEParameter, sESS_CDEParameter);
        }
    
        public virtual ObjectResult<EVENTS_BY_STUDENT_ID_Result> EVENTS_BY_STUDENT_ID(string sTU_USERNAME)
        {
            var sTU_USERNAMEParameter = sTU_USERNAME != null ?
                new ObjectParameter("STU_USERNAME", sTU_USERNAME) :
                new ObjectParameter("STU_USERNAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EVENTS_BY_STUDENT_ID_Result>("EVENTS_BY_STUDENT_ID", sTU_USERNAMEParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> GET_AA_APPID_BY_NAME_AND_DATE(Nullable<System.DateTime> nOW, Nullable<int> mODIFIER_ID)
        {
            var nOWParameter = nOW.HasValue ?
                new ObjectParameter("NOW", nOW) :
                new ObjectParameter("NOW", typeof(System.DateTime));
    
            var mODIFIER_IDParameter = mODIFIER_ID.HasValue ?
                new ObjectParameter("MODIFIER_ID", mODIFIER_ID) :
                new ObjectParameter("MODIFIER_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("GET_AA_APPID_BY_NAME_AND_DATE", nOWParameter, mODIFIER_IDParameter);
        }
    
        public virtual ObjectResult<GET_ALL_HEALTH_STATUS_Result> GET_ALL_HEALTH_STATUS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_ALL_HEALTH_STATUS_Result>("GET_ALL_HEALTH_STATUS");
        }
    
        public virtual ObjectResult<GET_ALL_MESSAGES_BY_ID_Result> GET_ALL_MESSAGES_BY_ID(Nullable<int> room_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_ALL_MESSAGES_BY_ID_Result>("GET_ALL_MESSAGES_BY_ID", room_idParameter);
        }
    
        public virtual ObjectResult<string> GET_ALL_ROOMS_BY_ID(Nullable<int> user_id)
        {
            var user_idParameter = user_id.HasValue ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GET_ALL_ROOMS_BY_ID", user_idParameter);
        }
    
        public virtual ObjectResult<string> GET_ALL_USERS_BY_ROOM_ID(Nullable<int> room_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GET_ALL_USERS_BY_ROOM_ID", room_idParameter);
        }
    
        public virtual ObjectResult<GET_HEALTH_CHECK_BY_ID_Result> GET_HEALTH_CHECK_BY_ID(Nullable<int> iD_NUM)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_HEALTH_CHECK_BY_ID_Result>("GET_HEALTH_CHECK_BY_ID", iD_NUMParameter);
        }
    
        public virtual ObjectResult<GET_HEALTH_CHECK_QUESTION_Result> GET_HEALTH_CHECK_QUESTION()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_HEALTH_CHECK_QUESTION_Result>("GET_HEALTH_CHECK_QUESTION");
        }
    
        public virtual ObjectResult<GET_HEALTH_STATUS_BY_ID_Result> GET_HEALTH_STATUS_BY_ID(Nullable<int> iD_NUM)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_HEALTH_STATUS_BY_ID_Result>("GET_HEALTH_STATUS_BY_ID", iD_NUMParameter);
        }
    
        public virtual ObjectResult<GET_ROOM_BY_ID_Result> GET_ROOM_BY_ID(Nullable<int> room_id)
        {
            var room_idParameter = room_id.HasValue ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_ROOM_BY_ID_Result>("GET_ROOM_BY_ID", room_idParameter);
        }
    
        public virtual ObjectResult<GET_STU_HOUSING_INFO_Result> GET_STU_HOUSING_INFO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_STU_HOUSING_INFO_Result>("GET_STU_HOUSING_INFO");
        }
    
        public virtual ObjectResult<GET_TIMESHEETS_CLOCK_IN_OUT_Result> GET_TIMESHEETS_CLOCK_IN_OUT(Nullable<int> iD_NUM)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GET_TIMESHEETS_CLOCK_IN_OUT_Result>("GET_TIMESHEETS_CLOCK_IN_OUT", iD_NUMParameter);
        }
    
        public virtual ObjectResult<GRP_ADMIN_EMAILS_PER_ACT_CDE_Result> GRP_ADMIN_EMAILS_PER_ACT_CDE(string aCT_CDE, string sESS_CDE)
        {
            var aCT_CDEParameter = aCT_CDE != null ?
                new ObjectParameter("ACT_CDE", aCT_CDE) :
                new ObjectParameter("ACT_CDE", typeof(string));
    
            var sESS_CDEParameter = sESS_CDE != null ?
                new ObjectParameter("SESS_CDE", sESS_CDE) :
                new ObjectParameter("SESS_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GRP_ADMIN_EMAILS_PER_ACT_CDE_Result>("GRP_ADMIN_EMAILS_PER_ACT_CDE", aCT_CDEParameter, sESS_CDEParameter);
        }
    
        public virtual int INSERT_AA_APPLICANT(Nullable<int> aPPLICATION_ID, Nullable<int> iD_NUM, string aPRT_PROGRAM, Nullable<bool> aPRT_PROGRAM_CREDIT, string sESS_CDE)
        {
            var aPPLICATION_IDParameter = aPPLICATION_ID.HasValue ?
                new ObjectParameter("APPLICATION_ID", aPPLICATION_ID) :
                new ObjectParameter("APPLICATION_ID", typeof(int));
    
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            var aPRT_PROGRAMParameter = aPRT_PROGRAM != null ?
                new ObjectParameter("APRT_PROGRAM", aPRT_PROGRAM) :
                new ObjectParameter("APRT_PROGRAM", typeof(string));
    
            var aPRT_PROGRAM_CREDITParameter = aPRT_PROGRAM_CREDIT.HasValue ?
                new ObjectParameter("APRT_PROGRAM_CREDIT", aPRT_PROGRAM_CREDIT) :
                new ObjectParameter("APRT_PROGRAM_CREDIT", typeof(bool));
    
            var sESS_CDEParameter = sESS_CDE != null ?
                new ObjectParameter("SESS_CDE", sESS_CDE) :
                new ObjectParameter("SESS_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_AA_APPLICANT", aPPLICATION_IDParameter, iD_NUMParameter, aPRT_PROGRAMParameter, aPRT_PROGRAM_CREDITParameter, sESS_CDEParameter);
        }
    
        public virtual int INSERT_AA_APPLICATION(Nullable<System.DateTime> nOW, Nullable<int> mODIFIER_ID)
        {
            var nOWParameter = nOW.HasValue ?
                new ObjectParameter("NOW", nOW) :
                new ObjectParameter("NOW", typeof(System.DateTime));
    
            var mODIFIER_IDParameter = mODIFIER_ID.HasValue ?
                new ObjectParameter("MODIFIER_ID", mODIFIER_ID) :
                new ObjectParameter("MODIFIER_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_AA_APPLICATION", nOWParameter, mODIFIER_IDParameter);
        }
    
        public virtual int INSERT_HEALTH_CHECK(Nullable<int> iD_NUM, Nullable<bool> answer)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            var answerParameter = answer.HasValue ?
                new ObjectParameter("Answer", answer) :
                new ObjectParameter("Answer", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_HEALTH_CHECK", iD_NUMParameter, answerParameter);
        }
    
        public virtual int INSERT_HEALTH_CHECK_UPDATED(Nullable<int> iD_NUM, string status)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_HEALTH_CHECK_UPDATED", iD_NUMParameter, statusParameter);
        }
    
        public virtual int INSERT_HEALTH_OVERRIDE(Nullable<int> iD_NUM, string status, Nullable<System.DateTime> expires, string created_By)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            var statusParameter = status != null ?
                new ObjectParameter("Status", status) :
                new ObjectParameter("Status", typeof(string));
    
            var expiresParameter = expires.HasValue ?
                new ObjectParameter("Expires", expires) :
                new ObjectParameter("Expires", typeof(System.DateTime));
    
            var created_ByParameter = created_By != null ?
                new ObjectParameter("Created_By", created_By) :
                new ObjectParameter("Created_By", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_HEALTH_OVERRIDE", iD_NUMParameter, statusParameter, expiresParameter, created_ByParameter);
        }
    
        public virtual int INSERT_HEALTH_QUESTION(string question, string yesPrompt, string noPrompt)
        {
            var questionParameter = question != null ?
                new ObjectParameter("Question", question) :
                new ObjectParameter("Question", typeof(string));
    
            var yesPromptParameter = yesPrompt != null ?
                new ObjectParameter("YesPrompt", yesPrompt) :
                new ObjectParameter("YesPrompt", typeof(string));
    
            var noPromptParameter = noPrompt != null ?
                new ObjectParameter("NoPrompt", noPrompt) :
                new ObjectParameter("NoPrompt", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_HEALTH_QUESTION", questionParameter, yesPromptParameter, noPromptParameter);
        }
    
        public virtual int INSERT_MESSAGE(Nullable<int> p_id, string room_id, string text, Nullable<System.DateTime> createdAt, string user_id, byte[] image, byte[] video, byte[] audio, Nullable<bool> system, Nullable<bool> sent, Nullable<bool> received, Nullable<bool> pending)
        {
            var p_idParameter = p_id.HasValue ?
                new ObjectParameter("p_id", p_id) :
                new ObjectParameter("p_id", typeof(int));
    
            var room_idParameter = room_id != null ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(string));
    
            var textParameter = text != null ?
                new ObjectParameter("text", text) :
                new ObjectParameter("text", typeof(string));
    
            var createdAtParameter = createdAt.HasValue ?
                new ObjectParameter("createdAt", createdAt) :
                new ObjectParameter("createdAt", typeof(System.DateTime));
    
            var user_idParameter = user_id != null ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(string));
    
            var imageParameter = image != null ?
                new ObjectParameter("image", image) :
                new ObjectParameter("image", typeof(byte[]));
    
            var videoParameter = video != null ?
                new ObjectParameter("video", video) :
                new ObjectParameter("video", typeof(byte[]));
    
            var audioParameter = audio != null ?
                new ObjectParameter("audio", audio) :
                new ObjectParameter("audio", typeof(byte[]));
    
            var systemParameter = system.HasValue ?
                new ObjectParameter("system", system) :
                new ObjectParameter("system", typeof(bool));
    
            var sentParameter = sent.HasValue ?
                new ObjectParameter("sent", sent) :
                new ObjectParameter("sent", typeof(bool));
    
            var receivedParameter = received.HasValue ?
                new ObjectParameter("received", received) :
                new ObjectParameter("received", typeof(bool));
    
            var pendingParameter = pending.HasValue ?
                new ObjectParameter("pending", pending) :
                new ObjectParameter("pending", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_MESSAGE", p_idParameter, room_idParameter, textParameter, createdAtParameter, user_idParameter, imageParameter, videoParameter, audioParameter, systemParameter, sentParameter, receivedParameter, pendingParameter);
        }
    
        public virtual int INSERT_NEWS_ITEM(string username, Nullable<int> categoryID, string subject, string body)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("CategoryID", categoryID) :
                new ObjectParameter("CategoryID", typeof(int));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("Subject", subject) :
                new ObjectParameter("Subject", typeof(string));
    
            var bodyParameter = body != null ?
                new ObjectParameter("Body", body) :
                new ObjectParameter("Body", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_NEWS_ITEM", usernameParameter, categoryIDParameter, subjectParameter, bodyParameter);
        }
    
        public virtual int INSERT_TIMESHEETS_CLOCK_IN_OUT(Nullable<int> iD_NUM, Nullable<bool> state)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            var stateParameter = state.HasValue ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_TIMESHEETS_CLOCK_IN_OUT", iD_NUMParameter, stateParameter);
        }
    
        public virtual int INSERT_USER(string p_id, string name, byte[] avatar)
        {
            var p_idParameter = p_id != null ?
                new ObjectParameter("p_id", p_id) :
                new ObjectParameter("p_id", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var avatarParameter = avatar != null ?
                new ObjectParameter("avatar", avatar) :
                new ObjectParameter("avatar", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_USER", p_idParameter, nameParameter, avatarParameter);
        }
    
        public virtual int INSERT_USER_ROOMS(string user_id, string room_id)
        {
            var user_idParameter = user_id != null ?
                new ObjectParameter("user_id", user_id) :
                new ObjectParameter("user_id", typeof(string));
    
            var room_idParameter = room_id != null ?
                new ObjectParameter("room_id", room_id) :
                new ObjectParameter("room_id", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("INSERT_USER_ROOMS", user_idParameter, room_idParameter);
        }
    
        public virtual ObjectResult<INSTRUCTOR_COURSES_BY_ID_NUM_AND_SESS_CDE_Result> INSTRUCTOR_COURSES_BY_ID_NUM_AND_SESS_CDE(Nullable<int> instructor_id, string sess_cde)
        {
            var instructor_idParameter = instructor_id.HasValue ?
                new ObjectParameter("instructor_id", instructor_id) :
                new ObjectParameter("instructor_id", typeof(int));
    
            var sess_cdeParameter = sess_cde != null ?
                new ObjectParameter("sess_cde", sess_cde) :
                new ObjectParameter("sess_cde", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<INSTRUCTOR_COURSES_BY_ID_NUM_AND_SESS_CDE_Result>("INSTRUCTOR_COURSES_BY_ID_NUM_AND_SESS_CDE", instructor_idParameter, sess_cdeParameter);
        }
    
        public virtual ObjectResult<LEADER_EMAILS_PER_ACT_CDE_Result> LEADER_EMAILS_PER_ACT_CDE(string aCT_CDE, string sESS_CDE)
        {
            var aCT_CDEParameter = aCT_CDE != null ?
                new ObjectParameter("ACT_CDE", aCT_CDE) :
                new ObjectParameter("ACT_CDE", typeof(string));
    
            var sESS_CDEParameter = sESS_CDE != null ?
                new ObjectParameter("SESS_CDE", sESS_CDE) :
                new ObjectParameter("SESS_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LEADER_EMAILS_PER_ACT_CDE_Result>("LEADER_EMAILS_PER_ACT_CDE", aCT_CDEParameter, sESS_CDEParameter);
        }
    
        public virtual ObjectResult<LEADER_MEMBERSHIPS_PER_ACT_CDE_Result> LEADER_MEMBERSHIPS_PER_ACT_CDE(string aCT_CDE)
        {
            var aCT_CDEParameter = aCT_CDE != null ?
                new ObjectParameter("ACT_CDE", aCT_CDE) :
                new ObjectParameter("ACT_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<LEADER_MEMBERSHIPS_PER_ACT_CDE_Result>("LEADER_MEMBERSHIPS_PER_ACT_CDE", aCT_CDEParameter);
        }
    
        public virtual ObjectResult<MEMBERSHIPS_PER_ACT_CDE_Result> MEMBERSHIPS_PER_ACT_CDE(string aCT_CDE)
        {
            var aCT_CDEParameter = aCT_CDE != null ?
                new ObjectParameter("ACT_CDE", aCT_CDE) :
                new ObjectParameter("ACT_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MEMBERSHIPS_PER_ACT_CDE_Result>("MEMBERSHIPS_PER_ACT_CDE", aCT_CDEParameter);
        }
    
        public virtual ObjectResult<MEMBERSHIPS_PER_STUDENT_ID_Result> MEMBERSHIPS_PER_STUDENT_ID(Nullable<int> sTUDENT_ID)
        {
            var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
                new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
                new ObjectParameter("STUDENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MEMBERSHIPS_PER_STUDENT_ID_Result>("MEMBERSHIPS_PER_STUDENT_ID", sTUDENT_IDParameter);
        }
    
        public virtual ObjectResult<MYSCHEDULE_BY_ID_Result> MYSCHEDULE_BY_ID(Nullable<int> iD_NUM)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MYSCHEDULE_BY_ID_Result>("MYSCHEDULE_BY_ID", iD_NUMParameter);
        }
    
        public virtual ObjectResult<NEWS_CATEGORIES_Result> NEWS_CATEGORIES()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NEWS_CATEGORIES_Result>("NEWS_CATEGORIES");
        }
    
        public virtual ObjectResult<NEWS_NEW_Result> NEWS_NEW()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NEWS_NEW_Result>("NEWS_NEW");
        }
    
        public virtual ObjectResult<NEWS_NOT_EXPIRED_Result> NEWS_NOT_EXPIRED()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NEWS_NOT_EXPIRED_Result>("NEWS_NOT_EXPIRED");
        }
    
        public virtual ObjectResult<NEWS_PERSONAL_UNAPPROVED_Result> NEWS_PERSONAL_UNAPPROVED(string username)
        {
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<NEWS_PERSONAL_UNAPPROVED_Result>("NEWS_PERSONAL_UNAPPROVED", usernameParameter);
        }
    
        public virtual ObjectResult<PHOTO_INFO_PER_USER_NAME_Result> PHOTO_INFO_PER_USER_NAME(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<PHOTO_INFO_PER_USER_NAME_Result>("PHOTO_INFO_PER_USER_NAME", iDParameter);
        }
    
        public virtual ObjectResult<REQUEST_PER_REQUEST_ID_Result> REQUEST_PER_REQUEST_ID(Nullable<int> rEQUEST_ID)
        {
            var rEQUEST_IDParameter = rEQUEST_ID.HasValue ?
                new ObjectParameter("REQUEST_ID", rEQUEST_ID) :
                new ObjectParameter("REQUEST_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<REQUEST_PER_REQUEST_ID_Result>("REQUEST_PER_REQUEST_ID", rEQUEST_IDParameter);
        }
    
        public virtual ObjectResult<REQUESTS_PER_ACT_CDE_Result> REQUESTS_PER_ACT_CDE(string aCT_CDE)
        {
            var aCT_CDEParameter = aCT_CDE != null ?
                new ObjectParameter("ACT_CDE", aCT_CDE) :
                new ObjectParameter("ACT_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<REQUESTS_PER_ACT_CDE_Result>("REQUESTS_PER_ACT_CDE", aCT_CDEParameter);
        }
    
        public virtual ObjectResult<REQUESTS_PER_STUDENT_ID_Result> REQUESTS_PER_STUDENT_ID(Nullable<int> sTUDENT_ID)
        {
            var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
                new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
                new ObjectParameter("STUDENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<REQUESTS_PER_STUDENT_ID_Result>("REQUESTS_PER_STUDENT_ID", sTUDENT_IDParameter);
        }
    
        public virtual ObjectResult<RIDERS_BY_RIDE_ID_Result> RIDERS_BY_RIDE_ID(string rIDE_ID)
        {
            var rIDE_IDParameter = rIDE_ID != null ?
                new ObjectParameter("RIDE_ID", rIDE_ID) :
                new ObjectParameter("RIDE_ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<RIDERS_BY_RIDE_ID_Result>("RIDERS_BY_RIDE_ID", rIDE_IDParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<STUDENT_COURSES_BY_ID_NUM_AND_SESS_CDE_Result> STUDENT_COURSES_BY_ID_NUM_AND_SESS_CDE(Nullable<int> id_num, string sess_cde)
        {
            var id_numParameter = id_num.HasValue ?
                new ObjectParameter("id_num", id_num) :
                new ObjectParameter("id_num", typeof(int));
    
            var sess_cdeParameter = sess_cde != null ?
                new ObjectParameter("sess_cde", sess_cde) :
                new ObjectParameter("sess_cde", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STUDENT_COURSES_BY_ID_NUM_AND_SESS_CDE_Result>("STUDENT_COURSES_BY_ID_NUM_AND_SESS_CDE", id_numParameter, sess_cdeParameter);
        }
    
        public virtual ObjectResult<STUDENT_JOBS_PER_ID_NUM_Result> STUDENT_JOBS_PER_ID_NUM(Nullable<int> iD_NUM)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<STUDENT_JOBS_PER_ID_NUM_Result>("STUDENT_JOBS_PER_ID_NUM", iD_NUMParameter);
        }
    
        public virtual int SUPERVISOR_PER_SUP_ID(Nullable<int> sUP_ID)
        {
            var sUP_IDParameter = sUP_ID.HasValue ?
                new ObjectParameter("SUP_ID", sUP_ID) :
                new ObjectParameter("SUP_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUPERVISOR_PER_SUP_ID", sUP_IDParameter);
        }
    
        public virtual int SUPERVISORS_PER_ACT_CDE(string aCT_CDE)
        {
            var aCT_CDEParameter = aCT_CDE != null ?
                new ObjectParameter("ACT_CDE", aCT_CDE) :
                new ObjectParameter("ACT_CDE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUPERVISORS_PER_ACT_CDE", aCT_CDEParameter);
        }
    
        public virtual int SUPERVISORS_PER_ID_NUM(Nullable<int> iD_NUM)
        {
            var iD_NUMParameter = iD_NUM.HasValue ?
                new ObjectParameter("ID_NUM", iD_NUM) :
                new ObjectParameter("ID_NUM", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SUPERVISORS_PER_ID_NUM", iD_NUMParameter);
        }
    
        public virtual ObjectResult<UPCOMING_RIDES_Result> UPCOMING_RIDES(Nullable<int> sTUDENT_ID)
        {
            var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
                new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
                new ObjectParameter("STUDENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UPCOMING_RIDES_Result>("UPCOMING_RIDES", sTUDENT_IDParameter);
        }
    
        public virtual ObjectResult<UPCOMING_RIDES_BY_STUDENT_ID_Result> UPCOMING_RIDES_BY_STUDENT_ID(Nullable<int> sTUDENT_ID)
        {
            var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
                new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
                new ObjectParameter("STUDENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<UPCOMING_RIDES_BY_STUDENT_ID_Result>("UPCOMING_RIDES_BY_STUDENT_ID", sTUDENT_IDParameter);
        }
    
        public virtual int UPDATE_ACT_INFO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_ACT_INFO");
        }
    
        public virtual int UPDATE_DESCRIPTION(Nullable<int> iD, string vALUE)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var vALUEParameter = vALUE != null ?
                new ObjectParameter("VALUE", vALUE) :
                new ObjectParameter("VALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_DESCRIPTION", iDParameter, vALUEParameter);
        }
    
        public virtual int UPDATE_MYSCHEDULE(string eVENTID, string gORDONID, string lOCATION, string dESCRIPTION, string mON_CDE, string tUE_CDE, string wED_CDE, string tHU_CDE, string fRI_CDE, string sAT_CDE, string sUN_CDE, Nullable<int> iS_ALLDAY, Nullable<System.TimeSpan> bEGINTIME, Nullable<System.TimeSpan> eNDTIME)
        {
            var eVENTIDParameter = eVENTID != null ?
                new ObjectParameter("EVENTID", eVENTID) :
                new ObjectParameter("EVENTID", typeof(string));
    
            var gORDONIDParameter = gORDONID != null ?
                new ObjectParameter("GORDONID", gORDONID) :
                new ObjectParameter("GORDONID", typeof(string));
    
            var lOCATIONParameter = lOCATION != null ?
                new ObjectParameter("LOCATION", lOCATION) :
                new ObjectParameter("LOCATION", typeof(string));
    
            var dESCRIPTIONParameter = dESCRIPTION != null ?
                new ObjectParameter("DESCRIPTION", dESCRIPTION) :
                new ObjectParameter("DESCRIPTION", typeof(string));
    
            var mON_CDEParameter = mON_CDE != null ?
                new ObjectParameter("MON_CDE", mON_CDE) :
                new ObjectParameter("MON_CDE", typeof(string));
    
            var tUE_CDEParameter = tUE_CDE != null ?
                new ObjectParameter("TUE_CDE", tUE_CDE) :
                new ObjectParameter("TUE_CDE", typeof(string));
    
            var wED_CDEParameter = wED_CDE != null ?
                new ObjectParameter("WED_CDE", wED_CDE) :
                new ObjectParameter("WED_CDE", typeof(string));
    
            var tHU_CDEParameter = tHU_CDE != null ?
                new ObjectParameter("THU_CDE", tHU_CDE) :
                new ObjectParameter("THU_CDE", typeof(string));
    
            var fRI_CDEParameter = fRI_CDE != null ?
                new ObjectParameter("FRI_CDE", fRI_CDE) :
                new ObjectParameter("FRI_CDE", typeof(string));
    
            var sAT_CDEParameter = sAT_CDE != null ?
                new ObjectParameter("SAT_CDE", sAT_CDE) :
                new ObjectParameter("SAT_CDE", typeof(string));
    
            var sUN_CDEParameter = sUN_CDE != null ?
                new ObjectParameter("SUN_CDE", sUN_CDE) :
                new ObjectParameter("SUN_CDE", typeof(string));
    
            var iS_ALLDAYParameter = iS_ALLDAY.HasValue ?
                new ObjectParameter("IS_ALLDAY", iS_ALLDAY) :
                new ObjectParameter("IS_ALLDAY", typeof(int));
    
            var bEGINTIMEParameter = bEGINTIME.HasValue ?
                new ObjectParameter("BEGINTIME", bEGINTIME) :
                new ObjectParameter("BEGINTIME", typeof(System.TimeSpan));
    
            var eNDTIMEParameter = eNDTIME.HasValue ?
                new ObjectParameter("ENDTIME", eNDTIME) :
                new ObjectParameter("ENDTIME", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_MYSCHEDULE", eVENTIDParameter, gORDONIDParameter, lOCATIONParameter, dESCRIPTIONParameter, mON_CDEParameter, tUE_CDEParameter, wED_CDEParameter, tHU_CDEParameter, fRI_CDEParameter, sAT_CDEParameter, sUN_CDEParameter, iS_ALLDAYParameter, bEGINTIMEParameter, eNDTIMEParameter);
        }
    
        public virtual int UPDATE_NEWS_ITEM(Nullable<int> sNID, string username, Nullable<int> categoryID, string subject, string body)
        {
            var sNIDParameter = sNID.HasValue ?
                new ObjectParameter("SNID", sNID) :
                new ObjectParameter("SNID", typeof(int));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("CategoryID", categoryID) :
                new ObjectParameter("CategoryID", typeof(int));
    
            var subjectParameter = subject != null ?
                new ObjectParameter("Subject", subject) :
                new ObjectParameter("Subject", typeof(string));
    
            var bodyParameter = body != null ?
                new ObjectParameter("Body", body) :
                new ObjectParameter("Body", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_NEWS_ITEM", sNIDParameter, usernameParameter, categoryIDParameter, subjectParameter, bodyParameter);
        }
    
        public virtual int UPDATE_PHONE_PRIVACY(Nullable<int> iD, string vALUE)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var vALUEParameter = vALUE != null ?
                new ObjectParameter("VALUE", vALUE) :
                new ObjectParameter("VALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_PHONE_PRIVACY", iDParameter, vALUEParameter);
        }
    
        public virtual int UPDATE_PHOTO_PATH(Nullable<int> iD, string fILE_PATH, string fILE_NAME)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var fILE_PATHParameter = fILE_PATH != null ?
                new ObjectParameter("FILE_PATH", fILE_PATH) :
                new ObjectParameter("FILE_PATH", typeof(string));
    
            var fILE_NAMEParameter = fILE_NAME != null ?
                new ObjectParameter("FILE_NAME", fILE_NAME) :
                new ObjectParameter("FILE_NAME", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_PHOTO_PATH", iDParameter, fILE_PATHParameter, fILE_NAMEParameter);
        }
    
        public virtual int UPDATE_SCHEDULE_PRIVACY(Nullable<int> iD, string vALUE)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var vALUEParameter = vALUE != null ?
                new ObjectParameter("VALUE", vALUE) :
                new ObjectParameter("VALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_SCHEDULE_PRIVACY", iDParameter, vALUEParameter);
        }
    
        public virtual int UPDATE_SHOW_PIC(Nullable<int> aCCOUNT_ID, string vALUE)
        {
            var aCCOUNT_IDParameter = aCCOUNT_ID.HasValue ?
                new ObjectParameter("ACCOUNT_ID", aCCOUNT_ID) :
                new ObjectParameter("ACCOUNT_ID", typeof(int));
    
            var vALUEParameter = vALUE != null ?
                new ObjectParameter("VALUE", vALUE) :
                new ObjectParameter("VALUE", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_SHOW_PIC", aCCOUNT_IDParameter, vALUEParameter);
        }
    
        public virtual int UPDATE_TIMESTAMP(Nullable<int> iD, Nullable<System.DateTime> vALUE)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var vALUEParameter = vALUE.HasValue ?
                new ObjectParameter("VALUE", vALUE) :
                new ObjectParameter("VALUE", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UPDATE_TIMESTAMP", iDParameter, vALUEParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> VALID_DRIVES_BY_ID(string dRIVERID)
        {
            var dRIVERIDParameter = dRIVERID != null ?
                new ObjectParameter("DRIVERID", dRIVERID) :
                new ObjectParameter("DRIVERID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("VALID_DRIVES_BY_ID", dRIVERIDParameter);
        }
    
        public virtual ObjectResult<VICTORY_PROMISE_BY_STUDENT_ID_Result> VICTORY_PROMISE_BY_STUDENT_ID(Nullable<int> sTUDENT_ID)
        {
            var sTUDENT_IDParameter = sTUDENT_ID.HasValue ?
                new ObjectParameter("STUDENT_ID", sTUDENT_ID) :
                new ObjectParameter("STUDENT_ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<VICTORY_PROMISE_BY_STUDENT_ID_Result>("VICTORY_PROMISE_BY_STUDENT_ID", sTUDENT_IDParameter);
        }
    }
}
