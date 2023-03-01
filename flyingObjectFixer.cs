using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000127 RID: 295
[Token(Token = "0x2000127")]
public class flyingObjectFixer : MonoBehaviour
{
	// Token: 0x06000883 RID: 2179 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000883")]
	[Address(RVA = "0x2F48B00", Offset = "0x2F47B00", VA = "0x182F48B00")]
	private void OnEnable()
	{
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000884")]
	[Address(RVA = "0x2F48A60", Offset = "0x2F47A60", VA = "0x182F48A60")]
	private void OnDisable()
	{
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000885")]
	[Address(RVA = "0x2F48C80", Offset = "0x2F47C80", VA = "0x182F48C80")]
	private IEnumerator dampRigidBody()
	{
		return null;
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000886")]
	[Address(RVA = "0x2F48C60", Offset = "0x2F47C60", VA = "0x182F48C60")]
	public flyingObjectFixer()
	{
	}

	// Token: 0x040006D9 RID: 1753
	[Token(Token = "0x40006D9")]
	[FieldOffset(Offset = "0x20")]
	public float _dragSetting;

	// Token: 0x040006DA RID: 1754
	[Token(Token = "0x40006DA")]
	[FieldOffset(Offset = "0x24")]
	public float _angularDrag;

	// Token: 0x040006DB RID: 1755
	[Token(Token = "0x40006DB")]
	[FieldOffset(Offset = "0x28")]
	public float _fixTime;

	// Token: 0x040006DC RID: 1756
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x2C")]
	public bool _lerpDownOverTime;

	// Token: 0x040006DD RID: 1757
	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rb;

	// Token: 0x040006DE RID: 1758
	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x38")]
	private float initDrag;

	// Token: 0x040006DF RID: 1759
	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x3C")]
	private float initAngularDrag;
}
