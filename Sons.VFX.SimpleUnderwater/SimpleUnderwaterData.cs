using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.VFX
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[AddComponentMenu("Sons/VFX/SimpleUnderwaterData")]
	public class SimpleUnderwaterData : MonoBehaviour, ISimpleUnderwaterData
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000036 RID: 54 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x17000009")]
		public Material WaterSurfaceMaterial
		{
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x1700000A")]
		public bool UseWaterHeight
		{
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x6599C0", Offset = "0x657FC0", VA = "0x1806599C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetWaterSurfaceMaterial(Material value)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x734A50", Offset = "0x733050", VA = "0x180734A50")]
		public void SetUseWaterHeight(bool value)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public SimpleUnderwaterData()
		{
		}

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_WaterSurfaceMaterial")]
		private Material _waterSurfaceMaterial;

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("_UseWaterHeight")]
		private bool _useWaterHeight;
	}
}
