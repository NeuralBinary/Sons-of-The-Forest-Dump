using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DA RID: 218
[Token(Token = "0x20000DA")]
public static class FMODNetworkedAudio
{
	// Token: 0x060006BB RID: 1723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x35238C0", Offset = "0x3521EC0", VA = "0x1835238C0")]
	public static void PlayOneShot(string eventName, Vector3 position)
	{
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x3523950", Offset = "0x3521F50", VA = "0x183523950")]
	public static void PlayOneShot(string eventName, Vector3 position, bool local)
	{
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x35239F0", Offset = "0x3521FF0", VA = "0x1835239F0")]
	public static void PlayOneShot(string eventName, Vector3 position, float maxDistance)
	{
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x3523A90", Offset = "0x3522090", VA = "0x183523A90")]
	public static void PlayOneShot(string eventName, Vector3 position, bool local, float maxDistance)
	{
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x3523EB0", Offset = "0x35224B0", VA = "0x183523EB0")]
	public static void PlayOneShotParameter(string eventName, Vector3 position, int index, float value)
	{
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x3523F70", Offset = "0x3522570", VA = "0x183523F70")]
	public static void PlayOneShotParameter(string eventName, Vector3 position, int index, float value, bool local)
	{
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x3524030", Offset = "0x3522630", VA = "0x183524030")]
	public static void PlayOneShotParameter(string eventName, Vector3 position, int index, float value, float maxDistance)
	{
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x35240F0", Offset = "0x35226F0", VA = "0x1835240F0")]
	public static void PlayOneShotParameter(string eventName, Vector3 position, int index, float value, bool local, float maxDistance)
	{
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x3524580", Offset = "0x3522B80", VA = "0x183524580")]
	private static void SendEvent(string eventName, Vector3 position, BoltConnection connection)
	{
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x3524610", Offset = "0x3522C10", VA = "0x183524610")]
	private static void SendEvent(string eventName, Vector3 position, BoltConnection connection, int index, float value)
	{
	}

	// Token: 0x0400058B RID: 1419
	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x0")]
	public static bool DefaultLocal;

	// Token: 0x0400058C RID: 1420
	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x4")]
	public static float DefaultDistance;
}
