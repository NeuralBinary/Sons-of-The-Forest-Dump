using System;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
[Serializable]
public class CoopLobbyMember : IEquatable<CoopLobbyMember>
{
	// Token: 0x06000003 RID: 3 RVA: 0x00002058 File Offset: 0x00000258
	[Token(Token = "0x6000003")]
	[Address(RVA = "0x30CFBB0", Offset = "0x30CE1B0", VA = "0x1830CFBB0", Slot = "4")]
	public bool Equals(CoopLobbyMember other)
	{
		return default(bool);
	}

	// Token: 0x06000004 RID: 4 RVA: 0x00002070 File Offset: 0x00000270
	[Token(Token = "0x6000004")]
	[Address(RVA = "0x30CFC90", Offset = "0x30CE290", VA = "0x1830CFC90", Slot = "2")]
	public override int GetHashCode()
	{
		return 0;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000005")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public CoopLobbyMember()
	{
	}

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x10")]
	public CSteamID Id;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x18")]
	public string IdString;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x20")]
	public string Name;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x28")]
	public Texture2D Texture;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x30")]
	public bool Init;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x31")]
	public bool IsHost;

	// Token: 0x0400000A RID: 10
	[Token(Token = "0x400000A")]
	[FieldOffset(Offset = "0x32")]
	public bool IsSelf;
}
