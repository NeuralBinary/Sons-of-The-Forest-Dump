using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x02000967 RID: 2407
	[Token(Token = "0x2000967")]
	public class PuffyBreathingVfx : MonoBehaviour
	{
		// Token: 0x060045BA RID: 17850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BA")]
		[Address(RVA = "0x3669790", Offset = "0x3667D90", VA = "0x183669790")]
		private void OnValidate()
		{
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BB")]
		[Address(RVA = "0x3669AA0", Offset = "0x36680A0", VA = "0x183669AA0")]
		private void Update()
		{
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x00015528 File Offset: 0x00013728
		[Token(Token = "0x60045BC")]
		[Address(RVA = "0x3669C00", Offset = "0x3668200", VA = "0x183669C00")]
		private float GetStrength()
		{
			return 0f;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60045BD")]
		[Address(RVA = "0x3669E00", Offset = "0x3668400", VA = "0x183669E00")]
		public PuffyBreathingVfx()
		{
		}

		// Token: 0x04004844 RID: 18500
		[Token(Token = "0x4004844")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BlendShapeManager _manager;

		// Token: 0x04004845 RID: 18501
		[Token(Token = "0x4004845")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailStatsManager _statsManager;

		// Token: 0x04004846 RID: 18502
		[Token(Token = "0x4004846")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x04004847 RID: 18503
		[Token(Token = "0x4004847")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x04004848 RID: 18504
		[Token(Token = "0x4004848")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _speedMultiplier;

		// Token: 0x04004849 RID: 18505
		[Token(Token = "0x4004849")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[FormerlySerializedAs("_breathingStrengthSpeed")]
		private float _breathingStrengthChangeSpeed;

		// Token: 0x0400484A RID: 18506
		[Token(Token = "0x400484A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<PuffyBlendShapeAnimation> _animations;

		// Token: 0x0400484B RID: 18507
		[Token(Token = "0x400484B")]
		[FieldOffset(Offset = "0x50")]
		private float _strengthGoal;

		// Token: 0x0400484C RID: 18508
		[Token(Token = "0x400484C")]
		[FieldOffset(Offset = "0x54")]
		private float _currentStrength;
	}
}
