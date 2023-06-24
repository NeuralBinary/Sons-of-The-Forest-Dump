using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Obi;
using UnityEngine;

// Token: 0x02000004 RID: 4
[Token(Token = "0x2000004")]
[RequireComponent(typeof(ObiCollider))]
public class ObiContactGrabber : MonoBehaviour
{
	// Token: 0x17000001 RID: 1
	// (get) Token: 0x0600000B RID: 11 RVA: 0x000020F8 File Offset: 0x000002F8
	[Token(Token = "0x17000001")]
	public bool grabbed
	{
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x27332E0", Offset = "0x27318E0", VA = "0x1827332E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x600000C")]
	[Address(RVA = "0x2733330", Offset = "0x2731930", VA = "0x182733330")]
	private void Awake()
	{
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x600000D")]
	[Address(RVA = "0x27333C0", Offset = "0x27319C0", VA = "0x1827333C0")]
	private void OnEnable()
	{
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x600000E")]
	[Address(RVA = "0x2733530", Offset = "0x2731B30", VA = "0x182733530")]
	private void OnDisable()
	{
	}

	// Token: 0x0600000F RID: 15 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x600000F")]
	[Address(RVA = "0x27336A0", Offset = "0x2731CA0", VA = "0x1827336A0")]
	private void Solver_OnCollision(object sender, ObiSolver.ObiCollisionEventArgs e)
	{
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x6000010")]
	[Address(RVA = "0x2733750", Offset = "0x2731D50", VA = "0x182733750")]
	private void UpdateParticleProperties()
	{
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002110 File Offset: 0x00000310
	[Token(Token = "0x6000011")]
	[Address(RVA = "0x27338A0", Offset = "0x2731EA0", VA = "0x1827338A0")]
	private bool GrabParticle(ObiSolver solver, int index)
	{
		return default(bool);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x6000012")]
	[Address(RVA = "0x2733D80", Offset = "0x2732380", VA = "0x182733D80")]
	public void Grab()
	{
	}

	// Token: 0x06000013 RID: 19 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x6000013")]
	[Address(RVA = "0x27341D0", Offset = "0x27327D0", VA = "0x1827341D0")]
	public void Release()
	{
	}

	// Token: 0x06000014 RID: 20 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x6000014")]
	[Address(RVA = "0x2734600", Offset = "0x2732C00", VA = "0x182734600")]
	private void FixedUpdate()
	{
	}

	// Token: 0x06000015 RID: 21 RVA: 0x000020F6 File Offset: 0x000002F6
	[Token(Token = "0x6000015")]
	[Address(RVA = "0x2734CC0", Offset = "0x27332C0", VA = "0x182734CC0")]
	public ObiContactGrabber()
	{
	}

	// Token: 0x04000004 RID: 4
	[Token(Token = "0x4000004")]
	[FieldOffset(Offset = "0x20")]
	public ObiSolver[] solvers;

	// Token: 0x04000005 RID: 5
	[Token(Token = "0x4000005")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<ObiSolver, ObiSolver.ObiCollisionEventArgs> collisionEvents;

	// Token: 0x04000006 RID: 6
	[Token(Token = "0x4000006")]
	[FieldOffset(Offset = "0x30")]
	private ObiCollider localCollider;

	// Token: 0x04000007 RID: 7
	[Token(Token = "0x4000007")]
	[FieldOffset(Offset = "0x38")]
	private HashSet<ObiContactGrabber.GrabbedParticle> grabbedParticles;

	// Token: 0x04000008 RID: 8
	[Token(Token = "0x4000008")]
	[FieldOffset(Offset = "0x40")]
	private HashSet<ObiActor> grabbedActors;

	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	private class GrabbedParticle : IEqualityComparer<ObiContactGrabber.GrabbedParticle>
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x2734F30", Offset = "0x2733530", VA = "0x182734F30")]
		public GrabbedParticle(ObiSolver solver, int index, float invMass)
		{
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x2734F90", Offset = "0x2733590", VA = "0x182734F90", Slot = "4")]
		public bool Equals(ObiContactGrabber.GrabbedParticle x, ObiContactGrabber.GrabbedParticle y)
		{
			return default(bool);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420", Slot = "5")]
		public int GetHashCode(ObiContactGrabber.GrabbedParticle obj)
		{
			return 0;
		}

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x14")]
		public float invMass;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 localPosition;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		public ObiSolver solver;
	}
}
