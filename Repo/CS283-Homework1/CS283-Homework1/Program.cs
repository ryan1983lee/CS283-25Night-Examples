using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonLibrary;

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
                type = "草系 / 毒系",
                hp = "60",
                stardust = "271484",
                candy = "27",
                powerup = "星星沙子：3000 ; 妙蛙種子的糖果：27",
                evolve = "妙蛙種子的糖果：25",
                tackle = "藤鞭",
                powerwhip = "汙泥炸彈"
            };
            Console.WriteLine(
                "怪物名稱：{0}, 身高：{1}, 體重：{2}, 性別：{3}, 類別：{4}, 血量：{5}, 星星沙子：{6}, 妙蛙種子的糖果：{7}, 強化：{8}, 進化：{9}, 普通攻擊：{10}, 蓄力攻擊：{11}"
                , apokemon.name
                , apokemon.hight
                , apokemon.weight
                , apokemon.gender
                , apokemon.type
                , apokemon.hp
                , apokemon.stardust
                , apokemon.candy
                , apokemon.powerup
                , apokemon.evolve
                , apokemon.tackle
                , apokemon.powerwhip
                );
        }
    }
}