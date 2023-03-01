using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000175 RID: 373
[Token(Token = "0x2000175")]
public class simpleIkSolver : MonoBehaviour
{
	// Token: 0x06000B0B RID: 2827 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0B")]
	[Address(RVA = "0x2F613F0", Offset = "0x2F603F0", VA = "0x182F613F0")]
	private void Start()
	{
	}

	// Token: 0x06000B0C RID: 2828 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0C")]
	[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B0D RID: 2829 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0D")]
	[Address(RVA = "0x2F60B80", Offset = "0x2F5FB80", VA = "0x182F60B80")]
	public void Solve()
	{
	}

	// Token: 0x06000B0E RID: 2830 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0E")]
	[Address(RVA = "0x2F60950", Offset = "0x2F5F950", VA = "0x182F60950")]
	private void CheckAngleRestrictions(simpleIkSolver.JointEntity jointEntity)
	{
	}

	// Token: 0x06000B0F RID: 2831 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B0F")]
	[Address(RVA = "0x2F60B10", Offset = "0x2F5FB10", VA = "0x182F60B10")]
	public void ResetJoints()
	{
	}

	// Token: 0x06000B10 RID: 2832 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B10")]
	[Address(RVA = "0x2F614D0", Offset = "0x2F604D0", VA = "0x182F614D0")]
	public simpleIkSolver()
	{
	}

	// Token: 0x040009C1 RID: 2497
	[Token(Token = "0x40009C1")]
	private const float IK_POS_THRESH = 0.0001f;

	// Token: 0x040009C2 RID: 2498
	[Token(Token = "0x40009C2")]
	private const int MAX_IK_TRIES = 20;

	// Token: 0x040009C3 RID: 2499
	[Token(Token = "0x40009C3")]
	[FieldOffset(Offset = "0x20")]
	public bool IsActive;

	// Token: 0x040009C4 RID: 2500
	[Token(Token = "0x40009C4")]
	[FieldOffset(Offset = "0x28")]
	public Transform Target;

	// Token: 0x040009C5 RID: 2501
	[Token(Token = "0x40009C5")]
	[FieldOffset(Offset = "0x30")]
	public simpleIkSolver.JointEntity[] JointEntities;

	// Token: 0x040009C6 RID: 2502
	[Token(Token = "0x40009C6")]
	[FieldOffset(Offset = "0x38")]
	public Transform leftFootTarget;

	// Token: 0x040009C7 RID: 2503
	[Token(Token = "0x40009C7")]
	[FieldOffset(Offset = "0x40")]
	public float heightOffset;

	// Token: 0x040009C8 RID: 2504
	[Token(Token = "0x40009C8")]
	[FieldOffset(Offset = "0x44")]
	public bool IsDamping;

	// Token: 0x040009C9 RID: 2505
	[Token(Token = "0x40009C9")]
	[FieldOffset(Offset = "0x48")]
	public float DampingMax;

	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	[Serializable]
	public class JointEntity
	{
		// Token: 0x06000B11 RID: 2833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B11")]
		[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
		public JointEntity()
		{
		}

		// Token: 0x040009CA RID: 2506
		[Token(Token = "0x40009CA")]
		[FieldOffset(Offset = "0x10")]
		public Transform Joint;

		// Token: 0x040009CB RID: 2507
		[Token(Token = "0x40009CB")]
		[FieldOffset(Offset = "0x18")]
		public simpleIkSolver.AngleRestriction AngleRestrictionRange;

		// Token: 0x040009CC RID: 2508
		[Token(Token = "0x40009CC")]
		[FieldOffset(Offset = "0x20")]
		internal Quaternion _initialRotation;
	}

	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	[Serializable]
	public class AngleRestriction
	{
		// Token: 0x06000B12 RID: 2834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x2F4AAA0", Offset = "0x2F49AA0", VA = "0x182F4AAA0")]
		public AngleRestriction()
		{
		}

		// Token: 0x040009CD RID: 2509
		[Token(Token = "0x40009CD")]
		[FieldOffset(Offset = "0x10")]
		public bool xAxis;

		// Token: 0x040009CE RID: 2510
		[Token(Token = "0x40009CE")]
		[FieldOffset(Offset = "0x14")]
		public float xMin;

		// Token: 0x040009CF RID: 2511
		[Token(Token = "0x40009CF")]
		[FieldOffset(Offset = "0x18")]
		public float xMax;

		// Token: 0x040009D0 RID: 2512
		[Token(Token = "0x40009D0")]
		[FieldOffset(Offset = "0x1C")]
		public bool yAxis;

		// Token: 0x040009D1 RID: 2513
		[Token(Token = "0x40009D1")]
		[FieldOffset(Offset = "0x20")]
		public float yMin;

		// Token: 0x040009D2 RID: 2514
		[Token(Token = "0x40009D2")]
		[FieldOffset(Offset = "0x24")]
		public float yMax;

		// Token: 0x040009D3 RID: 2515
		[Token(Token = "0x40009D3")]
		[FieldOffset(Offset = "0x28")]
		public bool zAxis;

		// Token: 0x040009D4 RID: 2516
		[Token(Token = "0x40009D4")]
		[FieldOffset(Offset = "0x2C")]
		public float zMin;

		// Token: 0x040009D5 RID: 2517
		[Token(Token = "0x40009D5")]
		[FieldOffset(Offset = "0x30")]
		public float zMax;
	}
}
