using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[RequireComponent(typeof(BoltEntity))]
	public abstract class BoltEntityBehaviourWrapper<TState> : EntityBehaviour<TState> where TState : IState
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002130 File Offset: 0x00000330
		[Token(Token = "0x17000003")]
		public bool IsServer
		{
			[Token(Token = "0x6000046")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x17000004")]
		public bool IsClient
		{
			[Token(Token = "0x6000047")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x17000005")]
		public bool IsBoltEntityAttached
		{
			[Token(Token = "0x6000048")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x17000006")]
		public bool IsBoltEntityStateValid
		{
			[Token(Token = "0x6000049")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x17000007")]
		public bool IsBoltEntityOwner
		{
			[Token(Token = "0x600004A")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600004B RID: 75 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x17000008")]
		public bool IsOfflineOrOwner
		{
			[Token(Token = "0x600004B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600004C RID: 76 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x17000009")]
		public bool IsOfflineOrServer
		{
			[Token(Token = "0x600004C")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000021D8 File Offset: 0x000003D8
		[Token(Token = "0x1700000A")]
		public bool IsBoltEntityLocallyControlled
		{
			[Token(Token = "0x600004D")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000B")]
		public TState BoltEntityState
		{
			[Token(Token = "0x600004E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000021F0 File Offset: 0x000003F0
		[Token(Token = "0x600004F")]
		protected bool TryAttachBoltEntity()
		{
			return default(bool);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		protected void TryAttachBoltEntityIfServer()
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		private void DelayedAttachedIfServer()
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002208 File Offset: 0x00000408
		[Token(Token = "0x6000052")]
		protected bool DestroyIfClient()
		{
			return default(bool);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		protected BoltEntityBehaviourWrapper()
		{
		}

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0x0")]
		private bool _isAttached;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0x0")]
		private bool _stateIsValid;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0x0")]
		private bool _isLocallyControlled;
	}
}
