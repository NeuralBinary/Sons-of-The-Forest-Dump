using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x02000765 RID: 1893
	[Token(Token = "0x2000765")]
	[CreateAssetMenu(fileName = "FootstepList", menuName = "Sons/Audio/FootstepList", order = 0)]
	[Serializable]
	public class FootstepEventList : ScriptableObject, FootstepManager.IFootstepList
	{
		// Token: 0x06003337 RID: 13111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003337")]
		[Address(RVA = "0x34B2EF0", Offset = "0x34B14F0", VA = "0x1834B2EF0")]
		public FootstepEventList()
		{
		}

		// Token: 0x06003338 RID: 13112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003338")]
		[Address(RVA = "0x34B3870", Offset = "0x34B1E70", VA = "0x1834B3870")]
		public void SetToDefaults(string prefixStep)
		{
		}

		// Token: 0x06003339 RID: 13113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003339")]
		[Address(RVA = "0x34B39F0", Offset = "0x34B1FF0", VA = "0x1834B39F0", Slot = "4")]
		public void PreloadEvents()
		{
		}

		// Token: 0x0600333A RID: 13114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333A")]
		[Address(RVA = "0x34B3C70", Offset = "0x34B2270", VA = "0x1834B3C70", Slot = "5")]
		public void UnloadEvents()
		{
		}

		// Token: 0x0600333B RID: 13115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600333B")]
		[Address(RVA = "0x34B3EF0", Offset = "0x34B24F0", VA = "0x1834B3EF0", Slot = "6")]
		public string GetEvent(UnderfootSurfaceDetector.SurfaceType surface, FootstepManager.SoundType type)
		{
			return null;
		}

		// Token: 0x0600333C RID: 13116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600333C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		private void SetToDefaults()
		{
		}

		// Token: 0x04002C24 RID: 11300
		[Token(Token = "0x4002C24")]
		[FieldOffset(Offset = "0x18")]
		public MutantFootstepMaterial Default;

		// Token: 0x04002C25 RID: 11301
		[Token(Token = "0x4002C25")]
		[FieldOffset(Offset = "0x20")]
		public MutantFootstepMaterial Dirt;

		// Token: 0x04002C26 RID: 11302
		[Token(Token = "0x4002C26")]
		[FieldOffset(Offset = "0x28")]
		public MutantFootstepMaterial Grass;

		// Token: 0x04002C27 RID: 11303
		[Token(Token = "0x4002C27")]
		[FieldOffset(Offset = "0x30")]
		public MutantFootstepMaterial Gravel;

		// Token: 0x04002C28 RID: 11304
		[Token(Token = "0x4002C28")]
		[FieldOffset(Offset = "0x38")]
		public MutantFootstepMaterial Sand;

		// Token: 0x04002C29 RID: 11305
		[Token(Token = "0x4002C29")]
		[FieldOffset(Offset = "0x40")]
		public MutantFootstepMaterial Snow;

		// Token: 0x04002C2A RID: 11306
		[Token(Token = "0x4002C2A")]
		[FieldOffset(Offset = "0x48")]
		public MutantFootstepMaterial Wood;

		// Token: 0x04002C2B RID: 11307
		[Token(Token = "0x4002C2B")]
		[FieldOffset(Offset = "0x50")]
		public MutantFootstepMaterial Rock;

		// Token: 0x04002C2C RID: 11308
		[Token(Token = "0x4002C2C")]
		[FieldOffset(Offset = "0x58")]
		public MutantFootstepMaterial Epoxy;

		// Token: 0x04002C2D RID: 11309
		[Token(Token = "0x4002C2D")]
		[FieldOffset(Offset = "0x60")]
		protected Dictionary<UnderfootSurfaceDetector.SurfaceType, MutantFootstepMaterial> _matInfos;

		// Token: 0x04002C2E RID: 11310
		[Token(Token = "0x4002C2E")]
		[FieldOffset(Offset = "0x68")]
		public string DefaultEventRoot;
	}
}
