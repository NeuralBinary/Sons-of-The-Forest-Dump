using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D1 RID: 465
[Token(Token = "0x20001D1")]
public class AutoDestructParticleSystems : MonoBehaviour
{
	// Token: 0x06000D1B RID: 3355 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x2F7D910", Offset = "0x2F7C910", VA = "0x182F7D910")]
	private void Awake()
	{
	}

	// Token: 0x06000D1C RID: 3356 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1C")]
	[Address(RVA = "0x2F7D970", Offset = "0x2F7C970", VA = "0x182F7D970")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000D1D RID: 3357 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D1D")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public AutoDestructParticleSystems()
	{
	}

	// Token: 0x04000C16 RID: 3094
	[Token(Token = "0x4000C16")]
	[FieldOffset(Offset = "0x20")]
	public bool ChildParticleSystems;

	// Token: 0x04000C17 RID: 3095
	[Token(Token = "0x4000C17")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem[] allParticleSystems;
}
