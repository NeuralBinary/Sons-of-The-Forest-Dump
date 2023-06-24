using System;
using Il2CppDummyDll;
using UnityEngine;

namespace PathologicalGames
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[RequireComponent(typeof(TargetTracker))]
	[AddComponentMenu("Path-o-logical/TargetPro/Modifier - Line of Sight")]
	public class LineOfSightModifier : MonoBehaviour
	{
		// Token: 0x060001C5 RID: 453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C5")]
		[Address(RVA = "0x28C6B60", Offset = "0x28C5160", VA = "0x1828C6B60")]
		private void Awake()
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x28C6F50", Offset = "0x28C5550", VA = "0x1828C6F50")]
		private void FilterTrackerTargetList(TargetList targets)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x28C7090", Offset = "0x28C5690", VA = "0x1828C7090")]
		private void FilterFireTargetList(TargetList targets)
		{
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x28C72E0", Offset = "0x28C58E0", VA = "0x1828C72E0")]
		private void FilterTargetList(TargetList targets, LayerMask mask, Vector3 fromPos, Color debugLineColor)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x28C7AC0", Offset = "0x28C60C0", VA = "0x1828C7AC0")]
		public LineOfSightModifier()
		{
		}

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x20")]
		public LayerMask targetTrackerLayerMask;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x24")]
		public LayerMask fireControllerLayerMask;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x28")]
		public LineOfSightModifier.TEST_MODE testMode;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x2C")]
		public float radius;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x30")]
		public DEBUG_LEVELS debugLevel;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x38")]
		[HideInInspector]
		public TargetTracker tracker;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		public FireController fireCtrl;

		// Token: 0x0200003C RID: 60
		[Token(Token = "0x200003C")]
		public enum TEST_MODE
		{
			// Token: 0x040000EB RID: 235
			[Token(Token = "0x40000EB")]
			SinglePoint,
			// Token: 0x040000EC RID: 236
			[Token(Token = "0x40000EC")]
			SixPoint
		}
	}
}
