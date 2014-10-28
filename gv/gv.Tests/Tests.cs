using System;
using System.Collections.Generic;
using NUnit.Framework;


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
                Console.WriteLine( P._name );
                Assert.That( P._name.Length <= 10 && P._name.Length >= 8);
            }

        }
        [Test]
        public void planet_type_list_works_as_should()
        {
            Universe u = new Universe();
            Assert.AreEqual(u._planetTypes[0], ( "Telluric Silicat" ));
            Assert.AreEqual(u._planetTypes[1], ( "Telluric Carbon" ));
            Assert.AreEqual(u._planetTypes[2], ( "Telluric Metal" ));
            Assert.AreEqual(u._planetTypes[3], ( "Telluric Lava" ));
            Assert.AreEqual(u._planetTypes[4], ( "Telluric Ice" ));
            Assert.AreEqual(u._planetTypes[5], ( "Telluric Desert" ));
            Assert.AreEqual(u._planetTypes[6], ( "Coreless" ));
            Assert.AreEqual(u._planetTypes[7], ( "Gazeous Hydrogen" ));
            Assert.AreEqual(u._planetTypes[8], ( "Gazeous Helium" ));
            Assert.AreEqual(u._planetTypes[9], ( "Chthonian" ));
        }
        [Test]
        public void planet_type_assignement_works()
        {
            Universe u = new Universe();
            int i;

            for( i = 0; i < 100; i++ )
            {
                Planet P = u.AddPlanet();
                Assert.That( u._planetTypes.Contains( P._type ) );
                Console.WriteLine( P._type );
            }
        }
    }
}
