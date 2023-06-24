using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000076 RID: 118
	[Token(Token = "0x2000076")]
	internal struct EventUnreliable
	{
		// Token: 0x06000489 RID: 1161 RVA: 0x000036C0 File Offset: 0x000018C0
		[Token(Token = "0x6000489")]
		[Address(RVA = "0x8E3C80", Offset = "0x8E2280", VA = "0x1808E3C80")]
		public static EventUnreliable Wrap(Event ev)
		{
			return default(EventUnreliable);
		}

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x0")]
		public bool Skipped;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x8")]
		public Event NetworkEvent;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x10")]
		public float Priority;

		// Token: 0x02000077 RID: 119
		[Token(Token = "0x2000077")]
		internal class PriorityComparer : IComparer<EventUnreliable>
		{
			// Token: 0x0600048A RID: 1162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600048A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			private PriorityComparer()
			{
			}

			// Token: 0x0600048B RID: 1163 RVA: 0x000036D8 File Offset: 0x000018D8
			[Token(Token = "0x600048B")]
			[Address(RVA = "0x8E3CE0", Offset = "0x8E22E0", VA = "0x1808E3CE0", Slot = "4")]
			private int Compare(EventUnreliable x, EventUnreliable y)
			{
				return 0;
			}

			// Token: 0x04000206 RID: 518
			[Token(Token = "0x4000206")]
			[FieldOffset(Offset = "0x0")]
			public static readonly EventUnreliable.PriorityComparer Instance;
		}
	}
}
