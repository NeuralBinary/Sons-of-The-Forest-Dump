using System;
using System.Collections.Generic;
using Endnight.Utilities.Configurations;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Steamworks;

namespace Sons.Multiplayer
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class ServerDedicatedConfig : JsonConfigurationFile<ServerDedicatedConfig>
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000001")]
		public override string RootName
		{
			[Token(Token = "0x6000003")]
			[Address(RVA = "0x30CEE90", Offset = "0x30CD490", VA = "0x1830CEE90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000206C File Offset: 0x0000026C
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x30CEEC0", Offset = "0x30CD4C0", VA = "0x1830CEEC0")]
		public static bool Validate(out string error)
		{
			return default(bool);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x30CF2F0", Offset = "0x30CD8F0", VA = "0x1830CF2F0")]
		public ServerDedicatedConfig()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x10")]
		public string IpAddress;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		public ushort GamePort;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x1A")]
		public ushort QueryPort;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x1C")]
		public ushort BlobSyncPort;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x20")]
		public string ServerName;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x28")]
		public int MaxPlayers;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x30")]
		public string Password;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x38")]
		public bool LanOnly;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x3C")]
		public uint SaveSlot;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x40")]
		public ServerDedicatedConfig.ESaveMode SaveMode;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x44")]
		public ServerDedicatedConfig.EGameMode GameMode;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x48")]
		public int SaveInterval;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x4C")]
		public float IdleDayCycleSpeed;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x50")]
		public uint IdleTargetFramerate;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x54")]
		public uint ActiveTargetFramerate;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x58")]
		[JsonIgnore]
		public readonly bool VerboseLogging;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x59")]
		public bool LogFilesEnabled;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x5A")]
		public bool TimestampLogFilenames;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x5B")]
		public bool TimestampLogEntries;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x60")]
		public Dictionary<string, object> GameSettings;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, object> CustomGameModeSettings;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x70")]
		[JsonIgnore]
		public readonly bool AutoStart;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x78")]
		[JsonIgnore]
		public readonly string ServerVersion;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x80")]
		[JsonIgnore]
		public readonly string ProductName;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x88")]
		[JsonIgnore]
		public readonly string ProductDescription;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x90")]
		[JsonIgnore]
		public readonly EServerMode ServerMode;

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum ESaveMode
		{
			// Token: 0x04000021 RID: 33
			[Token(Token = "0x4000021")]
			New,
			// Token: 0x04000022 RID: 34
			[Token(Token = "0x4000022")]
			Continue
		}

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		[JsonConverter(typeof(StringEnumConverter))]
		public enum EGameMode
		{
			// Token: 0x04000024 RID: 36
			[Token(Token = "0x4000024")]
			Normal,
			// Token: 0x04000025 RID: 37
			[Token(Token = "0x4000025")]
			Hard,
			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			HardSurvival,
			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			Peaceful,
			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			Custom = 5
		}
	}
}
