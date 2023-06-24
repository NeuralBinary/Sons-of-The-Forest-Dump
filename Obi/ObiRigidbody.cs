using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000167 RID: 359
	[Token(Token = "0x2000167")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Rigidbody))]
	public class ObiRigidbody : ObiRigidbodyBase
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x27D1AD0", Offset = "0x27D00D0", VA = "0x1827D1AD0", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x27D1CD0", Offset = "0x27D02D0", VA = "0x1827D1CD0")]
		private void UpdateKinematicVelocities(float stepTime)
		{
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x27D1EA0", Offset = "0x27D04A0", VA = "0x1827D1EA0", Slot = "5")]
		public override void UpdateIfNeeded(float stepTime)
		{
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x27D2030", Offset = "0x27D0630", VA = "0x1827D2030", Slot = "6")]
		public override void UpdateVelocities(Vector3 linearDelta, Vector3 angularDelta)
		{
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ObiRigidbody()
		{
		}

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody unityRigidbody;

		// Token: 0x040005F7 RID: 1527
		[Token(Token = "0x40005F7")]
		[FieldOffset(Offset = "0x38")]
		private Quaternion prevRotation;

		// Token: 0x040005F8 RID: 1528
		[Token(Token = "0x40005F8")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 prevPosition;
	}
}
