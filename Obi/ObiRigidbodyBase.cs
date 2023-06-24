using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000169 RID: 361
	[Token(Token = "0x2000169")]
	[ExecuteInEditMode]
	public abstract class ObiRigidbodyBase : MonoBehaviour
	{
		// Token: 0x06000715 RID: 1813 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x27D2CC0", Offset = "0x27D12C0", VA = "0x1827D2CC0", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x27D2F60", Offset = "0x27D1560", VA = "0x1827D2F60")]
		public void OnDestroy()
		{
		}

		// Token: 0x06000717 RID: 1815
		[Token(Token = "0x6000717")]
		public abstract void UpdateIfNeeded(float stepTime);

		// Token: 0x06000718 RID: 1816
		[Token(Token = "0x6000718")]
		public abstract void UpdateVelocities(Vector3 linearDelta, Vector3 angularDelta);

		// Token: 0x06000719 RID: 1817 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected ObiRigidbodyBase()
		{
		}

		// Token: 0x040005FC RID: 1532
		[Token(Token = "0x40005FC")]
		[FieldOffset(Offset = "0x20")]
		public bool kinematicForParticles;

		// Token: 0x040005FD RID: 1533
		[Token(Token = "0x40005FD")]
		[FieldOffset(Offset = "0x28")]
		public ObiRigidbodyHandle handle;
	}
}
