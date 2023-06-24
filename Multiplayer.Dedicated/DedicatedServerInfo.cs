using System;
using Il2CppDummyDll;
using Steamworks;
using UdpKit;
using UnityEngine;

namespace Sons.Multiplayer.Dedicated
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class DedicatedServerInfo : IEquatable<DedicatedServerInfo>, IServerInfo
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000225E File Offset: 0x0000045E
		[Token(Token = "0x17000006")]
		public string Ip
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x17000007")]
		public ushort Port
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0xF46FD0", Offset = "0xF455D0", VA = "0x180F46FD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000057 RID: 87 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x17000008")]
		public int IndexInSteamServerListRequest
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0000225E File Offset: 0x0000045E
		[Token(Token = "0x17000009")]
		public string Guid
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000059 RID: 89 RVA: 0x0000225E File Offset: 0x0000045E
		[Token(Token = "0x1700000A")]
		public string Name
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600005A RID: 90 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x1700000B")]
		public CSteamID ServerId
		{
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "7")]
			get
			{
				return default(CSteamID);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600005B RID: 91 RVA: 0x0000225E File Offset: 0x0000045E
		[Token(Token = "0x1700000C")]
		public string GameMode
		{
			[Token(Token = "0x600005B")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000022F4 File Offset: 0x000004F4
		[Token(Token = "0x1700000D")]
		public bool VersionMatch
		{
			[Token(Token = "0x600005C")]
			[Address(RVA = "0x9D9870", Offset = "0x9D7E70", VA = "0x1809D9870", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005D RID: 93 RVA: 0x0000230C File Offset: 0x0000050C
		[Token(Token = "0x1700000E")]
		public int CurrentMembers
		{
			[Token(Token = "0x600005D")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0", Slot = "10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00002324 File Offset: 0x00000524
		[Token(Token = "0x1700000F")]
		public int MemberLimit
		{
			[Token(Token = "0x600005E")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005F RID: 95 RVA: 0x0000233C File Offset: 0x0000053C
		[Token(Token = "0x17000010")]
		public bool IsValid
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000060 RID: 96 RVA: 0x00002354 File Offset: 0x00000554
		[Token(Token = "0x17000011")]
		public int Ping
		{
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x17000012")]
		public bool IsPasswordProtected
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x213CBA0", Offset = "0x213B1A0", VA = "0x18213CBA0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x17000013")]
		public int WeakPasswordHash
		{
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x245D8C0", Offset = "0x245BEC0", VA = "0x18245D8C0", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000063 RID: 99 RVA: 0x0000239C File Offset: 0x0000059C
		[Token(Token = "0x17000014")]
		public UdpEndPoint Ep
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x245D8D0", Offset = "0x245BED0", VA = "0x18245D8D0")]
			get
			{
				return default(UdpEndPoint);
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x245D8E0", Offset = "0x245BEE0", VA = "0x18245D8E0")]
		public DedicatedServerInfo(gameserveritem_t details, int indexInSteamServerListRequest)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x245D9B0", Offset = "0x245BFB0", VA = "0x18245D9B0")]
		public void UpdateDetails(gameserveritem_t details)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000023B4 File Offset: 0x000005B4
		[Token(Token = "0x6000066")]
		[Address(RVA = "0x245DCF0", Offset = "0x245C2F0", VA = "0x18245DCF0", Slot = "4")]
		public bool Equals(DedicatedServerInfo other)
		{
			return default(bool);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000023CC File Offset: 0x000005CC
		[Token(Token = "0x6000067")]
		[Address(RVA = "0x245DD80", Offset = "0x245C380", VA = "0x18245DD80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000023E4 File Offset: 0x000005E4
		[Token(Token = "0x6000068")]
		[Address(RVA = "0x245DEC0", Offset = "0x245C4C0", VA = "0x18245DEC0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000225E File Offset: 0x0000045E
		[Token(Token = "0x6000069")]
		[Address(RVA = "0x245E090", Offset = "0x245C690", VA = "0x18245E090")]
		public static string GetIpString(servernetadr_t addr)
		{
			return null;
		}

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x10")]
		[Header("Debug")]
		private readonly string _ip;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		private readonly ushort _port;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x1A")]
		private readonly UdpEndPoint _ep;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x24")]
		private readonly int _indexInSteamServerListRequest;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x28")]
		private string _name;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x30")]
		private int _ping;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x34")]
		private int _playersCount;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0x38")]
		private int _maxPlayersCount;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0x3C")]
		private uint _lastTimePlayed;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0x40")]
		private CSteamID _serverId;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0x48")]
		private bool _isValid;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x49")]
		private bool _versionMatch;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x50")]
		private string _gameGuid;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x58")]
		private string _gameMode;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x60")]
		private bool _isPasswordProtected;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x64")]
		private int _weakPasswordHash;
	}
}
