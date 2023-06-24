using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Types
{
	// Token: 0x02000073 RID: 115
	[Token(Token = "0x2000073")]
	public abstract class SingletonBoltBehaviour<T> : MonoBehaviour where T : MonoBehaviour
	{
		// Token: 0x0600028F RID: 655
		[Token(Token = "0x600028F")]
		public abstract void TransferControlTo(T newInstance);

		// Token: 0x06000290 RID: 656 RVA: 0x00003450 File Offset: 0x00001650
		[Token(Token = "0x6000290")]
		public static bool TryGetInstance(out T result)
		{
			return default(bool);
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		private void Awake()
		{
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00003468 File Offset: 0x00001668
		[Token(Token = "0x6000292")]
		private bool CheckDestroy(SingletonBoltBehaviour<T> newBehaviour)
		{
			return default(bool);
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		protected SingletonBoltBehaviour()
		{
		}

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x0")]
		protected static SingletonBoltBehaviour<T> _instance;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x0")]
		private static BoltEntity _entity;
	}
}
