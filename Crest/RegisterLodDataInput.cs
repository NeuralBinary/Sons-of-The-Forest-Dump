using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[ExecuteAlways]
	public abstract class RegisterLodDataInput<LodDataType> : RegisterLodDataInputBase where LodDataType : LodDataMgr
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001CA RID: 458
		[Token(Token = "0x1700006A")]
		protected abstract Color GizmoColor { [Token(Token = "0x60001CA")] get; }

		// Token: 0x060001CB RID: 459 RVA: 0x00002B50 File Offset: 0x00000D50
		[Token(Token = "0x60001CB")]
		private bool GetQueue(out int queue)
		{
			return default(bool);
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CC")]
		protected virtual void OnEnable()
		{
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CD")]
		protected virtual void OnDisable()
		{
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CE")]
		protected override void Update()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		protected RegisterLodDataInput()
		{
		}

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private bool _disableRenderer;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x0")]
		private int _registeredQueueValue;
	}
}
