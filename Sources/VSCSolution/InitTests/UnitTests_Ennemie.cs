﻿using BibliothequeClassesVSC;
using System.Collections.Generic;
using Xunit;

namespace InitTests
{
    public class UnitTests_Ennemie
    {
        [Fact]
        public void testConstructeurEnnemie()
        {
            string nom = "ennemie";
            string desc = "TestDesc";
            string img = "Test/img";

            HashSet<Stat> stats = new HashSet<Stat>();
            stats.Add(new Stat(Stat.NomStat.MaxHealth, 40));
            stats.Add(new Stat(Stat.NomStat.Luck));
            stats.Add(new Stat(Stat.NomStat.CritMultiplier, 10));

            Ennemie ennemie = new Ennemie(nom, desc, img, stats);

            Assert.Equal(nom, ennemie.Nom);

            foreach (Stat particularite in stats)
            {
                foreach (Stat stat in ennemie.stats)
                {
                    if(particularite.Nom == stat.Nom)
                    {
                        Assert.Equal(particularite, stat);
                    }
                }
            }
            Assert.Equal(desc, ennemie.Description);
            Assert.Equal(img, ennemie.Image);
        }
    }
}
