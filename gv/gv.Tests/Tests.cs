using System;
using System.Collections.Generic;
using NUnit.Framework;
using gv;


namespace gv.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
       public void creates_planet_name_between_6_and_8_char()
        {
            int i;
            Universe u = new Universe();
            for( i = 0; i < 100; i++ )
            {
                Planet P = u.AddPlanet();
                Console.WriteLine( P.Name );
                Assert.That( P.Name.Length <= 10 && P.Name.Length >= 8);
            }

        }
        [Test]
        public void planet_type_assignement_works()
        {
            Universe u = new Universe();
            int i;

            for( i = 0; i < 100; i++ )
            {
                Planet P = u.AddPlanet();
                Assert.That( PlanetAttributes.PlanetTypes.Contains( P.Type ) );
                Console.WriteLine( P.Type );
            }
        }
        [Test]
        public void random_type_check()
        {
            Universe u = new Universe();
            int i;
            int[] count = new int[10];

            for( i = 0; i < 10; i++ )
            {
                count[i] = 0;
            }

            for( i = 0; i < 100; i++ )
            {
                Planet P = u.AddPlanet();
                count[PlanetAttributes.PlanetTypes.IndexOf(P.Type)] += 1 ;
                
            }
            for( i = 0; i < 10; i++ )
            {
                Console.WriteLine( count[i] );
            }
        }
    }
}
