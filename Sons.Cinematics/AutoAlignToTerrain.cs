using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000003 RID: 3
[Token(Token = "0x2000003")]
public class AutoAlignToTerrain : MonoBehaviour
{
	// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000009")]
	[Address(RVA = "0x2D55370", Offset = "0x2D53970", VA = "0x182D55370")]
	private void Start()
	{
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000A")]
	[Address(RVA = "0x2D55380", Offset = "0x2D53980", VA = "0x182D55380")]
	private void LateUpdate()
	{
	}

	// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000B")]
	[Address(RVA = "0x2D55390", Offset = "0x2D53990", VA = "0x182D55390")]
	private void DoAlign()
	{
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2D55450", Offset = "0x2D53A50", VA = "0x182D55450")]
	public AutoAlignToTerrain()
	{
	}

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _autoUpdate;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private LayerMask _layerMask;

	// Token: 0x04000009 RID: 9
	[Token(Token = "0x4000009")]
	[FieldOffset(Offset = "0x28")]
	private Transform _cachedTransform;
}
