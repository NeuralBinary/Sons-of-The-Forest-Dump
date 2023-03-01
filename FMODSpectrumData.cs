using System;
using System.Collections.Generic;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200001B RID: 27
[Token(Token = "0x200001B")]
public class FMODSpectrumData : MonoBehaviour
{
	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000078 RID: 120 RVA: 0x000021A8 File Offset: 0x000003A8
	[Token(Token = "0x17000008")]
	public int SampleCount
	{
		[Token(Token = "0x6000078")]
		[Address(RVA = "0x589ED0", Offset = "0x588ED0", VA = "0x180589ED0")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x06000079 RID: 121 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000079")]
	[Address(RVA = "0x29A2390", Offset = "0x29A1390", VA = "0x1829A2390")]
	private void Start()
	{
	}

	// Token: 0x0600007A RID: 122 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007A")]
	[Address(RVA = "0x29A23E0", Offset = "0x29A13E0", VA = "0x1829A23E0")]
	private void Update()
	{
	}

	// Token: 0x0600007B RID: 123 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007B")]
	[Address(RVA = "0x29A22F0", Offset = "0x29A12F0", VA = "0x1829A22F0")]
	private void OnDestroy()
	{
	}

	// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600007C")]
	[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
	public IEnumerable<float> GetSamples()
	{
		return null;
	}

	// Token: 0x0600007D RID: 125 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x600007D")]
	[Address(RVA = "0x29A2210", Offset = "0x29A1210", VA = "0x1829A2210")]
	public float GetSample(int index)
	{
		return default(float);
	}

	// Token: 0x0600007E RID: 126 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007E")]
	[Address(RVA = "0x29A20E0", Offset = "0x29A10E0", VA = "0x1829A20E0")]
	public void Play()
	{
	}

	// Token: 0x0600007F RID: 127 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600007F")]
	[Address(RVA = "0x29A2380", Offset = "0x29A1380", VA = "0x1829A2380")]
	public void SetEventInstance(EventInstance eventInstance)
	{
	}

	// Token: 0x06000080 RID: 128 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000080")]
	[Address(RVA = "0x29A20E0", Offset = "0x29A10E0", VA = "0x1829A20E0")]
	private void CreateInstance()
	{
	}

	// Token: 0x06000081 RID: 129 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000081")]
	[Address(RVA = "0x29A2000", Offset = "0x29A1000", VA = "0x1829A2000")]
	private void CreateDSPFFT()
	{
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x29A1D50", Offset = "0x29A0D50", VA = "0x1829A1D50")]
	private void CollectSpectrumData()
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x29A2460", Offset = "0x29A1460", VA = "0x1829A2460")]
	public FMODSpectrumData()
	{
	}

	// Token: 0x04000098 RID: 152
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[EventRef]
	private string _eventPath;

	// Token: 0x04000099 RID: 153
	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _windowSize;

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private DSP_FFT_WINDOW _windowShape;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x30")]
	private ChannelGroup _channelGroup;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x38")]
	private DSP _dspfft;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x40")]
	private EventInstance _eventInstance;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x48")]
	private DSP_PARAMETER_FFT _fftParam;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x58")]
	private float[] _samples;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x60")]
	private float[][] _spectrumData;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x68")]
	private bool _shouldCleanupEventInstance;
}
