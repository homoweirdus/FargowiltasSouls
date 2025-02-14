﻿using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;
using ThoriumMod;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using Terraria.Localization;

namespace FargowiltasSouls.Items.Patreon
{
    public class ComputationOrb : ModItem
    {
        public override string Texture => "FargowiltasSouls/Items/Placeholder";

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Computation Orb");
            Tooltip.SetDefault(
@"Non magic attacks will deal 25% extra damage and consume 10 mana");
            DisplayName.AddTranslation(GameCulture.Chinese, "演算宝珠");
            Tooltip.AddTranslation(GameCulture.Chinese, 
@"非魔法攻击将额外造成25%伤害, 并消耗10法力");

        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.accessory = true;
            ItemID.Sets.ItemNoGravity[item.type] = true;
            item.rare = 10;
            item.value = 400000;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            FargoPlayer modPlayer = player.GetModPlayer<FargoPlayer>();
            modPlayer.AssassinEnchant = true;
        }
    }
}
