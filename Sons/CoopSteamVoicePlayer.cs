using System;
using System.Collections.Generic;
using FMOD;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000E8 RID: 232
[Token(Token = "0x20000E8")]
internal class CoopSteamVoicePlayer : MonoBehaviour
{
	// Token: 0x060006FF RID: 1791 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006FF")]
	[Address(RVA = "0x352ACA0", Offset = "0x35292A0", VA = "0x18352ACA0")]
	public static float[] GetBuffer(int size)
	{
		return null;
	}

	// Token: 0x170000EA RID: 234
	// (get) Token: 0x06000700 RID: 1792 RVA: 0x00004038 File Offset: 0x00002238
	[Token(Token = "0x170000EA")]
	private static float GlobalVoiceVolume
	{
		[Token(Token = "0x6000700")]
		[Address(RVA = "0x352ADE0", Offset = "0x35293E0", VA = "0x18352ADE0")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000701 RID: 1793 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000701")]
	[Address(RVA = "0x2612650", Offset = "0x2610C50", VA = "0x182612650")]
	private void Start()
	{
	}

	// Token: 0x06000702 RID: 1794 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000702")]
	[Address(RVA = "0x2612650", Offset = "0x2610C50", VA = "0x182612650")]
	private void InitializeAudioSystem()
	{
	}

	// Token: 0x06000703 RID: 1795 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000703")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void Update()
	{
	}

	// Token: 0x06000704 RID: 1796 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000704")]
	[Address(RVA = "0x352AE70", Offset = "0x3529470", VA = "0x18352AE70")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000705 RID: 1797 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000705")]
	[Address(RVA = "0x352AE80", Offset = "0x3529480", VA = "0x18352AE80")]
	private void OnDisable()
	{
	}

	// Token: 0x06000706 RID: 1798 RVA: 0x00004050 File Offset: 0x00002250
	[Token(Token = "0x6000706")]
	[Address(RVA = "0x352B070", Offset = "0x3529670", VA = "0x18352B070")]
	private bool CreateFMODSound(ulong sourceId, out Sound soundResult)
	{
		return default(bool);
	}

	// Token: 0x06000707 RID: 1799 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000707")]
	[Address(RVA = "0x352B370", Offset = "0x3529970", VA = "0x18352B370")]
	private static void SetFMODSoundData(Sound sound, float[] samples, int offset)
	{
	}

	// Token: 0x06000708 RID: 1800 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000708")]
	[Address(RVA = "0x352B610", Offset = "0x3529C10", VA = "0x18352B610")]
	private static float[] AppendSamples(float[] samples, float[] postClearSamples)
	{
		return null;
	}

	// Token: 0x06000709 RID: 1801 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000709")]
	[Address(RVA = "0x352B6A0", Offset = "0x3529CA0", VA = "0x18352B6A0")]
	private static void UnlockSound(Sound sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
	{
	}

	// Token: 0x0600070A RID: 1802 RVA: 0x00004068 File Offset: 0x00002268
	[Token(Token = "0x600070A")]
	[Address(RVA = "0x352B790", Offset = "0x3529D90", VA = "0x18352B790")]
	private static bool LockSound(Sound sound, uint floatOffset, uint bytesLength, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
	{
		return default(bool);
	}

	// Token: 0x0600070B RID: 1803 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070B")]
	[Address(RVA = "0x352B900", Offset = "0x3529F00", VA = "0x18352B900")]
	private static void CopySamplesToPointers(float[] samples, uint len2, uint len1, IntPtr ptr1, IntPtr ptr2)
	{
	}

	// Token: 0x0600070C RID: 1804 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070C")]
	[Address(RVA = "0x352BA40", Offset = "0x352A040", VA = "0x18352BA40")]
	private static void CopySecondSampleRange(float[] samples, IntPtr ptr2, bool isWrappedAround, int len1SamplesLength, int len2SamplesLength)
	{
	}

	// Token: 0x0600070D RID: 1805 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070D")]
	[Address(RVA = "0x352BAD0", Offset = "0x352A0D0", VA = "0x18352BAD0")]
	private static void CopyFirstSampleRange(float[] samples, IntPtr ptr1, int len1SamplesLength)
	{
	}

	// Token: 0x0600070E RID: 1806 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070E")]
	[Address(RVA = "0x352BB50", Offset = "0x352A150", VA = "0x18352BB50")]
	private static void CopySamplesToPointers(float[] samples, uint len2, uint len1, IntPtr ptr1, IntPtr ptr2, float[] postClearSamples)
	{
	}

	// Token: 0x0600070F RID: 1807 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600070F")]
	[Address(RVA = "0x352BCD0", Offset = "0x352A2D0", VA = "0x18352BCD0")]
	public void DataReceived(byte[] data, int size, ulong sourceId)
	{
	}

	// Token: 0x06000710 RID: 1808 RVA: 0x00004080 File Offset: 0x00002280
	[Token(Token = "0x6000710")]
	[Address(RVA = "0x352C130", Offset = "0x352A730", VA = "0x18352C130")]
	private static float GetPlayerVolume(ulong sourceId)
	{
		return 0f;
	}

	// Token: 0x06000711 RID: 1809 RVA: 0x00004098 File Offset: 0x00002298
	[Token(Token = "0x6000711")]
	[Address(RVA = "0x352C3C0", Offset = "0x352A9C0", VA = "0x18352C3C0")]
	private static bool IsPlayerMuted(ulong sourceId)
	{
		return default(bool);
	}

	// Token: 0x06000712 RID: 1810 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000712")]
	[Address(RVA = "0x352C570", Offset = "0x352AB70", VA = "0x18352C570")]
	private void ApplySamples(float[] floatSamples, int sampleCount, ulong sourceId)
	{
	}

	// Token: 0x06000713 RID: 1811 RVA: 0x000040B0 File Offset: 0x000022B0
	[Token(Token = "0x6000713")]
	[Address(RVA = "0x352C970", Offset = "0x352AF70", VA = "0x18352C970")]
	private bool GetSourceSoundBuffer(ulong sourceId, out FmodVoiceBuffer result)
	{
		return default(bool);
	}

	// Token: 0x06000714 RID: 1812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000714")]
	[Address(RVA = "0x352CB70", Offset = "0x352B170", VA = "0x18352CB70")]
	private void Play(FmodVoiceBuffer voiceBuffer)
	{
	}

	// Token: 0x06000715 RID: 1813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000715")]
	[Address(RVA = "0x352CE90", Offset = "0x352B490", VA = "0x18352CE90")]
	private void UpdatePlayedAudioSamples()
	{
	}

	// Token: 0x06000716 RID: 1814 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000716")]
	[Address(RVA = "0x352D520", Offset = "0x352BB20", VA = "0x18352D520")]
	private static void UpdatePlayedAudioSamples(FmodVoiceBuffer voiceBuffer)
	{
	}

	// Token: 0x06000717 RID: 1815 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000717")]
	[Address(RVA = "0x352D620", Offset = "0x352BC20", VA = "0x18352D620")]
	private void UpdateFMODChannel3D()
	{
	}

	// Token: 0x06000718 RID: 1816 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000718")]
	[Address(RVA = "0x352D840", Offset = "0x352BE40", VA = "0x18352D840")]
	private void UpdateFMODChannel3D(FmodVoiceBuffer voiceBuffer)
	{
	}

	// Token: 0x06000719 RID: 1817 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000719")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void ProcessDebug()
	{
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071A")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void CheckWriteCache()
	{
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071B")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void SaveCachedData(float[] vcSample, long sampleTime)
	{
	}

	// Token: 0x0600071C RID: 1820 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071C")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void ProcessDebugCacheSource()
	{
	}

	// Token: 0x0600071D RID: 1821 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071D")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void CacheVoiceData(float[] vcSample)
	{
	}

	// Token: 0x0600071E RID: 1822 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600071E")]
	[Address(RVA = "0x352DCA0", Offset = "0x352C2A0", VA = "0x18352DCA0")]
	public CoopSteamVoicePlayer()
	{
	}

	// Token: 0x040005C6 RID: 1478
	[Token(Token = "0x40005C6")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, float[]> buffers;

	// Token: 0x040005C7 RID: 1479
	[Token(Token = "0x40005C7")]
	public const int ByteBufferSize = 65536;

	// Token: 0x040005C8 RID: 1480
	[Token(Token = "0x40005C8")]
	private const float GLOBAL_VOLUME = 1f;

	// Token: 0x040005C9 RID: 1481
	[Token(Token = "0x40005C9")]
	private const int FREQUENCY = 11025;

	// Token: 0x040005CA RID: 1482
	[Token(Token = "0x40005CA")]
	private const int CHANNEL_COUNT = 1;

	// Token: 0x040005CB RID: 1483
	[Token(Token = "0x40005CB")]
	private const int SAMPLE_BUFFER_SIZE = 220500;

	// Token: 0x040005CC RID: 1484
	[Token(Token = "0x40005CC")]
	private const int FLOAT_SIZE = 4;

	// Token: 0x040005CD RID: 1485
	[Token(Token = "0x40005CD")]
	[FieldOffset(Offset = "0x20")]
	private byte[] vc_decomp;

	// Token: 0x040005CE RID: 1486
	[Token(Token = "0x40005CE")]
	[FieldOffset(Offset = "0x28")]
	private short[] vc_pcm;

	// Token: 0x040005CF RID: 1487
	[Token(Token = "0x40005CF")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioSource _audioSource;

	// Token: 0x040005D0 RID: 1488
	[Token(Token = "0x40005D0")]
	[FieldOffset(Offset = "0x38")]
	private int _postClearSamplesLength;

	// Token: 0x040005D1 RID: 1489
	[Token(Token = "0x40005D1")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<ulong, FmodVoiceBuffer> _fmodSoundDictionary;

	// Token: 0x040005D2 RID: 1490
	[Token(Token = "0x40005D2")]
	[FieldOffset(Offset = "0x8")]
	private static float[] _postClearSamples;

	// Token: 0x040005D3 RID: 1491
	[Token(Token = "0x40005D3")]
	[FieldOffset(Offset = "0x48")]
	private bool _playerMuted;

	// Token: 0x040005D4 RID: 1492
	[Token(Token = "0x40005D4")]
	[FieldOffset(Offset = "0x10")]
	private static List<ulong> _mutedPlayers;
}
