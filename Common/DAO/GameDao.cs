using Common.Entities;
using System;
using System.Linq;
using GolfApi.Model.GameManagement.Response;
public interface GameDao
{
    public List<GameListResponse> GetGamesByGameTypeAndEmail(long gameTypeId, string email);
  
};
