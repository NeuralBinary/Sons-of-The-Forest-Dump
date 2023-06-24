using System;
using Il2CppDummyDll;
using Valve.VR.InteractionSystem;

namespace TheForest.VR.InteractionSystem
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	public class Player : Player
	{
		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000358")]
		public new static Player instance
		{
			[Token(Token = "0x6001908")]
			[Address(RVA = "0x328C850", Offset = "0x328AE50", VA = "0x18328C850")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001909 RID: 6409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001909")]
		[Address(RVA = "0x328DAE0", Offset = "0x328C0E0", VA = "0x18328DAE0")]
		public Player()
		{
		}

		// Token: 0x040018A1 RID: 6305
		[Token(Token = "0x40018A1")]
		[FieldOffset(Offset = "0x0")]
		private static Player _instance;
	}
}
