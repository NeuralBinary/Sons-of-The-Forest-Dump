using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Animation.BlendShapes
{
	// Token: 0x020008E6 RID: 2278
	[Token(Token = "0x20008E6")]
	public class PuffyBreathingVfx : MonoBehaviour
	{
		// Token: 0x06003DE6 RID: 15846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE6")]
		[Address(RVA = "0x2F23230", Offset = "0x2F22230", VA = "0x182F23230")]
		private void OnValidate()
		{
		}

		// Token: 0x06003DE7 RID: 15847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE7")]
		[Address(RVA = "0x2F23410", Offset = "0x2F22410", VA = "0x182F23410")]
		private void Update()
		{
		}

		// Token: 0x06003DE8 RID: 15848 RVA: 0x00012348 File Offset: 0x00010548
		[Token(Token = "0x6003DE8")]
		[Address(RVA = "0x2F23110", Offset = "0x2F22110", VA = "0x182F23110")]
		private float GetStrength()
		{
			return default(float);
		}

		// Token: 0x06003DE9 RID: 15849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DE9")]
		[Address(RVA = "0x2F23630", Offset = "0x2F22630", VA = "0x182F23630")]
		public PuffyBreathingVfx()
		{
		}

		// Token: 0x040041BD RID: 16829
		[Token(Token = "0x40041BD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BlendShapeManager _manager;

		// Token: 0x040041BE RID: 16830
		[Token(Token = "0x40041BE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VailStatsManager _statsManager;

		// Token: 0x040041BF RID: 16831
		[Token(Token = "0x40041BF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VailActor _vailActor;

		// Token: 0x040041C0 RID: 16832
		[Token(Token = "0x40041C0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SkinnedMeshRenderer _skinnedMeshRenderer;

		// Token: 0x040041C1 RID: 16833
		[Token(Token = "0x40041C1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _speedMultiplier;

		// Token: 0x040041C2 RID: 16834
		[Token(Token = "0x40041C2")]
		[FieldOffset(Offset = "0x44")]
		[FormerlySerializedAs("_breathingStrengthSpeed")]
		[SerializeField]
		private float _breathingStrengthChangeSpeed;

		// Token: 0x040041C3 RID: 16835
		[Token(Token = "0x40041C3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<PuffyBlendShapeAnimation> _animations;

		// Token: 0x040041C4 RID: 16836
		[Token(Token = "0x40041C4")]
		[FieldOffset(Offset = "0x50")]
		private float _strengthGoal;

		// Token: 0x040041C5 RID: 16837
		[Token(Token = "0x40041C5")]
		[FieldOffset(Offset = "0x54")]
		private float _currentStrength;
	}
}
