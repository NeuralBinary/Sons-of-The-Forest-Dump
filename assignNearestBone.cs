using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

// Token: 0x02000108 RID: 264
[Token(Token = "0x2000108")]
public class assignNearestBone : MonoBehaviour
{
	// Token: 0x17000102 RID: 258
	// (get) Token: 0x060007F1 RID: 2033 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000102")]
	public Transform NearestBone
	{
		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		get
		{
			return null;
		}
	}

	// Token: 0x060007F2 RID: 2034 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F2")]
	[Address(RVA = "0x2F44D10", Offset = "0x2F43D10", VA = "0x182F44D10")]
	private void Awake()
	{
	}

	// Token: 0x060007F3 RID: 2035 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60007F3")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public assignNearestBone()
	{
	}

	// Token: 0x04000675 RID: 1653
	[Token(Token = "0x4000675")]
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("nearestBone")]
	[SerializeField]
	private Transform _nearestBone;

	// Token: 0x04000676 RID: 1654
	[Token(Token = "0x4000676")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private bool _disableGameObjectOnAwake;
}
