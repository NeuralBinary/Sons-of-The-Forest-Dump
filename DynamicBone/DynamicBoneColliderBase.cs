using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000008 RID: 8
[Token(Token = "0x2000008")]
public class DynamicBoneColliderBase : MonoBehaviour
{
	// Token: 0x0600002B RID: 43 RVA: 0x00002130 File Offset: 0x00000330
	[Token(Token = "0x600002B")]
	[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
	public virtual bool Collide(ref Vector3 particlePosition, float particleRadius)
	{
		return default(bool);
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600002C")]
	[Address(RVA = "0xA5BBA0", Offset = "0xA5A1A0", VA = "0x180A5BBA0")]
	public DynamicBoneColliderBase()
	{
	}

	// Token: 0x0400004D RID: 77
	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x20")]
	[Tooltip("The axis of the capsule's height.")]
	public DynamicBoneColliderBase.Direction m_Direction;

	// Token: 0x0400004E RID: 78
	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x24")]
	[Tooltip("The center of the sphere or capsule, in the object's local space.")]
	public Vector3 m_Center;

	// Token: 0x0400004F RID: 79
	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x30")]
	[Tooltip("Constrain bones to outside bound or inside bound.")]
	public DynamicBoneColliderBase.Bound m_Bound;

	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	public enum Direction
	{
		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		X,
		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		Y,
		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		Z
	}

	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	public enum Bound
	{
		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		Outside,
		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		Inside
	}
}
