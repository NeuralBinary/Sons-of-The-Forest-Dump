using System;
using Endnight.Utilities.Timer;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000013 RID: 19
[Token(Token = "0x2000013")]
public class FmodEmitterBuffer : MonoBehaviour
{
	// Token: 0x0600006E RID: 110 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600006E")]
	[Address(RVA = "0x2FD8FC0", Offset = "0x2FD75C0", VA = "0x182FD8FC0")]
	private void OnValidate()
	{
	}

	// Token: 0x0600006F RID: 111 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x600006F")]
	[Address(RVA = "0x2FD90F0", Offset = "0x2FD76F0", VA = "0x182FD90F0")]
	private void Update()
	{
	}

	// Token: 0x06000070 RID: 112 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000070")]
	[Address(RVA = "0x2FD91C0", Offset = "0x2FD77C0", VA = "0x182FD91C0")]
	public void Play()
	{
	}

	// Token: 0x06000071 RID: 113 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000071")]
	[Address(RVA = "0x2FD93C0", Offset = "0x2FD79C0", VA = "0x182FD93C0")]
	private void PlayInternal()
	{
	}

	// Token: 0x06000072 RID: 114 RVA: 0x0000209A File Offset: 0x0000029A
	[Token(Token = "0x6000072")]
	[Address(RVA = "0x2FD94A0", Offset = "0x2FD7AA0", VA = "0x182FD94A0")]
	public FmodEmitterBuffer()
	{
	}

	// Token: 0x04000069 RID: 105
	[Token(Token = "0x4000069")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SonsFMODEventEmitter _target;

	// Token: 0x0400006A RID: 106
	[Token(Token = "0x400006A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _timer;

	// Token: 0x0400006B RID: 107
	[Token(Token = "0x400006B")]
	[FieldOffset(Offset = "0x30")]
	private RealtimeAutoTimer _audioEventTimer;
}
