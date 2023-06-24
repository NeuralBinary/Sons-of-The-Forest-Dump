using System;
using Il2CppDummyDll;

namespace Endnight.Utilities
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class SetTargetsInactive : SetTargetsActive
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700001B")]
		protected override bool ActiveValue
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0xA8B5D0", Offset = "0xA89BD0", VA = "0x180A8B5D0")]
		public SetTargetsInactive()
		{
		}
	}
}
