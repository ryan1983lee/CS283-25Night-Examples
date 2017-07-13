using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary


namespace CS283_Homework1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon apokemon = new Pokemon()
            {
                name = "妙蛙種子",
                hight = "0.67 m",
                weight = "5.94 kg",
                gender = "公",
                category = "草系 ; 毒系",
                hp = "60",
                weapon = "籐鞭 & 汙泥炸彈"
            };
            Console.WriteLine(
                "怪物名稱：{0}, 身高{1}, 體重：{2}, 性別：{3}, 類別：{4}, 血量：{5}, 武器：{6}"
                , Pokemon.name
                , Pokemon.hight
                , Pokemon.weight
                , Pokemon.gender
                , Pokemon.category
                , Pokemon.hp
                , Pokemon.weapon
                );
        }
    }
}