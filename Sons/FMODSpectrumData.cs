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
	// (get) Token: 0x06000081 RID: 129 RVA: 0x000021C0 File Offset: 0x000003C0
	[Token(Token = "0x17000008")]
	public int SampleCount
	{
		[Token(Token = "0x6000081")]
		[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
		get
		{
			return 0;
		}
	}

	// Token: 0x06000082 RID: 130 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000082")]
	[Address(RVA = "0x2F6C0F0", Offset = "0x2F6A6F0", VA = "0x182F6C0F0")]
	private void Start()
	{
	}

	// Token: 0x06000083 RID: 131 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000083")]
	[Address(RVA = "0x2F6C180", Offset = "0x2F6A780", VA = "0x182F6C180")]
	private void Update()
	{
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000084")]
	[Address(RVA = "0x2F6C2C0", Offset = "0x2F6A8C0", VA = "0x182F6C2C0")]
	private void OnDestroy()
	{
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000085")]
	[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
	public IEnumerable<float> GetSamples()
	{
		return null;
	}

	// Token: 0x06000086 RID: 134 RVA: 0x000021D8 File Offset: 0x000003D8
	[Token(Token = "0x6000086")]
	[Address(RVA = "0x2F6C350", Offset = "0x2F6A950", VA = "0x182F6C350")]
	public float GetSample(int index)
	{
		return 0f;
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000087")]
	[Address(RVA = "0x2F6C3D0", Offset = "0x2F6A9D0", VA = "0x182F6C3D0")]
	public void Play()
	{
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000088")]
	[Address(RVA = "0x2F6C3E0", Offset = "0x2F6A9E0", VA = "0x182F6C3E0")]
	public void SetEventInstance(EventInstance eventInstance)
	{
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000089")]
	[Address(RVA = "0x2F6C3F0", Offset = "0x2F6A9F0", VA = "0x182F6C3F0")]
	private void CreateInstance()
	{
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008A")]
	[Address(RVA = "0x2F6C600", Offset = "0x2F6AC00", VA = "0x182F6C600")]
	private void CreateDSPFFT()
	{
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008B")]
	[Address(RVA = "0x2F6C740", Offset = "0x2F6AD40", VA = "0x182F6C740")]
	private void CollectSpectrumData()
	{
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600008C")]
	[Address(RVA = "0x2F6CB00", Offset = "0x2F6B100", VA = "0x182F6CB00")]
	public FMODSpectrumData()
	{
	}

	// Token: 0x0400009A RID: 154
	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x20")]
	[EventRef]
	[SerializeField]
	private string _eventPath;

	// Token: 0x0400009B RID: 155
	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private int _windowSize;

	// Token: 0x0400009C RID: 156
	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private DSP_FFT_WINDOW _windowShape;

	// Token: 0x0400009D RID: 157
	[Token(Token = "0x400009D")]
	[FieldOffset(Offset = "0x30")]
	private ChannelGroup _channelGroup;

	// Token: 0x0400009E RID: 158
	[Token(Token = "0x400009E")]
	[FieldOffset(Offset = "0x38")]
	private DSP _dspfft;

	// Token: 0x0400009F RID: 159
	[Token(Token = "0x400009F")]
	[FieldOffset(Offset = "0x40")]
	private EventInstance _eventInstance;

	// Token: 0x040000A0 RID: 160
	[Token(Token = "0x40000A0")]
	[FieldOffset(Offset = "0x48")]
	private DSP_PARAMETER_FFT _fftParam;

	// Token: 0x040000A1 RID: 161
	[Token(Token = "0x40000A1")]
	[FieldOffset(Offset = "0x58")]
	private float[] _samples;

	// Token: 0x040000A2 RID: 162
	[Token(Token = "0x40000A2")]
	[FieldOffset(Offset = "0x60")]
	private float[][] _spectrumData;

	// Token: 0x040000A3 RID: 163
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x68")]
	private bool _shouldCleanupEventInstance;
}
