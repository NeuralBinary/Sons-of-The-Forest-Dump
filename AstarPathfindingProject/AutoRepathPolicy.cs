using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Pathfinding
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[Serializable]
	public class AutoRepathPolicy
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x000039BC File Offset: 0x00001BBC
		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x649F80", Offset = "0x648580", VA = "0x180649F80", Slot = "4")]
		public virtual bool ShouldRecalculatePath(Vector3 position, float radius, Vector3 destination)
		{
			return default(bool);
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x64A140", Offset = "0x648740", VA = "0x18064A140", Slot = "5")]
		public virtual void Reset()
		{
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x64A150", Offset = "0x648750", VA = "0x18064A150", Slot = "6")]
		public virtual void DidRecalculatePath(Vector3 destination)
		{
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x64A1C0", Offset = "0x6487C0", VA = "0x18064A1C0")]
		public void DrawGizmos(Vector3 position, float radius)
		{
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x64A340", Offset = "0x648940", VA = "0x18064A340")]
		public AutoRepathPolicy()
		{
		}

		// Token: 0x0400021B RID: 539
		[Token(Token = "0x400021B")]
		[FieldOffset(Offset = "0x10")]
		public AutoRepathPolicy.Mode mode;

		// Token: 0x0400021C RID: 540
		[Token(Token = "0x400021C")]
		[FieldOffset(Offset = "0x14")]
		[FormerlySerializedAs("interval")]
		public float period;

		// Token: 0x0400021D RID: 541
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x18")]
		public float sensitivity;

		// Token: 0x0400021E RID: 542
		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x1C")]
		[FormerlySerializedAs("maximumInterval")]
		public float maximumPeriod;

		// Token: 0x0400021F RID: 543
		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x20")]
		public bool visualizeSensitivity;

		// Token: 0x04000220 RID: 544
		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 lastDestination;

		// Token: 0x04000221 RID: 545
		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x30")]
		private float lastRepathTime;

		// Token: 0x02000052 RID: 82
		[Token(Token = "0x2000052")]
		public enum Mode
		{
			// Token: 0x04000223 RID: 547
			[Token(Token = "0x4000223")]
			Never,
			// Token: 0x04000224 RID: 548
			[Token(Token = "0x4000224")]
			EveryNSeconds,
			// Token: 0x04000225 RID: 549
			[Token(Token = "0x4000225")]
			Dynamic
		}
	}
}
