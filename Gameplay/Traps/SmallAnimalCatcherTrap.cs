using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x020006F1 RID: 1777
	[Token(Token = "0x20006F1")]
	[AddComponentMenu("Sons/Gameplay/Traps/SmallAnimalCatcherTrap")]
	public class SmallAnimalCatcherTrap : BaseTrapController
	{
		// Token: 0x06002DD8 RID: 11736 RVA: 0x0000D068 File Offset: 0x0000B268
		[Token(Token = "0x6002DD8")]
		[Address(RVA = "0x2E144D0", Offset = "0x2E134D0", VA = "0x182E144D0", Slot = "26")]
		protected override bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DD9")]
		[Address(RVA = "0x2E141F0", Offset = "0x2E131F0", VA = "0x182E141F0")]
		private void CheckKillActors()
		{
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDA")]
		[Address(RVA = "0x2E14490", Offset = "0x2E13490", VA = "0x182E14490", Slot = "27")]
		protected override void OnReset()
		{
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DDB")]
		[Address(RVA = "0x2E03CB0", Offset = "0x2E02CB0", VA = "0x182E03CB0")]
		public SmallAnimalCatcherTrap()
		{
		}

		// Token: 0x040028E0 RID: 10464
		[Token(Token = "0x40028E0")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SphereCollider _killArea;

		// Token: 0x040028E1 RID: 10465
		[Token(Token = "0x40028E1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TrapBaitStimuli _baitStimuli;
	}
}
