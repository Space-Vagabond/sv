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
                Planet P = Universe.AddPlanet();
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
                Planet P = Universe.AddPlanet();
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
                Planet P = Universe.AddPlanet();
                count[PlanetAttributes.PlanetTypes.IndexOf(P.Type)] += 1 ;
                
            }
            for( i = 0; i < 10; i++ )
            {
                Console.WriteLine( count[i] );
            }
        }
        [Test]
        public void With_type_comes_ressources()
        {
            Universe u = new Universe();
            int i;

            for( i = 0; i < 100; i++ )
            {
                Planet P = Universe.AddPlanet();
                Console.WriteLine( i );
                Console.WriteLine("type: "+P.Type+ "Surface: "+ P.Surface+" Ressource: "+P.Ressource);
                if( P.Type == PlanetAttributes.PlanetTypes[0] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[0] );
                    Assert.That(P.Surface == PlanetAttributes.PlanetSurfaces[5] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[6] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[7] || 
                                P.Surface == PlanetAttributes.PlanetSurfaces[8]);

                }
                else if( P.Type == PlanetAttributes.PlanetTypes[1] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[1] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[5] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[6] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[7] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[8] );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[2] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[3] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[5] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[6] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[7] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[8] );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[3] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[6] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[0]);
                    Assert.That( P.Inhabited == true );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[4] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[6] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[3]);
                    Assert.That( P.Inhabited == true );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[5] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[6] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[5] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[6] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[7] ||
                                P.Surface == PlanetAttributes.PlanetSurfaces[8] );
                    Assert.That( P.Inhabited == true );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[6] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[0] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[1] );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[7] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[4] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[4]);
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[8] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[5] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[4] );
                }
                else if( P.Type == PlanetAttributes.PlanetTypes[9] )
                {
                    Assert.That( P.Ressource == PlanetAttributes.PlanetRessources[2] || P.Ressource == PlanetAttributes.PlanetRessources[1] );
                    Assert.That( P.Surface == PlanetAttributes.PlanetSurfaces[2] );
                    Assert.That( P.Inhabited == false );
                    Assert.AreEqual( P.InhabitantsName , "Inhabited planet" );
                } 
            }
        }
    }
}
