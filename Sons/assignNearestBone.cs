using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000105 RID: 261
[Token(Token = "0x2000105")]
public class assignNearestBone : MonoBehaviour
{
	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06000839 RID: 2105 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700010A")]
	public Transform NearestBone
	{
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		get
		{
			return null;
		}
	}

	// Token: 0x0600083A RID: 2106 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083A")]
	[Address(RVA = "0x3684570", Offset = "0x3682B70", VA = "0x183684570")]
	private void Awake()
	{
	}

	// Token: 0x0600083B RID: 2107 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600083B")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public assignNearestBone()
	{
	}

	// Token: 0x04000691 RID: 1681
	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("nearestBone")]
	[SerializeField]
	private Transform _nearestBone;

	// Token: 0x04000692 RID: 1682
	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _disableGameObjectOnAwake;
}
