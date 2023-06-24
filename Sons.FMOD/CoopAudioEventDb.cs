using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000D RID: 13
[Token(Token = "0x200000D")]
public class CoopAudioEventDb : ScriptableObject
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000049 RID: 73 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000001")]
	private static CoopAudioEventDb Instance
	{
		[Token(Token = "0x6000049")]
		[Address(RVA = "0x2FD6050", Offset = "0x2FD4650", VA = "0x182FD6050")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x2FD6640", Offset = "0x2FD4C40", VA = "0x182FD6640")]
	public static string FindEvent(int id)
	{
		return null;
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002234 File Offset: 0x00000434
	[Token(Token = "0x600004B")]
	[Address(RVA = "0x2FD66D0", Offset = "0x2FD4CD0", VA = "0x182FD66D0")]
	public static int FindId(string eventPath)
	{
		return 0;
	}

	// Token: 0x0600004C RID: 76 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600004C")]
	[Address(RVA = "0x2FD6790", Offset = "0x2FD4D90", VA = "0x182FD6790")]
	public CoopAudioEventDb()
	{
	}

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x0")]
	private static CoopAudioEventDb _instance;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	public string[] EventList;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, int> EventToId;

	// Token: 0x04000050 RID: 80
	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, string> IdToEvent;
}
