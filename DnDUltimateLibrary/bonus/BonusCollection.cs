using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace DnDUltimateLibrary.bonus
{
    public class BonusCollection
    {
        List<Bonus> bonuses = new List<Bonus>();
        public void Add(Bonus bonus)
        {
            bonuses.Add(bonus);
        }
        public Int16 Sum()
        {
            Dictionary<string, Int16> map = new Dictionary<string, Int16>();
            foreach (Bonus bonus in bonuses)
            {
                if (map.ContainsKey(bonus.Source.Name))
                {
                    if (bonus.Source.StackableWithTheSame)
                    {
                        map[bonus.Source.Name] += bonus.NumericValue;
                    }
                    else
                    {
                        map[bonus.Source.Name] = Math.Max(map[bonus.Source.Name], bonus.NumericValue);
                    }
                }
                else
                {
                    map.Add(bonus.Source.Name, bonus.NumericValue);
                }
            }
            return (Int16)map.Sum(x => x.Value);
        }
    }
}
