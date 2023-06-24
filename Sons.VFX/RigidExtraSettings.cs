using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200000C RID: 12
[Token(Token = "0x200000C")]
public class RigidExtraSettings : MonoBehaviour
{
	// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000039")]
	[Address(RVA = "0x5EA830", Offset = "0x5E8E30", VA = "0x1805EA830")]
	public void SetMaxDepenetration(float value)
	{
	}

	// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003A")]
	[Address(RVA = "0x5EA850", Offset = "0x5E8E50", VA = "0x1805EA850")]
	public void SetInitialRandomVelocity(float value)
	{
	}

	// Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003B")]
	[Address(RVA = "0x3167040", Offset = "0x3165640", VA = "0x183167040")]
	private void Start()
	{
	}

	// Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003C")]
	[Address(RVA = "0x3167050", Offset = "0x3165650", VA = "0x183167050")]
	private void Update()
	{
	}

	// Token: 0x0600003D RID: 61 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003D")]
	[Address(RVA = "0x3167180", Offset = "0x3165780", VA = "0x183167180")]
	private void ApplySettings()
	{
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003E")]
	[Address(RVA = "0x31674D0", Offset = "0x3165AD0", VA = "0x1831674D0")]
	private void GetSelfRigid()
	{
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600003F")]
	[Address(RVA = "0x2655D00", Offset = "0x2654300", VA = "0x182655D00")]
	public RigidExtraSettings()
	{
	}

	// Token: 0x0400005A RID: 90
	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _maxDepenetration;

	// Token: 0x0400005B RID: 91
	[Token(Token = "0x400005B")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _initialRandomVelocity;

	// Token: 0x0400005C RID: 92
	[Token(Token = "0x400005C")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Rigidbody _rigid;

	// Token: 0x0400005D RID: 93
	[Token(Token = "0x400005D")]
	[FieldOffset(Offset = "0x30")]
	private bool _waitForRigidToBeNotKinematic;
}
