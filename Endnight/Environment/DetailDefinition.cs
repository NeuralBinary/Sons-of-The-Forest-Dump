using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Environment
{
	// Token: 0x020000B9 RID: 185
	[Token(Token = "0x20000B9")]
	[CreateAssetMenu(fileName = "DetailDef", menuName = "Sons/Environment/Detail Definition")]
	public class DetailDefinition : ScriptableObject
	{
		// Token: 0x06000458 RID: 1112 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public GameObject GetLocator()
		{
			return null;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public GameObject GetVisualSource()
		{
			return null;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public DetailDefinition()
		{
		}

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		private const string PrefabExt = "prefab";

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		private const string LocatorSuffix = "Locator";

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		private const string AssetExt = "asset";

		// Token: 0x040002BA RID: 698
		[Token(Token = "0x40002BA")]
		private const string DefinitionSuffix = "Def";

		// Token: 0x040002BB RID: 699
		[Token(Token = "0x40002BB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _visualSource;

		// Token: 0x040002BC RID: 700
		[Token(Token = "0x40002BC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _locator;
	}
}
