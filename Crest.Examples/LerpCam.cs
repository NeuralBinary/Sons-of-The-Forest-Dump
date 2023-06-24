using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class LerpCam : MonoBehaviour
{
	// Token: 0x06000008 RID: 8 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000008")]
	[Address(RVA = "0x9EDB00", Offset = "0x9EC100", VA = "0x1809EDB00")]
	private void Update()
	{
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002096 File Offset: 0x00000296
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x9EE170", Offset = "0x9EC770", VA = "0x1809EE170")]
	public LerpCam()
	{
	}

	// Token: 0x04000016 RID: 22
	[Token(Token = "0x4000016")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _lerpAlpha;

	// Token: 0x04000017 RID: 23
	[Token(Token = "0x4000017")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _targetPos;

	// Token: 0x04000018 RID: 24
	[Token(Token = "0x4000018")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Transform _targetLookatPos;

	// Token: 0x04000019 RID: 25
	[Token(Token = "0x4000019")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _lookatOffset;

	// Token: 0x0400001A RID: 26
	[Token(Token = "0x400001A")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _minHeightAboveWater;

	// Token: 0x0400001B RID: 27
	[Token(Token = "0x400001B")]
	[FieldOffset(Offset = "0x40")]
	private SampleHeightHelper _sampleHeightHelper;
}
