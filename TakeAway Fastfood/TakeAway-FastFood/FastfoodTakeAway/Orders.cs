using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;
using Discord;
using Discord.WebSocket;
using System.Linq;
using System.Timers;

namespace TakeawayFastFood
{
    public class Orders : ModuleBase<SocketCommandContext>
    {

        [Command("category")] // пока не понадобилось

        public async Task CreateCategory()
        {
            ICategoryChannel category = await Context.Guild.CreateCategoryChannelAsync("ff");
            ITextChannel text = await Context.Guild.CreateTextChannelAsync("ff", x => x.CategoryId = category.Id);
            Task.Delay(2000);
            await text.ModifyAsync(x => x.Name = "CHANNEL");
        }

        [Alias("афыеащщв")]
        [Command("fastfood")]

        public async Task FastFood()
        {
            EmbedBuilder builder = new EmbedBuilder()

                .WithTitle($"*Здесь принимают фаст-фуд заказы.*")
                .WithCurrentTimestamp()
                .WithColor(new Color(0x59FAE5))
                .WithImageUrl("https://i.pinimg.com/originals/36/11/d3/3611d3ced99c00a150cdc4d3bcfa1fa9.gif")
                .AddField("Мы предлагаем:", ":fries::\n *- картофель фри (маленький)*\n *- картофель фри (средний)*\n *- картофель фри (большой)*\n\n :poultry_leg::\n *- наггетсы (4 штуки)*\n *- наггетсы (6 штук)*\n *- наггетсы (9 штук)*\n\n :hamburger::\n *- макчикен*\n *- чизбургер*\n *- роял*\n *- двойной роял*\n *- шримп ролл*\n *- цезарь ролл*\n\n :cup_with_straw::\n*- вода*\n*- кола 0.3*\n*- кола 0.5*\n*- спрайт 0.3*\n*- спрайт 0.5*\n*- капучино*\n*- латте*\n\n:cake::\n*- тирамису*");

            Embed embed = builder.Build();

            EmbedBuilder builder1 = new EmbedBuilder()
                .WithTitle($"__Введите ваш заказ, вызвав команду ***!order***, и перечислите то, что собираетесь заказать.__\n\n\n Oбразец заказа:")
                .WithDescription("`!order картофельфрифрималенький наггетсы9штук тирамису кола0.5`")
                .WithCurrentTimestamp()
                .WithColor(new Color(0x59FAE5));
            Embed embed1 = builder1.Build();
            await ReplyAsync("*Добро пожаловать!*", false, embed);
            await ReplyAsync("→ → → → → ", false, embed1);

        }


        [Alias("щквук")]
        [Command("order")]
        public async Task Order(params string[] order)
        {

            double waiting = 0;
            Dictionary<string, double> products = new Dictionary<string, double>
            {
                ["картофельфрималенький"] = 1, // в секундах
                ["картофельфрисредний"] = 3,
                ["картофельфрибольшой"] = 5,
                ["наггетсы4штуки"] = 8,
                ["наггетсы6штук"] = 6,
                ["наггетсы9штук"] = 5,
                ["кола0.3"] = 8,
                ["кола0.5"] = 6,
                ["вода"] = 4,
                ["спрайт0.3"] = 8,
                ["спрайт0.5"] = 6,
                ["тирамису"] = 6,
                ["цезарьролл"] = 4,
                ["шримпролл"] = 6,
                ["роял"] = 4,
                ["макчикен"] = 4,
                ["чизбургер"] = 7,
                ["двойнойроял"] = 9,
                ["капучино"] = 4,
                ["латте"] = 7,
            };


            string res = " ";
            foreach (string b in order)
            {
                if (!products.ContainsKey(b))
                {
                    await ReplyAsync("**Убедитесь, что все есть в меню!\n Пожалуйста, повторите ввод снова.**");
                    return;
                }

                double current = products[b];
                if (current > waiting)
                {
                    waiting = current;
                }
            }

            await ReplyAsync("OK!");
            EmbedBuilder builder2 = new EmbedBuilder()
                .WithTitle($"__Ваш заказ получен!__\n\n Пожалуйста, ожидайте.\n Ваше время ожидания: {waiting} минут.")
                .WithImageUrl("https://c.tenor.com/gkJspecR5CwAAAAC/burger-food.gif")
                .WithCurrentTimestamp()
                .WithColor(new Color(0x59FAE5));
            Embed embed2 = builder2.Build();
            await ReplyAsync(" ", false, embed2);

            Task.Delay(10000); // timer

            EmbedBuilder builder3 = new EmbedBuilder()
                .WithTitle($"__Ваш заказ готов!__\n\n Благодарим за заказ!\n")
                .WithDescription($"Ваш чек:\n {res} \n\n")
                .WithImageUrl("https://i.imgur.com/5qwRWWO.gif?noredirect")
                .WithCurrentTimestamp()
                .WithColor(new Color(0x59FAE5));
            Embed embed3 = builder3.Build();
            await ReplyAsync(" ", false, embed3);
        }
    }
}
