using System;
using Il2CppDummyDll;

// Token: 0x020000D2 RID: 210
[Token(Token = "0x20000D2")]
public static class CoopSteamCloud
{
	// Token: 0x0600069A RID: 1690 RVA: 0x00003EE8 File Offset: 0x000020E8
	[Token(Token = "0x600069A")]
	[Address(RVA = "0x3520680", Offset = "0x351EC80", VA = "0x183520680")]
	public static bool ShouldUseCloud()
	{
		return default(bool);
	}

	// Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069B")]
	[Address(RVA = "0x3520880", Offset = "0x351EE80", VA = "0x183520880")]
	public static string[] ListFiles()
	{
		return null;
	}

	// Token: 0x0600069C RID: 1692 RVA: 0x00003F00 File Offset: 0x00002100
	[Token(Token = "0x600069C")]
	[Address(RVA = "0x3520B20", Offset = "0x351F120", VA = "0x183520B20")]
	public static bool CloudSave(string filename, byte[] buffer)
	{
		return default(bool);
	}

	// Token: 0x0600069D RID: 1693 RVA: 0x00003F18 File Offset: 0x00002118
	[Token(Token = "0x600069D")]
	[Address(RVA = "0x3520B70", Offset = "0x351F170", VA = "0x183520B70")]
	public static bool CloudFileExist(string filename)
	{
		return default(bool);
	}

	// Token: 0x0600069E RID: 1694 RVA: 0x00003F30 File Offset: 0x00002130
	[Token(Token = "0x600069E")]
	[Address(RVA = "0x3520BA0", Offset = "0x351F1A0", VA = "0x183520BA0")]
	public static long CloudTimestamp(string filename)
	{
		return 0L;
	}

	// Token: 0x0600069F RID: 1695 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600069F")]
	[Address(RVA = "0x3520BD0", Offset = "0x351F1D0", VA = "0x183520BD0")]
	public static byte[] CloudLoad(string filename)
	{
		return null;
	}

	// Token: 0x060006A0 RID: 1696 RVA: 0x00003F48 File Offset: 0x00002148
	[Token(Token = "0x60006A0")]
	[Address(RVA = "0x3520C70", Offset = "0x351F270", VA = "0x183520C70")]
	public static bool CloudDelete(string filename)
	{
		return default(bool);
	}
}
