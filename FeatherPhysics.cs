using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x020001F3 RID: 499
[Token(Token = "0x20001F3")]
[AddComponentMenu("Sons/Feather Physics")]
public class FeatherPhysics : MonoBehaviour
{
	// Token: 0x06000DB0 RID: 3504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB0")]
	[Address(RVA = "0x2F88050", Offset = "0x2F87050", VA = "0x182F88050")]
	private void Start()
	{
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB1")]
	[Address(RVA = "0x2F87F40", Offset = "0x2F86F40", VA = "0x182F87F40")]
	private void FloatDown()
	{
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB2")]
	[Address(RVA = "0x2F87DF0", Offset = "0x2F86DF0", VA = "0x182F87DF0")]
	private void CleanUp()
	{
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000DB3")]
	[Address(RVA = "0x2F882A0", Offset = "0x2F872A0", VA = "0x182F882A0")]
	public FeatherPhysics()
	{
	}

	// Token: 0x04000CD0 RID: 3280
	[Token(Token = "0x4000CD0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool _unparent;

	// Token: 0x04000CD1 RID: 3281
	[Token(Token = "0x4000CD1")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _force;

	// Token: 0x04000CD2 RID: 3282
	[Token(Token = "0x4000CD2")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _destroyTime;

	// Token: 0x04000CD3 RID: 3283
	[Token(Token = "0x4000CD3")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 _torque;

	// Token: 0x04000CD4 RID: 3284
	[Token(Token = "0x4000CD4")]
	[FieldOffset(Offset = "0x38")]
	private ConstantForce _constantForce;

	// Token: 0x04000CD5 RID: 3285
	[Token(Token = "0x4000CD5")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody _rigidbody;
}
