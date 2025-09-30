using Backend.Models;

namespace Backend.Data;

public static class SeedData
{
    public static Stable[] Stables => new[]
    {
        new Stable { StableId = "stable1", StableName = "Zobair Farm", Location = "Riyadh", Colors = "orange" },
        new Stable { StableId = "stable2", StableName = "Zayed Farm", Location = "Dubai", Colors = "kiwi" },
        new Stable { StableId = "stable3", StableName = "Zahra Farm", Location = "Jeddah", Colors = "cinnamon" },
        new Stable { StableId = "stable4", StableName = "Sunny Stables", Location = "Jubail", Colors = "lemon" },
        new Stable { StableId = "stable5", StableName = "Ajman Stables", Location = "Ajman", Colors = "lemon" },
        new Stable { StableId = "stable6", StableName = "Dubai Stables", Location = "Dubai", Colors = "bright blue" },
    };

    public static Horse[] Horses => new[]
    {
        new Horse
        {
            HorseId = "horse1", HorseName = "Warrior", Age = 2, Gender = Gender.C, Registration = 11111,
            StableId = "stable1"
        },
        new Horse
        {
            HorseId = "horse2", HorseName = "Conquerer", Age = 2, Gender = Gender.F, Registration = 22222,
            StableId = "stable6"
        },
        new Horse
        {
            HorseId = "horse3", HorseName = "Dove of Peace", Age = 3, Gender = Gender.C, Registration = 33333,
            StableId = "stable1"
        },
        new Horse
        {
            HorseId = "horse4", HorseName = "Ever Faster", Age = 3, Gender = Gender.F, Registration = 44444,
            StableId = "stable3"
        },
        new Horse
        {
            HorseId = "horse5", HorseName = "Slow Winner", Age = 2, Gender = Gender.C, Registration = 55555,
            StableId = "stable3"
        },
        new Horse
        {
            HorseId = "horse6", HorseName = "Windrunner", Age = 2, Gender = Gender.F, Registration = 66666,
            StableId = "stable2"
        },
        new Horse
        {
            HorseId = "horse7", HorseName = "Catapult", Age = 4, Gender = Gender.M, Registration = 77777,
            StableId = "stable6"
        },
        new Horse
        {
            HorseId = "horse8", HorseName = "Flying Force", Age = 2, Gender = Gender.C, Registration = 88888,
            StableId = "stable4"
        },
        new Horse
        {
            HorseId = "horse9", HorseName = "Laggard", Age = 2, Gender = Gender.F, Registration = 99999,
            StableId = "stable4"
        },
        new Horse
        {
            HorseId = "horse10", HorseName = "Formula One", Age = 6, Gender = Gender.G, Registration = 10101,
            StableId = "stable2"
        },
        new Horse
        {
            HorseId = "horse11", HorseName = "Frisky Frolic", Age = 3, Gender = Gender.C, Registration = 11011,
            StableId = "stable4"
        },
        new Horse
        {
            HorseId = "horse12", HorseName = "Fantastic", Age = 3, Gender = Gender.F, Registration = 12121,
            StableId = "stable2"
        },
        new Horse
        {
            HorseId = "horse13", HorseName = "Midnight", Age = 2, Gender = Gender.C, Registration = 13131,
            StableId = "stable3"
        },
        new Horse
        {
            HorseId = "horse14", HorseName = "Running Wild", Age = 4, Gender = Gender.S, Registration = 14141,
            StableId = "stable2"
        },
        new Horse
        {
            HorseId = "horse15", HorseName = "FastOffMyFeet", Age = 3, Gender = Gender.C, Registration = 15151,
            StableId = "stable1"
        },
        new Horse
        {
            HorseId = "horse16", HorseName = "Slow Poke", Age = 2, Gender = Gender.C, Registration = 16161,
            StableId = "stable3"
        },
        new Horse
        {
            HorseId = "horse17", HorseName = "Slinger", Age = 3, Gender = Gender.F, Registration = 17171,
            StableId = "stable2"
        },
        new Horse
        {
            HorseId = "horse18", HorseName = "Sublime", Age = 5, Gender = Gender.M, Registration = 18181,
            StableId = "stable6"
        },
        new Horse
        {
            HorseId = "horse19", HorseName = "Front Runner", Age = 4, Gender = Gender.G, Registration = 19191,
            StableId = "stable4"
        },
        new Horse
        {
            HorseId = "horse20", HorseName = "Night", Age = 3, Gender = Gender.C, Registration = 20200,
            StableId = "stable1"
        },
        new Horse
        {
            HorseId = "horse21", HorseName = "Negative", Age = 3, Gender = Gender.F, Registration = 21210,
            StableId = "stable3"
        },
        new Horse
        {
            HorseId = "horse22", HorseName = "Lightening", Age = 2, Gender = Gender.C, Registration = 22220,
            StableId = "stable6"
        },
        new Horse
        {
            HorseId = "horse23", HorseName = "Lazy Loser", Age = 4, Gender = Gender.G, Registration = 23230,
            StableId = "stable1"
        },
        new Horse
        {
            HorseId = "horse24", HorseName = "Leaping Lizard", Age = 2, Gender = Gender.C, Registration = 24240,
            StableId = "stable1"
        },
        new Horse
        {
            HorseId = "horse25", HorseName = "Beautiful Brown", Age = 3, Gender = Gender.F, Registration = 25250,
            StableId = "stable6"
        },
        new Horse
        {
            HorseId = "horse26", HorseName = "Sick Winner", Age = 5, Gender = Gender.M, Registration = 26260,
            StableId = "stable2"
        },
    };

    public static Owner[] Owners => new[]
    {
        new Owner { OwnerId = "owner1", LName = "Saeed", FName = "Ahmed" },
        new Owner { OwnerId = "owner2", LName = "Mohammed", FName = "Khalid" },
        new Owner { OwnerId = "owner3", LName = "Mohammed", FName = "Faisal" },
        new Owner { OwnerId = "owner4", LName = "Fahd", FName = "Abdul Rahman" },
        new Owner { OwnerId = "owner5", LName = "Nasr", FName = "" },
        new Owner { OwnerId = "owner6", LName = "Mohammed", FName = "Sheikh" },
        new Owner { OwnerId = "owner7", LName = "Abed", FName = "Ahmed" },
        new Owner { OwnerId = "owner8", LName = "Mashour", FName = "" },
        new Owner { OwnerId = "owner9", LName = "Said", FName = "Sheikh" },
        new Owner { OwnerId = "owner10", LName = "Faisal", FName = "Khan" },
        new Owner { OwnerId = "owner11", LName = "Jabr", FName = "Mohammed" },
        new Owner { OwnerId = "owner12", LName = "Faleh", FName = "Mahmood" },
        new Owner { OwnerId = "owner13", LName = "Yahya", FName = "Mohammed" },
        new Owner { OwnerId = "owner14", LName = "Sulaiman", FName = "" },
        new Owner { OwnerId = "owner15", LName = "Saeed", FName = "Ali" },
        new Owner { OwnerId = "owner16", LName = "Ahmed", FName = "Faisal" },
        new Owner { OwnerId = "owner17", LName = "Saud", FName = "Mohammed" },
        new Owner { OwnerId = "owner18", LName = "Nazir", FName = "Mohammed" },
        new Owner { OwnerId = "owner19", LName = "Saleh", FName = "Fahd" },
        new Owner { OwnerId = "owner20", LName = "Mohammed", FName = "Naeem" },
    };

    public static Owns[] Owns => new[]
    {
        new Owns { OwnerId = "owner14", HorseId = "horse1" },
        new Owns { OwnerId = "owner3", HorseId = "horse2" },
        new Owns { OwnerId = "owner2", HorseId = "horse3" },
        new Owns { OwnerId = "owner2", HorseId = "horse4" },
        new Owns { OwnerId = "owner1", HorseId = "horse5" },
        new Owns { OwnerId = "owner12", HorseId = "horse5" },
        new Owns { OwnerId = "owner14", HorseId = "horse5" },
        new Owns { OwnerId = "owner1", HorseId = "horse6" },
        new Owns { OwnerId = "owner5", HorseId = "horse6" },
        new Owns { OwnerId = "owner20", HorseId = "horse7" },
        new Owns { OwnerId = "owner19", HorseId = "horse8" },
        new Owns { OwnerId = "owner2", HorseId = "horse9" },
        new Owns { OwnerId = "owner18", HorseId = "horse10" },
        new Owns { OwnerId = "owner3", HorseId = "horse10" },
        new Owns { OwnerId = "owner4", HorseId = "horse11" },
        new Owns { OwnerId = "owner16", HorseId = "horse12" },
        new Owns { OwnerId = "owner17", HorseId = "horse13" },
        new Owns { OwnerId = "owner15", HorseId = "horse14" },
        new Owns { OwnerId = "owner15", HorseId = "horse15" },
        new Owns { OwnerId = "owner20", HorseId = "horse16" },
        new Owns { OwnerId = "owner4", HorseId = "horse17" },
        new Owns { OwnerId = "owner6", HorseId = "horse19" },
        new Owns { OwnerId = "owner12", HorseId = "horse20" },
        new Owns { OwnerId = "owner7", HorseId = "horse21" },
        new Owns { OwnerId = "owner7", HorseId = "horse22" },
        new Owns { OwnerId = "owner10", HorseId = "horse23" },
        new Owns { OwnerId = "owner12", HorseId = "horse24" },
        new Owns { OwnerId = "owner13", HorseId = "horse25" },
        new Owns { OwnerId = "owner2", HorseId = "horse26" },
        new Owns { OwnerId = "owner9", HorseId = "horse23" },
        new Owns { OwnerId = "owner8", HorseId = "horse18" },
    };

    public static Trainer[] Trainers => new[]
    {
        new Trainer { TrainerId = "trainer1", LName = "Mohammed", FName = "Fahd", StableId = "stable2" },
        new Trainer { TrainerId = "trainer2", LName = "Saleh", FName = "Saeed", StableId = "stable1" },
        new Trainer { TrainerId = "trainer3", LName = "Ali", FName = "Raad", StableId = "stable4" },
        new Trainer { TrainerId = "trainer4", LName = "Sayed", FName = "Wasim", StableId = "stable3" },
        new Trainer { TrainerId = "trainer5", LName = "Ahmed", FName = "Ali", StableId = "stable3" },
        new Trainer { TrainerId = "trainer6", LName = "Faisal", FName = "Salah", StableId = "stable5" },
        new Trainer { TrainerId = "trainer7", LName = "Hamid", FName = "Ahmed", StableId = "stable6" },
        new Trainer { TrainerId = "trainer8", LName = "Khalid", FName = "Ahmed", StableId = "stable6" },
    };

    public static Track[] Tracks => new[]
    {
        new Track { TrackName = "Doha", Location = "QT", Length = 20 },
        new Track { TrackName = "Jubail", Location = "SA", Length = 15 },
        new Track { TrackName = "Yanbu", Location = "SA", Length = 18 },
        new Track { TrackName = "Dubai", Location = "UE", Length = 17 },
        new Track { TrackName = "Jeddah", Location = "SA", Length = 19 },
        new Track { TrackName = "Bahrain", Location = "BH", Length = 18 },
        new Track { TrackName = "Sharjah", Location = "UE", Length = 20 },
        new Track { TrackName = "Riyadh", Location = "SA", Length = 22 },
        new Track { TrackName = "Dhahran", Location = "SA", Length = 20 },
    };

    public static Race[] Races => new[]
    {
        new Race
        {
            RaceId = "race1", RaceName = "Kings Cup", TrackName = "Riyadh", RaceDate = new DateTime(2007, 5, 3),
            RaceTime = new TimeSpan(14, 0, 0)
        },
        new Race
        {
            RaceId = "race2", RaceName = "2-year-old fillies", TrackName = "Doha", RaceDate = new DateTime(2007, 5, 3),
            RaceTime = new TimeSpan(13, 0, 0)
        },
        new Race
        {
            RaceId = "race3", RaceName = "2-year-old colts", TrackName = "Doha", RaceDate = new DateTime(2007, 5, 3),
            RaceTime = new TimeSpan(13, 30, 0)
        },
        new Race
        {
            RaceId = "race4", RaceName = "Handicap", TrackName = "Doha", RaceDate = new DateTime(2007, 5, 3),
            RaceTime = new TimeSpan(12, 0, 0)
        },
        new Race
        {
            RaceId = "race5", RaceName = "Claiming Stake", TrackName = "Sharjah", RaceDate = new DateTime(2007, 5, 3),
            RaceTime = new TimeSpan(12, 30, 0)
        },
        new Race
        {
            RaceId = "race6", RaceName = "3-year-old fillies", TrackName = "Jubail",
            RaceDate = new DateTime(2007, 6, 2), RaceTime = new TimeSpan(12, 30, 0)
        },
        new Race
        {
            RaceId = "race7", RaceName = "Handicap", TrackName = "Jubail", RaceDate = new DateTime(2007, 6, 2),
            RaceTime = new TimeSpan(9, 30, 0)
        },
        new Race
        {
            RaceId = "race8", RaceName = "2-year-old colts", TrackName = "Riyadh", RaceDate = new DateTime(2007, 6, 2),
            RaceTime = new TimeSpan(10, 30, 0)
        },
        new Race
        {
            RaceId = "race9", RaceName = "2-year-old fillies", TrackName = "Jubail",
            RaceDate = new DateTime(2007, 6, 2), RaceTime = new TimeSpan(11, 30, 0)
        },
        new Race
        {
            RaceId = "race10", RaceName = "Claiming Stake", TrackName = "Sharjah", RaceDate = new DateTime(2007, 6, 2),
            RaceTime = new TimeSpan(12, 30, 0)
        },
        new Race
        {
            RaceId = "race11", RaceName = "3-year-old fillies", TrackName = "Dubai",
            RaceDate = new DateTime(2007, 4, 2), RaceTime = new TimeSpan(10, 30, 0)
        },
        new Race
        {
            RaceId = "race12", RaceName = "Handicap", TrackName = "Yanbu", RaceDate = new DateTime(2007, 5, 3),
            RaceTime = new TimeSpan(11, 30, 0)
        },
        new Race
        {
            RaceId = "race13", RaceName = "3-year-old fillies", TrackName = "Yanbu",
            RaceDate = new DateTime(2007, 5, 3), RaceTime = new TimeSpan(11, 0, 0)
        },
        new Race
        {
            RaceId = "race14", RaceName = "Handicap", TrackName = "Dhahran", RaceDate = new DateTime(2007, 5, 10),
            RaceTime = new TimeSpan(10, 0, 0)
        },
        new Race
        {
            RaceId = "race15", RaceName = "3-year-old colts", TrackName = "Dubai", RaceDate = new DateTime(2007, 5, 12),
            RaceTime = new TimeSpan(15, 0, 0)
        },
        new Race
        {
            RaceId = "race16", RaceName = "Claiming Stake", TrackName = "Yanbu", RaceDate = new DateTime(2007, 5, 20),
            RaceTime = new TimeSpan(14, 30, 0)
        },
        new Race
        {
            RaceId = "race17", RaceName = "Handicap", TrackName = "Doha", RaceDate = new DateTime(2007, 5, 20),
            RaceTime = new TimeSpan(13, 0, 0)
        },
        new Race
        {
            RaceId = "race18", RaceName = "3-year-old fillies", TrackName = "Sharjah",
            RaceDate = new DateTime(2007, 5, 21), RaceTime = new TimeSpan(8, 0, 0)
        },
        new Race
        {
            RaceId = "race19", RaceName = "2-year-old colts", TrackName = "Dhahran",
            RaceDate = new DateTime(2007, 5, 25), RaceTime = new TimeSpan(11, 0, 0)
        },
        new Race
        {
            RaceId = "race20", RaceName = "Claiming Stake", TrackName = "Jeddah", RaceDate = new DateTime(2007, 5, 25),
            RaceTime = new TimeSpan(8, 30, 0)
        },
        new Race
        {
            RaceId = "race21", RaceName = "3-year-old colts", TrackName = "Riyadh",
            RaceDate = new DateTime(2007, 3, 19), RaceTime = new TimeSpan(14, 30, 0)
        },
        new Race
        {
            RaceId = "race22", RaceName = "Handicap", TrackName = "Dhahran", RaceDate = new DateTime(2007, 3, 27),
            RaceTime = new TimeSpan(15, 0, 0)
        },
        new Race
        {
            RaceId = "race23", RaceName = "3-year-old fillies", TrackName = "Jeddah",
            RaceDate = new DateTime(2007, 3, 28), RaceTime = new TimeSpan(9, 30, 0)
        },
        new Race
        {
            RaceId = "race24", RaceName = "3-year-old colts", TrackName = "Jubail",
            RaceDate = new DateTime(2007, 3, 28), RaceTime = new TimeSpan(13, 30, 0)
        },
        new Race
        {
            RaceId = "race25", RaceName = "Claiming Stake", TrackName = "Jeddah", RaceDate = new DateTime(2007, 3, 29),
            RaceTime = new TimeSpan(10, 0, 0)
        },
        new Race
        {
            RaceId = "race26", RaceName = "3-year-old colts", TrackName = "Yanbu", RaceDate = new DateTime(2007, 3, 30),
            RaceTime = new TimeSpan(12, 30, 0)
        },
        new Race
        {
            RaceId = "race27", RaceName = "Handicap", TrackName = "Dubai", RaceDate = new DateTime(2007, 4, 3),
            RaceTime = new TimeSpan(14, 0, 0)
        },
        new Race
        {
            RaceId = "race28", RaceName = "2-year-old fillies", TrackName = "Jeddah",
            RaceDate = new DateTime(2007, 4, 4), RaceTime = new TimeSpan(8, 30, 0)
        },
        new Race
        {
            RaceId = "race29", RaceName = "3-year-old colts", TrackName = "Bahrain",
            RaceDate = new DateTime(2007, 4, 5), RaceTime = new TimeSpan(8, 0, 0)
        },
        new Race
        {
            RaceId = "race30", RaceName = "Claiming Stake", TrackName = "Dhahran", RaceDate = new DateTime(2007, 4, 8),
            RaceTime = new TimeSpan(9, 30, 0)
        },
        new Race
        {
            RaceId = "race31", RaceName = "Handicap", TrackName = "Dhahran", RaceDate = new DateTime(2007, 4, 8),
            RaceTime = new TimeSpan(9, 0, 0)
        },
        new Race
        {
            RaceId = "race32", RaceName = "2-year-old colts", TrackName = "Jubail", RaceDate = new DateTime(2007, 4, 9),
            RaceTime = new TimeSpan(11, 0, 0)
        },
        new Race
        {
            RaceId = "race33", RaceName = "Claiming Stake", TrackName = "Bahrain", RaceDate = new DateTime(2007, 4, 10),
            RaceTime = new TimeSpan(13, 0, 0)
        },
        new Race
        {
            RaceId = "race34", RaceName = "3-year-old colts", TrackName = "Dubai", RaceDate = new DateTime(2007, 5, 12),
            RaceTime = new TimeSpan(12, 0, 0)
        },
        new Race
        {
            RaceId = "race35", RaceName = "Handicap", TrackName = "Dubai", RaceDate = new DateTime(2007, 4, 13),
            RaceTime = new TimeSpan(10, 30, 0)
        },
        new Race
        {
            RaceId = "race36", RaceName = "3-year-old colts", TrackName = "Jeddah", RaceDate = new DateTime(2007, 5, 3),
            RaceTime = new TimeSpan(14, 30, 0)
        },
    };

    public static RaceResults[] RaceResults => new[]
    {
    new RaceResults { RaceId = "race1", HorseId = "horse3", Results = "first", Prize = 500000 },
    new RaceResults { RaceId = "race1", HorseId = "horse11", Results = "second", Prize = 200000 },
    new RaceResults { RaceId = "race1", HorseId = "horse15", Results = "third", Prize = 500000 },
    new RaceResults { RaceId = "race2", HorseId = "horse6", Results = "first", Prize = 100000 },
    new RaceResults { RaceId = "race2", HorseId = "horse2", Results = "second", Prize = 50000 },
    new RaceResults { RaceId = "race2", HorseId = "horse20", Results = "third", Prize = 20000 },
    new RaceResults { RaceId = "race3", HorseId = "horse22", Results = "first", Prize = 70000 },
    new RaceResults { RaceId = "race3", HorseId = "horse5", Results = "second", Prize = 50000 },
    new RaceResults { RaceId = "race3", HorseId = "horse1", Results = "third", Prize = 20000 },
    new RaceResults { RaceId = "race4", HorseId = "horse19", Results = "first", Prize = 50000 },
    new RaceResults { RaceId = "race4", HorseId = "horse18", Results = "no show", Prize = 0 },
    new RaceResults { RaceId = "race4", HorseId = "horse14", Results = "no show", Prize = 0 },
    new RaceResults { RaceId = "race6", HorseId = "horse25", Results = "first", Prize = 5000 },
    new RaceResults { RaceId = "race7", HorseId = "horse7", Results = "second", Prize = 2000 },
    new RaceResults { RaceId = "race9", HorseId = "horse11", Results = "last", Prize = 0 },
    new RaceResults { RaceId = "race10", HorseId = "horse18", Results = "fourth", Prize = 500 },
    new RaceResults { RaceId = "race11", HorseId = "horse12", Results = "first", Prize = 50000 },
    new RaceResults { RaceId = "race11", HorseId = "horse17", Results = "second", Prize = 25000 },
    new RaceResults { RaceId = "race11", HorseId = "horse21", Results = "fourth", Prize = 10000 },
    new RaceResults { RaceId = "race12", HorseId = "horse14", Results = "first", Prize = 6000 },
    new RaceResults { RaceId = "race12", HorseId = "horse18", Results = "second", Prize = 5000 },
    new RaceResults { RaceId = "race13", HorseId = "horse25", Results = "first", Prize = 100000 },
    new RaceResults { RaceId = "race13", HorseId = "horse4", Results = "second", Prize = 50000 },
    new RaceResults { RaceId = "race13", HorseId = "horse12", Results = "third", Prize = 30000 },
    new RaceResults { RaceId = "race14", HorseId = "horse23", Results = "first", Prize = 25000 },
    new RaceResults { RaceId = "race14", HorseId = "horse26", Results = "second", Prize = 20000 },
    new RaceResults { RaceId = "race15", HorseId = "horse11", Results = "second", Prize = 10000 },
    new RaceResults { RaceId = "race15", HorseId = "horse24", Results = "third", Prize = 8000 },
    new RaceResults { RaceId = "race16", HorseId = "horse10", Results = "second", Prize = 5000 },
    new RaceResults { RaceId = "race16", HorseId = "horse14", Results = "third", Prize = 4000 },
    new RaceResults { RaceId = "race17", HorseId = "horse7", Results = "first", Prize = 15000 },
    new RaceResults { RaceId = "race17", HorseId = "horse10", Results = "second", Prize = 1100 },
    new RaceResults { RaceId = "race18", HorseId = "horse6", Results = "first", Prize = 70000 },
    new RaceResults { RaceId = "race19", HorseId = "horse22", Results = "first", Prize = 1000000 },
    new RaceResults { RaceId = "race19", HorseId = "horse1", Results = "second", Prize = 80000 },
    new RaceResults { RaceId = "race19", HorseId = "horse8", Results = "third", Prize = 60000 },
    new RaceResults { RaceId = "race20", HorseId = "horse23", Results = "first", Prize = 1500 },
    new RaceResults { RaceId = "race20", HorseId = "horse14", Results = "second", Prize = 1000 },
    new RaceResults { RaceId = "race20", HorseId = "horse26", Results = "third", Prize = 800 },
    new RaceResults { RaceId = "race20", HorseId = "horse10", Results = "fourth", Prize = 500 },
    new RaceResults { RaceId = "race21", HorseId = "horse24", Results = "first", Prize = 70000 },
    new RaceResults { RaceId = "race21", HorseId = "horse15", Results = "second", Prize = 55000 },
    new RaceResults { RaceId = "race21", HorseId = "horse3", Results = "third", Prize = 40000 },
    new RaceResults { RaceId = "race22", HorseId = "horse18", Results = "first", Prize = 10000 },
    new RaceResults { RaceId = "race22", HorseId = "horse19", Results = "second", Prize = 8000 },
    new RaceResults { RaceId = "race23", HorseId = "horse25", Results = "first", Prize = 150000 },
    new RaceResults { RaceId = "race24", HorseId = "horse7", Results = "first", Prize = 10000 },
    new RaceResults { RaceId = "race25", HorseId = "horse10", Results = "second", Prize = 8000 },
    new RaceResults { RaceId = "race25", HorseId = "horse20", Results = "fourth", Prize = 2000 },
    new RaceResults { RaceId = "race26", HorseId = "horse24", Results = "first", Prize = 8000 },
    new RaceResults { RaceId = "race26", HorseId = "horse20", Results = "fourth", Prize = 2000 },
    new RaceResults { RaceId = "race27", HorseId = "horse18", Results = "first", Prize = 70000 },
    new RaceResults { RaceId = "race27", HorseId = "horse23", Results = "third", Prize = 40000 },
    new RaceResults { RaceId = "race28", HorseId = "horse25", Results = "first", Prize = 90000 },
    new RaceResults { RaceId = "race29", HorseId = "horse15", Results = "first", Prize = 80000 },
    new RaceResults { RaceId = "race29", HorseId = "horse3", Results = "second", Prize = 65000 },
    new RaceResults { RaceId = "race29", HorseId = "horse24", Results = "third", Prize = 50000 },
    new RaceResults { RaceId = "race30", HorseId = "horse14", Results = "second", Prize = 1500 },
    new RaceResults { RaceId = "race30", HorseId = "horse10", Results = "fourth", Prize = 500 },
    new RaceResults { RaceId = "race31", HorseId = "horse7", Results = "first", Prize = 90000 },
    new RaceResults { RaceId = "race31", HorseId = "horse26", Results = "second", Prize = 70000 },
    new RaceResults { RaceId = "race31", HorseId = "horse23", Results = "third", Prize = 50000 },
    new RaceResults { RaceId = "race31", HorseId = "horse10", Results = "fourth", Prize = 30000 },
    new RaceResults { RaceId = "race32", HorseId = "horse22", Results = "first", Prize = 150000 },
    new RaceResults { RaceId = "race32", HorseId = "horse13", Results = "second", Prize = 125000 },
    new RaceResults { RaceId = "race32", HorseId = "horse16", Results = "third", Prize = 100000 },
    new RaceResults { RaceId = "race33", HorseId = "horse23", Results = "second", Prize = 1700 },
    new RaceResults { RaceId = "race33", HorseId = "horse26", Results = "third", Prize = 1200 },
    new RaceResults { RaceId = "race34", HorseId = "horse11", Results = "first", Prize = 50000 },
    new RaceResults { RaceId = "race34", HorseId = "horse15", Results = "second", Prize = 30000 },
    new RaceResults { RaceId = "race35", HorseId = "horse7", Results = "first", Prize = 45000 },
    new RaceResults { RaceId = "race35", HorseId = "horse19", Results = "second", Prize = 25000 },
    new RaceResults { RaceId = "race36", HorseId = "horse11", Results = "first", Prize = 100000 },
    new RaceResults { RaceId = "race36", HorseId = "horse15", Results = "second", Prize = 80000 },
    new RaceResults { RaceId = "race36", HorseId = "horse20", Results = "third", Prize = 50000 },
    };

}