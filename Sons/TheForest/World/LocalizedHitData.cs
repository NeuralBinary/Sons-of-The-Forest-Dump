using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.World
{
	// Token: 0x02000380 RID: 896
	[Token(Token = "0x2000380")]
	public struct LocalizedHitData
	{
		// Token: 0x060017FF RID: 6143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60017FF")]
		[Address(RVA = "0x3277C60", Offset = "0x3276260", VA = "0x183277C60")]
		public LocalizedHitData(Vector3 position, float damage)
		{
		}

		// Token: 0x06001800 RID: 6144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001800")]
		[Address(RVA = "0x3277C80", Offset = "0x3276280", VA = "0x183277C80")]
		public LocalizedHitData(Vector3 position, float damage, float distortRatio)
		{
		}

		// Token: 0x040016EE RID: 5870
		[Token(Token = "0x40016EE")]
		[FieldOffset(Offset = "0x0")]
		public Vector3 _position;

		// Token: 0x040016EF RID: 5871
		[Token(Token = "0x40016EF")]
		[FieldOffset(Offset = "0xC")]
		public float _damage;

		// Token: 0x040016F0 RID: 5872
		[Token(Token = "0x40016F0")]
		[FieldOffset(Offset = "0x10")]
		public float _distortRatio;
	}
}
