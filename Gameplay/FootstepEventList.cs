using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000647 RID: 1607
	[Token(Token = "0x2000647")]
	[CreateAssetMenu(fileName = "FootstepList", menuName = "Sons/Audio/FootstepList", order = 0)]
	[Serializable]
	public class FootstepEventList : ScriptableObject, FootstepManager.IFootstepList
	{
		// Token: 0x06002954 RID: 10580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002954")]
		[Address(RVA = "0x2DCA5E0", Offset = "0x2DC95E0", VA = "0x182DCA5E0")]
		public FootstepEventList()
		{
		}

		// Token: 0x06002955 RID: 10581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002955")]
		[Address(RVA = "0x2DCA160", Offset = "0x2DC9160", VA = "0x182DCA160")]
		public void SetToDefaults(string prefixStep)
		{
		}

		// Token: 0x06002956 RID: 10582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002956")]
		[Address(RVA = "0x2DC9F30", Offset = "0x2DC8F30", VA = "0x182DC9F30", Slot = "4")]
		public void PreloadEvents()
		{
		}

		// Token: 0x06002957 RID: 10583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002957")]
		[Address(RVA = "0x2DCA3B0", Offset = "0x2DC93B0", VA = "0x182DCA3B0", Slot = "5")]
		public void UnloadEvents()
		{
		}

		// Token: 0x06002958 RID: 10584 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002958")]
		[Address(RVA = "0x2DC9E70", Offset = "0x2DC8E70", VA = "0x182DC9E70", Slot = "6")]
		public string GetEvent(UnderfootSurfaceDetector.SurfaceType surface, FootstepManager.SoundType type)
		{
			return null;
		}

		// Token: 0x06002959 RID: 10585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002959")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		private void SetToDefaults()
		{
		}

		// Token: 0x040024DE RID: 9438
		[Token(Token = "0x40024DE")]
		[FieldOffset(Offset = "0x18")]
		public MutantFootstepMaterial Default;

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		[FieldOffset(Offset = "0x20")]
		public MutantFootstepMaterial Dirt;

		// Token: 0x040024E0 RID: 9440
		[Token(Token = "0x40024E0")]
		[FieldOffset(Offset = "0x28")]
		public MutantFootstepMaterial Grass;

		// Token: 0x040024E1 RID: 9441
		[Token(Token = "0x40024E1")]
		[FieldOffset(Offset = "0x30")]
		public MutantFootstepMaterial Gravel;

		// Token: 0x040024E2 RID: 9442
		[Token(Token = "0x40024E2")]
		[FieldOffset(Offset = "0x38")]
		public MutantFootstepMaterial Sand;

		// Token: 0x040024E3 RID: 9443
		[Token(Token = "0x40024E3")]
		[FieldOffset(Offset = "0x40")]
		public MutantFootstepMaterial Snow;

		// Token: 0x040024E4 RID: 9444
		[Token(Token = "0x40024E4")]
		[FieldOffset(Offset = "0x48")]
		public MutantFootstepMaterial Wood;

		// Token: 0x040024E5 RID: 9445
		[Token(Token = "0x40024E5")]
		[FieldOffset(Offset = "0x50")]
		public MutantFootstepMaterial Rock;

		// Token: 0x040024E6 RID: 9446
		[Token(Token = "0x40024E6")]
		[FieldOffset(Offset = "0x58")]
		public MutantFootstepMaterial Epoxy;

		// Token: 0x040024E7 RID: 9447
		[Token(Token = "0x40024E7")]
		[FieldOffset(Offset = "0x60")]
		protected Dictionary<UnderfootSurfaceDetector.SurfaceType, MutantFootstepMaterial> _matInfos;

		// Token: 0x040024E8 RID: 9448
		[Token(Token = "0x40024E8")]
		[FieldOffset(Offset = "0x68")]
		public string DefaultEventRoot;
	}
}
