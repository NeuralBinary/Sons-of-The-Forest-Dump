using System;
using System.Collections.Generic;
using FMOD;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020000EA RID: 234
[Token(Token = "0x20000EA")]
internal class CoopSteamVoicePlayer : MonoBehaviour
{
	// Token: 0x060006B4 RID: 1716 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006B4")]
	[Address(RVA = "0x2E80F40", Offset = "0x2E7FF40", VA = "0x182E80F40")]
	public static float[] GetBuffer(int size)
	{
		return null;
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B5")]
	[Address(RVA = "0x21F6FC0", Offset = "0x21F5FC0", VA = "0x1821F6FC0")]
	private void Start()
	{
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B6")]
	[Address(RVA = "0x21F6FC0", Offset = "0x21F5FC0", VA = "0x1821F6FC0")]
	private void InitializeAudioSystem()
	{
	}

	// Token: 0x060006B7 RID: 1719 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B7")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void Update()
	{
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B8")]
	[Address(RVA = "0x2E80F30", Offset = "0x2E7FF30", VA = "0x182E80F30")]
	private void FixedUpdate()
	{
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006B9")]
	[Address(RVA = "0x2E81340", Offset = "0x2E80340", VA = "0x182E81340")]
	private void OnDisable()
	{
	}

	// Token: 0x060006BA RID: 1722 RVA: 0x00003E58 File Offset: 0x00002058
	[Token(Token = "0x60006BA")]
	[Address(RVA = "0x2E808D0", Offset = "0x2E7F8D0", VA = "0x182E808D0")]
	private bool CreateFMODSound(ulong sourceId, out Sound soundResult)
	{
		return default(bool);
	}

	// Token: 0x060006BB RID: 1723 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BB")]
	[Address(RVA = "0x2E815E0", Offset = "0x2E805E0", VA = "0x182E815E0")]
	private static void SetFMODSoundData(Sound sound, float[] samples, int offset)
	{
	}

	// Token: 0x060006BC RID: 1724 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x2E800C0", Offset = "0x2E7F0C0", VA = "0x182E800C0")]
	private static float[] AppendSamples(float[] samples, float[] postClearSamples)
	{
		return null;
	}

	// Token: 0x060006BD RID: 1725 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x2E81830", Offset = "0x2E80830", VA = "0x182E81830")]
	private static void UnlockSound(Sound sound, IntPtr ptr1, IntPtr ptr2, uint len1, uint len2)
	{
	}

	// Token: 0x060006BE RID: 1726 RVA: 0x00003E70 File Offset: 0x00002070
	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x2E81220", Offset = "0x2E80220", VA = "0x182E81220")]
	private static bool LockSound(Sound sound, uint floatOffset, uint bytesLength, out IntPtr ptr1, out IntPtr ptr2, out uint len1, out uint len2)
	{
		return default(bool);
	}

	// Token: 0x060006BF RID: 1727 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x2E80570", Offset = "0x2E7F570", VA = "0x182E80570")]
	private static void CopySamplesToPointers(float[] samples, uint len2, uint len1, IntPtr ptr1, IntPtr ptr2)
	{
	}

	// Token: 0x060006C0 RID: 1728 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C0")]
	[Address(RVA = "0x2E80840", Offset = "0x2E7F840", VA = "0x182E80840")]
	private static void CopySecondSampleRange(float[] samples, IntPtr ptr2, bool isWrappedAround, int len1SamplesLength, int len2SamplesLength)
	{
	}

	// Token: 0x060006C1 RID: 1729 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C1")]
	[Address(RVA = "0x2E804F0", Offset = "0x2E7F4F0", VA = "0x182E804F0")]
	private static void CopyFirstSampleRange(float[] samples, IntPtr ptr1, int len1SamplesLength)
	{
	}

	// Token: 0x060006C2 RID: 1730 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x2E806B0", Offset = "0x2E7F6B0", VA = "0x182E806B0")]
	private static void CopySamplesToPointers(float[] samples, uint len2, uint len1, IntPtr ptr1, IntPtr ptr2, float[] postClearSamples)
	{
	}

	// Token: 0x060006C3 RID: 1731 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x2E80B90", Offset = "0x2E7FB90", VA = "0x182E80B90")]
	public void DataReceived(byte[] data, int size, ulong sourceId)
	{
	}

	// Token: 0x060006C4 RID: 1732 RVA: 0x00003E88 File Offset: 0x00002088
	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x2E81070", Offset = "0x2E80070", VA = "0x182E81070")]
	private static float GetPlayerVolume(ulong sourceId)
	{
		return default(float);
	}

	// Token: 0x060006C5 RID: 1733 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x2E80150", Offset = "0x2E7F150", VA = "0x182E80150")]
	private void ApplySamples(float[] floatSamples, int sampleCount, ulong sourceId)
	{
	}

	// Token: 0x060006C6 RID: 1734 RVA: 0x00003EA0 File Offset: 0x000020A0
	[Token(Token = "0x60006C6")]
	[Address(RVA = "0x2E810C0", Offset = "0x2E800C0", VA = "0x182E810C0")]
	private bool GetSourceSoundBuffer(ulong sourceId, out FmodVoiceBuffer result)
	{
		return default(bool);
	}

	// Token: 0x060006C7 RID: 1735 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C7")]
	[Address(RVA = "0x2E814A0", Offset = "0x2E804A0", VA = "0x182E814A0")]
	private void Play(FmodVoiceBuffer voiceBuffer)
	{
	}

	// Token: 0x060006C8 RID: 1736 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C8")]
	[Address(RVA = "0x2E81E10", Offset = "0x2E80E10", VA = "0x182E81E10")]
	private void UpdatePlayedAudioSamples()
	{
	}

	// Token: 0x060006C9 RID: 1737 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006C9")]
	[Address(RVA = "0x2E82360", Offset = "0x2E81360", VA = "0x182E82360")]
	private static void UpdatePlayedAudioSamples(FmodVoiceBuffer voiceBuffer)
	{
	}

	// Token: 0x060006CA RID: 1738 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CA")]
	[Address(RVA = "0x2E81AC0", Offset = "0x2E80AC0", VA = "0x182E81AC0")]
	private void UpdateFMODChannel3D()
	{
	}

	// Token: 0x060006CB RID: 1739 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CB")]
	[Address(RVA = "0x2E81920", Offset = "0x2E80920", VA = "0x182E81920")]
	private void UpdateFMODChannel3D(FmodVoiceBuffer voiceBuffer)
	{
	}

	// Token: 0x060006CC RID: 1740 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CC")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void ProcessDebug()
	{
	}

	// Token: 0x060006CD RID: 1741 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CD")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void CheckWriteCache()
	{
	}

	// Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CE")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void SaveCachedData(float[] vcSample, long sampleTime)
	{
	}

	// Token: 0x060006CF RID: 1743 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void ProcessDebugCacheSource()
	{
	}

	// Token: 0x060006D0 RID: 1744 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D0")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void CacheVoiceData(float[] vcSample)
	{
	}

	// Token: 0x060006D1 RID: 1745 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60006D1")]
	[Address(RVA = "0x2E82540", Offset = "0x2E81540", VA = "0x182E82540")]
	public CoopSteamVoicePlayer()
	{
	}

	// Token: 0x040005A9 RID: 1449
	[Token(Token = "0x40005A9")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, float[]> buffers;

	// Token: 0x040005AA RID: 1450
	[Token(Token = "0x40005AA")]
	public const int ByteBufferSize = 65536;

	// Token: 0x040005AB RID: 1451
	[Token(Token = "0x40005AB")]
	private const float GLOBAL_VOLUME = 1f;

	// Token: 0x040005AC RID: 1452
	[Token(Token = "0x40005AC")]
	private const int FREQUENCY = 11025;

	// Token: 0x040005AD RID: 1453
	[Token(Token = "0x40005AD")]
	private const int CHANNEL_COUNT = 1;

	// Token: 0x040005AE RID: 1454
	[Token(Token = "0x40005AE")]
	private const int SAMPLE_BUFFER_SIZE = 220500;

	// Token: 0x040005AF RID: 1455
	[Token(Token = "0x40005AF")]
	private const int FLOAT_SIZE = 4;

	// Token: 0x040005B0 RID: 1456
	[Token(Token = "0x40005B0")]
	[FieldOffset(Offset = "0x20")]
	private byte[] vc_decomp;

	// Token: 0x040005B1 RID: 1457
	[Token(Token = "0x40005B1")]
	[FieldOffset(Offset = "0x28")]
	private short[] vc_pcm;

	// Token: 0x040005B2 RID: 1458
	[Token(Token = "0x40005B2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AudioSource _audioSource;

	// Token: 0x040005B3 RID: 1459
	[Token(Token = "0x40005B3")]
	[FieldOffset(Offset = "0x38")]
	private int _postClearSamplesLength;

	// Token: 0x040005B4 RID: 1460
	[Token(Token = "0x40005B4")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<ulong, FmodVoiceBuffer> _fmodSoundDictionary;

	// Token: 0x040005B5 RID: 1461
	[Token(Token = "0x40005B5")]
	[FieldOffset(Offset = "0x8")]
	private static float[] _postClearSamples;
}
