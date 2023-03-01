using System;
using AdvancedTerrainGrass;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000208 RID: 520
[Token(Token = "0x2000208")]
public class InventoryFakeGround : MonoBehaviour
{
	// Token: 0x06000DF3 RID: 3571 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF3")]
	[Address(RVA = "0x2F8D480", Offset = "0x2F8C480", VA = "0x182F8D480")]
	private void Awake()
	{
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF4")]
	[Address(RVA = "0x2F8D570", Offset = "0x2F8C570", VA = "0x182F8D570")]
	private void OnEnable()
	{
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF5")]
	[Address(RVA = "0x2F8D4F0", Offset = "0x2F8C4F0", VA = "0x182F8D4F0")]
	private void OnDisable()
	{
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DF6")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public InventoryFakeGround()
	{
	}

	// Token: 0x04000D16 RID: 3350
	[Token(Token = "0x4000D16")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LayerMask _realWorldCullingMask;

	// Token: 0x04000D17 RID: 3351
	[Token(Token = "0x4000D17")]
	[FieldOffset(Offset = "0x28")]
	public GrassManager _grassManager;
}
