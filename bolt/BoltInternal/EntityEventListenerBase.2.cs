using System;
using Bolt;
using Il2CppDummyDll;

namespace BoltInternal
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[Documentation(Alias = "Bolt.EntityEventListener<TState>")]
	public abstract class EntityEventListenerBase<TState> : EntityEventListenerBase
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000A4")]
		public TState state
		{
			[Token(Token = "0x6000352")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		protected EntityEventListenerBase()
		{
		}
	}
}
