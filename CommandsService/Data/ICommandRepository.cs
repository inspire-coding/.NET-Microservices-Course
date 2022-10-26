using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandsService.Models;

namespace CommandsService.Data
{
    public interface ICommandRepository
    {
        bool SaveChanges();


        // Platforms
        IEnumerable<Platform> GetAllPlatforms();
        void CreatePlatform(Platform platform);
        bool PlaformExits(int platformId);


        // Commands
        IEnumerable<Command> GetCommandsForPlatform(int platformId);
        Command GetCommand(int platformId, int commandId);
        void CreateCommand(int platformId, Command command);
    }
}