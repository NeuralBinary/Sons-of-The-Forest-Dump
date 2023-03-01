using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002A RID: 42
[Token(Token = "0x200002A")]
public class UpdateConstantForceDirection : MonoBehaviour
{
	// Token: 0x060000EF RID: 239 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000EF")]
	[Address(RVA = "0x29B4C30", Offset = "0x29B3C30", VA = "0x1829B4C30")]
	private void Update()
	{
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F0")]
	[Address(RVA = "0x29A55B0", Offset = "0x29A45B0", VA = "0x1829A55B0")]
	public UpdateConstantForceDirection()
	{
	}

	// Token: 0x04000100 RID: 256
	[Token(Token = "0x4000100")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ConstantForce _constantForce;

	// Token: 0x04000101 RID: 257
	[Token(Token = "0x4000101")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _transform;

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _strengthMultiplier;
}
