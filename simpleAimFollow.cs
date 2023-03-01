using System;
using Il2CppDummyDll;
using UnityEngine;
using Valve.VR.InteractionSystem;

// Token: 0x02000171 RID: 369
[Token(Token = "0x2000171")]
[ExecuteInEditMode]
public class simpleAimFollow : MonoBehaviour
{
	// Token: 0x06000AFC RID: 2812 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFC")]
	[Address(RVA = "0x2F5F3B0", Offset = "0x2F5E3B0", VA = "0x182F5F3B0")]
	private void Update()
	{
	}

	// Token: 0x06000AFD RID: 2813 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000AFD")]
	[Address(RVA = "0x2F5F600", Offset = "0x2F5E600", VA = "0x182F5F600")]
	public simpleAimFollow()
	{
	}

	// Token: 0x04000995 RID: 2453
	[Token(Token = "0x4000995")]
	[FieldOffset(Offset = "0x20")]
	public Transform HandTransform;

	// Token: 0x04000996 RID: 2454
	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x28")]
	public Transform AimRoot;

	// Token: 0x04000997 RID: 2455
	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x30")]
	public Transform BowFollow;

	// Token: 0x04000998 RID: 2456
	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x38")]
	public Transform nockRestTransform;

	// Token: 0x04000999 RID: 2457
	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x40")]
	public LinearMapping bowDrawLinearMapping;

	// Token: 0x0400099A RID: 2458
	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x48")]
	public Transform AimTarget;

	// Token: 0x0400099B RID: 2459
	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x50")]
	public float minPull;

	// Token: 0x0400099C RID: 2460
	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x54")]
	public float maxPull;

	// Token: 0x0400099D RID: 2461
	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x58")]
	public bool execute;

	// Token: 0x0400099E RID: 2462
	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x5C")]
	public Vector3 localNockPos;
}
