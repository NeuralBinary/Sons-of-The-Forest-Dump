using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000168 RID: 360
	[Token(Token = "0x2000168")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Rigidbody2D))]
	public class ObiRigidbody2D : ObiRigidbodyBase
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x27D2330", Offset = "0x27D0930", VA = "0x1827D2330", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x27D2530", Offset = "0x27D0B30", VA = "0x1827D2530")]
		private void UpdateKinematicVelocities(float stepTime)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x27D29B0", Offset = "0x27D0FB0", VA = "0x1827D29B0", Slot = "5")]
		public override void UpdateIfNeeded(float stepTime)
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x27D2B40", Offset = "0x27D1140", VA = "0x1827D2B40", Slot = "6")]
		public override void UpdateVelocities(Vector3 linearDelta, Vector3 angularDelta)
		{
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ObiRigidbody2D()
		{
		}

		// Token: 0x040005F9 RID: 1529
		[Token(Token = "0x40005F9")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody2D unityRigidbody;

		// Token: 0x040005FA RID: 1530
		[Token(Token = "0x40005FA")]
		[FieldOffset(Offset = "0x38")]
		private Quaternion prevRotation;

		// Token: 0x040005FB RID: 1531
		[Token(Token = "0x40005FB")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 prevPosition;
	}
}
