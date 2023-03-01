using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000646 RID: 1606
	[Token(Token = "0x2000646")]
	[AddComponentMenu("Sons/Gameplay/Footstep Anim Events")]
	public class FootstepAnimEvents : MonoBehaviour, VailActor.IFootstepInterface
	{
		// Token: 0x06002947 RID: 10567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002947")]
		[Address(RVA = "0x2DC9A40", Offset = "0x2DC8A40", VA = "0x182DC9A40")]
		private void OnValidate()
		{
		}

		// Token: 0x06002948 RID: 10568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002948")]
		[Address(RVA = "0x2DC9C50", Offset = "0x2DC8C50", VA = "0x182DC9C50")]
		private void PlayStep(Transform footTransform, FootstepManager.SoundType soundType)
		{
		}

		// Token: 0x06002949 RID: 10569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002949")]
		[Address(RVA = "0x2DC9AE0", Offset = "0x2DC8AE0", VA = "0x182DC9AE0", Slot = "4")]
		public void PlayLandSound(Vector3 position, float fallSpeed)
		{
		}

		// Token: 0x0600294A RID: 10570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294A")]
		[Address(RVA = "0x2DC9E40", Offset = "0x2DC8E40", VA = "0x182DC9E40")]
		public void StepLeft()
		{
		}

		// Token: 0x0600294B RID: 10571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294B")]
		[Address(RVA = "0x2DC9E50", Offset = "0x2DC8E50", VA = "0x182DC9E50")]
		public void StepRight()
		{
		}

		// Token: 0x0600294C RID: 10572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294C")]
		[Address(RVA = "0x2DC9E40", Offset = "0x2DC8E40", VA = "0x182DC9E40")]
		public void WalkStepLeft()
		{
		}

		// Token: 0x0600294D RID: 10573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294D")]
		[Address(RVA = "0x2DC9E50", Offset = "0x2DC8E50", VA = "0x182DC9E50")]
		public void WalkStepRight()
		{
		}

		// Token: 0x0600294E RID: 10574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294E")]
		[Address(RVA = "0x2DC9E20", Offset = "0x2DC8E20", VA = "0x182DC9E20")]
		public void SneakStepLeft()
		{
		}

		// Token: 0x0600294F RID: 10575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600294F")]
		[Address(RVA = "0x2DC9E30", Offset = "0x2DC8E30", VA = "0x182DC9E30")]
		public void SneakStepRight()
		{
		}

		// Token: 0x06002950 RID: 10576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002950")]
		[Address(RVA = "0x2DC9E00", Offset = "0x2DC8E00", VA = "0x182DC9E00")]
		public void RunStepLeft()
		{
		}

		// Token: 0x06002951 RID: 10577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002951")]
		[Address(RVA = "0x2DC9E10", Offset = "0x2DC8E10", VA = "0x182DC9E10")]
		public void RunStepRight()
		{
		}

		// Token: 0x06002952 RID: 10578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002952")]
		[Address(RVA = "0x2DC98C0", Offset = "0x2DC88C0", VA = "0x182DC98C0")]
		public void OnLanded()
		{
		}

		// Token: 0x06002953 RID: 10579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002953")]
		[Address(RVA = "0x2DC9E60", Offset = "0x2DC8E60", VA = "0x182DC9E60")]
		public FootstepAnimEvents()
		{
		}

		// Token: 0x040024D9 RID: 9433
		[Token(Token = "0x40024D9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FootstepManager.FootstepClassType _footstepClass;

		// Token: 0x040024DA RID: 9434
		[Token(Token = "0x40024DA")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _leftFoot;

		// Token: 0x040024DB RID: 9435
		[Token(Token = "0x40024DB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _rightFoot;

		// Token: 0x040024DC RID: 9436
		[Token(Token = "0x40024DC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private VailActor _actorSource;

		// Token: 0x040024DD RID: 9437
		[Token(Token = "0x40024DD")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _minLandSoundSpeed;
	}
}
