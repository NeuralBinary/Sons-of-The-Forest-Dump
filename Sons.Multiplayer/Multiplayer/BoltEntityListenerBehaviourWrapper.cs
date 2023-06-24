using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	[RequireComponent(typeof(BoltEntity))]
	public abstract class BoltEntityListenerBehaviourWrapper<TState> : EntityEventListener<TState> where TState : IState
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x1700000C")]
		public bool IsServer
		{
			[Token(Token = "0x6000062")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x1700000D")]
		public bool IsClient
		{
			[Token(Token = "0x6000063")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x1700000E")]
		public bool IsBoltEntityAttached
		{
			[Token(Token = "0x6000064")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000065 RID: 101 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x1700000F")]
		public bool IsBoltEntityStateValid
		{
			[Token(Token = "0x6000065")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000066 RID: 102 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x17000010")]
		public bool IsBoltEntityOwner
		{
			[Token(Token = "0x6000066")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000067 RID: 103 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x17000011")]
		public bool IsOfflineOrOwner
		{
			[Token(Token = "0x6000067")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000068 RID: 104 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x17000012")]
		public bool IsOfflineOrServer
		{
			[Token(Token = "0x6000068")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000069 RID: 105 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x17000013")]
		public bool IsBoltEntityLocallyControlled
		{
			[Token(Token = "0x6000069")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000014")]
		public TState BoltEntityState
		{
			[Token(Token = "0x600006A")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600006B")]
		protected bool TryAttachBoltEntity()
		{
			return default(bool);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006C")]
		protected void TryAttachBoltEntityIfServer()
		{
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006D")]
		private void DelayedAttachedIfServer()
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002328 File Offset: 0x00000528
		[Token(Token = "0x600006E")]
		protected bool DestroyIfClient()
		{
			return default(bool);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600006F")]
		protected BoltEntityListenerBehaviourWrapper()
		{
		}

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x0")]
		private bool _isAttached;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x0")]
		private bool _stateIsValid;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x0")]
		private bool _isLocallyControlled;
	}
}
