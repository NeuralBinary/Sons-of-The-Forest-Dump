using System;
using FMODUnity;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay.Traps
{
	// Token: 0x0200083F RID: 2111
	[Token(Token = "0x200083F")]
	[AddComponentMenu("Sons/Gameplay/Traps/SpringTrap")]
	public class SpringTrap : BaseTrapController
	{
		// Token: 0x06003BCA RID: 15306 RVA: 0x000122D0 File Offset: 0x000104D0
		[Token(Token = "0x6003BCA")]
		[Address(RVA = "0x3595680", Offset = "0x3593C80", VA = "0x183595680")]
		private Vector3 CenterPosition()
		{
			return default(Vector3);
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BCB")]
		[Address(RVA = "0x3595810", Offset = "0x3593E10", VA = "0x183595810", Slot = "26")]
		protected override void TriggerTrapAudio()
		{
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x000122E8 File Offset: 0x000104E8
		[Token(Token = "0x6003BCC")]
		[Address(RVA = "0x3595950", Offset = "0x3593F50", VA = "0x183595950", Slot = "27")]
		protected override bool TryTriggerTrapMechanics()
		{
			return default(bool);
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x00012300 File Offset: 0x00010500
		[Token(Token = "0x6003BCD")]
		[Address(RVA = "0x3595F40", Offset = "0x3594540", VA = "0x183595F40")]
		private static bool IsBigActor(VailActor actor)
		{
			return default(bool);
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BCE")]
		[Address(RVA = "0x3595FD0", Offset = "0x35945D0", VA = "0x183595FD0")]
		private void HitVailActor(VailActor actor)
		{
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BCF")]
		[Address(RVA = "0x3596210", Offset = "0x3594810", VA = "0x183596210")]
		public SpringTrap()
		{
		}

		// Token: 0x040032C1 RID: 12993
		[Token(Token = "0x40032C1")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private SphereCollider _trigger;

		// Token: 0x040032C2 RID: 12994
		[Token(Token = "0x40032C2")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Vector3 _force;

		// Token: 0x040032C3 RID: 12995
		[Token(Token = "0x40032C3")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private ForceMode _forceMode;

		// Token: 0x040032C4 RID: 12996
		[Token(Token = "0x40032C4")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _playerJumpMultiplier;

		// Token: 0x040032C5 RID: 12997
		[Token(Token = "0x40032C5")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _bigActorUpForce;

		// Token: 0x040032C6 RID: 12998
		[Token(Token = "0x40032C6")]
		[FieldOffset(Offset = "0xA0")]
		[EventRef]
		[SerializeField]
		private string _explosionSfxEvent;
	}
}
