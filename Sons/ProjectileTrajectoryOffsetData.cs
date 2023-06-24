using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000051 RID: 81
[Token(Token = "0x2000051")]
[CreateAssetMenu(fileName = "NewItem", menuName = "Sons/Data/ProjectileTrajectoryOffsetData")]
public class ProjectileTrajectoryOffsetData : ScriptableObject
{
	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06000273 RID: 627 RVA: 0x00002EB0 File Offset: 0x000010B0
	[Token(Token = "0x17000081")]
	public float ArcAngleOffset
	{
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
		get
		{
			return 0f;
		}
	}

	// Token: 0x06000274 RID: 628 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x6000274")]
	[Address(RVA = "0x31AFD90", Offset = "0x31AE390", VA = "0x1831AFD90")]
	public Vector3 PositionOffsetAdjusted()
	{
		return default(Vector3);
	}

	// Token: 0x06000275 RID: 629 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000275")]
	[Address(RVA = "0x31AFF20", Offset = "0x31AE520", VA = "0x1831AFF20")]
	public ProjectileTrajectoryOffsetData()
	{
	}

	// Token: 0x04000258 RID: 600
	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 _positionOffsetDown;

	// Token: 0x04000259 RID: 601
	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 _positionOffsetUp;

	// Token: 0x0400025A RID: 602
	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _arcAngleOffset;
}
