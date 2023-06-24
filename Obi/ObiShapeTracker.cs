using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200014E RID: 334
	[Token(Token = "0x200014E")]
	public abstract class ObiShapeTracker
	{
		// Token: 0x06000691 RID: 1681 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000691")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public virtual void Destroy()
		{
		}

		// Token: 0x06000692 RID: 1682
		[Token(Token = "0x6000692")]
		public abstract bool UpdateIfNeeded();

		// Token: 0x06000693 RID: 1683 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000693")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected ObiShapeTracker()
		{
		}

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		[FieldOffset(Offset = "0x10")]
		protected ObiColliderBase source;

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		[FieldOffset(Offset = "0x18")]
		protected Component collider;
	}
}
