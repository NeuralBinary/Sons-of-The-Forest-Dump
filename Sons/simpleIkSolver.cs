using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000174 RID: 372
[Token(Token = "0x2000174")]
public class simpleIkSolver : MonoBehaviour
{
	// Token: 0x06000B64 RID: 2916 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x36CE080", Offset = "0x36CC680", VA = "0x1836CE080")]
	private void Start()
	{
	}

	// Token: 0x06000B65 RID: 2917 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
	private void LateUpdate()
	{
	}

	// Token: 0x06000B66 RID: 2918 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B66")]
	[Address(RVA = "0x36CE290", Offset = "0x36CC890", VA = "0x1836CE290")]
	public void Solve()
	{
	}

	// Token: 0x06000B67 RID: 2919 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B67")]
	[Address(RVA = "0x36CECA0", Offset = "0x36CD2A0", VA = "0x1836CECA0")]
	private void CheckAngleRestrictions(simpleIkSolver.JointEntity jointEntity)
	{
	}

	// Token: 0x06000B68 RID: 2920 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B68")]
	[Address(RVA = "0x36CEE40", Offset = "0x36CD440", VA = "0x1836CEE40")]
	public void ResetJoints()
	{
	}

	// Token: 0x06000B69 RID: 2921 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000B69")]
	[Address(RVA = "0x36CEEF0", Offset = "0x36CD4F0", VA = "0x1836CEEF0")]
	public simpleIkSolver()
	{
	}

	// Token: 0x040009EA RID: 2538
	[Token(Token = "0x40009EA")]
	private const float IK_POS_THRESH = 0.0001f;

	// Token: 0x040009EB RID: 2539
	[Token(Token = "0x40009EB")]
	private const int MAX_IK_TRIES = 20;

	// Token: 0x040009EC RID: 2540
	[Token(Token = "0x40009EC")]
	[FieldOffset(Offset = "0x20")]
	public bool IsActive;

	// Token: 0x040009ED RID: 2541
	[Token(Token = "0x40009ED")]
	[FieldOffset(Offset = "0x28")]
	public Transform Target;

	// Token: 0x040009EE RID: 2542
	[Token(Token = "0x40009EE")]
	[FieldOffset(Offset = "0x30")]
	public simpleIkSolver.JointEntity[] JointEntities;

	// Token: 0x040009EF RID: 2543
	[Token(Token = "0x40009EF")]
	[FieldOffset(Offset = "0x38")]
	public Transform leftFootTarget;

	// Token: 0x040009F0 RID: 2544
	[Token(Token = "0x40009F0")]
	[FieldOffset(Offset = "0x40")]
	public float heightOffset;

	// Token: 0x040009F1 RID: 2545
	[Token(Token = "0x40009F1")]
	[FieldOffset(Offset = "0x44")]
	public bool IsDamping;

	// Token: 0x040009F2 RID: 2546
	[Token(Token = "0x40009F2")]
	[FieldOffset(Offset = "0x48")]
	public float DampingMax;

	// Token: 0x02000175 RID: 373
	[Token(Token = "0x2000175")]
	[Serializable]
	public class JointEntity
	{
		// Token: 0x06000B6A RID: 2922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public JointEntity()
		{
		}

		// Token: 0x040009F3 RID: 2547
		[Token(Token = "0x40009F3")]
		[FieldOffset(Offset = "0x10")]
		public Transform Joint;

		// Token: 0x040009F4 RID: 2548
		[Token(Token = "0x40009F4")]
		[FieldOffset(Offset = "0x18")]
		public simpleIkSolver.AngleRestriction AngleRestrictionRange;

		// Token: 0x040009F5 RID: 2549
		[Token(Token = "0x40009F5")]
		[FieldOffset(Offset = "0x20")]
		internal Quaternion _initialRotation;
	}

	// Token: 0x02000176 RID: 374
	[Token(Token = "0x2000176")]
	[Serializable]
	public class AngleRestriction
	{
		// Token: 0x06000B6B RID: 2923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000B6B")]
		[Address(RVA = "0x36CEF40", Offset = "0x36CD540", VA = "0x1836CEF40")]
		public AngleRestriction()
		{
		}

		// Token: 0x040009F6 RID: 2550
		[Token(Token = "0x40009F6")]
		[FieldOffset(Offset = "0x10")]
		public bool xAxis;

		// Token: 0x040009F7 RID: 2551
		[Token(Token = "0x40009F7")]
		[FieldOffset(Offset = "0x14")]
		public float xMin;

		// Token: 0x040009F8 RID: 2552
		[Token(Token = "0x40009F8")]
		[FieldOffset(Offset = "0x18")]
		public float xMax;

		// Token: 0x040009F9 RID: 2553
		[Token(Token = "0x40009F9")]
		[FieldOffset(Offset = "0x1C")]
		public bool yAxis;

		// Token: 0x040009FA RID: 2554
		[Token(Token = "0x40009FA")]
		[FieldOffset(Offset = "0x20")]
		public float yMin;

		// Token: 0x040009FB RID: 2555
		[Token(Token = "0x40009FB")]
		[FieldOffset(Offset = "0x24")]
		public float yMax;

		// Token: 0x040009FC RID: 2556
		[Token(Token = "0x40009FC")]
		[FieldOffset(Offset = "0x28")]
		public bool zAxis;

		// Token: 0x040009FD RID: 2557
		[Token(Token = "0x40009FD")]
		[FieldOffset(Offset = "0x2C")]
		public float zMin;

		// Token: 0x040009FE RID: 2558
		[Token(Token = "0x40009FE")]
		[FieldOffset(Offset = "0x30")]
		public float zMax;
	}
}
