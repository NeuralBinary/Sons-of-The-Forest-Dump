using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	[CreateAssetMenu(fileName = "DamageNodeMap", menuName = "Sons/Animation/DamageNodeMap", order = 0)]
	public class DamageNodeMap : ScriptableObject
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000213E File Offset: 0x0000033E
		[Token(Token = "0x1700002A")]
		public IReadOnlyCollection<DamageNodeMap.DamageNodeId> Ids
		{
			[Token(Token = "0x6000111")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public DamageNodeMap()
		{
		}

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<DamageNodeMap.DamageNodeId> _ids;

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		[Serializable]
		public class DamageNodeId
		{
			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000113 RID: 275 RVA: 0x0000213E File Offset: 0x0000033E
			[Token(Token = "0x1700002B")]
			public string Name
			{
				[Token(Token = "0x6000113")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000114 RID: 276 RVA: 0x0000251C File Offset: 0x0000071C
			[Token(Token = "0x1700002C")]
			public int Id
			{
				[Token(Token = "0x6000114")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public DamageNodeId()
			{
			}

			// Token: 0x040000B1 RID: 177
			[Token(Token = "0x40000B1")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private string _name;

			// Token: 0x040000B2 RID: 178
			[Token(Token = "0x40000B2")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private int _id;
		}
	}
}
