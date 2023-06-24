using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[Documentation(Alias = "Bolt.EntityBehaviour<TState>")]
	public abstract class EntityBehaviour<TState> : EntityBehaviour
	{
		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000CF")]
		public TState state
		{
			[Token(Token = "0x6000415")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000416")]
		protected EntityBehaviour()
		{
		}
	}
}
