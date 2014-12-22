using System;
using System.Linq;
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
                Planet P =  u.AddPlanet();
                Console.WriteLine( P.Name );
                Assert.That( P.Name.Length <= 10 && P.Name.Length >= 8);
            }

        }
        [Test]
        public void Checking_earth_spawn()
        {
            Universe u = new Universe();
            Assert.That( u.User.Position.X == 0 && u.User.Position.Y == 0 );
            var cell = u.Cells.Where( c => c.Position.X == 0 && c.Position.Y == 0 ).Single();
            Assert.That( cell.ContainsPlanet );
            Console.WriteLine( cell.Position.X + "//"+cell.Position.Y );
        }
        
        [Test]
        public void player_resources_are_initialized_at_0()
        {
            Universe u = new Universe();
            Assert.That( u.User.Ressources.ContainsKey( "Silicium" ) && u.User.Ressources["Silicium"] == 0 );
            Assert.That( u.User.Ressources.ContainsKey( "Plutonium" ) && u.User.Ressources["Plutonium"] == 0 );
            Assert.That( u.User.Ressources.ContainsKey( "Gems" ) && u.User.Ressources["Gems"] == 0 );
            Assert.That( u.User.Ressources.ContainsKey( "Metal" ) && u.User.Ressources["Metal"] == 0 );
            Assert.That( u.User.Ressources.ContainsKey( "Hydrogene" ) && u.User.Ressources["Hydrogene"] == 0 );
            Assert.That( u.User.Ressources.ContainsKey( "Helium" ) && u.User.Ressources["Helium"] == 0 );
        }                
    }
}
