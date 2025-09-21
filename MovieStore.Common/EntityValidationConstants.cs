using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MovieStore.Common
{
    public static class EntityValidationConstants
    {
        public static class Movie 
        {
            public const int TitleMaxLength = 50;
            public const int GenreMaxLength = 20;
            public const int DescriptionMaxLength = 250;
            public const int DirectorMaxLength = 80;
        }
    }
}
