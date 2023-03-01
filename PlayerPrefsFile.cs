using System;
using Il2CppDummyDll;
using TheForest.Commons.Enums;

// Token: 0x020002A5 RID: 677
[Token(Token = "0x20002A5")]
public static class PlayerPrefsFile
{
	// Token: 0x06001184 RID: 4484 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001184")]
	[Address(RVA = "0x2B85090", Offset = "0x2B84090", VA = "0x182B85090")]
	private static string GetPath(string name)
	{
		return null;
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x000061F8 File Offset: 0x000043F8
	[Token(Token = "0x6001185")]
	[Address(RVA = "0x2B85170", Offset = "0x2B84170", VA = "0x182B85170")]
	public static bool KeyExist(string name)
	{
		return default(bool);
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001186")]
	[Address(RVA = "0x2B85100", Offset = "0x2B84100", VA = "0x182B85100")]
	public static string GetString(string name, string defaultValue = "", bool useSlots = true)
	{
		return null;
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6001187")]
	[Address(RVA = "0x2B85020", Offset = "0x2B84020", VA = "0x182B85020")]
	public static byte[] GetBytes(string name, byte[] defaultValue, bool useSlots = true)
	{
		return null;
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001188")]
	[Address(RVA = "0x2B85360", Offset = "0x2B84360", VA = "0x182B85360")]
	public static void SetString(string name, string data, bool useSlots = true)
	{
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6001189")]
	[Address(RVA = "0x2B85220", Offset = "0x2B84220", VA = "0x182B85220")]
	public static void SetBytes(string name, byte[] data, bool useSlots = true)
	{
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118A")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	public static void Save()
	{
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118B")]
	[Address(RVA = "0x2B84F30", Offset = "0x2B83F30", VA = "0x182B84F30")]
	public static void DeleteKey(string name, bool useSlots = true)
	{
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118C")]
	[Address(RVA = "0x2B84D10", Offset = "0x2B83D10", VA = "0x182B84D10")]
	public static void ConvertToSlotSystem(string name, PlayerModes mode)
	{
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600118D")]
	[Address(RVA = "0x2B854D0", Offset = "0x2B844D0", VA = "0x182B854D0")]
	public static void SyncWithCloud(string name, PlayerModes mode, Slots slot)
	{
	}
}
