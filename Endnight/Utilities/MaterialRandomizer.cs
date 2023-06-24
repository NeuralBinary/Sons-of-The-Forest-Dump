using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Utilities
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class MaterialRandomizer : MonoBehaviour
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012A")]
		[Address(RVA = "0xA74F20", Offset = "0xA73520", VA = "0x180A74F20")]
		private void InitializeRandom()
		{
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0xA75010", Offset = "0xA73610", VA = "0x180A75010")]
		private void OnDisable()
		{
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012C")]
		[Address(RVA = "0xA750A0", Offset = "0xA736A0", VA = "0x180A750A0")]
		private void OnEnable()
		{
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012D")]
		[Address(RVA = "0xA750A0", Offset = "0xA736A0", VA = "0x180A750A0")]
		private void ApplyNextRandom()
		{
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA75240", Offset = "0xA73840", VA = "0x180A75240")]
		private MaterialRandomizer.MaterialRandomSet GetNextRandom()
		{
			return null;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x600012F")]
		[Address(RVA = "0xA753F0", Offset = "0xA739F0", VA = "0x180A753F0")]
		private bool IsMatchingRandom(MaterialRandomizer.MaterialRandomSet eachSet, ref int adjustedRandom)
		{
			return default(bool);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000130")]
		[Address(RVA = "0xA75410", Offset = "0xA73A10", VA = "0x180A75410")]
		private void Apply(MaterialRandomizer.MaterialRandomSet materialRandomSet)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000131")]
		[Address(RVA = "0xA754A0", Offset = "0xA73AA0", VA = "0x180A754A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000132")]
		[Address(RVA = "0xA75780", Offset = "0xA73D80", VA = "0x180A75780")]
		private int CountTotalShares()
		{
			return 0;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000133")]
		[Address(RVA = "0xA758E0", Offset = "0xA73EE0", VA = "0x180A758E0")]
		private void AddAllChildRenderersToDefault()
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000134")]
		[Address(RVA = "0xA759B0", Offset = "0xA73FB0", VA = "0x180A759B0")]
		private void CollectDefaults()
		{
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000135")]
		[Address(RVA = "0xA759E0", Offset = "0xA73FE0", VA = "0x180A759E0")]
		private void UpdateDefault(HashSet<Renderer> allRenderers)
		{
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000136")]
		[Address(RVA = "0xA75C40", Offset = "0xA74240", VA = "0x180A75C40")]
		private HashSet<Renderer> GetAllRenderers()
		{
			return null;
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MaterialRandomizer()
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		private const string DefaultId = "Default";

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MaterialRandomizer.MaterialRandomSet _defaultSet;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _totalShares;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<MaterialRandomizer.MaterialRandomSet> _sets;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x38")]
		private string _appliedId;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x40")]
		private System.Random _systemRandom;

		// Token: 0x02000039 RID: 57
		[Token(Token = "0x2000039")]
		[Serializable]
		public class MaterialRandomSet
		{
			// Token: 0x06000138 RID: 312 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000138")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			public IReadOnlyList<MaterialRandomizer.MaterialRandomTarget> GetTargets()
			{
				return null;
			}

			// Token: 0x06000139 RID: 313 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000139")]
			[Address(RVA = "0xA75FD0", Offset = "0xA745D0", VA = "0x180A75FD0")]
			public void Clear()
			{
			}

			// Token: 0x0600013A RID: 314 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013A")]
			[Address(RVA = "0xA760D0", Offset = "0xA746D0", VA = "0x180A760D0")]
			public void Add(Renderer eachRenderer)
			{
			}

			// Token: 0x0600013B RID: 315 RVA: 0x00002598 File Offset: 0x00000798
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			public int GetRandomShares()
			{
				return 0;
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013C")]
			[Address(RVA = "0xA76380", Offset = "0xA74980", VA = "0x180A76380")]
			public void Apply()
			{
			}

			// Token: 0x0600013D RID: 317 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			public string GetId()
			{
				return null;
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			public void SetId(string setId)
			{
			}

			// Token: 0x0600013F RID: 319 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public MaterialRandomSet()
			{
			}

			// Token: 0x040000D3 RID: 211
			[Token(Token = "0x40000D3")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _id;

			// Token: 0x040000D4 RID: 212
			[Token(Token = "0x40000D4")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Min(1f)]
			private int _randomShares;

			// Token: 0x040000D5 RID: 213
			[Token(Token = "0x40000D5")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private List<MaterialRandomizer.MaterialRandomTarget> _targets;
		}

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		[Serializable]
		public class MaterialRandomTarget
		{
			// Token: 0x06000140 RID: 320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000140")]
			[Address(RVA = "0xA764C0", Offset = "0xA74AC0", VA = "0x180A764C0")]
			public MaterialRandomTarget(Renderer eachRenderer)
			{
			}

			// Token: 0x06000141 RID: 321 RVA: 0x0000206A File Offset: 0x0000026A
			[Token(Token = "0x6000141")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			public Renderer GetRenderer()
			{
				return null;
			}

			// Token: 0x06000142 RID: 322 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000142")]
			[Address(RVA = "0xA76660", Offset = "0xA74C60", VA = "0x180A76660")]
			public void Apply()
			{
			}

			// Token: 0x040000D6 RID: 214
			[Token(Token = "0x40000D6")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private Renderer _targetRenderer;

			// Token: 0x040000D7 RID: 215
			[Token(Token = "0x40000D7")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private Material[] _materials;
		}
	}
}
