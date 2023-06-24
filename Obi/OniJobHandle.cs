using System;
using Il2CppDummyDll;

namespace Obi
{
	// Token: 0x02000117 RID: 279
	[Token(Token = "0x2000117")]
	public class OniJobHandle : IObiJobHandle
	{
		// Token: 0x060004FD RID: 1277 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x754960", Offset = "0x752F60", VA = "0x180754960")]
		public OniJobHandle(IntPtr pointer)
		{
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x27AE740", Offset = "0x27ACD40", VA = "0x1827AE740", Slot = "4")]
		public void Complete()
		{
		}

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x10")]
		public IntPtr pointer;
	}
}
