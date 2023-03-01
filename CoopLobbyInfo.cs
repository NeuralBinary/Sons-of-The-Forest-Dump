using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Steamworks;

// Token: 0x02000067 RID: 103
[Token(Token = "0x2000067")]
[Serializable]
public class CoopLobbyInfo
{
	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060002ED RID: 749 RVA: 0x00002E98 File Offset: 0x00001098
	// (set) Token: 0x060002EE RID: 750 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000084")]
	public CSteamID LobbyId
	{
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x5E65C0", Offset = "0x5E55C0", VA = "0x1805E65C0")]
		[CompilerGenerated]
		get
		{
			return default(CSteamID);
		}
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x219E110", Offset = "0x219D110", VA = "0x18219E110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060002EF RID: 751 RVA: 0x00002EB0 File Offset: 0x000010B0
	// (set) Token: 0x060002F0 RID: 752 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000085")]
	public CSteamID ServerId
	{
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x2B63750", Offset = "0x2B62750", VA = "0x182B63750")]
		get
		{
			return default(CSteamID);
		}
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x6A3840", Offset = "0x6A2840", VA = "0x1806A3840")]
		set
		{
		}
	}

	// Token: 0x17000086 RID: 134
	// (get) Token: 0x060002F1 RID: 753 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x17000086")]
	public CSteamID OwnerSteamId
	{
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x2B63720", Offset = "0x2B62720", VA = "0x182B63720")]
		get
		{
			return default(CSteamID);
		}
	}

	// Token: 0x060002F2 RID: 754 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F2")]
	[Address(RVA = "0x2B636C0", Offset = "0x2B626C0", VA = "0x182B636C0")]
	public CoopLobbyInfo(ulong steamid)
	{
	}

	// Token: 0x060002F3 RID: 755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F3")]
	[Address(RVA = "0x2B636F0", Offset = "0x2B626F0", VA = "0x182B636F0")]
	public CoopLobbyInfo(CSteamID lobbyId)
	{
	}

	// Token: 0x060002F4 RID: 756 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F4")]
	[Address(RVA = "0x2B63550", Offset = "0x2B62550", VA = "0x182B63550")]
	public void RequestData()
	{
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x2B63560", Offset = "0x2B62560", VA = "0x182B63560")]
	public void UpdateData()
	{
	}

	// Token: 0x040002B4 RID: 692
	[Token(Token = "0x40002B4")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	// Token: 0x040002B5 RID: 693
	[Token(Token = "0x40002B5")]
	[FieldOffset(Offset = "0x18")]
	public string Guid;

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x20")]
	public string PrefabDbVersion;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x28")]
	public int CurrentMembers;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x2C")]
	public bool Joinable;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x2D")]
	public bool Destroyed;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x30")]
	public int MemberLimit;

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x34")]
	public bool IsOwner;

	// Token: 0x040002BC RID: 700
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x38")]
	private CSteamID _serverId;

	// Token: 0x040002BD RID: 701
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x40")]
	private CSteamID _ownerId;
}
