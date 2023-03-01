using System;
using Il2CppDummyDll;
using Obi;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x02000639 RID: 1593
	[Token(Token = "0x2000639")]
	[AddComponentMenu("Sons/Gameplay/CutRope")]
	public class CutRope : MonoBehaviour
	{
		// Token: 0x060028E7 RID: 10471 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E7")]
		[Address(RVA = "0x2DB5550", Offset = "0x2DB4550", VA = "0x182DB5550")]
		private void OnEnable()
		{
		}

		// Token: 0x060028E8 RID: 10472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E8")]
		[Address(RVA = "0x2DB4F40", Offset = "0x2DB3F40", VA = "0x182DB4F40")]
		private void OnBreak(IBreakSender arg1, IImpactData arg2)
		{
		}

		// Token: 0x060028E9 RID: 10473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028E9")]
		[Address(RVA = "0x2DB5420", Offset = "0x2DB4420", VA = "0x182DB5420")]
		private void OnDisable()
		{
		}

		// Token: 0x060028EA RID: 10474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EA")]
		[Address(RVA = "0x2DB5620", Offset = "0x2DB4620", VA = "0x182DB5620")]
		private void Update()
		{
		}

		// Token: 0x060028EB RID: 10475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EB")]
		[Address(RVA = "0x2DB5020", Offset = "0x2DB4020", VA = "0x182DB5020")]
		private void OnCollision(ObiSolver s, ObiSolver.ObiCollisionEventArgs e)
		{
		}

		// Token: 0x060028EC RID: 10476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EC")]
		[Address(RVA = "0x2DB4D80", Offset = "0x2DB3D80", VA = "0x182DB4D80")]
		public void DoCutRope()
		{
		}

		// Token: 0x060028ED RID: 10477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028ED")]
		[Address(RVA = "0x2DB4CB0", Offset = "0x2DB3CB0", VA = "0x182DB4CB0")]
		private void DoCutRopeCheap()
		{
		}

		// Token: 0x060028EE RID: 10478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EE")]
		[Address(RVA = "0x2DB4E00", Offset = "0x2DB3E00", VA = "0x182DB4E00")]
		private void DoCutRope(ObiStructuralElement obiStructuralElement)
		{
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028EF")]
		[Address(RVA = "0x2DB4C70", Offset = "0x2DB3C70", VA = "0x182DB4C70")]
		private void DisablePhysics()
		{
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60028F0")]
		[Address(RVA = "0x2DB5800", Offset = "0x2DB4800", VA = "0x182DB5800")]
		public CutRope()
		{
		}

		// Token: 0x04002495 RID: 9365
		[Token(Token = "0x4002495")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ObiSolver _solver;

		// Token: 0x04002496 RID: 9366
		[Token(Token = "0x4002496")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ObiFixedUpdater _fixedUpdater;

		// Token: 0x04002497 RID: 9367
		[Token(Token = "0x4002497")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ObiRope _rope;

		// Token: 0x04002498 RID: 9368
		[Token(Token = "0x4002498")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Rigidbody _tacticalRigidbody;

		// Token: 0x04002499 RID: 9369
		[Token(Token = "0x4002499")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _activeRangeMetres;

		// Token: 0x0400249A RID: 9370
		[Token(Token = "0x400249A")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _disableSolverAfterCutDelay;

		// Token: 0x0400249B RID: 9371
		[Token(Token = "0x400249B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x0400249C RID: 9372
		[Token(Token = "0x400249C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _doCheapCut;

		// Token: 0x0400249D RID: 9373
		[Token(Token = "0x400249D")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent OnRopeCutCheap;

		// Token: 0x0400249E RID: 9374
		[Token(Token = "0x400249E")]
		[FieldOffset(Offset = "0x60")]
		private bool _isActive;

		// Token: 0x0400249F RID: 9375
		[Token(Token = "0x400249F")]
		[FieldOffset(Offset = "0x61")]
		private bool _isCut;

		// Token: 0x040024A0 RID: 9376
		[Token(Token = "0x40024A0")]
		[FieldOffset(Offset = "0x62")]
		private bool _initialized;

		// Token: 0x040024A1 RID: 9377
		[Token(Token = "0x40024A1")]
		[FieldOffset(Offset = "0x63")]
		private bool _cutPending;
	}
}
