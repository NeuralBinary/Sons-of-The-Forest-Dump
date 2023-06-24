using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000764 RID: 1892
	[Token(Token = "0x2000764")]
	[AddComponentMenu("Sons/Gameplay/Footstep Anim Events")]
	public class FootstepAnimEvents : MonoBehaviour, VailActor.IFootstepInterface
	{
		// Token: 0x0600332A RID: 13098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332A")]
		[Address(RVA = "0x34B26E0", Offset = "0x34B0CE0", VA = "0x1834B26E0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600332B RID: 13099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332B")]
		[Address(RVA = "0x34B2810", Offset = "0x34B0E10", VA = "0x1834B2810")]
		private void PlayStep(Transform footTransform, FootstepManager.SoundType soundType)
		{
		}

		// Token: 0x0600332C RID: 13100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332C")]
		[Address(RVA = "0x34B2B20", Offset = "0x34B1120", VA = "0x1834B2B20", Slot = "4")]
		public void PlayLandSound(Vector3 position, float fallSpeed)
		{
		}

		// Token: 0x0600332D RID: 13101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332D")]
		[Address(RVA = "0x34B2D50", Offset = "0x34B1350", VA = "0x1834B2D50")]
		public void StepLeft()
		{
		}

		// Token: 0x0600332E RID: 13102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332E")]
		[Address(RVA = "0x34B2D60", Offset = "0x34B1360", VA = "0x1834B2D60")]
		public void StepRight()
		{
		}

		// Token: 0x0600332F RID: 13103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600332F")]
		[Address(RVA = "0x34B2D50", Offset = "0x34B1350", VA = "0x1834B2D50")]
		public void WalkStepLeft()
		{
		}

		// Token: 0x06003330 RID: 13104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003330")]
		[Address(RVA = "0x34B2D60", Offset = "0x34B1360", VA = "0x1834B2D60")]
		public void WalkStepRight()
		{
		}

		// Token: 0x06003331 RID: 13105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003331")]
		[Address(RVA = "0x34B2D70", Offset = "0x34B1370", VA = "0x1834B2D70")]
		public void SneakStepLeft()
		{
		}

		// Token: 0x06003332 RID: 13106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003332")]
		[Address(RVA = "0x34B2D80", Offset = "0x34B1380", VA = "0x1834B2D80")]
		public void SneakStepRight()
		{
		}

		// Token: 0x06003333 RID: 13107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003333")]
		[Address(RVA = "0x34B2D90", Offset = "0x34B1390", VA = "0x1834B2D90")]
		public void RunStepLeft()
		{
		}

		// Token: 0x06003334 RID: 13108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003334")]
		[Address(RVA = "0x34B2DA0", Offset = "0x34B13A0", VA = "0x1834B2DA0")]
		public void RunStepRight()
		{
		}

		// Token: 0x06003335 RID: 13109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003335")]
		[Address(RVA = "0x34B2DB0", Offset = "0x34B13B0", VA = "0x1834B2DB0")]
		public void OnLanded()
		{
		}

		// Token: 0x06003336 RID: 13110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003336")]
		[Address(RVA = "0x34B2EA0", Offset = "0x34B14A0", VA = "0x1834B2EA0")]
		public FootstepAnimEvents()
		{
		}

		// Token: 0x04002C1F RID: 11295
		[Token(Token = "0x4002C1F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FootstepManager.FootstepClassType _footstepClass;

		// Token: 0x04002C20 RID: 11296
		[Token(Token = "0x4002C20")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _leftFoot;

		// Token: 0x04002C21 RID: 11297
		[Token(Token = "0x4002C21")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _rightFoot;

		// Token: 0x04002C22 RID: 11298
		[Token(Token = "0x4002C22")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VailActor _actorSource;

		// Token: 0x04002C23 RID: 11299
		[Token(Token = "0x4002C23")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _minLandSoundSpeed;
	}
}
