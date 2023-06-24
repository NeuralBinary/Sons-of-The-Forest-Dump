using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public static class SteamMusic
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x0000572C File Offset: 0x0000392C
		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x938860", Offset = "0x936E60", VA = "0x180938860")]
		public static bool BIsEnabled()
		{
			return default(bool);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00005744 File Offset: 0x00003944
		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x938920", Offset = "0x936F20", VA = "0x180938920")]
		public static bool BIsPlaying()
		{
			return default(bool);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000575C File Offset: 0x0000395C
		[Token(Token = "0x60002EB")]
		[Address(RVA = "0x9389E0", Offset = "0x936FE0", VA = "0x1809389E0")]
		public static AudioPlayback_Status GetPlaybackStatus()
		{
			return AudioPlayback_Status.AudioPlayback_Undefined;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EC")]
		[Address(RVA = "0x938A90", Offset = "0x937090", VA = "0x180938A90")]
		public static void Play()
		{
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002ED")]
		[Address(RVA = "0x938B40", Offset = "0x937140", VA = "0x180938B40")]
		public static void Pause()
		{
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x938BF0", Offset = "0x9371F0", VA = "0x180938BF0")]
		public static void PlayPrevious()
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x938CA0", Offset = "0x9372A0", VA = "0x180938CA0")]
		public static void PlayNext()
		{
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F0")]
		[Address(RVA = "0x938D50", Offset = "0x937350", VA = "0x180938D50")]
		public static void SetVolume(float flVolume)
		{
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00005774 File Offset: 0x00003974
		[Token(Token = "0x60002F1")]
		[Address(RVA = "0x938E10", Offset = "0x937410", VA = "0x180938E10")]
		public static float GetVolume()
		{
			return 0f;
		}
	}
}
