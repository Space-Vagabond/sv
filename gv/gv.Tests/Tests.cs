using System;
using System.Collections.Generic;
using NUnit.Framework;
using System.Linq;
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
                Planet P =  u.AddPlanet();
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
                //Assert.That( PlanetAttributes.PlanetTypes.Contains( P.Type ) );
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
               // count[PlanetAttributes.PlanetTypes.IndexOf(P.Type)] += 1 ;
                
            }
            for( i = 0; i < 10; i++ )
            {
                Console.WriteLine( count[i] );
            }
        }
        /*[Test]
        public void With_type_comes_ressources()
        {
            Universe u = new Universe();
            int i;

            for( i = 0; i < 100; i++ )
            {
                Planet P = u.AddPlanet();
                Console.WriteLine( i );
                Console.WriteLine("type: "+P.Type+ "Surface: "+ P.Surface+" Ressource: "+P.Ressources);
                if( P.Type == PlanetAttributes.PlanetTypes[0] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[0] );
                    Assert.That(P.Surface == PlanetAttributes.PlanetSurfaces[5] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[6] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[7] || 
                                P.Surface == PlanetAttributes.PlanetSurfaces[8]);

                }
                else if( P.Type == PlanetAttributes.PlanetTypes[1] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[1] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[5] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[6] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[7] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[8] );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[2] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[3] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[5] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[6] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[7] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[8] );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[3] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[6] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[0]);
                    Assert.That( P.IsInhabited == true );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[4] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[6] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[3]);
                    Assert.That( P.IsInhabited == true );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[5] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[6] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[5] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[6] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[7] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[8] );
                    Assert.That( P.IsInhabited == true );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[6] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[0] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[1] );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[7] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[4] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[4]);
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[8] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[5] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[4] );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[9] )
                {
                    Assert.That( P.Ressources == PlanetAttributes.PlanetRessources[2] || P.Ressources == PlanetAttributes.PlanetRessources[1] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[2] );
                    Assert.That( P.IsInhabited == false );
                    Assert.AreEqual( P.InhabitantsName , "Inhabited planet" );
                } 
            }
        }*/
        [Test]
        public void Planets_Pos_test()
        {
            Universe u = new Universe();
            foreach( Planet p in u.Planets.Values )
            {
                //Console.WriteLine( "PositionX " + p.Position.X + "  Position Y  " + p.Position.Y );
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
        public void event_added_to_EventOccured_list()
        {
            Universe sut = new Universe();
            sut.Event.EventOccurs(1);
            Assert.That( sut.Event.EventsOccured.Count != 0 );
            for( int i = 0; i < sut.Event.EventsOccured.Count; i += 1 )
            {
                Console.WriteLine( sut.Event.EventsOccured[i] );
            }
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
