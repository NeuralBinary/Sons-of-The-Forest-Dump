using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000DC RID: 220
[Token(Token = "0x20000DC")]
public static class FMODNetworkedAudio
{
	// Token: 0x06000671 RID: 1649 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000671")]
	[Address(RVA = "0x2E856F0", Offset = "0x2E846F0", VA = "0x182E856F0")]
	public static void PlayOneShot(string eventName, Vector3 position)
	{
	}

	// Token: 0x06000672 RID: 1650 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000672")]
	[Address(RVA = "0x2E85A90", Offset = "0x2E84A90", VA = "0x182E85A90")]
	public static void PlayOneShot(string eventName, Vector3 position, bool local)
	{
	}

	// Token: 0x06000673 RID: 1651 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000673")]
	[Address(RVA = "0x2E85B30", Offset = "0x2E84B30", VA = "0x182E85B30")]
	public static void PlayOneShot(string eventName, Vector3 position, float maxDistance)
	{
	}

	// Token: 0x06000674 RID: 1652 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000674")]
	[Address(RVA = "0x2E85780", Offset = "0x2E84780", VA = "0x182E85780")]
	public static void PlayOneShot(string eventName, Vector3 position, bool local, float maxDistance)
	{
	}

	// Token: 0x06000675 RID: 1653 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000675")]
	[Address(RVA = "0x2E85630", Offset = "0x2E84630", VA = "0x182E85630")]
	public static void PlayOneShotParameter(string eventName, Vector3 position, int index, float value)
	{
	}

	// Token: 0x06000676 RID: 1654 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000676")]
	[Address(RVA = "0x2E85570", Offset = "0x2E84570", VA = "0x182E85570")]
	public static void PlayOneShotParameter(string eventName, Vector3 position, int index, float value, bool local)
	{
	}

	// Token: 0x06000677 RID: 1655 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000677")]
	[Address(RVA = "0x2E850D0", Offset = "0x2E840D0", VA = "0x182E850D0")]
	public static void PlayOneShotParameter(string eventName, Vector3 position, int index, float value, float maxDistance)
	{
	}

	// Token: 0x06000678 RID: 1656 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000678")]
	[Address(RVA = "0x2E85190", Offset = "0x2E84190", VA = "0x182E85190")]
	public static void PlayOneShotParameter(string eventName, Vector3 position, int index, float value, bool local, float maxDistance)
	{
	}

	// Token: 0x06000679 RID: 1657 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000679")]
	[Address(RVA = "0x2E85C80", Offset = "0x2E84C80", VA = "0x182E85C80")]
	private static void SendEvent(string eventName, Vector3 position, BoltConnection connection)
	{
	}

	// Token: 0x0600067A RID: 1658 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600067A")]
	[Address(RVA = "0x2E85BD0", Offset = "0x2E84BD0", VA = "0x182E85BD0")]
	private static void SendEvent(string eventName, Vector3 position, BoltConnection connection, int index, float value)
	{
	}

	// Token: 0x0400056E RID: 1390
	[Token(Token = "0x400056E")]
	[FieldOffset(Offset = "0x0")]
	public static bool DefaultLocal;

	// Token: 0x0400056F RID: 1391
	[Token(Token = "0x400056F")]
	[FieldOffset(Offset = "0x4")]
	public static float DefaultDistance;
}
