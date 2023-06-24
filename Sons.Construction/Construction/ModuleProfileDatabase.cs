using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[CreateAssetMenu(menuName = "Sons/Construction/ModuleProfileDatabase")]
	public class ModuleProfileDatabase : ScriptableObject
	{
		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000F5")]
		public ItemModuleProfile[] DefaultItemPrefabs
		{
			[Token(Token = "0x600029C")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170000F6")]
		public ItemTypeModuleProfile[] DefaultItemTypePrefabs
		{
			[Token(Token = "0x600029D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600029E")]
		[Address(RVA = "0x18682A0", Offset = "0x18668A0", VA = "0x1818682A0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00003254 File Offset: 0x00001454
		[Token(Token = "0x600029F")]
		[Address(RVA = "0x2D77D70", Offset = "0x2D76370", VA = "0x182D77D70")]
		public bool TryGetValidProfiles(ItemData item, List<ModuleProfile> moduleProfiles)
		{
			return default(bool);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000326C File Offset: 0x0000146C
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2D780B0", Offset = "0x2D766B0", VA = "0x182D780B0")]
		public bool TryGetMatchingProfile(ItemData item, out ModuleProfile moduleProfile)
		{
			return default(bool);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00003284 File Offset: 0x00001484
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x2D78360", Offset = "0x2D76960", VA = "0x182D78360")]
		public bool TryGetMatchingProfile(Types itemType, out ModuleProfile moduleProfile)
		{
			return default(bool);
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0000329C File Offset: 0x0000149C
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x2D78470", Offset = "0x2D76A70", VA = "0x182D78470")]
		public bool TryGetMatchingProfile(ElementProfile elementProfile, out ModuleProfile moduleProfile)
		{
			return default(bool);
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x2D787A0", Offset = "0x2D76DA0", VA = "0x182D787A0")]
		public IReadOnlyList<ModuleProfile> GetCarouselProfiles()
		{
			return null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002A4")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ModuleProfileDatabase()
		{
		}

		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ItemModuleProfile[] _defaultItemPrefabs;

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ItemTypeModuleProfile[] _defaultItemTypePrefabs;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x28")]
		private List<ModuleProfile> _carouselProfiles;
	}
}
