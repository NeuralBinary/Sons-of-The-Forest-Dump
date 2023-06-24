using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	[StructLayout(2)]
	internal struct NetworkTrigger
	{
		// Token: 0x060005E9 RID: 1513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E9")]
		[Address(RVA = "0x8F56A0", Offset = "0x8F3CA0", VA = "0x1808F56A0")]
		public void Update(int frame, bool set)
		{
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[Token(Token = "0x60005EA")]
		[Address(RVA = "0x65FF70", Offset = "0x65E570", VA = "0x18065FF70")]
		public static bool operator ==(NetworkTrigger a, NetworkTrigger b)
		{
			return default(bool);
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x00003DE0 File Offset: 0x00001FE0
		[Token(Token = "0x60005EB")]
		[Address(RVA = "0x65FF90", Offset = "0x65E590", VA = "0x18065FF90")]
		public static bool operator !=(NetworkTrigger a, NetworkTrigger b)
		{
			return default(bool);
		}

		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int Frame;

		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int History;
	}
}
