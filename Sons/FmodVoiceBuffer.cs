using System;
using System.Runtime.CompilerServices;
using FMOD;
using Il2CppDummyDll;

// Token: 0x020000F3 RID: 243
[Token(Token = "0x20000F3")]
public class FmodVoiceBuffer : IDisposable
{
	// Token: 0x170000F2 RID: 242
	// (get) Token: 0x06000763 RID: 1891 RVA: 0x000041B8 File Offset: 0x000023B8
	// (set) Token: 0x06000764 RID: 1892 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F2")]
	public Sound Sound
	{
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		[CompilerGenerated]
		get
		{
			return default(Sound);
		}
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x16755D0", Offset = "0x1673BD0", VA = "0x1816755D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x06000765 RID: 1893 RVA: 0x000041D0 File Offset: 0x000023D0
	// (set) Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F3")]
	public Channel Channel
	{
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		[CompilerGenerated]
		get
		{
			return default(Channel);
		}
		[Token(Token = "0x6000766")]
		[Address(RVA = "0xA7FE00", Offset = "0xA7E400", VA = "0x180A7FE00")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x06000767 RID: 1895 RVA: 0x000041E8 File Offset: 0x000023E8
	// (set) Token: 0x06000768 RID: 1896 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F4")]
	public uint SamplesPlayed
	{
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000F5 RID: 245
	// (get) Token: 0x06000769 RID: 1897 RVA: 0x00004200 File Offset: 0x00002400
	// (set) Token: 0x0600076A RID: 1898 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F5")]
	public uint SamplesReceived
	{
		[Token(Token = "0x6000769")]
		[Address(RVA = "0x674020", Offset = "0x672620", VA = "0x180674020")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
		[Token(Token = "0x600076A")]
		[Address(RVA = "0x674030", Offset = "0x672630", VA = "0x180674030")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x0600076B RID: 1899 RVA: 0x00004218 File Offset: 0x00002418
	// (set) Token: 0x0600076C RID: 1900 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F6")]
	public uint TimeSamplesPrev
	{
		[Token(Token = "0x600076B")]
		[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
		[CompilerGenerated]
		get
		{
			return 0U;
		}
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x65D100", Offset = "0x65B700", VA = "0x18065D100")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000F7 RID: 247
	// (get) Token: 0x0600076D RID: 1901 RVA: 0x00004230 File Offset: 0x00002430
	// (set) Token: 0x0600076E RID: 1902 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F7")]
	public float PausedTime
	{
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x620AA0", Offset = "0x61F0A0", VA = "0x180620AA0")]
		[CompilerGenerated]
		get
		{
			return 0f;
		}
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x620AB0", Offset = "0x61F0B0", VA = "0x180620AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x170000F8 RID: 248
	// (get) Token: 0x0600076F RID: 1903 RVA: 0x00004248 File Offset: 0x00002448
	// (set) Token: 0x06000770 RID: 1904 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x170000F8")]
	public bool Locked
	{
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	// Token: 0x06000771 RID: 1905 RVA: 0x00004260 File Offset: 0x00002460
	[Token(Token = "0x6000771")]
	[Address(RVA = "0x3676170", Offset = "0x3674770", VA = "0x183676170")]
	public uint GetAudioTimeSamples()
	{
		return 0U;
	}

	// Token: 0x06000772 RID: 1906 RVA: 0x00004278 File Offset: 0x00002478
	[Token(Token = "0x6000772")]
	[Address(RVA = "0x3676210", Offset = "0x3674810", VA = "0x183676210")]
	public bool ChannelReady()
	{
		return default(bool);
	}

	// Token: 0x06000773 RID: 1907 RVA: 0x00004290 File Offset: 0x00002490
	[Token(Token = "0x6000773")]
	[Address(RVA = "0x3676240", Offset = "0x3674840", VA = "0x183676240")]
	public bool IsPlaying()
	{
		return default(bool);
	}

	// Token: 0x06000774 RID: 1908 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000774")]
	[Address(RVA = "0x3676360", Offset = "0x3674960", VA = "0x183676360", Slot = "4")]
	public void Dispose()
	{
	}

	// Token: 0x06000775 RID: 1909 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000775")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	public FmodVoiceBuffer()
	{
	}

	// Token: 0x040005F3 RID: 1523
	[Token(Token = "0x40005F3")]
	[FieldOffset(Offset = "0x10")]
	private bool _disposed;
}
