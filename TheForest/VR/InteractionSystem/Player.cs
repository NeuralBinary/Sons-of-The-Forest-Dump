using System;
using Il2CppDummyDll;
using Valve.VR.InteractionSystem;

namespace TheForest.VR.InteractionSystem
{
	// Token: 0x020003B0 RID: 944
	[Token(Token = "0x20003B0")]
	public class Player : Player
	{
		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000350")]
		public static Player instance
		{
			[Token(Token = "0x60018CD")]
			[Address(RVA = "0x2CCF9D0", Offset = "0x2CCE9D0", VA = "0x182CCF9D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x2CD1740", Offset = "0x2CD0740", VA = "0x182CD1740")]
		public Player()
		{
		}

		// Token: 0x04001882 RID: 6274
		[Token(Token = "0x4001882")]
		[FieldOffset(Offset = "0x0")]
		private static Player _instance;
	}
}
