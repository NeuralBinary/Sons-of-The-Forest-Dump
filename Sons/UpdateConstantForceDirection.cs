using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002A RID: 42
[Token(Token = "0x200002A")]
public class UpdateConstantForceDirection : MonoBehaviour
{
	// Token: 0x060000F8 RID: 248 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F8")]
	[Address(RVA = "0x2F73E50", Offset = "0x2F72450", VA = "0x182F73E50")]
	private void Update()
	{
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000F9")]
	[Address(RVA = "0x2B948D0", Offset = "0x2B92ED0", VA = "0x182B948D0")]
	public UpdateConstantForceDirection()
	{
	}

	// Token: 0x04000102 RID: 258
	[Token(Token = "0x4000102")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ConstantForce _constantForce;

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _transform;

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _strengthMultiplier;
}
