using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000866 RID: 2150
	[Token(Token = "0x2000866")]
	[AddComponentMenu("Sons/Items/SeveredHeadController")]
	public class SeveredHeadController : HeldControllerBase
	{
		// Token: 0x06003990 RID: 14736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003990")]
		[Address(RVA = "0x2EDC4D0", Offset = "0x2EDB4D0", VA = "0x182EDC4D0", Slot = "10")]
		protected virtual void Update()
		{
		}

		// Token: 0x06003991 RID: 14737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003991")]
		[Address(RVA = "0x2EDC110", Offset = "0x2EDB110", VA = "0x182EDC110")]
		private void CheckFireInput()
		{
		}

		// Token: 0x06003992 RID: 14738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003992")]
		[Address(RVA = "0x2EDC330", Offset = "0x2EDB330", VA = "0x182EDC330")]
		private void HoldHead()
		{
		}

		// Token: 0x06003993 RID: 14739 RVA: 0x00010DE8 File Offset: 0x0000EFE8
		[Token(Token = "0x6003993")]
		[Address(RVA = "0x2EDC400", Offset = "0x2EDB400", VA = "0x182EDC400", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003994 RID: 14740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003994")]
		[Address(RVA = "0x2EC61C0", Offset = "0x2EC51C0", VA = "0x182EC61C0")]
		public SeveredHeadController()
		{
		}

		// Token: 0x0400310D RID: 12557
		[Token(Token = "0x400310D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private EventStimuli _holdEvent;

		// Token: 0x0400310E RID: 12558
		[Token(Token = "0x400310E")]
		[FieldOffset(Offset = "0x78")]
		private bool _currentReloadHasTriggered;
	}
}
