using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Ballistics
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[AddComponentMenu("Ballistics/Ballistic Object")]
	public class BallisticObject : MonoBehaviour
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x904220", Offset = "0x902820", VA = "0x180904220", Slot = "4")]
		public virtual void SurfaceImpact(SurfaceImpactInfo surfaceImpactInfo)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x9042B0", Offset = "0x9028B0", VA = "0x1809042B0", Slot = "5")]
		public virtual void Impact(ImpactInfo impactInfo)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BallisticObject()
		{
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public BallisticMaterial ballisticMaterial;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		public OnSurfaceImpactEvent OnSurfaceImpact;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		public OnImpactEvent OnImpact;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x38")]
		private bool _checkedForRigidbody;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody _rigidbody;
	}
}
