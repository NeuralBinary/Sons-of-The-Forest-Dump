using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200004F RID: 79
[Token(Token = "0x200004F")]
[CreateAssetMenu(fileName = "NewItem", menuName = "Sons/Data/ProjectileTrajectoryOffsetData")]
public class ProjectileTrajectoryOffsetData : ScriptableObject
{
	// Token: 0x1700007B RID: 123
	// (get) Token: 0x06000254 RID: 596 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x1700007B")]
	public float ArcAngleOffset
	{
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x8A27B0", Offset = "0x8A17B0", VA = "0x1808A27B0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x06000255 RID: 597 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x6000255")]
	[Address(RVA = "0x2B7ED80", Offset = "0x2B7DD80", VA = "0x182B7ED80")]
	public Vector3 PositionOffsetAdjusted()
	{
		return default(Vector3);
	}

	// Token: 0x06000256 RID: 598 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000256")]
	[Address(RVA = "0x2B7EF20", Offset = "0x2B7DF20", VA = "0x182B7EF20")]
	public ProjectileTrajectoryOffsetData()
	{
	}

	// Token: 0x04000225 RID: 549
	[Token(Token = "0x4000225")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Vector3 _positionOffsetDown;

	// Token: 0x04000226 RID: 550
	[Token(Token = "0x4000226")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private Vector3 _positionOffsetUp;

	// Token: 0x04000227 RID: 551
	[Token(Token = "0x4000227")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float _arcAngleOffset;
}
