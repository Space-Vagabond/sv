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
            for( i = 0; i < 100; i++ )
            {
                Planet P = new Planet();
                Console.WriteLine( P._name );
                Assert.That( P._name.Length <= 10 && P._name.Length >= 8);
            }

        }
    }
}
