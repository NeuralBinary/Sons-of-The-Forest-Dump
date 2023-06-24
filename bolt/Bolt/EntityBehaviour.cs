using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Bolt
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[Documentation]
	public abstract class EntityBehaviour : MonoBehaviour, IEntityBehaviour
	{
		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000CD")]
		public BoltEntity entity
		{
			[Token(Token = "0x6000407")]
			[Address(RVA = "0x8DDCB0", Offset = "0x8DC2B0", VA = "0x1808DDCB0", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000408")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000409")]
		[Address(RVA = "0x8DDE60", Offset = "0x8DC460", VA = "0x1808DDE60")]
		private BoltEntity FindEntityInParents()
		{
			return null;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00003408 File Offset: 0x00001608
		[Token(Token = "0x170000CE")]
		public bool HasEntity
		{
			[Token(Token = "0x600040A")]
			[Address(RVA = "0x8DE100", Offset = "0x8DC700", VA = "0x1808DE100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040B")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "15")]
		public virtual void Initialized()
		{
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		public virtual void Attached()
		{
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		public virtual void Detached()
		{
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "18")]
		public virtual void SimulateOwner()
		{
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600040F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "19")]
		public virtual void SimulateController()
		{
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000410")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "20")]
		public virtual void ControlGained()
		{
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000411")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "21")]
		public virtual void ControlLost()
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000412")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "22")]
		public virtual void MissingCommand(Command previous)
		{
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000413")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "23")]
		public virtual void ExecuteCommand(Command command, bool resetState)
		{
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000414")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected EntityBehaviour()
		{
		}

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x20")]
		internal BoltEntity _entity;
	}
}
