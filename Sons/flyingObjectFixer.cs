using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000124 RID: 292
[Token(Token = "0x2000124")]
public class flyingObjectFixer : MonoBehaviour
{
	// Token: 0x060008CA RID: 2250 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x368BFD0", Offset = "0x368A5D0", VA = "0x18368BFD0")]
	private void OnEnable()
	{
	}

	// Token: 0x060008CB RID: 2251 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x368C340", Offset = "0x368A940", VA = "0x18368C340")]
	private void OnDisable()
	{
	}

	// Token: 0x060008CC RID: 2252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x368C480", Offset = "0x368AA80", VA = "0x18368C480")]
	private IEnumerator dampRigidBody()
	{
		return null;
	}

	// Token: 0x060008CD RID: 2253 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x368C510", Offset = "0x368AB10", VA = "0x18368C510")]
	public flyingObjectFixer()
	{
	}

	// Token: 0x040006F5 RID: 1781
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x20")]
	public float _dragSetting;

	// Token: 0x040006F6 RID: 1782
	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x24")]
	public float _angularDrag;

	// Token: 0x040006F7 RID: 1783
	[Token(Token = "0x40006F7")]
	[FieldOffset(Offset = "0x28")]
	public float _fixTime;

	// Token: 0x040006F8 RID: 1784
	[Token(Token = "0x40006F8")]
	[FieldOffset(Offset = "0x2C")]
	public bool _lerpDownOverTime;

	// Token: 0x040006F9 RID: 1785
	[Token(Token = "0x40006F9")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rb;

	// Token: 0x040006FA RID: 1786
	[Token(Token = "0x40006FA")]
	[FieldOffset(Offset = "0x38")]
	private float initDrag;

	// Token: 0x040006FB RID: 1787
	[Token(Token = "0x40006FB")]
	[FieldOffset(Offset = "0x3C")]
	private float initAngularDrag;
}
