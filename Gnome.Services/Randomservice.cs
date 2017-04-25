using System;

namespace Gnome.Services
{
    public class RandomService : IRandomService
    {
        public int GetRandom()
        {
            return new Random().Next(100);
        }
    }
}
