using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[AddComponentMenu("Sons/Ai/Vail Actor Lods")]
	public class VailActorLods : MonoBehaviour
	{
		// Token: 0x06000351 RID: 849 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x2AFD360", Offset = "0x2AFB960", VA = "0x182AFD360")]
		public void UpdateLods(float viewDist)
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x2AFD520", Offset = "0x2AFBB20", VA = "0x182AFD520")]
		private void PreviewDistance(float distance)
		{
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000353")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VailActorLods()
		{
		}

		// Token: 0x040002D3 RID: 723
		[Token(Token = "0x40002D3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<VailActorLods.LodGroup> _lodGroups;

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		[Serializable]
		internal class LodGroup
		{
			// Token: 0x06000354 RID: 852 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x2AFD530", Offset = "0x2AFBB30", VA = "0x182AFD530")]
			public void UpdateSettings(float viewDist)
			{
			}

			// Token: 0x06000355 RID: 853 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x66E8E0", Offset = "0x66CEE0", VA = "0x18066E8E0")]
			public LodGroup()
			{
			}

			// Token: 0x040002D4 RID: 724
			[Token(Token = "0x40002D4")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private float _visibleDistance;

			// Token: 0x040002D5 RID: 725
			[Token(Token = "0x40002D5")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _fullQualityDistance;

			// Token: 0x040002D6 RID: 726
			[Token(Token = "0x40002D6")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private List<SkinnedMeshRenderer> _skinnedMeshRenderer;

			// Token: 0x040002D7 RID: 727
			[Token(Token = "0x40002D7")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private List<MeshRenderer> _meshRenderers;

			// Token: 0x040002D8 RID: 728
			[Token(Token = "0x40002D8")]
			[FieldOffset(Offset = "0x28")]
			private bool _visible;

			// Token: 0x040002D9 RID: 729
			[Token(Token = "0x40002D9")]
			[FieldOffset(Offset = "0x2C")]
			private SkinQuality _skinQuality;
		}
	}
}
