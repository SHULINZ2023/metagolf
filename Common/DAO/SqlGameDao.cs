using Common.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using DomainEntities;
using GolfApi.Model.GameManagement.Response;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
public class SqlGameDao : GameDao
{
    private readonly GolfDbContext _dbcontext;
    private readonly ILogger<SqlGameDao> _logger;
    public SqlGameDao(GolfDbContext dbcontext)
    {
        _dbcontext = dbcontext;
        _logger = LoggerFactory.Create(builder => builder.AddConsole())
                       .CreateLogger<SqlGameDao>();
    }
    public List<GameListResponse> GetGamesByGameTypeAndEmail(long gameTypeId, string email)
    {
        // Implementation to retrieve a user from a SQL database
        // ...
        var currentdate = DateTime.Now.Date;
       
        if(gameTypeId < 4)
        {
        var query = from Game in _dbcontext.Games 
                    join GameType in _dbcontext.GameTypes
                    on Game.game_type_id equals GameType.game_type_id
                    join GameGolfer in _dbcontext.GameGolfers 
                    on Game.game_id equals GameGolfer.game_id
                    join User in _dbcontext.Users
                    on GameGolfer.golfer_id equals User.UserSystemId
                    where User.Email == email && GameType.game_type_id == gameTypeId 
                    && Game.status=="approved" && Game.game_date >= currentdate
                    select new GameListResponse
                    {
                        game_id = Game.game_id,
                        game_name=Game.game_name,
                        game_date=Game.game_date,
                        game_type_id = GameType.game_type_id,
                        game_type_code=GameType.game_type_code,
                        //email=User.Email
                    };
                    var result = query.ToList();
                    return result;
        }
        else
        {
             var query = from Game in _dbcontext.Games 
                    join GameType in _dbcontext.GameTypes
                    on Game.game_type_id equals GameType.game_type_id
                    join GameGolfer in _dbcontext.GameGolfers 
                    on Game.game_id equals GameGolfer.game_id
                    join User in _dbcontext.Users
                    on GameGolfer.golfer_id equals User.UserSystemId
                    where User.Email == email && GameType.game_type_id == gameTypeId 
                    && Game.status=="approved" && Game.game_date >= currentdate
                    select new GameListResponse
                    {
                        game_id = Game.game_id,
                        game_name=Game.game_name,
                        game_date=Game.game_date,
                        game_type_id = GameType.game_type_id,
                        game_type_code=GameType.game_type_code,
                        //email=User.Email
                    };
                    var result = query.ToList();
                    return result;

        }
                    
                    

    }
public List<CourseListResponse> GetGolfCourseList()
    {
        // Implementation to retrieve a user from a SQL database
        // ...
        var query = from golfCourse in _dbcontext.GolfCourses 
                    join area in _dbcontext.Area
                   on golfCourse.area_id equals area.area_id
                   select new CourseListResponse
                    {
                        Area_id = area.area_id,
                        Area_name=area.area_name,
                        Golfcourse_id=golfCourse.golf_course_id,
                        Golfcourse_name = golfCourse.golf_course_name,
                        Address=golfCourse.address,
                        City = golfCourse.city,
                        Province=golfCourse.province
                        //email=User.Email
                    };
                    var result = query.ToList();
         return result;           

    }
    

    // Other CRUD methods...
    public int CreateNewGame(Games newGame)
    {
        //insert table games
     
        _dbcontext.Games.Add(newGame);
        _dbcontext.SaveChanges();
        _logger.LogInformation("yyy" + newGame.game_id);
       // _logger.LogInformation(insertsql1);
       /*
        _dbcontext.Database.ExecuteSqlRaw(
             "INSERT INTO games (create_time, creator, game_date, game_name, game_type_id, golf_course_id, golfhandle1, golfhandle2, golfhandle3, golfhandle4, golfhandle5, golfhandle6, golfhandle7, last_upt_time, start_half_id, status,golfhandle0) " +
            "VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, {11}, {12}, {13}, {14}, {15},{16})",
            newGame.create_time,
            newGame.creator,
            newGame.game_date,
            newGame.game_name,
            newGame.game_type_id,
            newGame.golf_course_id,
            newGame.golfhandle1,
            newGame.golfhandle2,
            newGame.golfhandle3,
            newGame.golfhandle4,
            newGame.golfhandle5,
            newGame.golfhandle6,
            newGame.golfhandle7,
            newGame.last_upt_time,
            newGame.start_half_id,
            newGame.status,
            newGame.creator
        );
        */
        
        //insert into gamegolfer
        var createtime = newGame.create_time;
        var creator = newGame.creator;
      

        _logger.LogInformation("");
        _dbcontext.Database.ExecuteSqlRaw("insert into gamegolfers(game_id,golfer_id,status,create_time,last_upt_time)" 
        + "(select game_id , UserSystemId,'Approved',create_time,last_upt_time from Games g, Users u " 
        + "where g.game_id={0} and g.golfhandle0 = u.Email "
        + "union "
        + "select game_id , UserSystemId,'Approved',create_time,last_upt_time from Games g, Users u "
        + "where g.golfhandle1<> 'not defined' and g.golfhandle1 = u.Email and g.game_id={0} "
        + "union "
        + "select game_id , UserSystemId,'Approved',create_time,last_upt_time from Games g, Users u "
        + "where g.golfhandle2<> 'not defined' and g.golfhandle1 = u.Email and g.game_id={0} "
        + "union "
        + "select game_id , UserSystemId,'Approved',create_time,last_upt_time from Games g, Users u "
        + "where g.golfhandle3<> 'not defined' and g.golfhandle3 = u.Email and g.game_id={0} "
        + "union "
        + "select game_id , UserSystemId,'Approved',create_time,last_upt_time from Games g, Users u "
        + "where g.golfhandle4<> 'not defined' and g.golfhandle4 = u.Email and g.game_id={0} "
        + "union "
        + "select game_id , UserSystemId,'Approved',create_time,last_upt_time from Games g, Users u "
        + "where g.golfhandle5<> 'not defined' and g.golfhandle5 = u.Email and g.game_id={0} "
        + "union "
        + "select game_id , UserSystemId,'Approved',create_time,last_upt_time from Games g, Users u "
        + "where g.golfhandle6<> 'not defined' and g.golfhandle6 = u.Email and g.game_id={0} "
        + "union "
        + "select game_id , UserSystemId,'Approved',create_time,last_upt_time from Games g, Users u "
        + "where g.golfhandle7<> 'not defined' and g.golfhandle7 = u.Email and g.game_id={0} )",
        newGame.game_id);

        int record= _dbcontext.SaveChanges();
        return record;
    }
}
