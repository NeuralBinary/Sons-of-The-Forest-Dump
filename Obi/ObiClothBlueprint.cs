using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[CreateAssetMenu(fileName = "cloth blueprint", menuName = "Obi/Cloth Blueprint", order = 120)]
	public class ObiClothBlueprint : ObiClothBlueprintBase
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000242C File Offset: 0x0000062C
		[Token(Token = "0x17000024")]
		public override bool usesTethers
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2740320", Offset = "0x273E920", VA = "0x182740320", Slot = "17")]
		protected override IEnumerator Initialize()
		{
			return null;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x27403B0", Offset = "0x273E9B0", VA = "0x1827403B0", Slot = "20")]
		protected virtual IEnumerator CreateDistanceConstraints()
		{
			return null;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2740440", Offset = "0x273EA40", VA = "0x182740440", Slot = "21")]
		protected virtual IEnumerator CreateAerodynamicConstraints()
		{
			return null;
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x27404D0", Offset = "0x273EAD0", VA = "0x1827404D0", Slot = "22")]
		protected virtual IEnumerator CreateBendingConstraints()
		{
			return null;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60000FD")]
		[Address(RVA = "0x2740560", Offset = "0x273EB60", VA = "0x182740560", Slot = "23")]
		protected virtual IEnumerator CreateVolumeConstraints()
		{
			return null;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000FE")]
		[Address(RVA = "0x27405F0", Offset = "0x273EBF0", VA = "0x1827405F0", Slot = "16")]
		public override void ClearTethers()
		{
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60000FF")]
		[Address(RVA = "0x2740680", Offset = "0x273EC80", VA = "0x182740680")]
		private List<HashSet<int>> GenerateIslands(IEnumerable<int> particles, Func<int, bool> condition)
		{
			return null;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x2740F80", Offset = "0x273F580", VA = "0x182740F80", Slot = "15")]
		public override void GenerateTethers(bool[] selected)
		{
		}

		// Token: 0x06000101 RID: 257 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x27416B0", Offset = "0x273FCB0", VA = "0x1827416B0")]
		private void GenerateTethersForIsland(HashSet<int> particles, List<int> particleIndices, bool[] selected, int maxTethers)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x2741FD0", Offset = "0x27405D0", VA = "0x182741FD0")]
		public ObiClothBlueprint()
		{
		}
	}
}
