using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TheForest.Modding.Bridge.Interfaces;
using UnityEngine;

// Token: 0x020001DC RID: 476
[Token(Token = "0x20001DC")]
public class Cheats : MonoBehaviour
{
	// Token: 0x1700018C RID: 396
	// (get) Token: 0x06000D3B RID: 3387 RVA: 0x00005388 File Offset: 0x00003588
	// (set) Token: 0x06000D3C RID: 3388 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018C")]
	public static bool NoEnemies
	{
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0x2F81D90", Offset = "0x2F80D90", VA = "0x182F81D90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x2F81F90", Offset = "0x2F80F90", VA = "0x182F81F90")]
		set
		{
		}
	}

	// Token: 0x1700018D RID: 397
	// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000053A0 File Offset: 0x000035A0
	// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018D")]
	public static bool DebugConsole
	{
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x2F81F30", Offset = "0x2F80F30", VA = "0x182F81F30")]
		set
		{
		}
	}

	// Token: 0x1700018E RID: 398
	// (get) Token: 0x06000D3F RID: 3391 RVA: 0x000053B8 File Offset: 0x000035B8
	// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x1700018E")]
	public static bool Allowed
	{
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x2F81D40", Offset = "0x2F80D40", VA = "0x182F81D40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x2F81ED0", Offset = "0x2F80ED0", VA = "0x182F81ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x06000D41 RID: 3393 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D41")]
	[Address(RVA = "0x2F80930", Offset = "0x2F7F930", VA = "0x182F80930")]
	private void Start()
	{
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x2F81540", Offset = "0x2F80540", VA = "0x182F81540")]
	private void Update()
	{
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x2F807F0", Offset = "0x2F7F7F0", VA = "0x182F807F0")]
	public static void SetAllowed(bool onoff)
	{
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public Cheats()
	{
	}

	// Token: 0x04000C43 RID: 3139
	[Token(Token = "0x4000C43")]
	[FieldOffset(Offset = "0x0")]
	public static Cheats.CheatsBridge Bridge;

	// Token: 0x04000C44 RID: 3140
	[Token(Token = "0x4000C44")]
	[FieldOffset(Offset = "0x20")]
	private string[] VeganModeCode;

	// Token: 0x04000C45 RID: 3141
	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x28")]
	private string[] VegetarianModeCode;

	// Token: 0x04000C46 RID: 3142
	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x30")]
	private string[] MeatModeCode;

	// Token: 0x04000C47 RID: 3143
	[Token(Token = "0x4000C47")]
	[FieldOffset(Offset = "0x38")]
	private string[] RawMeatModeCode;

	// Token: 0x04000C48 RID: 3144
	[Token(Token = "0x4000C48")]
	[FieldOffset(Offset = "0x40")]
	private string[] creativeCode;

	// Token: 0x04000C49 RID: 3145
	[Token(Token = "0x4000C49")]
	[FieldOffset(Offset = "0x48")]
	private string[] resetHolesCode;

	// Token: 0x04000C4A RID: 3146
	[Token(Token = "0x4000C4A")]
	[FieldOffset(Offset = "0x50")]
	private string[] debugConsoleCode;

	// Token: 0x04000C4B RID: 3147
	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x58")]
	private int VeganModeIndex;

	// Token: 0x04000C4C RID: 3148
	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x5C")]
	private int VegetarianModeIndex;

	// Token: 0x04000C4D RID: 3149
	[Token(Token = "0x4000C4D")]
	[FieldOffset(Offset = "0x60")]
	private int IronForestModeIndex;

	// Token: 0x04000C4E RID: 3150
	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x64")]
	private int MeatModeIndex;

	// Token: 0x04000C4F RID: 3151
	[Token(Token = "0x4000C4F")]
	[FieldOffset(Offset = "0x68")]
	private int RawMeatModeIndex;

	// Token: 0x04000C50 RID: 3152
	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x6C")]
	private int ResetHolesIndex;

	// Token: 0x04000C51 RID: 3153
	[Token(Token = "0x4000C51")]
	[FieldOffset(Offset = "0x70")]
	private int DebugConsoleIndex;

	// Token: 0x04000C52 RID: 3154
	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0x8")]
	public static bool NoEnemiesInternal;

	// Token: 0x04000C53 RID: 3155
	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0x9")]
	public static bool NoEnemiesDuringDay;

	// Token: 0x04000C54 RID: 3156
	[Token(Token = "0x4000C54")]
	[FieldOffset(Offset = "0xA")]
	public static bool Creative;

	// Token: 0x04000C55 RID: 3157
	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0xB")]
	public static bool GodMode;

	// Token: 0x04000C56 RID: 3158
	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0xC")]
	public static bool InfiniteEnergy;

	// Token: 0x04000C57 RID: 3159
	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0xD")]
	public static bool InfiniteAmmo;

	// Token: 0x04000C58 RID: 3160
	[Token(Token = "0x4000C58")]
	[FieldOffset(Offset = "0xE")]
	public static bool PermaDeath;

	// Token: 0x04000C59 RID: 3161
	[Token(Token = "0x4000C59")]
	[FieldOffset(Offset = "0xF")]
	public static bool ResetHoles;

	// Token: 0x04000C5A RID: 3162
	[Token(Token = "0x4000C5A")]
	[FieldOffset(Offset = "0x10")]
	public static bool NoSurvival;

	// Token: 0x04000C5B RID: 3163
	[Token(Token = "0x4000C5B")]
	[FieldOffset(Offset = "0x11")]
	private static bool _debugConsole;

	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	public class CheatsBridge : ICheatsBridge
	{
		// Token: 0x06000D46 RID: 3398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D46")]
		[Address(RVA = "0x2F805B0", Offset = "0x2F7F5B0", VA = "0x182F805B0", Slot = "4")]
		public void SetCreative(bool onoff)
		{
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D47")]
		[Address(RVA = "0x2F80610", Offset = "0x2F7F610", VA = "0x182F80610", Slot = "5")]
		public void SetGodMode(bool onoff)
		{
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D48")]
		[Address(RVA = "0x2F806D0", Offset = "0x2F7F6D0", VA = "0x182F806D0", Slot = "6")]
		public void SetInfiniteEnergy(bool onoff)
		{
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D49")]
		[Address(RVA = "0x2F80670", Offset = "0x2F7F670", VA = "0x182F80670")]
		public void SetInfiniteAmmo(bool onoff)
		{
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4A")]
		[Address(RVA = "0x2F80790", Offset = "0x2F7F790", VA = "0x182F80790", Slot = "8")]
		public void SetPermaDeath(bool onoff)
		{
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4B")]
		[Address(RVA = "0x2F80730", Offset = "0x2F7F730", VA = "0x182F80730", Slot = "7")]
		public void SetNoSurvival(bool onoff)
		{
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000D4C")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public CheatsBridge()
		{
		}
	}
}
