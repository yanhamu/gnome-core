using MediatR;
using System;

namespace Gnome.Services
{
    public class RandomRequestHandler : IRequestHandler<RandomCommand, string>
    {
        public string Handle(RandomCommand message)
        {
            return new Random().Next(100).ToString();
        }
    }
}