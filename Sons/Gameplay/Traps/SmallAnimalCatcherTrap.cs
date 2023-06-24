using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x0200083E RID: 2110
	[Token(Token = "0x200083E")]
	[AddComponentMenu("Sons/Gameplay/Traps/SmallAnimalCatcherTrap")]
	public class SmallAnimalCatcherTrap : BaseTrapController
	{
		// Token: 0x06003BC6 RID: 15302 RVA: 0x000122B8 File Offset: 0x000104B8
		[Token(Token = "0x6003BC6")]
		[Address(RVA = "0x3595100", Offset = "0x3593700", VA = "0x183595100", Slot = "27")]
		protected override bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC7")]
		[Address(RVA = "0x35951C0", Offset = "0x35937C0", VA = "0x1835951C0")]
		private void CheckKillActors()
		{
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC8")]
		[Address(RVA = "0x35955D0", Offset = "0x3593BD0", VA = "0x1835955D0", Slot = "28")]
		protected override void OnReset()
		{
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BC9")]
		[Address(RVA = "0x3593EE0", Offset = "0x35924E0", VA = "0x183593EE0")]
		public SmallAnimalCatcherTrap()
		{
		}

		// Token: 0x040032BF RID: 12991
		[Token(Token = "0x40032BF")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SphereCollider _killArea;

		// Token: 0x040032C0 RID: 12992
		[Token(Token = "0x40032C0")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private TrapBaitStimuli _baitStimuli;
	}
}
