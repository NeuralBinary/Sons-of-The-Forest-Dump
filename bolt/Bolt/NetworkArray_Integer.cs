using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000091 RID: 145
	[Token(Token = "0x2000091")]
	[Documentation]
	public class NetworkArray_Integer : NetworkArray_Values<int>
	{
		// Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x8EAE80", Offset = "0x8E9480", VA = "0x1808EAE80")]
		internal NetworkArray_Integer(int length, int stride)
		{
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x000038B8 File Offset: 0x00001AB8
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x8EAF60", Offset = "0x8E9560", VA = "0x1808EAF60", Slot = "7")]
		protected override int GetValue(int index)
		{
			return 0;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x000038D0 File Offset: 0x00001AD0
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x8EAFB0", Offset = "0x8E95B0", VA = "0x1808EAFB0", Slot = "8")]
		protected override bool SetValue(int index, int value)
		{
			return default(bool);
		}
	}
}
