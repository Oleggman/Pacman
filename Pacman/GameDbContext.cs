using System;
using Pacman.Models;
using Microsoft.EntityFrameworkCore;

namespace Pacman
{
    public class GameDbContext : DbContext
    {
        public DbSet<SoundSettings> soundSettingsSet { get; set; } = null!;
        public DbSet<GameInfo> gameInfoSet { get; set; } = null!;
        private static GameDbContext dbContext;

        public static GameDbContext GetContext()
        {
            if (dbContext == null)
            {
                dbContext = new GameDbContext();
            }
            return dbContext;
        }

        private GameDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=pacman.db");
        }

        public SoundSettings GetSoundSettings()
        {
            if (soundSettingsSet.Count() == 0)
            {
                soundSettingsSet.Add(new SoundSettings());
                SaveChanges();
            }
            return soundSettingsSet.First();
        }

        public GameInfo GetGameInfo(uint level)
        {
            if (gameInfoSet.Count() == 0)
            {
                AddDefaultGameInfos();
                SaveChanges();
            }
            GameInfo gameInfo = null;
            try
            {
                gameInfo = gameInfoSet.Where(gInfo => gInfo.Level == level).First();
            }
            catch (InvalidOperationException e)
            {
                if (gameInfo == null)
                {
                    gameInfo = new GameInfo { Height = 800, Width = 800, Level = level };
                    gameInfoSet.Add(gameInfo);
                    SaveChanges();
                }
            }
            return gameInfo;
        }

        private void AddDefaultGameInfos()
        {
            gameInfoSet.Add(new GameInfo { Height = 500, Width = 500, Level = 1 });
            gameInfoSet.Add(new GameInfo { Height = 550, Width = 550, Level = 2 });
            gameInfoSet.Add(new GameInfo { Height = 600, Width = 400, Level = 3 });
            gameInfoSet.Add(new GameInfo { Height = 800, Width = 500, Level = 4 });
            gameInfoSet.Add(new GameInfo { Height = 500, Width = 800, Level = 5 });
            gameInfoSet.Add(new GameInfo { Height = 600, Width = 600, Level = 6 });
            gameInfoSet.Add(new GameInfo { Height = 650, Width = 750, Level = 7 });
            gameInfoSet.Add(new GameInfo { Height = 750, Width = 650, Level = 8 });
            gameInfoSet.Add(new GameInfo { Height = 750, Width = 750, Level = 9 });
            gameInfoSet.Add(new GameInfo { Height = 800, Width = 800, Level = 10 });
        }

        public void UpdateSoundSettings(SoundSettings soundSettings)
        {
            soundSettingsSet.Update(soundSettings);
            SaveChanges();
        }
    }
}
