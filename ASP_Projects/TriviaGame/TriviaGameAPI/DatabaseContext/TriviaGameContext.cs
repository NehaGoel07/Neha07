using Microsoft.EntityFrameworkCore;
using TriviaGameLibraryShared;

namespace TriviaGameAPI
{
    public class TriviaGameContext :DbContext
    {
        public TriviaGameContext(DbContextOptions<TriviaGameContext> options):base(options)
        {
        }

        public virtual DbSet<AdminUsers> AdminUsers { get; set; }
        public virtual DbSet<Answers> Answers { get; set; }
        public virtual DbSet<RoleMaster> RoleMaster { get; set; }
        public virtual DbSet<GameRuleDesc> GameRuleDesc { get; set; }
        public virtual DbSet<GameRules> GameRules { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<PlatformMaster> PlatformMaster { get; set; }
        public virtual DbSet<QuestionTypeMaster> QuestionTypeMaster { get; set; }
        public virtual DbSet<DifficultyLevelMaster> DifficultyLevelMaster { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<UserQuestionLogs> UserQuestionLogs { get; set; }
        public virtual DbSet<UserSocialShareLogs> UserSocialShareLogs { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminUsers>(entity =>
            {
                entity.ToTable("Admin_Users");
                entity.Property(p => p.IsActive).IsRequired().HasColumnName("isActive").HasDefaultValueSql("((1))");
                entity.Property(p => p.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("((0))");
                entity.Property(p => p.FK_RoleMasterId).HasColumnName("FK_RoleMaster_Id");
                entity.HasOne(e => e.RoleMaster).WithMany(p => p.AdminUsers)
                .HasForeignKey(p => p.FK_RoleMasterId)
                .OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_RoleMaster");
                entity.Property(p => p.ModifiedOn).HasColumnName("Modified_On");
                entity.Property(p => p.Name).IsRequired().HasMaxLength(50);
                entity.Property(p => p.Password).IsRequired();
            });

            modelBuilder.Entity<RoleMaster>(entity =>
            {
                entity.Property(p => p.IsActive).IsRequired().HasColumnName("isActive").HasDefaultValueSql("((1))");
                entity.Property(p => p.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("((0))");
                entity.Property(p => p.RoleCode).HasColumnName("Role_code").IsRequired().HasMaxLength(1).IsUnicode(false);
                entity.Property(p => p.RoleDesc).HasColumnName("Role_Desc").IsRequired().HasMaxLength(100).IsUnicode(false);
                entity.Property(p => p.RoleType).HasColumnName("Role_Type").IsRequired().HasMaxLength(50).IsUnicode(false);
            });

            modelBuilder.Entity<DifficultyLevelMaster>(entity =>
            {
                entity.ToTable("DifficultyLevel_Master");
                entity.Property(x => x.DiffLvl).IsRequired().HasColumnName("Diff_Lvl").HasMaxLength(50).IsUnicode(false);
                entity.Property(x => x.DiffCode).IsRequired().HasColumnName("Diff_Code").HasMaxLength(1).IsUnicode(false);
                entity.Property(x => x.IsActive).IsRequired().HasColumnName("isActive").HasDefaultValueSql("((1))");
                entity.Property(x => x.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("((0))");
                entity.Property(x => x.Weightage).IsRequired();
            });

            modelBuilder.Entity<Answers>(entity =>
            {
                entity.HasKey(e => e.AnsId);
                entity.Property(e => e.AnsId).HasColumnName("Ans_Id");
                entity.Property(e => e.AnsType).HasColumnName("Ans_Type");
                entity.Property(e => e.Answer).IsRequired();
                entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
                entity.Property(e => e.FkQuesId).HasColumnName("fk_Ques_Id");
                entity.Property(e => e.IsActive).IsRequired().HasColumnName("isActive").HasDefaultValueSql("((1))");
                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("((0))");
                entity.Property(e => e.IsEnabled).IsRequired().HasColumnName("isEnabled").HasDefaultValueSql("((1))");
                entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
                entity.HasOne(d => d.FkQues).WithMany(p => p.Answers).HasForeignKey(d => d.FkQuesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Questions");
            });

            modelBuilder.Entity<GameRuleDesc>(entity =>
            {
                entity.ToTable("GameRule_Desc");
                entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
                entity.Property(e => e.FkDifficultyLvlId).HasColumnName("fk_DifficultyLvl_Id");
                entity.Property(e => e.FkGameRuleId).HasColumnName("fk_GameRule_Id");
                entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
                entity.Property(e => e.NoOfQues).HasColumnName("No_Of_Ques");
                entity.HasOne(d => d.FkDifficultyLvl)
                    .WithMany(p => p.GameRuleDesc)
                    .HasForeignKey(d => d.FkDifficultyLvlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameRule_Desc_DifficultyLevel_Master");
                entity.HasOne(d => d.FkGameRule)
                    .WithMany(p => p.GameRuleDesc)
                    .HasForeignKey(d => d.FkGameRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameRule_Desc_GameRules");
            });

            modelBuilder.Entity<GameRules>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
                entity.Property(e => e.FkDifficultyLvlId).HasColumnName("fk_DifficultyLvl_Id");
                entity.Property(e => e.FkGameId).HasColumnName("fk_Game_Id");
                entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
                entity.Property(e => e.NoOfQues).HasColumnName("No_Of_Ques");
                entity.HasOne(d => d.FkDifficultyLvl)
                    .WithMany(p => p.GameRules)
                    .HasForeignKey(d => d.FkDifficultyLvlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameRules_DifficultyLevel_Master");
                entity.HasOne(d => d.FkGame)
                    .WithMany(p => p.GameRules)
                    .HasForeignKey(d => d.FkGameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GameRules_Games");
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
                entity.Property(e => e.FkPlateformId).HasColumnName("fk_Plateform_Id");
                entity.Property(e => e.GameDesc)
                    .HasColumnName("Game_Desc")
                    .IsUnicode(false);
                entity.Property(e => e.GameEndDate).HasColumnName("GameEnd_Date");
                entity.Property(e => e.GameId).HasColumnName("Game_ID");
                entity.Property(e => e.GameImage).HasColumnName("Game_Image");
                entity.Property(e => e.GameName).HasColumnName("Game_Name");
                entity.Property(e => e.GameStartDate).HasColumnName("GameStart_Date");
                entity.Property(e => e.GameTitle)
                    .IsRequired()
                    .HasColumnName("Game_Title")
                    .IsUnicode(false);
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("((0))");
                entity.Property(e => e.IsEnabled).IsRequired().HasColumnName("isEnabled").HasDefaultValueSql("((1))");
                entity.Property(e => e.MaxScore).HasColumnName("Max_Score");
                entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
                entity.Property(e => e.QuesCount).HasColumnName("Ques_Count");
                entity.HasOne(d => d.FkPlateform).WithMany(p => p.Games).HasForeignKey(d => d.FkPlateformId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Games_Plateform_Master");
            });

            modelBuilder.Entity<PlatformMaster>(entity =>
            {
                entity.ToTable("Platform_Master");
                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");
                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("((0))");
                entity.Property(e => e.PlatformCode).IsRequired().HasColumnName("Platform_Code");
                entity.Property(e => e.PlatformDesc).HasColumnName("Platform_Desc").HasMaxLength(100);
                entity.Property(e => e.PlatformType)
                    .IsRequired()
                    .HasColumnName("Platform_Type")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<QuestionTypeMaster>(entity =>
            {
                entity.ToTable("QuestionType_Master");
                entity.Property(e => e.Description).HasMaxLength(100).IsUnicode(false);
                entity.Property(e => e.IsActive).IsRequired().HasColumnName("isActive").HasDefaultValueSql("((1))");
                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("((0))");
                entity.Property(e => e.QuesCode).IsRequired().HasColumnName("Ques_Code").HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
                entity.Property(e => e.QuesType).IsRequired().HasMaxLength(50).IsUnicode(false);
            });

            modelBuilder.Entity<Questions>(entity =>
            {
                entity.HasKey(e => e.QuesId);
                entity.Property(e => e.QuesId).HasColumnName("Ques_Id");
                entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
                entity.Property(e => e.FkAdmUserId).HasColumnName("fk_AdmUser_id");
                entity.Property(e => e.FkDiffLvlId).HasColumnName("fk_DiffLvl_Id");
                entity.Property(e => e.FkQuesTypeId).HasColumnName("fk_QuesType_Id");
                entity.Property(e => e.IsActive).IsRequired().HasColumnName("isActive").HasDefaultValueSql("((1))");
                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted").HasDefaultValueSql("((0))");
                entity.Property(e => e.IsEnabled).IsRequired().HasColumnName("isEnabled").HasDefaultValueSql("((1))");
                entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
                entity.Property(e => e.QuesDesc).HasColumnName("Ques_Desc").IsUnicode(false);
                entity.Property(e => e.QuesImage).HasColumnName("Ques_Image");
                entity.Property(e => e.QuesTitle).HasColumnName("Ques_Title").IsUnicode(false);
                entity.HasOne(d => d.FkAdmUser)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.FkAdmUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Admin_Users");
                entity.HasOne(d => d.FkDiffLvl)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.FkDiffLvlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DifficultyLevel_Master");
                entity.HasOne(d => d.FkQuesType)
                    .WithMany(p => p.Questions)
                    .HasForeignKey(d => d.FkQuesTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionType_Master");
            });

            modelBuilder.Entity<UserQuestionLogs>(entity =>
            {
                entity.ToTable("User_Question_Logs");
                entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
                entity.Property(e => e.FkAnsId).HasColumnName("fk_Ans_Id");
                entity.Property(e => e.FkQuesId).HasColumnName("fk_Ques_Id");
                entity.Property(e => e.FkUsrId).HasColumnName("fk_Usr_Id");
                entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
                entity.Property(e => e.QuesEdt).HasColumnName("Ques_Edt");
                entity.Property(e => e.QuesSdt).HasColumnName("Ques_Sdt");
                entity.Property(e => e.Remarks).HasMaxLength(500);
                entity.Property(e => e.TotalTime).HasColumnName("Total_Time");
                entity.HasOne(d => d.FkAns)
                    .WithMany(p => p.UserQuestionLogs)
                    .HasForeignKey(d => d.FkAnsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Question_Logs_Answers");
                entity.HasOne(d => d.FkQues)
                    .WithMany(p => p.UserQuestionLogs)
                    .HasForeignKey(d => d.FkQuesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Question_Logs_Questions");
                entity.HasOne(d => d.FkUsr)
                    .WithMany(p => p.UserQuestionLogs)
                    .HasForeignKey(d => d.FkUsrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Question_Logs_Users");
            });

            modelBuilder.Entity<UserSocialShareLogs>(entity =>
            {
                entity.ToTable("User_SocialShare_logs");
                entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
                entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
                entity.Property(e => e.Remarks).HasMaxLength(500);
                entity.Property(e => e.ShareDetails).IsRequired().HasColumnName("Share_Details").HasMaxLength(100);
                entity.Property(e => e.UsrCompKey).IsRequired().HasColumnName("Usr_Comp_Key");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.CreatedOn).HasColumnName("Created_On");
                entity.Property(e => e.FkDiffLvlId).HasColumnName("fk_DiffLvl_Id");
                entity.Property(e => e.FkGameId).HasColumnName("fk_Game_Id");
                entity.Property(e => e.FkPlatformId).HasColumnName("fk_Platform_Id");
                entity.Property(e => e.GameEdt).HasColumnName("Game_Edt");
                entity.Property(e => e.GameSdt).HasColumnName("Game_Sdt");
                entity.Property(e => e.ModifiedOn).HasColumnName("Modified_On");
                entity.Property(e => e.NoOfQuesAttempt).HasColumnName("No_of_Ques_Attempt");
                entity.Property(e => e.Remarks).HasMaxLength(500);
                entity.Property(e => e.TotalScore).HasColumnName("Total_Score");
                entity.Property(e => e.TotalTime).HasColumnName("Total_Time");
                entity.Property(e => e.UsrCompKey).IsRequired().HasColumnName("Usr_Comp_Key");
                entity.Property(e => e.UsrDob).HasColumnName("Usr_DOB");
                entity.Property(e => e.UsrEmail).HasColumnName("Usr_Email").HasMaxLength(100);
                entity.Property(e => e.UsrName).IsRequired().HasColumnName("Usr_Name").HasMaxLength(50);
                entity.Property(e => e.UsrPhone).HasColumnName("Usr_Phone");
                entity.Property(e => e.UsrZipCode).HasColumnName("Usr_ZipCode");
                entity.HasOne(d => d.FkDiffLvl)
                    .WithMany(p=>p.Users)
                    .HasForeignKey(d => d.FkDiffLvlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_DifficultyLevel_Master");
                entity.HasOne(d => d.FkGame)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FkGameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersGames");
                entity.HasOne(d => d.FkPlatform)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FkPlatformId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_Platform_Master");
            });



        }
    }
}
