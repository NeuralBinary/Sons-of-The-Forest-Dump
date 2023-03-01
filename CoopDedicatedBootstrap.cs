using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EE RID: 238
[Token(Token = "0x20000EE")]
public class CoopDedicatedBootstrap : MonoBehaviour
{
	// Token: 0x060006E5 RID: 1765 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E5")]
	[Address(RVA = "0x2E71670", Offset = "0x2E70670", VA = "0x182E71670")]
	private void Awake()
	{
	}

	// Token: 0x060006E6 RID: 1766 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x2E71880", Offset = "0x2E70880", VA = "0x182E71880")]
	private void ClientRoutine(string[] args)
	{
	}

	// Token: 0x060006E7 RID: 1767 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x2E72AA0", Offset = "0x2E71AA0", VA = "0x182E72AA0")]
	private void ServerRoutine(string[] args)
	{
	}

	// Token: 0x060006E8 RID: 1768 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x2E71520", Offset = "0x2E70520", VA = "0x182E71520")]
	private void ApplyCheatsAndOptions()
	{
	}

	// Token: 0x060006E9 RID: 1769 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x2E71F70", Offset = "0x2E70F70", VA = "0x182E71F70")]
	public void LaunchDSServer()
	{
	}

	// Token: 0x060006EA RID: 1770 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x2E74420", Offset = "0x2E73420", VA = "0x182E74420")]
	private void showServerData()
	{
	}

	// Token: 0x060006EB RID: 1771 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x2E73EF0", Offset = "0x2E72EF0", VA = "0x182E73EF0")]
	private void setServerData()
	{
	}

	// Token: 0x060006EC RID: 1772 RVA: 0x00003EE8 File Offset: 0x000020E8
	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x2E71EB0", Offset = "0x2E70EB0", VA = "0x182E71EB0")]
	private bool HasOption(string[] args, string name, bool defaultState)
	{
		return default(bool);
	}

	// Token: 0x060006ED RID: 1773 RVA: 0x00003F00 File Offset: 0x00002100
	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x2E71F20", Offset = "0x2E70F20", VA = "0x182E71F20")]
	private bool HasOption(string[] args, string name)
	{
		return default(bool);
	}

	// Token: 0x060006EE RID: 1774 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x2E71C80", Offset = "0x2E70C80", VA = "0x182E71C80")]
	private string GetPasswordArg(string[] args, string name, string defaultValue)
	{
		return null;
	}

	// Token: 0x060006EF RID: 1775 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x2E71E00", Offset = "0x2E70E00", VA = "0x182E71E00")]
	private string GetStringArg(string[] args, string name, string defaultValue)
	{
		return null;
	}

	// Token: 0x060006F0 RID: 1776 RVA: 0x00003F18 File Offset: 0x00002118
	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x2E71BB0", Offset = "0x2E70BB0", VA = "0x182E71BB0")]
	private int GetIntArg(string[] args, string name, int defaultValue)
	{
		return default(int);
	}

	// Token: 0x060006F1 RID: 1777 RVA: 0x00003F30 File Offset: 0x00002130
	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x2E71D20", Offset = "0x2E70D20", VA = "0x182E71D20")]
	private ushort GetShortArg(string[] args, string name, ushort defaultValue)
	{
		return default(ushort);
	}

	// Token: 0x060006F2 RID: 1778 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F2")]
	private T StringToEnum<T>(string value)
	{
		return null;
	}

	// Token: 0x060006F3 RID: 1779 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006F3")]
	private T GetEnumArg<T>(string[] args, string name, T defaultValue)
	{
		return null;
	}

	// Token: 0x060006F4 RID: 1780 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x2E73C00", Offset = "0x2E72C00", VA = "0x182E73C00")]
	public CoopDedicatedBootstrap()
	{
	}

	// Token: 0x040005BD RID: 1469
	[Token(Token = "0x40005BD")]
	[FieldOffset(Offset = "0x20")]
	public bool UseServerArgs;

	// Token: 0x040005BE RID: 1470
	[Token(Token = "0x40005BE")]
	[FieldOffset(Offset = "0x28")]
	public string[] ServerArgs;

	// Token: 0x040005BF RID: 1471
	[Token(Token = "0x40005BF")]
	[FieldOffset(Offset = "0x30")]
	public bool UseClientArgs;

	// Token: 0x040005C0 RID: 1472
	[Token(Token = "0x40005C0")]
	[FieldOffset(Offset = "0x38")]
	public string[] ClientArgs;

	// Token: 0x040005C1 RID: 1473
	[Token(Token = "0x40005C1")]
	[FieldOffset(Offset = "0x40")]
	public Canvas canvas;
}
