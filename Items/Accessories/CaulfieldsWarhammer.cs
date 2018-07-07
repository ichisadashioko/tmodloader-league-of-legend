﻿using LeagueOfLegend.Items.Accessories;
using LeagueOfLegend.Items.AttackDamageClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace LeagueOfLegend.Items.Accessories
{
    public class CaulfieldsWarhammer : ModItem
    {
        public const int PRICE = 1100;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Caulfield's Warhammer");
            Tooltip.SetDefault(string.Format("[c/0596aa:+25 Attack Damage]"));
        }

        public override void SetDefaults()
        {
            item.accessory = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType<Items.Gold>(), PRICE);
            recipe.SetResult(this);
            recipe.AddRecipe();

            recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType<Items.Accessories.LongSword>(), 2);
            recipe.AddIngredient(mod.ItemType<Items.Gold>(), PRICE - LongSword.PRICE * 2);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            AttackDamagePlayer modPlayer = AttackDamagePlayer.ModPlayer(player);
            modPlayer.attackBonus += 25;
        }

    }
}
