using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Utils
{
	// Token: 0x020004E6 RID: 1254
	[Token(Token = "0x20004E6")]
	public class GenericDistanceActivator : DistanceActivationBase
	{
		// Token: 0x060020EF RID: 8431 RVA: 0x000099D8 File Offset: 0x00007BD8
		[Token(Token = "0x60020EF")]
		[Address(RVA = "0x15771D0", Offset = "0x15757D0", VA = "0x1815771D0", Slot = "10")]
		protected override bool StartIsActive()
		{
			return default(bool);
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020F0")]
		[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10", Slot = "13")]
		public override string GetTaskName()
		{
			return null;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F1")]
		[Address(RVA = "0x331EA70", Offset = "0x331D070", VA = "0x18331EA70", Slot = "16")]
		protected override void MainThreadDeactivated()
		{
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F2")]
		[Address(RVA = "0x331EA90", Offset = "0x331D090", VA = "0x18331EA90", Slot = "17")]
		protected override void MainThreadActivated()
		{
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F3")]
		[Address(RVA = "0x331EAB0", Offset = "0x331D0B0", VA = "0x18331EAB0", Slot = "11")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060020F4 RID: 8436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020F4")]
		[Address(RVA = "0x331EAC0", Offset = "0x331D0C0", VA = "0x18331EAC0")]
		public GenericDistanceActivator()
		{
		}

		// Token: 0x04001E8D RID: 7821
		[Token(Token = "0x4001E8D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private string _taskName;

		// Token: 0x04001E8E RID: 7822
		[Token(Token = "0x4001E8E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private bool _startIsActive;

		// Token: 0x04001E8F RID: 7823
		[Token(Token = "0x4001E8F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UnityEvent _onActivatedUnityEvent;

		// Token: 0x04001E90 RID: 7824
		[Token(Token = "0x4001E90")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UnityEvent _onDeactivatedUnityEvent;
	}
}
