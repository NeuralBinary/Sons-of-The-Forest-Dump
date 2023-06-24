using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sons.Save
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[Serializable]
	public class GameStateData
	{
		// Token: 0x06000041 RID: 65 RVA: 0x000021A4 File Offset: 0x000003A4
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x2FED730", Offset = "0x2FEBD30", VA = "0x182FED730")]
		public DateTime GetSaveTime()
		{
			return default(DateTime);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x2FED7D0", Offset = "0x2FEBDD0", VA = "0x182FED7D0")]
		public bool MatchesGameId(string activeGuid)
		{
			return default(bool);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x2FED8A0", Offset = "0x2FEBEA0", VA = "0x182FED8A0")]
		public GameStateData()
		{
		}

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x10")]
		public string Version;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x18")]
		public string GameName;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x20")]
		public string SaveTime;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x28")]
		public string GameType;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x30")]
		public string GameId;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x38")]
		public int GameDays;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x3C")]
		public int GameHours;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x40")]
		public int GameMinutes;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x44")]
		public int GameSeconds;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x48")]
		public int GameMilliseconds;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x4C")]
		public bool IsRobbyDead;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x4D")]
		public bool IsVirginiaDead;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x4E")]
		public bool CoreGameCompleted;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x4F")]
		public bool EscapedIsland;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x50")]
		public bool StayedOnIsland;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x58")]
		public string CrashSite;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x60")]
		public List<NamedIntData> NamedIntDatas;
	}
}
