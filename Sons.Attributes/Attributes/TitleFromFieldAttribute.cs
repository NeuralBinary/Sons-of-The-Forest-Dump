using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Attributes
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class TitleFromFieldAttribute : PropertyAttribute
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public TitleFromFieldAttribute(string ElementTitleVar)
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x18")]
		public string Varname;
	}
}
