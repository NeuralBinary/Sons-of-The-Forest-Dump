using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public static class SteamMusicRemote
	{
		// Token: 0x060002F2 RID: 754 RVA: 0x0000578C File Offset: 0x0000398C
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x938EC0", Offset = "0x9374C0", VA = "0x180938EC0")]
		public static bool RegisterSteamMusicRemote(string pchName)
		{
			return default(bool);
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000057A4 File Offset: 0x000039A4
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x9390B0", Offset = "0x9376B0", VA = "0x1809390B0")]
		public static bool DeregisterSteamMusicRemote()
		{
			return default(bool);
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000057BC File Offset: 0x000039BC
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x939170", Offset = "0x937770", VA = "0x180939170")]
		public static bool BIsCurrentMusicRemote()
		{
			return default(bool);
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000057D4 File Offset: 0x000039D4
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x939230", Offset = "0x937830", VA = "0x180939230")]
		public static bool BActivationSuccess(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000057EC File Offset: 0x000039EC
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x939300", Offset = "0x937900", VA = "0x180939300")]
		public static bool SetDisplayName(string pchDisplayName)
		{
			return default(bool);
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00005804 File Offset: 0x00003A04
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x9394F0", Offset = "0x937AF0", VA = "0x1809394F0")]
		public static bool SetPNGIcon_64x64(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0000581C File Offset: 0x00003A1C
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x9395D0", Offset = "0x937BD0", VA = "0x1809395D0")]
		public static bool EnablePlayPrevious(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00005834 File Offset: 0x00003A34
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x9396A0", Offset = "0x937CA0", VA = "0x1809396A0")]
		public static bool EnablePlayNext(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0000584C File Offset: 0x00003A4C
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x939770", Offset = "0x937D70", VA = "0x180939770")]
		public static bool EnableShuffled(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00005864 File Offset: 0x00003A64
		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x939840", Offset = "0x937E40", VA = "0x180939840")]
		public static bool EnableLooped(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0000587C File Offset: 0x00003A7C
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x939910", Offset = "0x937F10", VA = "0x180939910")]
		public static bool EnableQueue(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00005894 File Offset: 0x00003A94
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x9399E0", Offset = "0x937FE0", VA = "0x1809399E0")]
		public static bool EnablePlaylists(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x060002FE RID: 766 RVA: 0x000058AC File Offset: 0x00003AAC
		[Token(Token = "0x60002FE")]
		[Address(RVA = "0x939AB0", Offset = "0x9380B0", VA = "0x180939AB0")]
		public static bool UpdatePlaybackStatus(AudioPlayback_Status nStatus)
		{
			return default(bool);
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000058C4 File Offset: 0x00003AC4
		[Token(Token = "0x60002FF")]
		[Address(RVA = "0x939B70", Offset = "0x938170", VA = "0x180939B70")]
		public static bool UpdateShuffled(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000058DC File Offset: 0x00003ADC
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x939C40", Offset = "0x938240", VA = "0x180939C40")]
		public static bool UpdateLooped(bool bValue)
		{
			return default(bool);
		}

		// Token: 0x06000301 RID: 769 RVA: 0x000058F4 File Offset: 0x00003AF4
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x939D10", Offset = "0x938310", VA = "0x180939D10")]
		public static bool UpdateVolume(float flValue)
		{
			return default(bool);
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000590C File Offset: 0x00003B0C
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x939DE0", Offset = "0x9383E0", VA = "0x180939DE0")]
		public static bool CurrentEntryWillChange()
		{
			return default(bool);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00005924 File Offset: 0x00003B24
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x939EA0", Offset = "0x9384A0", VA = "0x180939EA0")]
		public static bool CurrentEntryIsAvailable(bool bAvailable)
		{
			return default(bool);
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000593C File Offset: 0x00003B3C
		[Token(Token = "0x6000304")]
		[Address(RVA = "0x939F70", Offset = "0x938570", VA = "0x180939F70")]
		public static bool UpdateCurrentEntryText(string pchText)
		{
			return default(bool);
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00005954 File Offset: 0x00003B54
		[Token(Token = "0x6000305")]
		[Address(RVA = "0x93A160", Offset = "0x938760", VA = "0x18093A160")]
		public static bool UpdateCurrentEntryElapsedSeconds(int nValue)
		{
			return default(bool);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000596C File Offset: 0x00003B6C
		[Token(Token = "0x6000306")]
		[Address(RVA = "0x93A220", Offset = "0x938820", VA = "0x18093A220")]
		public static bool UpdateCurrentEntryCoverArt(byte[] pvBuffer, uint cbBufferLength)
		{
			return default(bool);
		}

		// Token: 0x06000307 RID: 775 RVA: 0x00005984 File Offset: 0x00003B84
		[Token(Token = "0x6000307")]
		[Address(RVA = "0x93A300", Offset = "0x938900", VA = "0x18093A300")]
		public static bool CurrentEntryDidChange()
		{
			return default(bool);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000599C File Offset: 0x00003B9C
		[Token(Token = "0x6000308")]
		[Address(RVA = "0x93A3C0", Offset = "0x9389C0", VA = "0x18093A3C0")]
		public static bool QueueWillChange()
		{
			return default(bool);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x000059B4 File Offset: 0x00003BB4
		[Token(Token = "0x6000309")]
		[Address(RVA = "0x93A480", Offset = "0x938A80", VA = "0x18093A480")]
		public static bool ResetQueueEntries()
		{
			return default(bool);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x000059CC File Offset: 0x00003BCC
		[Token(Token = "0x600030A")]
		[Address(RVA = "0x93A540", Offset = "0x938B40", VA = "0x18093A540")]
		public static bool SetQueueEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		// Token: 0x0600030B RID: 779 RVA: 0x000059E4 File Offset: 0x00003BE4
		[Token(Token = "0x600030B")]
		[Address(RVA = "0x93A740", Offset = "0x938D40", VA = "0x18093A740")]
		public static bool SetCurrentQueueEntry(int nID)
		{
			return default(bool);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x000059FC File Offset: 0x00003BFC
		[Token(Token = "0x600030C")]
		[Address(RVA = "0x93A800", Offset = "0x938E00", VA = "0x18093A800")]
		public static bool QueueDidChange()
		{
			return default(bool);
		}

		// Token: 0x0600030D RID: 781 RVA: 0x00005A14 File Offset: 0x00003C14
		[Token(Token = "0x600030D")]
		[Address(RVA = "0x93A8C0", Offset = "0x938EC0", VA = "0x18093A8C0")]
		public static bool PlaylistWillChange()
		{
			return default(bool);
		}

		// Token: 0x0600030E RID: 782 RVA: 0x00005A2C File Offset: 0x00003C2C
		[Token(Token = "0x600030E")]
		[Address(RVA = "0x93A980", Offset = "0x938F80", VA = "0x18093A980")]
		public static bool ResetPlaylistEntries()
		{
			return default(bool);
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00005A44 File Offset: 0x00003C44
		[Token(Token = "0x600030F")]
		[Address(RVA = "0x93AA40", Offset = "0x939040", VA = "0x18093AA40")]
		public static bool SetPlaylistEntry(int nID, int nPosition, string pchEntryText)
		{
			return default(bool);
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00005A5C File Offset: 0x00003C5C
		[Token(Token = "0x6000310")]
		[Address(RVA = "0x93AC40", Offset = "0x939240", VA = "0x18093AC40")]
		public static bool SetCurrentPlaylistEntry(int nID)
		{
			return default(bool);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00005A74 File Offset: 0x00003C74
		[Token(Token = "0x6000311")]
		[Address(RVA = "0x93AD00", Offset = "0x939300", VA = "0x18093AD00")]
		public static bool PlaylistDidChange()
		{
			return default(bool);
		}
	}
}
