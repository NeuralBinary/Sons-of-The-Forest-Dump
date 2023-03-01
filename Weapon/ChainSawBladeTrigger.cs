using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000834 RID: 2100
	[Token(Token = "0x2000834")]
	[AddComponentMenu("Sons/Weapon/ChainSawBladeTrigger")]
	public class ChainSawBladeTrigger : MonoBehaviour
	{
		// Token: 0x060037F4 RID: 14324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F4")]
		[Address(RVA = "0x2EB3BE0", Offset = "0x2EB2BE0", VA = "0x182EB3BE0")]
		private void OnValidate()
		{
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x00010548 File Offset: 0x0000E748
		[Token(Token = "0x60037F5")]
		[Address(RVA = "0x2EB3EC0", Offset = "0x2EB2EC0", VA = "0x182EB3EC0")]
		private bool ValidCollider(Collider other)
		{
			return default(bool);
		}

		// Token: 0x060037F6 RID: 14326 RVA: 0x00010560 File Offset: 0x0000E760
		[Token(Token = "0x60037F6")]
		[Address(RVA = "0x2EB38C0", Offset = "0x2EB28C0", VA = "0x182EB38C0")]
		private bool IsWood(Collider other)
		{
			return default(bool);
		}

		// Token: 0x060037F7 RID: 14327 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F7")]
		[Address(RVA = "0x2EB3940", Offset = "0x2EB2940", VA = "0x182EB3940")]
		private void OnDisable()
		{
		}

		// Token: 0x060037F8 RID: 14328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F8")]
		[Address(RVA = "0x2EB39A0", Offset = "0x2EB29A0", VA = "0x182EB39A0")]
		private void OnTriggerEnter(Collider other)
		{
		}

		// Token: 0x060037F9 RID: 14329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037F9")]
		[Address(RVA = "0x2EB3B80", Offset = "0x2EB2B80", VA = "0x182EB3B80")]
		private void OnTriggerExit(Collider other)
		{
		}

		// Token: 0x060037FA RID: 14330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FA")]
		[Address(RVA = "0x2EB3C80", Offset = "0x2EB2C80", VA = "0x182EB3C80")]
		private void UpdateOverlap(Collider other)
		{
		}

		// Token: 0x060037FB RID: 14331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FB")]
		[Address(RVA = "0x2EB3D20", Offset = "0x2EB2D20", VA = "0x182EB3D20")]
		private void Update()
		{
		}

		// Token: 0x060037FC RID: 14332 RVA: 0x00010578 File Offset: 0x0000E778
		[Token(Token = "0x60037FC")]
		[Address(RVA = "0x2EB3880", Offset = "0x2EB2880", VA = "0x182EB3880")]
		public bool IsCuttingFlesh()
		{
			return default(bool);
		}

		// Token: 0x060037FD RID: 14333 RVA: 0x00010590 File Offset: 0x0000E790
		[Token(Token = "0x60037FD")]
		[Address(RVA = "0x1D46A20", Offset = "0x1D45A20", VA = "0x181D46A20")]
		public bool IsCuttingTree()
		{
			return default(bool);
		}

		// Token: 0x060037FE RID: 14334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x2EB3F40", Offset = "0x2EB2F40", VA = "0x182EB3F40")]
		public ChainSawBladeTrigger()
		{
		}

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Collider _bladeCollider;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x28")]
		private readonly List<Collider> _activeColliders;

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x30")]
		private float _cuttingFleshTime;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x34")]
		private bool _cuttingTree;

		// Token: 0x04002FEB RID: 12267
		[Token(Token = "0x4002FEB")]
		[FieldOffset(Offset = "0x35")]
		private bool _cuttingFlesh;
	}
}
