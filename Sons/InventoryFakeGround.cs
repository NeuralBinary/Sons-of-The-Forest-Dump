using System;
using AdvancedTerrainGrass;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000207 RID: 519
[Token(Token = "0x2000207")]
public class InventoryFakeGround : MonoBehaviour
{
	// Token: 0x06000E4E RID: 3662 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4E")]
	[Address(RVA = "0x3717470", Offset = "0x3715A70", VA = "0x183717470")]
	private void Awake()
	{
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E4F")]
	[Address(RVA = "0x37175A0", Offset = "0x3715BA0", VA = "0x1837175A0")]
	private void OnEnable()
	{
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E50")]
	[Address(RVA = "0x3717710", Offset = "0x3715D10", VA = "0x183717710")]
	private void OnDisable()
	{
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E51")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public InventoryFakeGround()
	{
	}

	// Token: 0x04000D45 RID: 3397
	[Token(Token = "0x4000D45")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LayerMask _realWorldCullingMask;

	// Token: 0x04000D46 RID: 3398
	[Token(Token = "0x4000D46")]
	[FieldOffset(Offset = "0x28")]
	public GrassManager _grassManager;
}
