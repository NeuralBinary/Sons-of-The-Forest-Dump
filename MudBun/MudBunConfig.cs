using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MudBun
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	public class MudBunConfig : ScriptableObject
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700005F")]
		public static MudBunConfig Instance
		{
			[Token(Token = "0x60002A8")]
			[Address(RVA = "0x23C8690", Offset = "0x23C6C90", VA = "0x1823C8690")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x23C8880", Offset = "0x23C6E80", VA = "0x1823C8880")]
		public MudBunConfig()
		{
		}

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x0")]
		private static MudBunConfig s_instance;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x18")]
		public bool CheckCompatibility;
	}
}
