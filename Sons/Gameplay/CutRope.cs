using System;
using Il2CppDummyDll;
using Obi;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gameplay
{
	// Token: 0x02000756 RID: 1878
	[Token(Token = "0x2000756")]
	[AddComponentMenu("Sons/Gameplay/CutRope")]
	public class CutRope : MonoBehaviour
	{
		// Token: 0x060032C6 RID: 12998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C6")]
		[Address(RVA = "0x34AB040", Offset = "0x34A9640", VA = "0x1834AB040")]
		private void OnEnable()
		{
		}

		// Token: 0x060032C7 RID: 12999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C7")]
		[Address(RVA = "0x34AB160", Offset = "0x34A9760", VA = "0x1834AB160")]
		private void OnBreak(IBreakSender arg1, IImpactData arg2)
		{
		}

		// Token: 0x060032C8 RID: 13000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C8")]
		[Address(RVA = "0x34AB3E0", Offset = "0x34A99E0", VA = "0x1834AB3E0")]
		private void OnDisable()
		{
		}

		// Token: 0x060032C9 RID: 13001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032C9")]
		[Address(RVA = "0x34AB640", Offset = "0x34A9C40", VA = "0x1834AB640")]
		private void Update()
		{
		}

		// Token: 0x060032CA RID: 13002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CA")]
		[Address(RVA = "0x34AB8B0", Offset = "0x34A9EB0", VA = "0x1834AB8B0")]
		private void OnCollision(ObiSolver s, ObiSolver.ObiCollisionEventArgs e)
		{
		}

		// Token: 0x060032CB RID: 13003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CB")]
		[Address(RVA = "0x34ABD20", Offset = "0x34AA320", VA = "0x1834ABD20")]
		public void DoCutRope()
		{
		}

		// Token: 0x060032CC RID: 13004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CC")]
		[Address(RVA = "0x34ABE50", Offset = "0x34AA450", VA = "0x1834ABE50")]
		private void DoCutRopeCheap()
		{
		}

		// Token: 0x060032CD RID: 13005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CD")]
		[Address(RVA = "0x34ABF90", Offset = "0x34AA590", VA = "0x1834ABF90")]
		private void DoCutRope(ObiStructuralElement obiStructuralElement)
		{
		}

		// Token: 0x060032CE RID: 13006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CE")]
		[Address(RVA = "0x34AC0C0", Offset = "0x34AA6C0", VA = "0x1834AC0C0")]
		private void DisablePhysics()
		{
		}

		// Token: 0x060032CF RID: 13007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60032CF")]
		[Address(RVA = "0x34AC180", Offset = "0x34AA780", VA = "0x1834AC180")]
		public CutRope()
		{
		}

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ObiSolver _solver;

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ObiFixedUpdater _fixedUpdater;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ObiRope _rope;

		// Token: 0x04002BDD RID: 11229
		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Rigidbody _tacticalRigidbody;

		// Token: 0x04002BDE RID: 11230
		[Token(Token = "0x4002BDE")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _activeRangeMetres;

		// Token: 0x04002BDF RID: 11231
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _disableSolverAfterCutDelay;

		// Token: 0x04002BE0 RID: 11232
		[Token(Token = "0x4002BE0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DamageNode _damageNode;

		// Token: 0x04002BE1 RID: 11233
		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _doCheapCut;

		// Token: 0x04002BE2 RID: 11234
		[Token(Token = "0x4002BE2")]
		[FieldOffset(Offset = "0x58")]
		public UnityEvent OnRopeCutCheap;

		// Token: 0x04002BE3 RID: 11235
		[Token(Token = "0x4002BE3")]
		[FieldOffset(Offset = "0x60")]
		private bool _isActive;

		// Token: 0x04002BE4 RID: 11236
		[Token(Token = "0x4002BE4")]
		[FieldOffset(Offset = "0x61")]
		private bool _isCut;

		// Token: 0x04002BE5 RID: 11237
		[Token(Token = "0x4002BE5")]
		[FieldOffset(Offset = "0x62")]
		private bool _initialized;
	}
}
