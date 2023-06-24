using System;
using Il2CppDummyDll;

namespace Sons.Items.Core
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[Flags]
	public enum Types
	{
		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		Equippable = 1,
		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		Clothing = 2,
		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		CraftingMaterial = 4,
		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		Craftable = 2048,
		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		Edible = 8,
		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		Droppable = 16,
		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		Ammo = 32,
		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		Projectile = 64,
		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		Special = 128,
		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		StructureBlueprint = 256,
		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		RangedWeapon = 512,
		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		Story = 1024,
		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		Weapon = 4096,
		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		Extension = 8192,
		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		Armor = 16384,
		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		Axe = 32768
	}
}
