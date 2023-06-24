using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using Steamworks;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[Serializable]
	public class CoopLobby : IServerInfo
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000015")]
		public string Guid
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000016")]
		public string PrefabDbVersion
		{
			[Token(Token = "0x600007B")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00002370 File Offset: 0x00000570
		[Token(Token = "0x17000017")]
		public bool VersionMatch
		{
			[Token(Token = "0x600007C")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00002388 File Offset: 0x00000588
		[Token(Token = "0x17000018")]
		public int CurrentMembers
		{
			[Token(Token = "0x600007D")]
			[Address(RVA = "0x6FF7C0", Offset = "0x6FDDC0", VA = "0x1806FF7C0", Slot = "9")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600007E RID: 126 RVA: 0x000023A0 File Offset: 0x000005A0
		[Token(Token = "0x17000019")]
		public bool Destroyed
		{
			[Token(Token = "0x600007E")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007F RID: 127 RVA: 0x000023B8 File Offset: 0x000005B8
		[Token(Token = "0x1700001A")]
		public int MemberLimit
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000080 RID: 128 RVA: 0x000023D0 File Offset: 0x000005D0
		[Token(Token = "0x1700001B")]
		public bool IsOwner
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700001C")]
		public string GameMode
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000023E8 File Offset: 0x000005E8
		[Token(Token = "0x1700001D")]
		public bool IsValid
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x30D5BD0", Offset = "0x30D41D0", VA = "0x1830D5BD0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00002400 File Offset: 0x00000600
		[Token(Token = "0x1700001E")]
		public int Ping
		{
			[Token(Token = "0x6000083")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "12")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000084 RID: 132 RVA: 0x00002418 File Offset: 0x00000618
		[Token(Token = "0x1700001F")]
		public bool IsPasswordProtected
		{
			[Token(Token = "0x6000084")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00002430 File Offset: 0x00000630
		[Token(Token = "0x17000020")]
		public int WeakPasswordHash
		{
			[Token(Token = "0x6000085")]
			[Address(RVA = "0x634E60", Offset = "0x633460", VA = "0x180634E60", Slot = "14")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x30D5C00", Offset = "0x30D4200", VA = "0x1830D5C00")]
		public IEnumerable<string> GetMembersData(string key)
		{
			return null;
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000021")]
		internal IEnumerable<CSteamID> AllMembers
		{
			[Token(Token = "0x6000087")]
			[Address(RVA = "0x30D5D10", Offset = "0x30D4310", VA = "0x1830D5D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x30D5DB0", Offset = "0x30D43B0", VA = "0x1830D5DB0")]
		internal void Destroy()
		{
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000089")]
		[Address(RVA = "0x30D5E50", Offset = "0x30D4450", VA = "0x1830D5E50")]
		internal void SetDestroyed(bool value)
		{
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008A")]
		[Address(RVA = "0x30D5EF0", Offset = "0x30D44F0", VA = "0x1830D5EF0")]
		internal void SetGameMode(string value)
		{
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008B")]
		[Address(RVA = "0x30D5FB0", Offset = "0x30D45B0", VA = "0x1830D5FB0")]
		internal void SetName(string name)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x30D6070", Offset = "0x30D4670", VA = "0x1830D6070")]
		internal void SetGuid(string guid)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x30D6170", Offset = "0x30D4770", VA = "0x1830D6170")]
		public void SetCurrentMembers(int value)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x30D6270", Offset = "0x30D4870", VA = "0x1830D6270")]
		internal void SetPrefabDbVersion(string value)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x30D63C0", Offset = "0x30D49C0", VA = "0x1830D63C0")]
		internal void SetServer(CSteamID server)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x30D64A0", Offset = "0x30D4AA0", VA = "0x1830D64A0")]
		public void SetMemberLimit(int limit)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x30D6580", Offset = "0x30D4B80", VA = "0x1830D6580")]
		public void SetJoinable(bool joinable)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00002448 File Offset: 0x00000648
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public CSteamID LobbyId
		{
			[Token(Token = "0x6000092")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return default(CSteamID);
			}
			[Token(Token = "0x6000093")]
			[Address(RVA = "0x30D65A0", Offset = "0x30D4BA0", VA = "0x1830D65A0")]
			private set
			{
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002460 File Offset: 0x00000660
		// (set) Token: 0x06000095 RID: 149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public CSteamID ServerId
		{
			[Token(Token = "0x6000094")]
			[Address(RVA = "0x30D6610", Offset = "0x30D4C10", VA = "0x1830D6610", Slot = "6")]
			get
			{
				return default(CSteamID);
			}
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x30D6630", Offset = "0x30D4C30", VA = "0x1830D6630")]
			set
			{
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x30D66A0", Offset = "0x30D4CA0", VA = "0x1830D66A0")]
		private CSteamID GetLobbyServerId()
		{
			return default(CSteamID);
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x17000024")]
		public CSteamID OwnerSteamId
		{
			[Token(Token = "0x6000097")]
			[Address(RVA = "0x30D6890", Offset = "0x30D4E90", VA = "0x1830D6890")]
			get
			{
				return default(CSteamID);
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000025")]
		public string Name
		{
			[Token(Token = "0x6000098")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x30D68C0", Offset = "0x30D4EC0", VA = "0x1830D68C0")]
		public CoopLobby(CSteamID lobbyId, [Optional] string name, int memberLimit = 0, bool isOwner = false, bool joinable = false, [Optional] string guid)
		{
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x30D6A10", Offset = "0x30D5010", VA = "0x1830D6A10")]
		public CoopLobby(ulong lobbyId, [Optional] string name, int memberLimit = 0, bool isOwner = false, bool joinable = false, [Optional] string guid)
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000024A8 File Offset: 0x000006A8
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x30D6A30", Offset = "0x30D5030", VA = "0x1830D6A30")]
		public bool RequestData()
		{
			return default(bool);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x30D6A40", Offset = "0x30D5040", VA = "0x1830D6A40")]
		public Task<bool> RequestDataAsync(Action onSuccess)
		{
			return null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x30D6C20", Offset = "0x30D5220", VA = "0x1830D6C20")]
		public void UpdateData()
		{
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x30D6F60", Offset = "0x30D5560", VA = "0x1830D6F60")]
		public void ClearGuid()
		{
		}

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		public const string LobbyPchKeyName = "name";

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		public const string LobbyPchKeyDestroyed = "destroyed";

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		public const string LobbyPchKeyPrefabDbVersion = "prefabdbversion";

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		public const string LobbyPchKeyGameMode = "gamemode";

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private CSteamID _serverId;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private CSteamID _ownerId;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private CSteamID _lobbyId;

		// Token: 0x04000049 RID: 73
		[Token(Token = "0x4000049")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _name;

		// Token: 0x0400004A RID: 74
		[Token(Token = "0x400004A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _isOwner;

		// Token: 0x0400004B RID: 75
		[Token(Token = "0x400004B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		[SerializeField]
		private int _memberLimit;

		// Token: 0x0400004C RID: 76
		[Token(Token = "0x400004C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _destroyed;

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _guid;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _prefabDbVersion;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _versionMatch;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[SerializeField]
		private int _currentMembers;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _joinable;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _gameMode;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _lobbyIdString;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _serverIdString;
	}
}
