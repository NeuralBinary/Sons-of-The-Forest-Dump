using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F2 RID: 498
[Token(Token = "0x20001F2")]
[AddComponentMenu("Sons/Feather Physics")]
public class FeatherPhysics : MonoBehaviour
{
	// Token: 0x06000E0B RID: 3595 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0B")]
	[Address(RVA = "0x3710E50", Offset = "0x370F450", VA = "0x183710E50")]
	private void Start()
	{
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0C")]
	[Address(RVA = "0x37112C0", Offset = "0x370F8C0", VA = "0x1837112C0")]
	private void FloatDown()
	{
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0D")]
	[Address(RVA = "0x3711480", Offset = "0x370FA80", VA = "0x183711480")]
	private void CleanUp()
	{
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000E0E")]
	[Address(RVA = "0x3711670", Offset = "0x370FC70", VA = "0x183711670")]
	public FeatherPhysics()
	{
	}

	// Token: 0x04000CFF RID: 3327
	[Token(Token = "0x4000CFF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _unparent;

	// Token: 0x04000D00 RID: 3328
	[Token(Token = "0x4000D00")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _force;

	// Token: 0x04000D01 RID: 3329
	[Token(Token = "0x4000D01")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _destroyTime;

	// Token: 0x04000D02 RID: 3330
	[Token(Token = "0x4000D02")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 _torque;

	// Token: 0x04000D03 RID: 3331
	[Token(Token = "0x4000D03")]
	[FieldOffset(Offset = "0x38")]
	private ConstantForce _constantForce;

	// Token: 0x04000D04 RID: 3332
	[Token(Token = "0x4000D04")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody _rigidbody;
}
