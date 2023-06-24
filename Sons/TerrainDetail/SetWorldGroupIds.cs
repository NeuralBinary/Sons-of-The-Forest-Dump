using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.TerrainDetail
{
	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x2000506")]
	[AddComponentMenu("Sons/Terrain/Set World Group Ids")]
	public class SetWorldGroupIds : MonoBehaviour
	{
		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06002184 RID: 8580 RVA: 0x00009D20 File Offset: 0x00007F20
		[Token(Token = "0x1700049A")]
		public bool HasSourceOverride
		{
			[Token(Token = "0x6002184")]
			[Address(RVA = "0x3329610", Offset = "0x3327C10", VA = "0x183329610")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002185")]
		[Address(RVA = "0x33296D0", Offset = "0x3327CD0", VA = "0x1833296D0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002186")]
		[Address(RVA = "0x3329700", Offset = "0x3327D00", VA = "0x183329700")]
		private void UpdateFromSourceOverride()
		{
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002187")]
		[Address(RVA = "0x3329AA0", Offset = "0x33280A0", VA = "0x183329AA0")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002188")]
		[Address(RVA = "0x3329D00", Offset = "0x3328300", VA = "0x183329D00")]
		public void Apply()
		{
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002189")]
		[Address(RVA = "0x332A080", Offset = "0x3328680", VA = "0x18332A080")]
		public SetWorldGroupIds()
		{
		}

		// Token: 0x04001F0F RID: 7951
		[Token(Token = "0x4001F0F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SetWorldGroupIds _sourceOverride;

		// Token: 0x04001F10 RID: 7952
		[Token(Token = "0x4001F10")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<WorldGroupState> _worldGroupStates;
	}
}
