using System;
using Il2CppDummyDll;

namespace PathologicalGames
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public struct HitEffect
	{
		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x28CF4B0", Offset = "0x28CDAB0", VA = "0x1828CF4B0")]
		public HitEffect(HitEffect hitEffect)
		{
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000257 RID: 599 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000062")]
		public float deltaDurationTime
		{
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x28CF520", Offset = "0x28CDB20", VA = "0x1828CF520")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x28CF5A0", Offset = "0x28CDBA0", VA = "0x1828CF5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x0")]
		public string name;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x8")]
		public float value;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0xC")]
		public float duration;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		public float hitTime;
	}
}
