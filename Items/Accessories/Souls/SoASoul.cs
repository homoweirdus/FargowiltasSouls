﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using Terraria.Localization;
using System;
using SacredTools;
using Microsoft.Xna.Framework;

namespace FargowiltasSouls.Items.Accessories.Forces.SoA
{
    public class SoASoul : ModItem
    {
        private readonly Mod soa = ModLoader.GetMod("SacredTools");

        public override string Texture => "FargowiltasSouls/Items/Placeholder";

        public override bool Autoload(ref string name)
        {
            return ModLoader.GetMod("SacredTools") != null;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Soul of Two Realms");
            Tooltip.SetDefault(
@"'Two worlds, now embodied as one'
All armor bonuses from Bismuth, Frosthunter, and Blightbone
All armor bonuses from Dreadfire, Space Junk, and Marstech
All armor bonuses from Blazing Brute, Cosmic Commander, and Nebulous Apprentice
All armor bonuses from Stellar Priest and Fallen Prince
All armor bonuses from Void Warden, Vulcan Reaper, and Flarium
All armor bonuses from Asthraltite
Effects of Dreadflame Emblem, Lapis Pendant, Frigid Pendant, and Pumpkin Amulet
Effects of Nuba's Blessing, Novaniel's Resolve, and Celestial Ring
Effects of Ring of the Fallen, Memento Mori, and Arcanum of the Caster
Summons several pets");
            DisplayName.AddTranslation(GameCulture.Chinese, "两界之魂");
            Tooltip.AddTranslation(GameCulture.Chinese, 
@"'两个世界, 现在显现合一'
拥有铋, 霜冻猎人和荒骨的套装效果
拥有惧焰, 太空垃圾和火星科技的套装效果
拥有赤炎, 宇宙指挥官和星云学徒的套装效果
拥有恒星牧师和堕落王子的套装效果
拥有虚空守望, 火神收割者和熔火的套装效果
拥有阿斯德罗特的套装效果
拥有恐惧火焰徽记, 青金石挂饰, 极寒吊坠和南瓜护身符的效果
拥有努巴的祝福, 诺瓦尼尔的决心和天体星环的效果
拥有堕落之戒, 死亡意志和魔法奥秘的效果
召唤数个宠物");
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            item.rare = 11;
            item.value = 1000000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            if (!Fargowiltas.Instance.CalamityLoaded) return;

            FargoPlayer fargoPlayer = player.GetModPlayer<FargoPlayer>(mod);
            ModdedPlayer modPlayer = player.GetModPlayer<ModdedPlayer>();

            mod.GetItem("GenerationsForce").UpdateAccessory(player, hideVisual);
            mod.GetItem("SoranForce").UpdateAccessory(player, hideVisual);
            mod.GetItem("SyranForce").UpdateAccessory(player, hideVisual);
        }


        public override void AddRecipes()
        {
            if (!Fargowiltas.Instance.SOALoaded) return;

            ModRecipe recipe = new ModRecipe(mod);

            recipe.AddIngredient(null, "GenerationsForce");
            recipe.AddIngredient(null, "SoranForce");
            recipe.AddIngredient(null, "SyranForce");

            recipe.AddTile(mod, "CrucibleCosmosSheet");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
