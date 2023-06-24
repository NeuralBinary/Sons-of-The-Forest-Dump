using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000078 RID: 120
	[Token(Token = "0x2000078")]
	internal struct EventReliable
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x000036F0 File Offset: 0x000018F0
		[Token(Token = "0x600048D")]
		[Address(RVA = "0x8E3DE0", Offset = "0x8E23E0", VA = "0x1808E3DE0")]
		public static EventReliable Wrap(Event ev)
		{
			return default(EventReliable);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00003708 File Offset: 0x00001908
		[Token(Token = "0x600048E")]
		[Address(RVA = "0x8E3E60", Offset = "0x8E2460", VA = "0x1808E3E60")]
		public static EventReliable Wrap(Event ev, uint sequence)
		{
			return default(EventReliable);
		}

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x0")]
		public Event NetworkEvent;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x8")]
		public uint Sequence;
	}
}
