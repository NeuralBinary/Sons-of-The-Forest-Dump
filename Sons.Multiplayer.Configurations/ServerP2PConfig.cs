using System;
using Endnight.Utilities.Configurations;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Steamworks;

namespace Sons.Multiplayer
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class ServerP2PConfig : JsonConfigurationFile<ServerP2PConfig>
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000002")]
		public override string RootName
		{
			[Token(Token = "0x6000006")]
			[Address(RVA = "0x30CF700", Offset = "0x30CDD00", VA = "0x1830CF700", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x30CF730", Offset = "0x30CDD30", VA = "0x1830CF730")]
		public ServerP2PConfig()
		{
		}

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		[JsonIgnore]
		public readonly ushort GamePort;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x12")]
		[JsonIgnore]
		public readonly ushort QueryPort;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0x18")]
		[JsonIgnore]
		public readonly string ServerVersion;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0x20")]
		[JsonIgnore]
		public readonly string ProductName;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0x28")]
		[JsonIgnore]
		public readonly string ProductDescription;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x30")]
		[JsonIgnore]
		public readonly EServerMode ServerMode;
	}
}
