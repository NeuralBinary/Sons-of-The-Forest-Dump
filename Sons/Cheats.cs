using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Modding.Bridge.Interfaces;
using UnityEngine;

// Token: 0x020001DB RID: 475
[Token(Token = "0x20001DB")]
public class Cheats : MonoBehaviour
{
	// Token: 0x17000195 RID: 405
	// (get) Token: 0x06000D96 RID: 3478 RVA: 0x000055C8 File Offset: 0x000037C8
	// (set) Token: 0x06000D97 RID: 3479 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000195")]
	public static bool NoEnemies
	{
		[Token(Token = "0x6000D96")]
		[Address(RVA = "0x3705590", Offset = "0x3703B90", VA = "0x183705590")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D97")]
		[Address(RVA = "0x3705740", Offset = "0x3703D40", VA = "0x183705740")]
		set
		{
		}
	}

	// Token: 0x17000196 RID: 406
	// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000055E0 File Offset: 0x000037E0
	// (set) Token: 0x06000D99 RID: 3481 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000196")]
	public static bool DebugConsole
	{
		[Token(Token = "0x6000D98")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D99")]
		[Address(RVA = "0x37057A0", Offset = "0x3703DA0", VA = "0x1837057A0")]
		set
		{
		}
	}

	// Token: 0x17000197 RID: 407
	// (get) Token: 0x06000D9A RID: 3482 RVA: 0x000055F8 File Offset: 0x000037F8
	// (set) Token: 0x06000D9B RID: 3483 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000197")]
	public static bool Allowed
	{
		[Token(Token = "0x6000D9A")]
		[Address(RVA = "0x3705800", Offset = "0x3703E00", VA = "0x183705800")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D9B")]
		[Address(RVA = "0x3705850", Offset = "0x3703E50", VA = "0x183705850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9C")]
	[Address(RVA = "0x37058B0", Offset = "0x3703EB0", VA = "0x1837058B0")]
	private void Start()
	{
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9D")]
	[Address(RVA = "0x3706410", Offset = "0x3704A10", VA = "0x183706410")]
	private void Update()
	{
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9E")]
	[Address(RVA = "0x3706E80", Offset = "0x3705480", VA = "0x183706E80")]
	public static void SetAllowed(bool onoff)
	{
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D9F")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public Cheats()
	{
	}

	// Token: 0x04000C72 RID: 3186
	[Token(Token = "0x4000C72")]
	[FieldOffset(Offset = "0x0")]
	public static Cheats.CheatsBridge Bridge;

	// Token: 0x04000C73 RID: 3187
	[Token(Token = "0x4000C73")]
	[FieldOffset(Offset = "0x20")]
	private string[] VeganModeCode;

	// Token: 0x04000C74 RID: 3188
	[Token(Token = "0x4000C74")]
	[FieldOffset(Offset = "0x28")]
	private string[] VegetarianModeCode;

	// Token: 0x04000C75 RID: 3189
	[Token(Token = "0x4000C75")]
	[FieldOffset(Offset = "0x30")]
	private string[] MeatModeCode;

	// Token: 0x04000C76 RID: 3190
	[Token(Token = "0x4000C76")]
	[FieldOffset(Offset = "0x38")]
	private string[] RawMeatModeCode;

	// Token: 0x04000C77 RID: 3191
	[Token(Token = "0x4000C77")]
	[FieldOffset(Offset = "0x40")]
	private string[] creativeCode;

	// Token: 0x04000C78 RID: 3192
	[Token(Token = "0x4000C78")]
	[FieldOffset(Offset = "0x48")]
	private string[] resetHolesCode;

	// Token: 0x04000C79 RID: 3193
	[Token(Token = "0x4000C79")]
	[FieldOffset(Offset = "0x50")]
	private string[] debugConsoleCode;

	// Token: 0x04000C7A RID: 3194
	[Token(Token = "0x4000C7A")]
	[FieldOffset(Offset = "0x58")]
	private int VeganModeIndex;

	// Token: 0x04000C7B RID: 3195
	[Token(Token = "0x4000C7B")]
	[FieldOffset(Offset = "0x5C")]
	private int VegetarianModeIndex;

	// Token: 0x04000C7C RID: 3196
	[Token(Token = "0x4000C7C")]
	[FieldOffset(Offset = "0x60")]
	private int IronForestModeIndex;

	// Token: 0x04000C7D RID: 3197
	[Token(Token = "0x4000C7D")]
	[FieldOffset(Offset = "0x64")]
	private int MeatModeIndex;

	// Token: 0x04000C7E RID: 3198
	[Token(Token = "0x4000C7E")]
	[FieldOffset(Offset = "0x68")]
	private int RawMeatModeIndex;

	// Token: 0x04000C7F RID: 3199
	[Token(Token = "0x4000C7F")]
	[FieldOffset(Offset = "0x6C")]
	private int ResetHolesIndex;

	// Token: 0x04000C80 RID: 3200
	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0x70")]
	private int DebugConsoleIndex;

	// Token: 0x04000C81 RID: 3201
	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0x8")]
	public static bool NoEnemiesInternal;

	// Token: 0x04000C82 RID: 3202
	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0x9")]
	public static bool NoEnemiesDuringDay;

	// Token: 0x04000C83 RID: 3203
	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0xA")]
	public static bool Creative;

	// Token: 0x04000C84 RID: 3204
	[Token(Token = "0x4000C84")]
	[FieldOffset(Offset = "0xB")]
	public static bool GodMode;

	// Token: 0x04000C85 RID: 3205
	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0xC")]
	public static bool InfiniteEnergy;

	// Token: 0x04000C86 RID: 3206
	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0xD")]
	public static bool InfiniteAmmo;

	// Token: 0x04000C87 RID: 3207
	[Token(Token = "0x4000C87")]
	[FieldOffset(Offset = "0xE")]
	public static bool PermaDeath;

	// Token: 0x04000C88 RID: 3208
	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0xF")]
	public static bool ResetHoles;

	// Token: 0x04000C89 RID: 3209
	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0x10")]
	public static bool NoSurvival;

	// Token: 0x04000C8A RID: 3210
	[Token(Token = "0x4000C8A")]
	[FieldOffset(Offset = "0x11")]
	private static bool _debugConsole;

	// Token: 0x020001DC RID: 476
	[Token(Token = "0x20001DC")]
	public class CheatsBridge : ICheatsBridge
	{
		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x3707070", Offset = "0x3705670", VA = "0x183707070", Slot = "4")]
		public void SetCreative(bool onoff)
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x37070D0", Offset = "0x37056D0", VA = "0x1837070D0", Slot = "5")]
		public void SetGodMode(bool onoff)
		{
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x3707130", Offset = "0x3705730", VA = "0x183707130", Slot = "6")]
		public void SetInfiniteEnergy(bool onoff)
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x3707190", Offset = "0x3705790", VA = "0x183707190")]
		public void SetInfiniteAmmo(bool onoff)
		{
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA5")]
		[Address(RVA = "0x37071F0", Offset = "0x37057F0", VA = "0x1837071F0", Slot = "8")]
		public void SetPermaDeath(bool onoff)
		{
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA6")]
		[Address(RVA = "0x3707250", Offset = "0x3705850", VA = "0x183707250", Slot = "7")]
		public void SetNoSurvival(bool onoff)
		{
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DA7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public CheatsBridge()
		{
		}
	}
}
