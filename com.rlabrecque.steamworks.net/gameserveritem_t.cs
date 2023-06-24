using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	[Serializable]
	[StructLayout(0)]
	public class gameserveritem_t
	{
		// Token: 0x06000987 RID: 2439 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000987")]
		[Address(RVA = "0x988C50", Offset = "0x987250", VA = "0x180988C50")]
		public string GetGameDir()
		{
			return null;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000988")]
		[Address(RVA = "0x988D50", Offset = "0x987350", VA = "0x180988D50")]
		public void SetGameDir(string dir)
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x6000989")]
		[Address(RVA = "0x988E20", Offset = "0x987420", VA = "0x180988E20")]
		public string GetMap()
		{
			return null;
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098A")]
		[Address(RVA = "0x988F20", Offset = "0x987520", VA = "0x180988F20")]
		public void SetMap(string map)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600098B")]
		[Address(RVA = "0x988FF0", Offset = "0x9875F0", VA = "0x180988FF0")]
		public string GetGameDescription()
		{
			return null;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098C")]
		[Address(RVA = "0x9890F0", Offset = "0x9876F0", VA = "0x1809890F0")]
		public void SetGameDescription(string desc)
		{
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600098D")]
		[Address(RVA = "0x9891C0", Offset = "0x9877C0", VA = "0x1809891C0")]
		public string GetServerName()
		{
			return null;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600098E")]
		[Address(RVA = "0x989300", Offset = "0x987900", VA = "0x180989300")]
		public void SetServerName(string name)
		{
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x600098F")]
		[Address(RVA = "0x9893D0", Offset = "0x9879D0", VA = "0x1809893D0")]
		public string GetGameTags()
		{
			return null;
		}

		// Token: 0x06000990 RID: 2448 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000990")]
		[Address(RVA = "0x9894D0", Offset = "0x987AD0", VA = "0x1809894D0")]
		public void SetGameTags(string tags)
		{
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000991")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public gameserveritem_t()
		{
		}

		// Token: 0x04000A4C RID: 2636
		[Token(Token = "0x4000A4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public servernetadr_t m_NetAdr;

		// Token: 0x04000A4D RID: 2637
		[Token(Token = "0x4000A4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public int m_nPing;

		// Token: 0x04000A4E RID: 2638
		[Token(Token = "0x4000A4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		public bool m_bHadSuccessfulResponse;

		// Token: 0x04000A4F RID: 2639
		[Token(Token = "0x4000A4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D")]
		public bool m_bDoNotRefresh;

		// Token: 0x04000A50 RID: 2640
		[Token(Token = "0x4000A50")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private byte[] m_szGameDir;

		// Token: 0x04000A51 RID: 2641
		[Token(Token = "0x4000A51")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private byte[] m_szMap;

		// Token: 0x04000A52 RID: 2642
		[Token(Token = "0x4000A52")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private byte[] m_szGameDescription;

		// Token: 0x04000A53 RID: 2643
		[Token(Token = "0x4000A53")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public uint m_nAppID;

		// Token: 0x04000A54 RID: 2644
		[Token(Token = "0x4000A54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
		public int m_nPlayers;

		// Token: 0x04000A55 RID: 2645
		[Token(Token = "0x4000A55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public int m_nMaxPlayers;

		// Token: 0x04000A56 RID: 2646
		[Token(Token = "0x4000A56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public int m_nBotPlayers;

		// Token: 0x04000A57 RID: 2647
		[Token(Token = "0x4000A57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool m_bPassword;

		// Token: 0x04000A58 RID: 2648
		[Token(Token = "0x4000A58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
		public bool m_bSecure;

		// Token: 0x04000A59 RID: 2649
		[Token(Token = "0x4000A59")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public uint m_ulTimeLastPlayed;

		// Token: 0x04000A5A RID: 2650
		[Token(Token = "0x4000A5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public int m_nServerVersion;

		// Token: 0x04000A5B RID: 2651
		[Token(Token = "0x4000A5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private byte[] m_szServerName;

		// Token: 0x04000A5C RID: 2652
		[Token(Token = "0x4000A5C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private byte[] m_szGameTags;

		// Token: 0x04000A5D RID: 2653
		[Token(Token = "0x4000A5D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public CSteamID m_steamID;
	}
}
