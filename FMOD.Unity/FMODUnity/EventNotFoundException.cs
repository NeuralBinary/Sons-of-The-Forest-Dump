using System;
using Il2CppDummyDll;

namespace FMODUnity
{
	// Token: 0x020000F4 RID: 244
	[Token(Token = "0x20000F4")]
	public class EventNotFoundException : Exception
	{
		// Token: 0x06000671 RID: 1649 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000671")]
		[Address(RVA = "0xB50CA0", Offset = "0xB4F2A0", VA = "0x180B50CA0")]
		public EventNotFoundException(string path)
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000672")]
		[Address(RVA = "0xB50D90", Offset = "0xB4F390", VA = "0x180B50D90")]
		public EventNotFoundException(Guid guid)
		{
		}

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[FieldOffset(Offset = "0x90")]
		public Guid Guid;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[FieldOffset(Offset = "0xA0")]
		public string Path;
	}
}
