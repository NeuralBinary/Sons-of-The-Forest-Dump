using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000504 RID: 1284
	[Token(Token = "0x2000504")]
	[AddComponentMenu("Sons/Terrain/Set World Group Ids")]
	public class SetWorldGroupIds : MonoBehaviour
	{
		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x00009798 File Offset: 0x00007998
		[Token(Token = "0x17000487")]
		public bool HasSourceOverride
		{
			[Token(Token = "0x60020C1")]
			[Address(RVA = "0x2D321E0", Offset = "0x2D311E0", VA = "0x182D321E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C2")]
		[Address(RVA = "0x2D31DF0", Offset = "0x2D30DF0", VA = "0x182D31DF0")]
		private void OnValidate()
		{
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C3")]
		[Address(RVA = "0x2D31E60", Offset = "0x2D30E60", VA = "0x182D31E60")]
		private void UpdateFromSourceOverride()
		{
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C4")]
		[Address(RVA = "0x2D31CE0", Offset = "0x2D30CE0", VA = "0x182D31CE0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C5")]
		[Address(RVA = "0x2D319A0", Offset = "0x2D309A0", VA = "0x182D319A0")]
		public void Apply()
		{
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020C6")]
		[Address(RVA = "0x2D32160", Offset = "0x2D31160", VA = "0x182D32160")]
		public SetWorldGroupIds()
		{
		}

		// Token: 0x04001E77 RID: 7799
		[Token(Token = "0x4001E77")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SetWorldGroupIds _sourceOverride;

		// Token: 0x04001E78 RID: 7800
		[Token(Token = "0x4001E78")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<WorldGroupState> _worldGroupStates;
	}
}
