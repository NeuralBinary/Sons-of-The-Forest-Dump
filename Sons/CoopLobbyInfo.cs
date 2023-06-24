using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Steamworks;

// Token: 0x02000064 RID: 100
[Token(Token = "0x2000064")]
[Serializable]
public class CoopLobbyInfo
{
	// Token: 0x17000086 RID: 134
	// (get) Token: 0x060002F0 RID: 752 RVA: 0x00002F40 File Offset: 0x00001140
	// (set) Token: 0x060002F1 RID: 753 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000086")]
	public CSteamID LobbyId
	{
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
		[CompilerGenerated]
		get
		{
			return default(CSteamID);
		}
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x25A71F0", Offset = "0x25A57F0", VA = "0x1825A71F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060002F2 RID: 754 RVA: 0x00002F58 File Offset: 0x00001158
	// (set) Token: 0x060002F3 RID: 755 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x17000087")]
	public CSteamID ServerId
	{
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x31BB390", Offset = "0x31B9990", VA = "0x1831BB390")]
		get
		{
			return default(CSteamID);
		}
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x75C1B0", Offset = "0x75A7B0", VA = "0x18075C1B0")]
		set
		{
		}
	}

	// Token: 0x17000088 RID: 136
	// (get) Token: 0x060002F4 RID: 756 RVA: 0x00002F70 File Offset: 0x00001170
	[Token(Token = "0x17000088")]
	public CSteamID OwnerSteamId
	{
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x31BB4B0", Offset = "0x31B9AB0", VA = "0x1831BB4B0")]
		get
		{
			return default(CSteamID);
		}
	}

	// Token: 0x060002F5 RID: 757 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F5")]
	[Address(RVA = "0x25A71F0", Offset = "0x25A57F0", VA = "0x1825A71F0")]
	public CoopLobbyInfo(ulong steamid)
	{
	}

	// Token: 0x060002F6 RID: 758 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F6")]
	[Address(RVA = "0x25A71F0", Offset = "0x25A57F0", VA = "0x1825A71F0")]
	public CoopLobbyInfo(CSteamID lobbyId)
	{
	}

	// Token: 0x060002F7 RID: 759 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F7")]
	[Address(RVA = "0x31BB4E0", Offset = "0x31B9AE0", VA = "0x1831BB4E0")]
	public void RequestData()
	{
	}

	// Token: 0x060002F8 RID: 760 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60002F8")]
	[Address(RVA = "0x31BB4F0", Offset = "0x31B9AF0", VA = "0x1831BB4F0")]
	public void UpdateData()
	{
	}

	// Token: 0x040002B6 RID: 694
	[Token(Token = "0x40002B6")]
	[FieldOffset(Offset = "0x10")]
	public string Name;

	// Token: 0x040002B7 RID: 695
	[Token(Token = "0x40002B7")]
	[FieldOffset(Offset = "0x18")]
	public string Guid;

	// Token: 0x040002B8 RID: 696
	[Token(Token = "0x40002B8")]
	[FieldOffset(Offset = "0x20")]
	public string PrefabDbVersion;

	// Token: 0x040002B9 RID: 697
	[Token(Token = "0x40002B9")]
	[FieldOffset(Offset = "0x28")]
	public int CurrentMembers;

	// Token: 0x040002BA RID: 698
	[Token(Token = "0x40002BA")]
	[FieldOffset(Offset = "0x2C")]
	public bool Joinable;

	// Token: 0x040002BB RID: 699
	[Token(Token = "0x40002BB")]
	[FieldOffset(Offset = "0x2D")]
	public bool Destroyed;

	// Token: 0x040002BC RID: 700
	[Token(Token = "0x40002BC")]
	[FieldOffset(Offset = "0x30")]
	public int MemberLimit;

	// Token: 0x040002BD RID: 701
	[Token(Token = "0x40002BD")]
	[FieldOffset(Offset = "0x34")]
	public bool IsOwner;

	// Token: 0x040002BE RID: 702
	[Token(Token = "0x40002BE")]
	[FieldOffset(Offset = "0x38")]
	private CSteamID _serverId;

	// Token: 0x040002BF RID: 703
	[Token(Token = "0x40002BF")]
	[FieldOffset(Offset = "0x40")]
	private CSteamID _ownerId;
}
