using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001D0 RID: 464
[Token(Token = "0x20001D0")]
public class AutoDestructParticleSystems : MonoBehaviour
{
	// Token: 0x06000D76 RID: 3446 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D76")]
	[Address(RVA = "0x37014C0", Offset = "0x36FFAC0", VA = "0x1837014C0")]
	private void Awake()
	{
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D77")]
	[Address(RVA = "0x3701570", Offset = "0x36FFB70", VA = "0x183701570")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000D78")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public AutoDestructParticleSystems()
	{
	}

	// Token: 0x04000C45 RID: 3141
	[Token(Token = "0x4000C45")]
	[FieldOffset(Offset = "0x20")]
	public bool ChildParticleSystems;

	// Token: 0x04000C46 RID: 3142
	[Token(Token = "0x4000C46")]
	[FieldOffset(Offset = "0x28")]
	private ParticleSystem[] allParticleSystems;
}
