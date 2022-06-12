using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using System.IO;


namespace DBDパークルーレット
{
    public class PerkObj
    {
        public PerkInfo[] SurvivorPerks { get; set; }
        public PerkInfo[] KillerPerks { get; set; }
    }

    public class PerkInfo
    {
        public string Perk;
        public string Character;
        public string Effect;
        public int Page;
        public int Order;

        public string GetTooltipText()
        {
            string result = $"キャラクター：{Character}\n効果：\n";
            if(Effect[Effect.Length-1] == '|')
            {
                result += $"    {Effect.Substring(0, Effect.Length - 1)}\n";
            }
            else
            {
                string[] splittedEffect = Effect.Split('|');
                for (int i = 0; i < splittedEffect.Length; i++)
                {
                    if (splittedEffect[i].Trim() == "")
                    {
                        break;
                    }

                    result += $"    {splittedEffect[i]}\n";
                }
            }
            return result;
        }
    }

    public class Perk
    {
        public PerkObj Perks;

        public Perk()
        {
            var input = new StreamReader("Perks.yaml", Encoding.UTF8);
            var deserializer = new Deserializer();
            Perks = deserializer.Deserialize<PerkObj>(input);
            input.Close();
        }
    }
}
