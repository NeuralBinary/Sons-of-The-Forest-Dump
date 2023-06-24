using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
public class RippleGenerator : MonoBehaviour
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x9EE250", Offset = "0x9EC850", VA = "0x1809EE250")]
	private void Start()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x9EE560", Offset = "0x9ECB60", VA = "0x1809EE560")]
	private void Update()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x9EEB10", Offset = "0x9ED110", VA = "0x1809EEB10")]
	public RippleGenerator()
	{
	}

	// Token: 0x0400001C RID: 28
	[Token(Token = "0x400001C")]
	[FieldOffset(Offset = "0x20")]
	public bool _animate;

	// Token: 0x0400001D RID: 29
	[Token(Token = "0x400001D")]
	[FieldOffset(Offset = "0x24")]
	public float _warmUp;

	// Token: 0x0400001E RID: 30
	[Token(Token = "0x400001E")]
	[FieldOffset(Offset = "0x28")]
	public float _onTime;

	// Token: 0x0400001F RID: 31
	[Token(Token = "0x400001F")]
	[FieldOffset(Offset = "0x2C")]
	public float _period;

	// Token: 0x04000020 RID: 32
	[Token(Token = "0x4000020")]
	[FieldOffset(Offset = "0x30")]
	private Renderer _rend;

	// Token: 0x04000021 RID: 33
	[Token(Token = "0x4000021")]
	[FieldOffset(Offset = "0x38")]
	private MaterialPropertyBlock _mpb;

	// Token: 0x04000022 RID: 34
	[Token(Token = "0x4000022")]
	[FieldOffset(Offset = "0x40")]
	private RegisterDynWavesInput _rdwi;
}
